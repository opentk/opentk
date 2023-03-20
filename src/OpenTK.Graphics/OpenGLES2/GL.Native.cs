// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES2
{
    public static unsafe partial class GL
    {
        /// <summary> <b>[requires: v2.0] [glActiveTexture]</b> Select active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation-dependent, but must be at least 32. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveTexture.xhtml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v2.0] [glAttachShader]</b> Attaches a shader object to a program object. </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglAttachShader.xhtml" /></remarks>
        public static void AttachShader(int program, int shader) => GLPointers._glAttachShader_fnptr(program, shader);
        
        /// <summary> <b>[requires: v2.0] [glBindAttribLocation]</b> Associates a generic vertex attribute index with a named attribute variable. </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindAttribLocation.xhtml" /></remarks>
        public static void BindAttribLocation(int program, uint index, byte* name) => GLPointers._glBindAttribLocation_fnptr(program, index, name);
        
        /// <summary> <b>[requires: v2.0] [glBindBuffer]</b> Bind a named buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="buffer"> Specifies the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBuffer.xhtml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        /// <summary> <b>[requires: v2.0] [glBindFramebuffer]</b> Bind a framebuffer to a framebuffer target. </summary>
        /// <param name="target"> Specifies the framebuffer target of the binding operation. </param>
        /// <param name="framebuffer"> Specifies the name of the framebuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindFramebuffer.xhtml" /></remarks>
        public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebuffer_fnptr((uint)target, framebuffer);
        
        /// <summary> <b>[requires: v2.0] [glBindRenderbuffer]</b> Bind a renderbuffer to a renderbuffer target. </summary>
        /// <param name="target"> Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of the renderbuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindRenderbuffer.xhtml" /></remarks>
        public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbuffer_fnptr((uint)target, renderbuffer);
        
        /// <summary> <b>[requires: v2.0] [glBindTexture]</b> Bind a named texture to a texturing target. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound. Must be either GL_TEXTURE_2D, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="texture"> Specifies the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTexture.xhtml" /></remarks>
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        /// <summary> <b>[requires: v2.0] [glBlendColor]</b> Set the blend color. </summary>
        /// <param name="red"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="green"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="blue"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="alpha"> specify the components of GL_BLEND_COLOR </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendColor.xhtml" /></remarks>
        public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._glBlendColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0] [glBlendEquation]</b> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquation_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0] [glBlendEquationSeparate]</b> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparate_fnptr((uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v2.0] [glBlendFunc]</b> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        /// <summary> <b>[requires: v2.0] [glBlendFuncSeparate]</b> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparate_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
        
        /// <summary> <b>[requires: v2.0] [glBufferData]</b> Creates and initializes a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object&apos;s new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferData.xhtml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        /// <summary> <b>[requires: v2.0] [glBufferSubData]</b> Updates a subset of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object&apos;s data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferSubData.xhtml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        /// <summary> <b>[requires: v2.0] [glCheckFramebufferStatus]</b> Check the completeness status of a framebuffer. </summary>
        /// <param name="target"> Specify the target of the framebuffer completeness check. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCheckFramebufferStatus.xhtml" /></remarks>
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatus_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0] [glClear]</b> Clear buffers to preset values. </summary>
        /// <param name="mask"> Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClear.xhtml" /></remarks>
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        /// <summary> <b>[requires: v2.0] [glClearColor]</b> Specify clear values for the color buffers. </summary>
        /// <param name="red"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="green"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="blue"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="alpha"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearColor.xhtml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0] [glClearDepthf]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth"> Specifies the depth value used when the depth buffer is cleared. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearDepthf.xhtml" /></remarks>
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        /// <summary> <b>[requires: v2.0] [glClearStencil]</b> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s"> Specifies the index used when the stencil buffer is cleared. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearStencil.xhtml" /></remarks>
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        /// <summary> <b>[requires: v2.0] [glColorMask]</b> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0] [glCompileShader]</b> Compiles a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompileShader.xhtml" /></remarks>
        public static void CompileShader(int shader) => GLPointers._glCompileShader_fnptr(shader);
        
        /// <summary> <b>[requires: v2.0] [glCompressedTexImage2D]</b> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompressedTexImage2D.xhtml" /></remarks>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        /// <summary> <b>[requires: v2.0] [glCompressedTexSubImage2D]</b> Specify a two-dimensional texture subimage in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompressedTexSubImage2D.xhtml" /></remarks>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v2.0] [glCopyTexImage2D]</b> Copy pixels into a 2D texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_ALPHA, GL_LUMINANCE, GL_LUMINANCE_ALPHA, GL_RGB, GL_RGBA, GL_R8, GL_RG8, GL_RGB565, GL_RGB8, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_SRGB8, GL_SRGB8_ALPHA8, GL_R8I, GL_R8UI, GL_R16I, GL_R16UI, GL_R32I, GL_R32UI, GL_RG8I, GL_RG8UI, GL_RG16I, GL_RG16UI, GL_RG32I, GL_RG32UI, GL_RGBA8I, GL_RGBA8UI, GL_RGB10_A2UI, GL_RGBA16I, GL_RGBA16UI, GL_RGBA32I, GL_RGBA32UI. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="border"> Specifies the width of the border. Must be 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyTexImage2D.xhtml" /></remarks>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        /// <summary> <b>[requires: v2.0] [glCopyTexSubImage2D]</b> Copy a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyTexSubImage2D.xhtml" /></remarks>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v2.0] [glCreateProgram]</b> Creates a program object. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateProgram.xhtml" /></remarks>
        public static int CreateProgram() => GLPointers._glCreateProgram_fnptr();
        
        /// <summary> <b>[requires: v2.0] [glCreateShader]</b> Creates a shader object. </summary>
        /// <param name="shaderType"> Specifies the type of shader to be created. Must be one of GL_COMPUTE_SHADER, GL_VERTEX_SHADER, GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER, or GL_FRAGMENT_SHADER. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShader.xhtml" /></remarks>
        public static int CreateShader(ShaderType type) => GLPointers._glCreateShader_fnptr((uint)type);
        
        /// <summary> <b>[requires: v2.0] [glCullFace]</b> Specify whether front- or back-facing polygons can be culled. </summary>
        /// <param name="mode"> Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCullFace.xhtml" /></remarks>
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0] [glDeleteBuffers]</b> Delete named buffer objects. </summary>
        /// <param name="n"> Specifies the number of buffer objects to be deleted. </param>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteBuffers.xhtml" /></remarks>
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v2.0] [glDeleteFramebuffers]</b> Delete framebuffer objects. </summary>
        /// <param name="n"> Specifies the number of framebuffer objects to be deleted. </param>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteFramebuffers.xhtml" /></remarks>
        public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffers_fnptr(n, framebuffers);
        
        /// <summary> <b>[requires: v2.0] [glDeleteProgram]</b> Deletes a program object. </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgram.xhtml" /></remarks>
        public static void DeleteProgram(int program) => GLPointers._glDeleteProgram_fnptr(program);
        
        /// <summary> <b>[requires: v2.0] [glDeleteRenderbuffers]</b> Delete renderbuffer objects. </summary>
        /// <param name="n"> Specifies the number of renderbuffer objects to be deleted. </param>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteRenderbuffers.xhtml" /></remarks>
        public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffers_fnptr(n, renderbuffers);
        
        /// <summary> <b>[requires: v2.0] [glDeleteShader]</b> Deletes a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteShader.xhtml" /></remarks>
        public static void DeleteShader(int shader) => GLPointers._glDeleteShader_fnptr(shader);
        
        /// <summary> <b>[requires: v2.0] [glDeleteTextures]</b> Delete named textures. </summary>
        /// <param name="n"> Specifies the number of textures to be deleted. </param>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTextures.xhtml" /></remarks>
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v2.0] [glDepthFunc]</b> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func"> Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthFunc.xhtml" /></remarks>
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        /// <summary> <b>[requires: v2.0] [glDepthMask]</b> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag"> Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthMask.xhtml" /></remarks>
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0] [glDepthRangef]</b> Specify mapping of depth values from normalized device coordinates to window coordinates. </summary>
        /// <param name="n"> Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0. </param>
        /// <param name="f"> Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthRangef.xhtml" /></remarks>
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        /// <summary> <b>[requires: v2.0] [glDetachShader]</b> Detaches a shader object from a program object to which it is attached. </summary>
        /// <param name="program">Specifies the program object from which to detach the shader object.</param>
        /// <param name="shader">Specifies the shader object to be detached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDetachShader.xhtml" /></remarks>
        public static void DetachShader(int program, int shader) => GLPointers._glDetachShader_fnptr(program, shader);
        
        /// <summary> <b>[requires: v2.0] [glDisable]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v2.0] [glDisableVertexAttribArray]</b> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void DisableVertexAttribArray(uint index) => GLPointers._glDisableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v2.0] [glDrawArrays]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArrays.xhtml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        /// <summary> <b>[requires: v2.0] [glDrawElements]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElements.xhtml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v2.0] [glEnable]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v2.0] [glEnableVertexAttribArray]</b> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void EnableVertexAttribArray(uint index) => GLPointers._glEnableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v2.0] [glFinish]</b> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFinish.xhtml" /></remarks>
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        /// <summary> <b>[requires: v2.0] [glFlush]</b> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlush.xhtml" /></remarks>
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        /// <summary> <b>[requires: v2.0] [glFramebufferRenderbuffer]</b> Attach a renderbuffer as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="renderbuffertarget"> Specifies the renderbuffer target and must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferRenderbuffer.xhtml" /></remarks>
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
        
        /// <summary> <b>[requires: v2.0] [glFramebufferTexture2D]</b> Attach a level of a texture object as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="textarget"> Specifies a 2D texture target, 2D multisample texture target, or for cube map textures, which face is to be attached. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture2D.xhtml" /></remarks>
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
        
        /// <summary> <b>[requires: v2.0] [glFrontFace]</b> Define front- and back-facing polygons. </summary>
        /// <param name="mode"> Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFrontFace.xhtml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0] [glGenBuffers]</b> Generate buffer object names. </summary>
        /// <param name="n"> Specifies the number of buffer object names to be generated. </param>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenBuffers.xhtml" /></remarks>
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v2.0] [glGenerateMipmap]</b> Generate mipmaps for a specified texture target. </summary>
        /// <param name="target"> Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenerateMipmap.xhtml" /></remarks>
        public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmap_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0] [glGenFramebuffers]</b> Generate framebuffer object names. </summary>
        /// <param name="n"> Specifies the number of framebuffer object names to generate. </param>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenFramebuffers.xhtml" /></remarks>
        public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffers_fnptr(n, framebuffers);
        
        /// <summary> <b>[requires: v2.0] [glGenRenderbuffers]</b> Generate renderbuffer object names. </summary>
        /// <param name="n"> Specifies the number of renderbuffer object names to generate. </param>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenRenderbuffers.xhtml" /></remarks>
        public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffers_fnptr(n, renderbuffers);
        
        /// <summary> <b>[requires: v2.0] [glGenTextures]</b> Generate texture names. </summary>
        /// <param name="n"> Specifies the number of texture names to be generated. </param>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTextures.xhtml" /></remarks>
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v2.0] [glGetActiveAttrib]</b> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveAttrib.xhtml" /></remarks>
        public static void GetActiveAttrib(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetActiveAttrib_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v2.0] [glGetActiveUniform]</b> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniform.xhtml" /></remarks>
        public static void GetActiveUniform(int program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => GLPointers._glGetActiveUniform_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v2.0] [glGetAttachedShaders]</b> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttachedShaders.xhtml" /></remarks>
        public static void GetAttachedShaders(int program, int maxCount, int* count, int* shaders) => GLPointers._glGetAttachedShaders_fnptr(program, maxCount, count, shaders);
        
        /// <summary> <b>[requires: v2.0] [glGetAttribLocation]</b> Returns the location of an attribute variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttribLocation.xhtml" /></remarks>
        public static int GetAttribLocation(int program, byte* name) => GLPointers._glGetAttribLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v2.0] [glGetBooleanv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        /// <summary> <b>[requires: v2.0] [glGetBufferParameteriv]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetError]</b> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetError.xhtml" /></remarks>
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        /// <summary> <b>[requires: v2.0] [glGetFloatv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v2.0] [glGetFramebufferAttachmentParameteriv]</b> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        /// <param name="parameters"> Specifies the address of a variable receive the value of pname for attachment. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferAttachmentParameteriv.xhtml" /></remarks>
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetIntegerv]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v2.0] [glGetProgramiv]</b> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramiv.xhtml" /></remarks>
        public static void GetProgramiv(int program, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetProgramiv_fnptr(program, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetProgramInfoLog]</b> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInfoLog.xhtml" /></remarks>
        public static void GetProgramInfoLog(int program, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v2.0] [glGetRenderbufferParameteriv]</b> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        /// <param name="parameters"> Specifies the address of an array to receive the value of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetRenderbufferParameteriv.xhtml" /></remarks>
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetShaderiv]</b> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderiv.xhtml" /></remarks>
        public static void GetShaderiv(int shader, ShaderParameterName pname, int* parameters) => GLPointers._glGetShaderiv_fnptr(shader, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetShaderInfoLog]</b> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderInfoLog.xhtml" /></remarks>
        public static void GetShaderInfoLog(int shader, int bufSize, int* length, byte* infoLog) => GLPointers._glGetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v2.0] [glGetShaderPrecisionFormat]</b> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="shaderType"> Specifies the type of shader whose precision to query. shaderType must be GL_VERTEX_SHADER or GL_FRAGMENT_SHADER. </param>
        /// <param name="precisionType"> Specifies the numeric format whose precision and range to query. </param>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation&apos;s numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderPrecisionFormat.xhtml" /></remarks>
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._glGetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
        
        /// <summary> <b>[requires: v2.0] [glGetShaderSource]</b> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderSource.xhtml" /></remarks>
        public static void GetShaderSource(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetShaderSource_fnptr(shader, bufSize, length, source);
        
        /// <summary> <b>[requires: v2.0] [glGetString]</b> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        /// <summary> <b>[requires: v2.0] [glGetTexParameterfv]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetTexParameteriv]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetUniformfv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformfv(int program, int location, float* parameters) => GLPointers._glGetUniformfv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetUniformiv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformiv(int program, int location, int* parameters) => GLPointers._glGetUniformiv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetUniformLocation]</b> Returns the location of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformLocation.xhtml" /></remarks>
        public static int GetUniformLocation(int program, byte* name) => GLPointers._glGetUniformLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v2.0] [glGetVertexAttribfv]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._glGetVertexAttribfv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetVertexAttribiv]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._glGetVertexAttribiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glGetVertexAttribPointerv]</b> Return the address of the specified generic vertex attribute pointer. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</param>
        /// <param name="pointer">Returns the pointer value.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttribPointerv.xhtml" /></remarks>
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._glGetVertexAttribPointerv_fnptr(index, (uint)pname, pointer);
        
        /// <summary> <b>[requires: v2.0] [glHint]</b> Specify implementation-specific hints. </summary>
        /// <param name="target"> Specifies a symbolic constant indicating the behavior to be controlled. GL_FRAGMENT_SHADER_DERIVATIVE_HINT, and GL_GENERATE_MIPMAP_HINT are accepted. </param>
        /// <param name="mode"> Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglHint.xhtml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        /// <summary> <b>[requires: v2.0] [glIsBuffer]</b> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsBuffer.xhtml" /></remarks>
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsEnabled]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsFramebuffer]</b> Determine if a name corresponds to a framebuffer object. </summary>
        /// <param name="framebuffer"> Specifies a value that may be the name of a framebuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsFramebuffer.xhtml" /></remarks>
        public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebuffer_fnptr(framebuffer) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsProgram]</b> Determines if a name corresponds to a program object. </summary>
        /// <param name="program">Specifies a potential program object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgram.xhtml" /></remarks>
        public static bool IsProgram(int program) => GLPointers._glIsProgram_fnptr(program) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsRenderbuffer]</b> Determine if a name corresponds to a renderbuffer object. </summary>
        /// <param name="renderbuffer"> Specifies a value that may be the name of a renderbuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsRenderbuffer.xhtml" /></remarks>
        public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbuffer_fnptr(renderbuffer) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsShader]</b> Determines if a name corresponds to a shader object. </summary>
        /// <param name="shader">Specifies a potential shader object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsShader.xhtml" /></remarks>
        public static bool IsShader(int shader) => GLPointers._glIsShader_fnptr(shader) != 0;
        
        /// <summary> <b>[requires: v2.0] [glIsTexture]</b> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTexture.xhtml" /></remarks>
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        /// <summary> <b>[requires: v2.0] [glLineWidth]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width"> Specifies the width of rasterized lines. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLineWidth.xhtml" /></remarks>
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        /// <summary> <b>[requires: v2.0] [glLinkProgram]</b> Links a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLinkProgram.xhtml" /></remarks>
        public static void LinkProgram(int program) => GLPointers._glLinkProgram_fnptr(program);
        
        /// <summary> <b>[requires: v2.0] [glPixelStorei]</b> Set pixel storage modes. </summary>
        /// <param name="pname"> Specifies the symbolic name of the parameter to be set. Four values affect the packing of pixel data into memory: GL_PACK_ROW_LENGTH, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT. </param>
        /// <param name="param"> Specifies the value that pname is set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPixelStorei.xhtml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v2.0] [glPolygonOffset]</b> Set the scale and units used to calculate depth values. </summary>
        /// <param name="factor"> Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0. </param>
        /// <param name="units"> Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPolygonOffset.xhtml" /></remarks>
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        /// <summary> <b>[requires: v2.0] [glReadPixels]</b> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0] [glReleaseShaderCompiler]</b> Release resources consumed by the implementation&apos;s shader compiler. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReleaseShaderCompiler.xhtml" /></remarks>
        public static void ReleaseShaderCompiler() => GLPointers._glReleaseShaderCompiler_fnptr();
        
        /// <summary> <b>[requires: v2.0] [glRenderbufferStorage]</b> Establish data storage, format and dimensions of a renderbuffer object&apos;s image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object&apos;s image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorage.xhtml" /></remarks>
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v2.0] [glSampleCoverage]</b> Specify multisample coverage parameters. </summary>
        /// <param name="value"> Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0. </param>
        /// <param name="invert"> Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleCoverage.xhtml" /></remarks>
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0] [glScissor]</b> Define the scissor box. </summary>
        /// <param name="x"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="y"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="width"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglScissor.xhtml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v2.0] [glShaderBinary]</b> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderBinary.xhtml" /></remarks>
        public static void ShaderBinary(int count, int* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._glShaderBinary_fnptr(count, shaders, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v2.0] [glShaderSource]</b> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="str">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderSource.xhtml" /></remarks>
        public static void ShaderSource(int shader, int count, byte** str, int* length) => GLPointers._glShaderSource_fnptr(shader, count, str, length);
        
        /// <summary> <b>[requires: v2.0] [glStencilFunc]</b> Set front and back function and reference value for stencil testing. </summary>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFunc.xhtml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0] [glStencilFuncSeparate]</b> Set front and/or back function and reference value for stencil testing. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFuncSeparate.xhtml" /></remarks>
        public static void StencilFuncSeparate(TriangleFace face, StencilFunction func, int reference, uint mask) => GLPointers._glStencilFuncSeparate_fnptr((uint)face, (uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0] [glStencilMask]</b> Control the front and back writing of individual bits in the stencil planes. </summary>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMask.xhtml" /></remarks>
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        /// <summary> <b>[requires: v2.0] [glStencilMaskSeparate]</b> Control the front and/or back writing of individual bits in the stencil planes. </summary>
        /// <param name="face"> Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMaskSeparate.xhtml" /></remarks>
        public static void StencilMaskSeparate(TriangleFace face, uint mask) => GLPointers._glStencilMaskSeparate_fnptr((uint)face, mask);
        
        /// <summary> <b>[requires: v2.0] [glStencilOp]</b> Set front and back stencil test actions. </summary>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOp.xhtml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        /// <summary> <b>[requires: v2.0] [glStencilOpSeparate]</b> Set front and/or back stencil test actions. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOpSeparate.xhtml" /></remarks>
        public static void StencilOpSeparate(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._glStencilOpSeparate_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
        
        /// <summary> <b>[requires: v2.0] [glTexImage2D]</b> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalFormat"> Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, or one of the sized internal formats given in Table 2, below. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexImage2D.xhtml" /></remarks>
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0] [glTexParameterf]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0] [glTexParameterfv]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glTexParameteri]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0] [glTexParameteriv]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0] [glTexSubImage2D]</b> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexSubImage2D.xhtml" /></remarks>
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0] [glUniform1f]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1f(int location, float v0) => GLPointers._glUniform1f_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0] [glUniform1fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1fv(int location, int count, float* value) => GLPointers._glUniform1fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform1i]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1i(int location, int v0) => GLPointers._glUniform1i_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0] [glUniform1iv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1iv(int location, int count, int* value) => GLPointers._glUniform1iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform2f]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2f(int location, float v0, float v1) => GLPointers._glUniform2f_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0] [glUniform2fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2fv(int location, int count, float* value) => GLPointers._glUniform2fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform2i]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2i(int location, int v0, int v1) => GLPointers._glUniform2i_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0] [glUniform2iv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2iv(int location, int count, int* value) => GLPointers._glUniform2iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform3f]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3f(int location, float v0, float v1, float v2) => GLPointers._glUniform3f_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0] [glUniform3fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3fv(int location, int count, float* value) => GLPointers._glUniform3fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform3i]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3i(int location, int v0, int v1, int v2) => GLPointers._glUniform3i_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0] [glUniform3iv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3iv(int location, int count, int* value) => GLPointers._glUniform3iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform4f]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => GLPointers._glUniform4f_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0] [glUniform4fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4fv(int location, int count, float* value) => GLPointers._glUniform4fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniform4i]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => GLPointers._glUniform4i_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0] [glUniform4iv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4iv(int location, int count, int* value) => GLPointers._glUniform4iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0] [glUniformMatrix2fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v2.0] [glUniformMatrix3fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v2.0] [glUniformMatrix4fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v2.0] [glUseProgram]</b> Installs a program object as part of current rendering state. </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgram.xhtml" /></remarks>
        public static void UseProgram(int program) => GLPointers._glUseProgram_fnptr(program);
        
        /// <summary> <b>[requires: v2.0] [glValidateProgram]</b> Validates a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be validated.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgram.xhtml" /></remarks>
        public static void ValidateProgram(int program) => GLPointers._glValidateProgram_fnptr(program);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib1f]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1f(uint index, float x) => GLPointers._glVertexAttrib1f_fnptr(index, x);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib1fv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1fv(uint index, float* v) => GLPointers._glVertexAttrib1fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib2f]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2f(uint index, float x, float y) => GLPointers._glVertexAttrib2f_fnptr(index, x, y);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib2fv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2fv(uint index, float* v) => GLPointers._glVertexAttrib2fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib3f]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3f(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3f_fnptr(index, x, y, z);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib3fv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3fv(uint index, float* v) => GLPointers._glVertexAttrib3fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib4f]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4f_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttrib4fv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4fv(uint index, float* v) => GLPointers._glVertexAttrib4fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0] [glVertexAttribPointer]</b> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="normalized">For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => GLPointers._glVertexAttribPointer_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);
        
        /// <summary> <b>[requires: v2.0] [glViewport]</b> Set the viewport. </summary>
        /// <param name="x"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="y"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="width"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglViewport.xhtml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v3.0] [glReadBuffer]</b> Select a color buffer source for pixels. </summary>
        /// <param name="src"> Specifies a color buffer. Accepted values are GL_BACK, GL_NONE, and GL_COLOR_ATTACHMENTi. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadBuffer.xhtml" /></remarks>
        public static void ReadBuffer(ReadBufferMode src) => GLPointers._glReadBuffer_fnptr((uint)src);
        
        /// <summary> <b>[requires: v3.0] [glDrawRangeElements]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElements.xhtml" /></remarks>
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._glDrawRangeElements_fnptr((uint)mode, start, end, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v3.0] [glTexImage3D]</b> Specify a three-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image. </param>
        /// <param name="internalFormat"> Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, or one of the sized internal formats given in Table 2, below. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 3D texture images that are at least 256 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high. </param>
        /// <param name="depth"> Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexImage3D.xhtml" /></remarks>
        public static void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3D_fnptr((uint)target, level, (int)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v3.0] [glTexSubImage3D]</b> Specify a three-dimensional texture subimage. </summary>
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
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexSubImage3D.xhtml" /></remarks>
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v3.0] [glCopyTexSubImage3D]</b> Copy a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyTexSubImage3D.xhtml" /></remarks>
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v3.0] [glCompressedTexImage3D]</b> Specify a three-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="depth"> Specifies the depth of the texture image. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompressedTexImage3D.xhtml" /></remarks>
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3D_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
        
        /// <summary> <b>[requires: v3.0] [glCompressedTexSubImage3D]</b> Specify a three-dimensional texture subimage in a compressed format. </summary>
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
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompressedTexSubImage3D.xhtml" /></remarks>
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v3.0] [glGenQueries]</b> Generate query object names. </summary>
        /// <param name="n"> Specifies the number of query object names to be generated. </param>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenQueries.xhtml" /></remarks>
        public static void GenQueries(int n, int* ids) => GLPointers._glGenQueries_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0] [glDeleteQueries]</b> Delete named query objects. </summary>
        /// <param name="n"> Specifies the number of query objects to be deleted. </param>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteQueries.xhtml" /></remarks>
        public static void DeleteQueries(int n, int* ids) => GLPointers._glDeleteQueries_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0] [glIsQuery]</b> Determine if a name corresponds to a query object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsQuery.xhtml" /></remarks>
        public static bool IsQuery(int id) => GLPointers._glIsQuery_fnptr(id) != 0;
        
        /// <summary> <b>[requires: v3.0] [glBeginQuery]</b> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void BeginQuery(QueryTarget target, int id) => GLPointers._glBeginQuery_fnptr((uint)target, id);
        
        /// <summary> <b>[requires: v3.0] [glEndQuery]</b> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void EndQuery(QueryTarget target) => GLPointers._glEndQuery_fnptr((uint)target);
        
        /// <summary> <b>[requires: v3.0] [glGetQueryiv]</b> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryiv.xhtml" /></remarks>
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetQueryObjectuiv]</b> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryObjectuiv.xhtml" /></remarks>
        public static void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuiv_fnptr(id, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glUnmapBuffer]</b> Map a section of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static bool UnmapBuffer(BufferTargetARB target) => GLPointers._glUnmapBuffer_fnptr((uint)target) != 0;
        
        /// <summary> <b>[requires: v3.0] [glGetBufferPointerv]</b> Return the pointer to a mapped buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="pname"> Specifies the pointer to be returned. The symbolic constant must be GL_BUFFER_MAP_POINTER. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferPointerv.xhtml" /></remarks>
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointerv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glDrawBuffers]</b> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="n">Specifies the number of buffers in bufs.</param>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawBuffers.xhtml" /></remarks>
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffers_fnptr(n, (uint*)bufs);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix2x3fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix3x2fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix2x4fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix4x2fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix3x4fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glUniformMatrix4x3fv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0] [glBlitFramebuffer]</b> Copy a block of pixels from the read framebuffer to the draw framebuffer. </summary>
        /// <param name="srcX0"> Specify the bounds of the source rectangle within the read buffer of the read framebuffer. </param>
        /// <param name="srcY0"> Specify the bounds of the source rectangle within the read buffer of the read framebuffer. </param>
        /// <param name="srcX1"> Specify the bounds of the source rectangle within the read buffer of the read framebuffer. </param>
        /// <param name="srcY1"> Specify the bounds of the source rectangle within the read buffer of the read framebuffer. </param>
        /// <param name="dstX0"> Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. </param>
        /// <param name="dstY0"> Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. </param>
        /// <param name="dstX1"> Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. </param>
        /// <param name="dstY1"> Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. </param>
        /// <param name="mask"> The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT and GL_STENCIL_BUFFER_BIT. </param>
        /// <param name="filter"> Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlitFramebuffer.xhtml" /></remarks>
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
        
        /// <summary> <b>[requires: v3.0] [glRenderbufferStorageMultisample]</b> Establish data storage, format, dimensions and sample count of a renderbuffer object&apos;s image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="samples"> Specifies the number of samples to be used for the renderbuffer object&apos;s storage. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object&apos;s image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorageMultisample.xhtml" /></remarks>
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0] [glFramebufferTextureLayer]</b> Attach a single layer of a texture to a framebuffer. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <param name="layer"> Specifies the layer of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTextureLayer.xhtml" /></remarks>
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayer_fnptr((uint)target, (uint)attachment, texture, level, layer);
        
        /// <summary> <b>[requires: v3.0] [glMapBufferRange]</b> Map a section of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the starting offset within the buffer of the range to be mapped. </param>
        /// <param name="length"> Specifies the length of the range to be mapped. </param>
        /// <param name="access"> Specifies a combination of access flags indicating the desired access to the range. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRange_fnptr((uint)target, offset, length, (uint)access);
        
        /// <summary> <b>[requires: v3.0] [glFlushMappedBufferRange]</b> Indicate modifications to a range of a mapped buffer. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the start of the buffer subrange, in basic machine units. </param>
        /// <param name="length"> Specifies the length of the buffer subrange, in basic machine units. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlushMappedBufferRange.xhtml" /></remarks>
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRange_fnptr((uint)target, offset, length);
        
        /// <summary> <b>[requires: v3.0] [glBindVertexArray]</b> Bind a vertex array object. </summary>
        /// <param name="array"> Specifies the name of the vertex array to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexArray.xhtml" /></remarks>
        public static void BindVertexArray(int array) => GLPointers._glBindVertexArray_fnptr(array);
        
        /// <summary> <b>[requires: v3.0] [glDeleteVertexArrays]</b> Delete vertex array objects. </summary>
        /// <param name="n"> Specifies the number of vertex array objects to be deleted. </param>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteVertexArrays.xhtml" /></remarks>
        public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArrays_fnptr(n, arrays);
        
        /// <summary> <b>[requires: v3.0] [glGenVertexArrays]</b> Generate vertex array object names. </summary>
        /// <param name="n"> Specifies the number of vertex array object names to generate. </param>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenVertexArrays.xhtml" /></remarks>
        public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArrays_fnptr(n, arrays);
        
        /// <summary> <b>[requires: v3.0] [glIsVertexArray]</b> Determine if a name corresponds to a vertex array object. </summary>
        /// <param name="array"> Specifies a value that may be the name of a vertex array object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsVertexArray.xhtml" /></remarks>
        public static bool IsVertexArray(int array) => GLPointers._glIsVertexArray_fnptr(array) != 0;
        
        /// <summary> <b>[requires: v3.0] [glGetIntegeri_v]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.0] [glBeginTransformFeedback]</b> Start transform feedback operation. </summary>
        /// <param name="primitiveMode"> Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform feedback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedback_fnptr((uint)primitiveMode);
        
        /// <summary> <b>[requires: v3.0] [glEndTransformFeedback]</b> Start transform feedback operation. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void EndTransformFeedback() => GLPointers._glEndTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0] [glBindBufferRange]</b> Bind a range within a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <param name="offset"> The starting offset in basic machine units into the buffer object buffer. </param>
        /// <param name="size"> The amount of data in machine units that can be read from the buffet object while used as an indexed target. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferRange.xhtml" /></remarks>
        public static void BindBufferRange(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRange_fnptr((uint)target, index, buffer, offset, size);
        
        /// <summary> <b>[requires: v3.0] [glBindBufferBase]</b> Bind a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferBase.xhtml" /></remarks>
        public static void BindBufferBase(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBase_fnptr((uint)target, index, buffer);
        
        /// <summary> <b>[requires: v3.0] [glTransformFeedbackVaryings]</b> Specify values to record in transform feedback buffers. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="count"> The number of varying variables used for transform feedback. </param>
        /// <param name="varyings"> An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback. </param>
        /// <param name="bufferMode"> Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTransformFeedbackVaryings.xhtml" /></remarks>
        public static void TransformFeedbackVaryings(int program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryings_fnptr(program, count, varyings, (uint)bufferMode);
        
        /// <summary> <b>[requires: v3.0] [glGetTransformFeedbackVarying]</b> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTransformFeedbackVarying.xhtml" /></remarks>
        public static void GetTransformFeedbackVarying(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribIPointer]</b> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v3.0] [glGetVertexAttribIiv]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetVertexAttribIuiv]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribI4i]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4i_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribI4ui]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4ui_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribI4iv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4iv(uint index, int* v) => GLPointers._glVertexAttribI4iv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribI4uiv]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4uiv(uint index, uint* v) => GLPointers._glVertexAttribI4uiv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.0] [glGetUniformuiv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformuiv(int program, int location, uint* parameters) => GLPointers._glGetUniformuiv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetFragDataLocation]</b> Query the bindings of color numbers to user-defined varying out variables. </summary>
        /// <param name="program"> The name of the program containing varying out variable whose binding to query </param>
        /// <param name="name"> The name of the user-defined varying out variable whose binding to query </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFragDataLocation.xhtml" /></remarks>
        public static int GetFragDataLocation(int program, byte* name) => GLPointers._glGetFragDataLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v3.0] [glUniform1ui]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1ui(int location, uint v0) => GLPointers._glUniform1ui_fnptr(location, v0);
        
        /// <summary> <b>[requires: v3.0] [glUniform2ui]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2ui(int location, uint v0, uint v1) => GLPointers._glUniform2ui_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v3.0] [glUniform3ui]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => GLPointers._glUniform3ui_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.0] [glUniform4ui]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glUniform4ui_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.0] [glUniform1uiv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1uiv(int location, int count, uint* value) => GLPointers._glUniform1uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0] [glUniform2uiv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2uiv(int location, int count, uint* value) => GLPointers._glUniform2uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0] [glUniform3uiv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3uiv(int location, int count, uint* value) => GLPointers._glUniform3uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0] [glUniform4uiv]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4uiv(int location, int count, uint* value) => GLPointers._glUniform4uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0] [glClearBufferiv]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearBufferiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0] [glClearBufferuiv]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearBufferuiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0] [glClearBufferfv]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearBufferfv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0] [glClearBufferfi]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="depth"> The value to clear a depth render buffer to. </param>
        /// <param name="stencil"> The value to clear a stencil render buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearBufferfi_fnptr((uint)buffer, drawbuffer, depth, stencil);
        
        /// <summary> <b>[requires: v3.0] [glGetStringi]</b> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <param name="index"> For glGetStringi, specifies the index of the string to return. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetStringi_(StringName name, uint index) => GLPointers._glGetStringi_fnptr((uint)name, index);
        
        /// <summary> <b>[requires: v3.0] [glCopyBufferSubData]</b> Copy part of the data store of a buffer object to the data store of another buffer object. </summary>
        /// <param name="readtarget"> Specifies the target from whose data store data should be read. </param>
        /// <param name="writetarget"> Specifies the target to whose data store data should be written. </param>
        /// <param name="readoffset"> Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read. </param>
        /// <param name="writeoffset"> Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written. </param>
        /// <param name="size"> Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyBufferSubData.xhtml" /></remarks>
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
        
        /// <summary> <b>[requires: v3.0] [glGetUniformIndices]</b> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformIndices.xhtml" /></remarks>
        public static void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._glGetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        
        /// <summary> <b>[requires: v3.0] [glGetActiveUniformsiv]</b> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
        /// <param name="parameters">Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformsiv.xhtml" /></remarks>
        public static void GetActiveUniformsiv(int program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._glGetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetUniformBlockIndex]</b> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters containing the name of the uniform block whose index to retrieve. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformBlockIndex.xhtml" /></remarks>
        public static uint GetUniformBlockIndex(int program, byte* uniformBlockName) => GLPointers._glGetUniformBlockIndex_fnptr(program, uniformBlockName);
        
        /// <summary> <b>[requires: v3.0] [glGetActiveUniformBlockiv]</b> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        /// <param name="parameters"> Specifies the address of a variable to receive the result of the query. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockiv.xhtml" /></remarks>
        public static void GetActiveUniformBlockiv(int program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._glGetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetActiveUniformBlockName]</b> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockName.xhtml" /></remarks>
        public static void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._glGetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        /// <summary> <b>[requires: v3.0] [glUniformBlockBinding]</b> Assign a binding point to an active uniform block. </summary>
        /// <param name="program"> The name of a program object containing the active uniform block whose binding to assign. </param>
        /// <param name="uniformBlockIndex"> The index of the active uniform block within program whose binding to assign. </param>
        /// <param name="uniformBlockBinding"> Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniformBlockBinding.xhtml" /></remarks>
        public static void UniformBlockBinding(int program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._glUniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        
        /// <summary> <b>[requires: v3.0] [glDrawArraysInstanced]</b> Draw multiple instances of a range of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysInstanced.xhtml" /></remarks>
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => GLPointers._glDrawArraysInstanced_fnptr((uint)mode, first, count, instancecount);
        
        /// <summary> <b>[requires: v3.0] [glDrawElementsInstanced]</b> Draw multiple instances of a set of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstanced.xhtml" /></remarks>
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => GLPointers._glDrawElementsInstanced_fnptr((uint)mode, count, (uint)type, indices, instancecount);
        
        /// <summary> <b>[requires: v3.0] [glFenceSync]</b> Create a new sync object and insert it into the GL command stream. </summary>
        /// <param name="condition"> Specifies the condition that must be met to set the sync object&apos;s state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. </param>
        /// <param name="flags"> Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFenceSync.xhtml" /></remarks>
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSync_fnptr((uint)condition, (uint)flags);
        
        /// <summary> <b>[requires: v3.0] [glIsSync]</b> Determine if a name corresponds to a sync object. </summary>
        /// <param name="sync"> Specifies a value that may be the name of a sync object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSync.xhtml" /></remarks>
        public static bool IsSync(GLSync sync) => GLPointers._glIsSync_fnptr((IntPtr)sync) != 0;
        
        /// <summary> <b>[requires: v3.0] [glDeleteSync]</b> Delete a sync object. </summary>
        /// <param name="sync"> The sync object to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSync.xhtml" /></remarks>
        public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSync_fnptr((IntPtr)sync);
        
        /// <summary> <b>[requires: v3.0] [glClientWaitSync]</b> Block and wait for a sync object to become signaled. </summary>
        /// <param name="sync"> The sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT. </param>
        /// <param name="timeout"> The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClientWaitSync.xhtml" /></remarks>
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary> <b>[requires: v3.0] [glWaitSync]</b> Instruct the GL server to block until the specified sync object becomes signaled. </summary>
        /// <param name="sync"> Specifies the sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags must be zero. </param>
        /// <param name="timeout"> Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglWaitSync.xhtml" /></remarks>
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary> <b>[requires: v3.0] [glGetInteger64v]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64v_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v3.0] [glGetSynciv]</b> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="bufSize"> Specifies the size of the buffer whose address is given in values. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSynciv.xhtml" /></remarks>
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
        
        /// <summary> <b>[requires: v3.0] [glGetInteger64i_v]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => GLPointers._glGetInteger64i_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.0] [glGetBufferParameteri64v]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => GLPointers._glGetBufferParameteri64v_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGenSamplers]</b> Generate sampler object names. </summary>
        /// <param name="n"> Specifies the number of sampler object names to generate. </param>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenSamplers.xhtml" /></remarks>
        public static void GenSamplers(int count, int* samplers) => GLPointers._glGenSamplers_fnptr(count, samplers);
        
        /// <summary> <b>[requires: v3.0] [glDeleteSamplers]</b> Delete named sampler objects. </summary>
        /// <param name="n"> Specifies the number of sampler objects to be deleted. </param>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSamplers.xhtml" /></remarks>
        public static void DeleteSamplers(int count, int* samplers) => GLPointers._glDeleteSamplers_fnptr(count, samplers);
        
        /// <summary> <b>[requires: v3.0] [glIsSampler]</b> Determine if a name corresponds to a sampler object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a sampler object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSampler.xhtml" /></remarks>
        public static bool IsSampler(int sampler) => GLPointers._glIsSampler_fnptr(sampler) != 0;
        
        /// <summary> <b>[requires: v3.0] [glBindSampler]</b> Bind a named sampler to a texturing target. </summary>
        /// <param name="unit"> Specifies the index of the texture unit to which the sampler is bound. </param>
        /// <param name="sampler"> Specifies the name of a sampler. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindSampler.xhtml" /></remarks>
        public static void BindSampler(uint unit, int sampler) => GLPointers._glBindSampler_fnptr(unit, sampler);
        
        /// <summary> <b>[requires: v3.0] [glSamplerParameteri]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteri(int sampler, SamplerParameterI pname, int param) => GLPointers._glSamplerParameteri_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0] [glSamplerParameteriv]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteriv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameteriv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0] [glSamplerParameterf]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterf(int sampler, SamplerParameterF pname, float param) => GLPointers._glSamplerParameterf_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0] [glSamplerParameterfv]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterfv(int sampler, SamplerParameterF pname, float* param) => GLPointers._glSamplerParameterfv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0] [glGetSamplerParameteriv]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameteriv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameteriv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glGetSamplerParameterfv]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterfv(int sampler, SamplerParameterF pname, float* parameters) => GLPointers._glGetSamplerParameterfv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0] [glVertexAttribDivisor]</b> Modify the rate at which generic vertex attributes advance during instanced rendering. </summary>
        /// <param name="index"> Specify the index of the generic vertex attribute. </param>
        /// <param name="divisor"> Specify the number of instances that will pass between updates of the generic attribute at slot index. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribDivisor.xhtml" /></remarks>
        public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisor_fnptr(index, divisor);
        
        /// <summary> <b>[requires: v3.0] [glBindTransformFeedback]</b> Bind a transform feedback object. </summary>
        /// <param name="target"> Specifies the target to which to bind the transform feedback object id. target must be GL_TRANSFORM_FEEDBACK. </param>
        /// <param name="id"> Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTransformFeedback.xhtml" /></remarks>
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, int id) => GLPointers._glBindTransformFeedback_fnptr((uint)target, id);
        
        /// <summary> <b>[requires: v3.0] [glDeleteTransformFeedbacks]</b> Delete transform feedback objects. </summary>
        /// <param name="n"> Specifies the number of transform feedback objects to delete. </param>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTransformFeedbacks.xhtml" /></remarks>
        public static void DeleteTransformFeedbacks(int n, int* ids) => GLPointers._glDeleteTransformFeedbacks_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0] [glGenTransformFeedbacks]</b> Reserve transform feedback object names. </summary>
        /// <param name="n"> Specifies the number of transform feedback object names to reserve. </param>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTransformFeedbacks.xhtml" /></remarks>
        public static void GenTransformFeedbacks(int n, int* ids) => GLPointers._glGenTransformFeedbacks_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0] [glIsTransformFeedback]</b> Determine if a name corresponds to a transform feedback object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a transform feedback object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTransformFeedback.xhtml" /></remarks>
        public static bool IsTransformFeedback(int id) => GLPointers._glIsTransformFeedback_fnptr(id) != 0;
        
        /// <summary> <b>[requires: v3.0] [glPauseTransformFeedback]</b> Pause transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPauseTransformFeedback.xhtml" /></remarks>
        public static void PauseTransformFeedback() => GLPointers._glPauseTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0] [glResumeTransformFeedback]</b> Resume transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglResumeTransformFeedback.xhtml" /></remarks>
        public static void ResumeTransformFeedback() => GLPointers._glResumeTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0] [glGetProgramBinary]</b> Return a binary representation of a program object&apos;s compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="bufsize">!!missing documentation!!</param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program&apos;s binary representation. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramBinary.xhtml" /></remarks>
        public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinary_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
        
        /// <summary> <b>[requires: v3.0] [glProgramBinary]</b> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramBinary.xhtml" /></remarks>
        public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinary_fnptr(program, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v3.0] [glProgramParameteri]</b> Specify a parameter for a program object. </summary>
        /// <param name="program"> Specifies the name of a program object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the name of the parameter to modify. </param>
        /// <param name="value"> Specifies the new value of the parameter specified by pname for program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramParameteri.xhtml" /></remarks>
        public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteri_fnptr(program, (uint)pname, value);
        
        /// <summary> <b>[requires: v3.0] [glInvalidateFramebuffer]</b> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateFramebuffer.xhtml" /></remarks>
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glInvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
        
        /// <summary> <b>[requires: v3.0] [glInvalidateSubFramebuffer]</b> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateSubFramebuffer.xhtml" /></remarks>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
        
        /// <summary> <b>[requires: v3.0] [glTexStorage2D]</b> Simultaneously specify storage for all levels of a two-dimensional texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_2D, or GL_TEXTURE_CUBE_MAP. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2D.xhtml" /></remarks>
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0] [glTexStorage3D]</b> Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array, or cube map array texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3D.xhtml" /></remarks>
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
        
        /// <summary> <b>[requires: v3.0] [glGetInternalformativ]</b> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        /// <param name="bufSize"> Specifies the maximum number of integers that may be written to params by the function. </param>
        /// <param name="parameters"> Specifies the address of a variable into which to write the retrieved information. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetInternalformativ.xhtml" /></remarks>
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        /// <summary> <b>[requires: v3.1] [glDispatchCompute]</b> Launch one or more compute work groups. </summary>
        /// <param name="num_groups_x"> The number of work groups to be launched in the X dimension. </param>
        /// <param name="num_groups_y"> The number of work groups to be launched in the Y dimension. </param>
        /// <param name="num_groups_z"> The number of work groups to be launched in the Z dimension. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchCompute.xhtml" /></remarks>
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._glDispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        
        /// <summary> <b>[requires: v3.1] [glDispatchComputeIndirect]</b> Launch one or more compute work groups using parameters stored in a buffer. </summary>
        /// <param name="indirect"> The offset into the buffer object currently bound to the GL_DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch parameters are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchComputeIndirect.xhtml" /></remarks>
        public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._glDispatchComputeIndirect_fnptr(indirect);
        
        /// <summary> <b>[requires: v3.1] [glDrawArraysIndirect]</b> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysIndirect.xhtml" /></remarks>
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._glDrawArraysIndirect_fnptr((uint)mode, indirect);
        
        /// <summary> <b>[requires: v3.1] [glDrawElementsIndirect]</b> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsIndirect.xhtml" /></remarks>
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._glDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
        
        /// <summary> <b>[requires: v3.1] [glFramebufferParameteri]</b> Set a named parameter of a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be modified. </param>
        /// <param name="param"> The new value for the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferParameteri.xhtml" /></remarks>
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.1] [glGetFramebufferParameteriv]</b> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        /// <param name="parameters"> The address of a variable to receive the value of the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferParameteriv.xhtml" /></remarks>
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramInterfaceiv]</b> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        /// <param name="parameters"> The address of a variable to retrieve the value of pname for the program interface. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInterface.xhtml" /></remarks>
        public static void GetProgramInterfaceiv(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._glGetProgramInterfaceiv_fnptr(program, (uint)programInterface, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramResourceIndex]</b> Query the index of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the index of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceIndex.xhtml" /></remarks>
        public static uint GetProgramResourceIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceIndex_fnptr(program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramResourceName]</b> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceName.xhtml" /></remarks>
        public static void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetProgramResourceName_fnptr(program, (uint)programInterface, index, bufSize, length, name);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramResourceiv]</b> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="propCount">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="bufSize">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
        /// <param name="parameters">!!missing documentation!!</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResource.xhtml" /></remarks>
        public static void GetProgramResourceiv(int program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => GLPointers._glGetProgramResourceiv_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramResourceLocation]</b> Query the location of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the location of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceLocation.xhtml" /></remarks>
        public static int GetProgramResourceLocation(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocation_fnptr(program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1] [glUseProgramStages]</b> Bind stages of a program object to a program pipeline. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to which to bind stages from program. </param>
        /// <param name="stages"> Specifies a set of program stages to bind to the program pipeline object. </param>
        /// <param name="program"> Specifies the program object containing the shader executables to use in pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgramStages.xhtml" /></remarks>
        public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStages_fnptr(pipeline, (uint)stages, program);
        
        /// <summary> <b>[requires: v3.1] [glActiveShaderProgram]</b> Set the active program object for a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to set the active program object for. </param>
        /// <param name="program"> Specifies the program object to set as the active program pipeline object pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveShaderProgram.xhtml" /></remarks>
        public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgram_fnptr(pipeline, program);
        
        /// <summary> <b>[requires: v3.1] [glCreateShaderProgramv]</b> Create a stand-alone program from an array of null-terminated source code strings. </summary>
        /// <param name="type"> Specifies the type of shader to create. </param>
        /// <param name="count"> Specifies the number of source code strings in the array strings. </param>
        /// <param name="strings"> Specifies the address of an array of pointers to source code strings from which to create the program object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShaderProgram.xhtml" /></remarks>
        public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramv_fnptr((uint)type, count, strings);
        
        /// <summary> <b>[requires: v3.1] [glBindProgramPipeline]</b> Bind a program pipeline to the current context. </summary>
        /// <param name="pipeline"> Specifies the name of the pipeline object to bind to the context. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindProgramPipeline.xhtml" /></remarks>
        public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipeline_fnptr(pipeline);
        
        /// <summary> <b>[requires: v3.1] [glDeleteProgramPipelines]</b> Delete program pipeline objects. </summary>
        /// <param name="n"> Specifies the number of program pipeline objects to delete. </param>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgramPipelines.xhtml" /></remarks>
        public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelines_fnptr(n, pipelines);
        
        /// <summary> <b>[requires: v3.1] [glGenProgramPipelines]</b> Reserve program pipeline object names. </summary>
        /// <param name="n"> Specifies the number of program pipeline object names to reserve. </param>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenProgramPipelines.xhtml" /></remarks>
        public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelines_fnptr(n, pipelines);
        
        /// <summary> <b>[requires: v3.1] [glIsProgramPipeline]</b> Determine if a name corresponds to a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies a value that may be the name of a program pipeline object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgramPipeline.xhtml" /></remarks>
        public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipeline_fnptr(pipeline) != 0;
        
        /// <summary> <b>[requires: v3.1] [glGetProgramPipelineiv]</b> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        /// <param name="parameters"> Specifies the address of a variable into which will be written the value or values of pname for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipeline.xhtml" /></remarks>
        public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineiv_fnptr(pipeline, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1i]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1i_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2i]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2i_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3i]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3i_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4i]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1ui]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1ui_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2ui]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2ui_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3ui]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4ui]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1f]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1f_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2f]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2f_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3f]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3f_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4f]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1iv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2iv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3iv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4iv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1uiv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2uiv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3uiv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4uiv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform1fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform2fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform3fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniform4fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix2fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix3fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix4fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix2x3fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix3x2fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix2x4fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix4x2fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix3x4fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glProgramUniformMatrix4x3fv]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1] [glValidateProgramPipeline]</b> Validate a program pipeline object against current GL state. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object to validate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgramPipeline.xhtml" /></remarks>
        public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipeline_fnptr(pipeline);
        
        /// <summary> <b>[requires: v3.1] [glGetProgramPipelineInfoLog]</b> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipelineInfoLog.xhtml" /></remarks>
        public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v3.1] [glBindImageTexture]</b> Bind a level of a texture to an image unit. </summary>
        /// <param name="unit"> Specifies the index of the image unit to which to bind the texture </param>
        /// <param name="texture"> Specifies the name of the texture to bind to the image unit. </param>
        /// <param name="level"> Specifies the level of the texture that is to be bound. </param>
        /// <param name="layered"> Specifies whether a layered texture binding is to be established. </param>
        /// <param name="layer"> If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise. </param>
        /// <param name="access"> Specifies a token indicating the type of access that will be performed on the image. </param>
        /// <param name="format"> Specifies the format that the elements of the image will be treated as for the purposes of formatted loads and stores. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindImageTexture.xhtml" /></remarks>
        public static void BindImageTexture(uint unit, int texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._glBindImageTexture_fnptr(unit, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, (uint)format);
        
        /// <summary> <b>[requires: v3.1] [glGetBooleani_v]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleani_v(BufferTargetARB target, uint index, bool* data) => GLPointers._glGetBooleani_v_fnptr((uint)target, index, (byte*)data);
        
        /// <summary> <b>[requires: v3.1] [glMemoryBarrier]</b> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrier_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.1] [glMemoryBarrierByRegion]</b> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierByRegion_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.1] [glTexStorage2DMultisample]</b> Specify storage for a two-dimensional multisample texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2DMultisample.xhtml" /></remarks>
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        /// <summary> <b>[requires: v3.1] [glGetMultisamplefv]</b> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetMultisamplefv.xhtml" /></remarks>
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefv_fnptr((uint)pname, index, val);
        
        /// <summary> <b>[requires: v3.1] [glSampleMaski]</b> Set the value of a sub-word of the sample mask. </summary>
        /// <param name="maskNumber"> Specifies which 32-bit sub-word of the sample mask to update. </param>
        /// <param name="mask"> Specifies the new value of the mask sub-word. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleMaski.xhtml" /></remarks>
        public static void SampleMaski(uint maskNumber, uint mask) => GLPointers._glSampleMaski_fnptr(maskNumber, mask);
        
        /// <summary> <b>[requires: v3.1] [glGetTexLevelParameteriv]</b> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameteriv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1] [glGetTexLevelParameterfv]</b> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexLevelParameterfv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1] [glBindVertexBuffer]</b> Bind a buffer to a vertex buffer bind point. </summary>
        /// <param name="bindingindex"> The index of the vertex buffer binding point to which to bind the buffer. </param>
        /// <param name="buffer"> The name of an existing buffer to bind to the vertex buffer binding point. </param>
        /// <param name="offset"> The offset of the first element of the buffer. </param>
        /// <param name="stride"> The distance between elements within the buffer. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexBuffer.xhtml" /></remarks>
        public static void BindVertexBuffer(uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glBindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        
        /// <summary> <b>[requires: v3.1] [glVertexAttribFormat]</b> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="normalized"> Specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexAttribFormat_fnptr(attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
        
        /// <summary> <b>[requires: v3.1] [glVertexAttribIFormat]</b> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        /// <summary> <b>[requires: v3.1] [glVertexAttribBinding]</b> Associate a vertex attribute and a vertex buffer binding. </summary>
        /// <param name="attribindex"> The index of the attribute to associate with a vertex buffer binding. </param>
        /// <param name="bindingindex"> The index of the vertex buffer binding with which to associate the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribBinding.xhtml" /></remarks>
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._glVertexAttribBinding_fnptr(attribindex, bindingindex);
        
        /// <summary> <b>[requires: v3.1] [glVertexBindingDivisor]</b> Modify the rate at which generic vertex attributes advance. </summary>
        /// <param name="bindingindex"> The index of the binding whose divisor to modify. </param>
        /// <param name="divisor"> The new value for the instance step rate to apply. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexBindingDivisor.xhtml" /></remarks>
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._glVertexBindingDivisor_fnptr(bindingindex, divisor);
        
        /// <summary> <b>[requires: v3.2] [glBlendBarrier]</b> Specifies a boundary between advanced blending passes. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendBarrier.xhtml" /></remarks>
        public static void BlendBarrier() => GLPointers._glBlendBarrier_fnptr();
        
        /// <summary> <b>[requires: v3.2] [glCopyImageSubData]</b> Perform a raw data copy between two images. </summary>
        /// <param name="srcName"> The name of a texture or renderbuffer object from which to copy. </param>
        /// <param name="srcTarget"> The target representing the namespace of the source name srcName. </param>
        /// <param name="srcLevel"> The mipmap level to read from the source. </param>
        /// <param name="srcX"> The X coordinate of the left edge of the souce region to copy. </param>
        /// <param name="srcY"> The Y coordinate of the top edge of the souce region to copy. </param>
        /// <param name="srcZ"> The Z coordinate of the near edge of the souce region to copy. </param>
        /// <param name="dstName"> The name of a texture or renderbuffer object to which to copy. </param>
        /// <param name="dstTarget"> The target representing the namespace of the destination name dstName. </param>
        /// <param name="dstLevel">!!missing documentation!!</param>
        /// <param name="dstX"> The X coordinate of the left edge of the destination region. </param>
        /// <param name="dstY"> The Y coordinate of the top edge of the destination region. </param>
        /// <param name="dstZ"> The Z coordinate of the near edge of the destination region. </param>
        /// <param name="srcWidth"> The width of the region to be copied. </param>
        /// <param name="srcHeight"> The height of the region to be copied. </param>
        /// <param name="srcDepth"> The depth of the region to be copied. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyImageSubData.xhtml" /></remarks>
        public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubData_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageControl]</b> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="count"> The length of the array ids. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageInsert]</b> Inject an application-supplied message into the debug message queue. </summary>
        /// <param name="source"> The source of the debug message to insert. </param>
        /// <param name="type"> The type of the debug message insert. </param>
        /// <param name="id"> The user-supplied identifier of the message to insert. </param>
        /// <param name="severity"> The severity of the debug messages to insert. </param>
        /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
        /// <param name="message"> The address of a character array containing the message to insert. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageCallback]</b> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetDebugMessageLog]</b> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetDebugMessageLog.xhtml" /></remarks>
        public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glPushDebugGroup]</b> Push a named debug group into the command stream. </summary>
        /// <param name="source"> The source of the debug message. </param>
        /// <param name="id"> The identifier of the message. </param>
        /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
        /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glPopDebugGroup]</b> Pop the active debug group. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
        public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glObjectLabel]</b> Label a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object to label. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetObjectLabel]</b> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glObjectPtrLabel]</b> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetObjectPtrLabel]</b> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetPointerv]</b> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glEnablei]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enablei(EnableCap target, uint index) => GLPointers._glEnablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v3.2] [glDisablei]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disablei(EnableCap target, uint index) => GLPointers._glDisablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v3.2] [glBlendEquationi]</b> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="buf"> for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation. </param>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationi_fnptr(buf, (uint)mode);
        
        /// <summary> <b>[requires: v3.2] [glBlendEquationSeparatei]</b> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="buf"> for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations. </param>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparatei_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v3.2] [glBlendFunci]</b> Specify pixel arithmetic. </summary>
        /// <param name="buf"> For glBlendFunci, specifies the index of the draw buffer for which to set the blend function. </param>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunci_fnptr(buf, (uint)src, (uint)dst);
        
        /// <summary> <b>[requires: v3.2] [glBlendFuncSeparatei]</b> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="buf"> For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions. </param>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparatei_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
        
        /// <summary> <b>[requires: v3.2] [glColorMaski]</b> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="buf"> For glColorMaski, specifies the index of the draw buffer whose color mask to set. </param>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaski_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
        
        /// <summary> <b>[requires: v3.2] [glIsEnabledi]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnabledi_fnptr((uint)target, index) != 0;
        
        /// <summary> <b>[requires: v3.2] [glDrawElementsBaseVertex]</b> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsBaseVertex.xhtml" /></remarks>
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v3.2] [glDrawRangeElementsBaseVertex]</b> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElementsBaseVertex.xhtml" /></remarks>
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v3.2] [glDrawElementsInstancedBaseVertex]</b> Render multiple instances of a set of primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the indexed geometry that should be drawn. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstancedBaseVertex.xhtml" /></remarks>
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
        
        /// <summary> <b>[requires: v3.2] [glFramebufferTexture]</b> Attach a level of a texture object as a logical buffer of a framebuffer object. </summary>
        /// <param name="target"> Specifies the target to which the framebuffer is bound. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="texture"> Specifies the name of an existing texture object to attach. </param>
        /// <param name="level"> Specifies the mipmap level of the texture object to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture.xhtml" /></remarks>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTexture_fnptr((uint)target, (uint)attachment, texture, level);
        
        /// <summary> <b>[requires: v3.2] [glPrimitiveBoundingBox]</b> Set the bounding box for a primitive. </summary>
        /// <param name="minX"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minY"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minZ"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minW"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="maxX"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxY"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxZ"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxW"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPrimitiveBoundingBox.xhtml" /></remarks>
        public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBox_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetGraphicsResetStatus]</b> Check if the rendering context has not been lost due to software or hardware issues. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
        public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glReadnPixels]</b> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
        /// <param name="data"> Returns the pixel data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
        public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformfv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformiv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformuiv]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2] [glMinSampleShading]</b> Specifies minimum rate at which sample shading takes place. </summary>
        /// <param name="value"> Specifies the rate at which samples are shaded within each covered pixel. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMinSampleShading.xhtml" /></remarks>
        public static void MinSampleShading(float value) => GLPointers._glMinSampleShading_fnptr(value);
        
        /// <summary> <b>[requires: v3.2] [glPatchParameteri]</b> Specifies the parameters for patch primitives. </summary>
        /// <param name="pname"> Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES is accepted. </param>
        /// <param name="value"> Specifies the new value for the parameter given by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPatchParameteri.xhtml" /></remarks>
        public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteri_fnptr((uint)pname, value);
        
        /// <summary> <b>[requires: v3.2] [glTexParameterIiv]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glTexParameterIuiv]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glGetTexParameterIiv]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glGetTexParameterIuiv]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glSamplerParameterIiv]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIiv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2] [glSamplerParameterIuiv]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuiv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2] [glGetSamplerParameterIiv]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIiv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glGetSamplerParameterIuiv]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuiv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2] [glTexBuffer]</b> Attach a buffer object&apos;s data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBuffer.xhtml" /></remarks>
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBuffer_fnptr((uint)target, (uint)internalformat, buffer);
        
        /// <summary> <b>[requires: v3.2] [glTexBufferRange]</b> Attach a range of a buffer object&apos;s data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexBufferRange. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <param name="offset"> Specifies the offset of the start of the range of the buffer&apos;s data store to attach. </param>
        /// <param name="size"> Specifies the size of the range of the buffer&apos;s data store to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBufferRange.xhtml" /></remarks>
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRange_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
        
        /// <summary> <b>[requires: v3.2] [glTexStorage3DMultisample]</b> Specify storage for a two-dimensional multisample array texture. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in layers. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3DMultisample.xhtml" /></remarks>
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced] [glRenderbufferStorageMultisampleAdvancedAMD]</b>  </summary>
            public static void RenderbufferStorageMultisampleAdvanced(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAdvancedAMD_fnptr((uint)target, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced] [glNamedRenderbufferStorageMultisampleAdvancedAMD]</b>  </summary>
            public static void NamedRenderbufferStorageMultisampleAdvanced(int renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorGroupsAMD]</b>  </summary>
            public static void GetPerfMonitorGroups(int* numGroups, int groupsSize, uint* groups) => GLPointers._glGetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorCountersAMD]</b>  </summary>
            public static void GetPerfMonitorCounters(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => GLPointers._glGetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorGroupStringAMD]</b>  </summary>
            public static void GetPerfMonitorGroupString(uint group, int bufSize, int* length, byte* groupString) => GLPointers._glGetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorCounterStringAMD]</b>  </summary>
            public static void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, int* length, byte* counterString) => GLPointers._glGetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorCounterInfoAMD]</b>  </summary>
            public static void GetPerfMonitorCounterInfo(uint group, uint counter, All pname, void* data) => GLPointers._glGetPerfMonitorCounterInfoAMD_fnptr(group, counter, (uint)pname, data);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGenPerfMonitorsAMD]</b>  </summary>
            public static void GenPerfMonitors(int n, uint* monitors) => GLPointers._glGenPerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glDeletePerfMonitorsAMD]</b>  </summary>
            public static void DeletePerfMonitors(int n, uint* monitors) => GLPointers._glDeletePerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glSelectPerfMonitorCountersAMD]</b>  </summary>
            public static void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, uint* counterList) => GLPointers._glSelectPerfMonitorCountersAMD_fnptr(monitor, (byte)(enable ? 1 : 0), group, numCounters, counterList);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glBeginPerfMonitorAMD]</b>  </summary>
            public static void BeginPerfMonitor(uint monitor) => GLPointers._glBeginPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glEndPerfMonitorAMD]</b>  </summary>
            public static void EndPerfMonitor(uint monitor) => GLPointers._glEndPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor] [glGetPerfMonitorCounterDataAMD]</b>  </summary>
            public static void GetPerfMonitorCounterData(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => GLPointers._glGetPerfMonitorCounterDataAMD_fnptr(monitor, (uint)pname, dataSize, data, bytesWritten);
            
        }
        /// <summary>ANGLE extensions.</summary>
        public static unsafe partial class ANGLE
        {
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_blit] [glBlitFramebufferANGLE]</b>  </summary>
            public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_multisample] [glRenderbufferStorageMultisampleANGLE]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleANGLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays] [glDrawArraysInstancedANGLE]</b>  </summary>
            public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedANGLE_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays] [glDrawElementsInstancedANGLE]</b>  </summary>
            public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedANGLE_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays] [glVertexAttribDivisorANGLE]</b>  </summary>
            public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisorANGLE_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_ANGLE_translated_shader_source] [glGetTranslatedShaderSourceANGLE]</b>  </summary>
            public static void GetTranslatedShaderSource(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetTranslatedShaderSourceANGLE_fnptr(shader, bufSize, length, source);
            
        }
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
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage] [glEGLImageTargetTexStorageEXT]</b>  </summary>
            public static void EGLImageTargetTexStorage(All target, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTexStorageEXT_fnptr((uint)target, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage] [glEGLImageTargetTextureStorageEXT]</b>  </summary>
            public static void EGLImageTargetTextureStorage(int texture, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_base_instance] [glDrawArraysInstancedBaseInstanceEXT]</b>  </summary>
            public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._glDrawArraysInstancedBaseInstanceEXT_fnptr((uint)mode, first, count, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_base_instance] [glDrawElementsInstancedBaseInstanceEXT]</b>  </summary>
            public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_base_instance] [glDrawElementsInstancedBaseVertexBaseInstanceEXT]</b>  </summary>
            public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended] [glBindFragDataLocationIndexedEXT]</b>  </summary>
            public static void BindFragDataLocationIndexed(int program, uint colorNumber, uint index, byte* name) => GLPointers._glBindFragDataLocationIndexedEXT_fnptr(program, colorNumber, index, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended] [glBindFragDataLocationEXT]</b>  </summary>
            public static void BindFragDataLocation(int program, uint color, byte* name) => GLPointers._glBindFragDataLocationEXT_fnptr(program, color, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended] [glGetProgramResourceLocationIndexEXT]</b>  </summary>
            public static int GetProgramResourceLocationIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocationIndexEXT_fnptr(program, (uint)programInterface, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended] [glGetFragDataIndexEXT]</b>  </summary>
            public static int GetFragDataIndex(int program, byte* name) => GLPointers._glGetFragDataIndexEXT_fnptr(program, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_minmax] [glBlendEquationEXT]</b>  </summary>
            public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_buffer_storage] [glBufferStorageEXT]</b>  </summary>
            public static void BufferStorage(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._glBufferStorageEXT_fnptr((uint)target, size, data, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture] [glClearTexImageEXT]</b>  </summary>
            public static void ClearTexImage(int texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexImageEXT_fnptr(texture, level, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture] [glClearTexSubImageEXT]</b>  </summary>
            public static void ClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexSubImageEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clip_control] [glClipControlEXT]</b>  </summary>
            public static void ClipControl(All origin, All depth) => GLPointers._glClipControlEXT_fnptr((uint)origin, (uint)depth);
            
            /// <summary> <b>[requires: GL_EXT_copy_image] [glCopyImageSubDataEXT]</b>  </summary>
            public static void CopyImageSubData(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataEXT_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_EXT_debug_label] [glLabelObjectEXT]</b>  </summary>
            public static void LabelObject(All type, uint obj, int length, byte* label) => GLPointers._glLabelObjectEXT_fnptr((uint)type, obj, length, label);
            
            /// <summary> <b>[requires: GL_EXT_debug_label] [glGetObjectLabelEXT]</b>  </summary>
            public static void GetObjectLabel(All type, uint obj, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelEXT_fnptr((uint)type, obj, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glInsertEventMarkerEXT]</b>  </summary>
            public static void InsertEventMarker(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glPushGroupMarkerEXT]</b>  </summary>
            public static void PushGroupMarker(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker] [glPopGroupMarkerEXT]</b>  </summary>
            public static void PopGroupMarker() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_discard_framebuffer] [glDiscardFramebufferEXT]</b>  </summary>
            public static void DiscardFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glDiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glGenQueriesEXT]</b>  </summary>
            public static void GenQueries(int n, int* ids) => GLPointers._glGenQueriesEXT_fnptr(n, ids);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glDeleteQueriesEXT]</b>  </summary>
            public static void DeleteQueries(int n, int* ids) => GLPointers._glDeleteQueriesEXT_fnptr(n, ids);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glIsQueryEXT]</b>  </summary>
            public static bool IsQuery(int id) => GLPointers._glIsQueryEXT_fnptr(id) != 0;
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glBeginQueryEXT]</b>  </summary>
            public static void BeginQuery(QueryTarget target, int id) => GLPointers._glBeginQueryEXT_fnptr((uint)target, id);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glEndQueryEXT]</b>  </summary>
            public static void EndQuery(QueryTarget target) => GLPointers._glEndQueryEXT_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query] [glQueryCounterEXT]</b>  </summary>
            public static void QueryCounter(int id, QueryCounterTarget target) => GLPointers._glQueryCounterEXT_fnptr(id, (uint)target);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glGetQueryivEXT]</b>  </summary>
            public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query] [glGetQueryObjectivEXT]</b>  </summary>
            public static void GetQueryObjectiv(int id, QueryObjectParameterName pname, int* parameters) => GLPointers._glGetQueryObjectivEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean] [glGetQueryObjectuivEXT]</b>  </summary>
            public static void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuivEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query] [glGetQueryObjecti64vEXT]</b>  </summary>
            public static void GetQueryObjecti64v(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64vEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query] [glGetQueryObjectui64vEXT]</b>  </summary>
            public static void GetQueryObjectui64v(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64vEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query] [glGetInteger64vEXT]</b>  </summary>
            public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64vEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers] [glDrawBuffersEXT]</b>  </summary>
            public static void DrawBuffers(int n, All* bufs) => GLPointers._glDrawBuffersEXT_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glEnableiEXT]</b>  </summary>
            public static void Enablei(EnableCap target, uint index) => GLPointers._glEnableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glDisableiEXT]</b>  </summary>
            public static void Disablei(EnableCap target, uint index) => GLPointers._glDisableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glBlendEquationiEXT]</b>  </summary>
            public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiEXT_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glBlendEquationSeparateiEXT]</b>  </summary>
            public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiEXT_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glBlendFunciEXT]</b>  </summary>
            public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciEXT_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glBlendFuncSeparateiEXT]</b>  </summary>
            public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiEXT_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glColorMaskiEXT]</b>  </summary>
            public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiEXT_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed] [glIsEnablediEXT]</b>  </summary>
            public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnablediEXT_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex] [glDrawElementsBaseVertexEXT]</b>  </summary>
            public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex] [glDrawRangeElementsBaseVertexEXT]</b>  </summary>
            public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexEXT_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex] [glDrawElementsInstancedBaseVertexEXT]</b>  </summary>
            public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex] [glMultiDrawElementsBaseVertexEXT]</b>  </summary>
            public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays] [glDrawArraysInstancedEXT]</b>  </summary>
            public static void DrawArraysInstanced(PrimitiveType mode, int start, int count, int primcount) => GLPointers._glDrawArraysInstancedEXT_fnptr((uint)mode, start, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays] [glDrawElementsInstancedEXT]</b>  </summary>
            public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback] [glDrawTransformFeedbackEXT]</b>  </summary>
            public static void DrawTransformFeedback(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedbackEXT_fnptr((uint)mode, id);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback] [glDrawTransformFeedbackInstancedEXT]</b>  </summary>
            public static void DrawTransformFeedbackInstanced(PrimitiveType mode, int id, int instancecount) => GLPointers._glDrawTransformFeedbackInstancedEXT_fnptr((uint)mode, id, instancecount);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer] [glBufferStorageExternalEXT]</b>  </summary>
            public static void BufferStorageExternal(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glBufferStorageExternalEXT_fnptr((uint)target, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer] [glNamedBufferStorageExternalEXT]</b>  </summary>
            public static void NamedBufferStorageExternal(int buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glNamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate] [glGetFragmentShadingRatesEXT]</b>  </summary>
            public static void GetFragmentShadingRates(int samples, int maxCount, int* count, ShadingRate* shadingRates) => GLPointers._glGetFragmentShadingRatesEXT_fnptr(samples, maxCount, count, (uint*)shadingRates);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate] [glShadingRateEXT]</b>  </summary>
            public static void ShadingRate(ShadingRate rate) => GLPointers._glShadingRateEXT_fnptr((uint)rate);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate] [glShadingRateCombinerOpsEXT]</b>  </summary>
            public static void ShadingRateCombinerOps(ShadingRateCombinerOp combinerOp0, ShadingRateCombinerOp combinerOp1) => GLPointers._glShadingRateCombinerOpsEXT_fnptr((uint)combinerOp0, (uint)combinerOp1);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate] [glFramebufferShadingRateEXT]</b>  </summary>
            public static void FramebufferShadingRate(FramebufferTarget target, FramebufferAttachment attachment, int texture, int baseLayer, int numLayers, int texelWidth, int texelHeight) => GLPointers._glFramebufferShadingRateEXT_fnptr((uint)target, (uint)attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
            
            /// <summary> <b>[requires: GL_EXT_framebuffer_blit_layers] [glBlitFramebufferLayersEXT]</b>  </summary>
            public static void BlitFramebufferLayers(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayersEXT_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_framebuffer_blit_layers] [glBlitFramebufferLayerEXT]</b>  </summary>
            public static void BlitFramebufferLayer(int srcX0, int srcY0, int srcX1, int srcY1, int srcLayer, int dstX0, int dstY0, int dstX1, int dstY1, int dstLayer, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayerEXT_fnptr(srcX0, srcY0, srcX1, srcY1, srcLayer, dstX0, dstY0, dstX1, dstY1, dstLayer, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_geometry_shader] [glFramebufferTextureEXT]</b>  </summary>
            public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureEXT_fnptr((uint)target, (uint)attachment, texture, level);
            
            /// <summary> <b>[requires: GL_EXT_instanced_arrays] [glVertexAttribDivisorEXT]</b>  </summary>
            public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisorEXT_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range] [glMapBufferRangeEXT]</b>  </summary>
            public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range] [glFlushMappedBufferRangeEXT]</b>  </summary>
            public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore] [glGetUnsignedBytevEXT]</b>  </summary>
            public static void GetUnsignedBytev(GetPName pname, byte* data) => GLPointers._glGetUnsignedBytevEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore] [glGetUnsignedBytei_vEXT]</b>  </summary>
            public static void GetUnsignedBytei_v(All target, uint index, byte* data) => GLPointers._glGetUnsignedBytei_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glDeleteMemoryObjectsEXT]</b>  </summary>
            public static void DeleteMemoryObjects(int n, uint* memoryObjects) => GLPointers._glDeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glIsMemoryObjectEXT]</b>  </summary>
            public static bool IsMemoryObject(uint memoryObject) => GLPointers._glIsMemoryObjectEXT_fnptr(memoryObject) != 0;
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glCreateMemoryObjectsEXT]</b>  </summary>
            public static void CreateMemoryObjects(int n, uint* memoryObjects) => GLPointers._glCreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glMemoryObjectParameterivEXT]</b>  </summary>
            public static void MemoryObjectParameteriv(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glGetMemoryObjectParameterivEXT]</b>  </summary>
            public static void GetMemoryObjectParameteriv(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glGetMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTexStorageMem2DEXT]</b>  </summary>
            public static void TexStorageMem2D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTexStorageMem2DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTexStorageMem2DMultisampleEXT]</b>  </summary>
            public static void TexStorageMem2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem2DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTexStorageMem3DEXT]</b>  </summary>
            public static void TexStorageMem3D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTexStorageMem3DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTexStorageMem3DMultisampleEXT]</b>  </summary>
            public static void TexStorageMem3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem3DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glBufferStorageMemEXT]</b>  </summary>
            public static void BufferStorageMem(BufferTargetARB target, nint size, uint memory, ulong offset) => GLPointers._glBufferStorageMemEXT_fnptr((uint)target, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTextureStorageMem2DEXT]</b>  </summary>
            public static void TextureStorageMem2D(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTextureStorageMem2DMultisampleEXT]</b>  </summary>
            public static void TextureStorageMem2DMultisample(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTextureStorageMem3DEXT]</b>  </summary>
            public static void TextureStorageMem3D(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTextureStorageMem3DMultisampleEXT]</b>  </summary>
            public static void TextureStorageMem3DMultisample(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glNamedBufferStorageMemEXT]</b>  </summary>
            public static void NamedBufferStorageMem(int buffer, nint size, uint memory, ulong offset) => GLPointers._glNamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTexStorageMem1DEXT]</b>  </summary>
            public static void TexStorageMem1D(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTexStorageMem1DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object] [glTextureStorageMem1DEXT]</b>  </summary>
            public static void TextureStorageMem1D(int texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTextureStorageMem1DEXT_fnptr(texture, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_fd] [glImportMemoryFdEXT]</b>  </summary>
            public static void ImportMemoryFd(uint memory, ulong size, ExternalHandleType handleType, int fd) => GLPointers._glImportMemoryFdEXT_fnptr(memory, size, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32] [glImportMemoryWin32HandleEXT]</b>  </summary>
            public static void ImportMemoryWin32Handle(uint memory, ulong size, ExternalHandleType handleType, void* handle) => GLPointers._glImportMemoryWin32HandleEXT_fnptr(memory, size, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32] [glImportMemoryWin32NameEXT]</b>  </summary>
            public static void ImportMemoryWin32Name(uint memory, ulong size, ExternalHandleType handleType, void* name) => GLPointers._glImportMemoryWin32NameEXT_fnptr(memory, size, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays] [glMultiDrawArraysEXT]</b>  </summary>
            public static void MultiDrawArrays(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays] [glMultiDrawElementsEXT]</b>  </summary>
            public static void MultiDrawElements(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect] [glMultiDrawArraysIndirectEXT]</b>  </summary>
            public static void MultiDrawArraysIndirect(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawArraysIndirectEXT_fnptr((uint)mode, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect] [glMultiDrawElementsIndirectEXT]</b>  </summary>
            public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawElementsIndirectEXT_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture] [glRenderbufferStorageMultisampleEXT]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture] [glFramebufferTexture2DMultisampleEXT]</b>  </summary>
            public static void FramebufferTexture2DMultisample(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers] [glReadBufferIndexedEXT]</b>  </summary>
            public static void ReadBufferIndexed(ReadBufferMode src, int index) => GLPointers._glReadBufferIndexedEXT_fnptr((uint)src, index);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers] [glDrawBuffersIndexedEXT]</b>  </summary>
            public static void DrawBuffersIndexed(int n, All* location, int* indices) => GLPointers._glDrawBuffersIndexedEXT_fnptr(n, (uint*)location, indices);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers] [glGetIntegeri_vEXT]</b>  </summary>
            public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_polygon_offset_clamp] [glPolygonOffsetClampEXT]</b>  </summary>
            public static void PolygonOffsetClamp(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClampEXT_fnptr(factor, units, clamp);
            
            /// <summary> <b>[requires: GL_EXT_primitive_bounding_box] [glPrimitiveBoundingBoxEXT]</b>  </summary>
            public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples] [glRasterSamplesEXT]</b>  </summary>
            public static void RasterSamples(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetGraphicsResetStatusEXT]</b>  </summary>
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glReadnPixelsEXT]</b>  </summary>
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetnUniformfvEXT]</b>  </summary>
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness] [glGetnUniformivEXT]</b>  </summary>
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glGenSemaphoresEXT]</b>  </summary>
            public static void GenSemaphores(int n, uint* semaphores) => GLPointers._glGenSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glDeleteSemaphoresEXT]</b>  </summary>
            public static void DeleteSemaphores(int n, uint* semaphores) => GLPointers._glDeleteSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glIsSemaphoreEXT]</b>  </summary>
            public static bool IsSemaphore(uint semaphore) => GLPointers._glIsSemaphoreEXT_fnptr(semaphore) != 0;
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glSemaphoreParameterui64vEXT]</b>  </summary>
            public static void SemaphoreParameterui64v(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glGetSemaphoreParameterui64vEXT]</b>  </summary>
            public static void GetSemaphoreParameterui64v(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glGetSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glWaitSemaphoreEXT]</b>  </summary>
            public static void WaitSemaphore(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* srcLayouts) => GLPointers._glWaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)srcLayouts);
            
            /// <summary> <b>[requires: GL_EXT_semaphore] [glSignalSemaphoreEXT]</b>  </summary>
            public static void SignalSemaphore(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* dstLayouts) => GLPointers._glSignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)dstLayouts);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_fd] [glImportSemaphoreFdEXT]</b>  </summary>
            public static void ImportSemaphoreFd(uint semaphore, ExternalHandleType handleType, int fd) => GLPointers._glImportSemaphoreFdEXT_fnptr(semaphore, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32] [glImportSemaphoreWin32HandleEXT]</b>  </summary>
            public static void ImportSemaphoreWin32Handle(uint semaphore, ExternalHandleType handleType, void* handle) => GLPointers._glImportSemaphoreWin32HandleEXT_fnptr(semaphore, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32] [glImportSemaphoreWin32NameEXT]</b>  </summary>
            public static void ImportSemaphoreWin32Name(uint semaphore, ExternalHandleType handleType, void* name) => GLPointers._glImportSemaphoreWin32NameEXT_fnptr(semaphore, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glUseShaderProgramEXT]</b>  </summary>
            public static void UseShaderProgram(All type, int program) => GLPointers._glUseShaderProgramEXT_fnptr((uint)type, program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glActiveProgramEXT]</b>  </summary>
            public static void ActiveProgram(int program) => GLPointers._glActiveProgramEXT_fnptr(program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glCreateShaderProgramEXT]</b>  </summary>
            public static int CreateShaderProgram(ShaderType type, byte* str) => GLPointers._glCreateShaderProgramEXT_fnptr((uint)type, str);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glActiveShaderProgramEXT]</b>  </summary>
            public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgramEXT_fnptr(pipeline, program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glBindProgramPipelineEXT]</b>  </summary>
            public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipelineEXT_fnptr(pipeline);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glCreateShaderProgramvEXT]</b>  </summary>
            public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramvEXT_fnptr((uint)type, count, strings);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glDeleteProgramPipelinesEXT]</b>  </summary>
            public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelinesEXT_fnptr(n, pipelines);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glGenProgramPipelinesEXT]</b>  </summary>
            public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelinesEXT_fnptr(n, pipelines);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glGetProgramPipelineInfoLogEXT]</b>  </summary>
            public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glGetProgramPipelineivEXT]</b>  </summary>
            public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineivEXT_fnptr(pipeline, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glIsProgramPipelineEXT]</b>  </summary>
            public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipelineEXT_fnptr(pipeline) != 0;
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramParameteriEXT]</b>  </summary>
            public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteriEXT_fnptr(program, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1fEXT]</b>  </summary>
            public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1fEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1fvEXT]</b>  </summary>
            public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1iEXT]</b>  </summary>
            public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1iEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1ivEXT]</b>  </summary>
            public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2fEXT]</b>  </summary>
            public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2fEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2fvEXT]</b>  </summary>
            public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2iEXT]</b>  </summary>
            public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2iEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2ivEXT]</b>  </summary>
            public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3fEXT]</b>  </summary>
            public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3fvEXT]</b>  </summary>
            public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3iEXT]</b>  </summary>
            public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3ivEXT]</b>  </summary>
            public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4fEXT]</b>  </summary>
            public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4fvEXT]</b>  </summary>
            public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4iEXT]</b>  </summary>
            public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4ivEXT]</b>  </summary>
            public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix2fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix3fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix4fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glUseProgramStagesEXT]</b>  </summary>
            public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStagesEXT_fnptr(pipeline, (uint)stages, program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glValidateProgramPipelineEXT]</b>  </summary>
            public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipelineEXT_fnptr(pipeline);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1uiEXT]</b>  </summary>
            public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1uiEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2uiEXT]</b>  </summary>
            public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3uiEXT]</b>  </summary>
            public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4uiEXT]</b>  </summary>
            public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform1uivEXT]</b>  </summary>
            public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform2uivEXT]</b>  </summary>
            public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform3uivEXT]</b>  </summary>
            public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniform4uivEXT]</b>  </summary>
            public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix2x3fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix3x2fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix2x4fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix4x2fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix3x4fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects] [glProgramUniformMatrix4x3fvEXT]</b>  </summary>
            public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_shader_framebuffer_fetch_non_coherent] [glFramebufferFetchBarrierEXT]</b>  </summary>
            public static void FramebufferFetchBarrier() => GLPointers._glFramebufferFetchBarrierEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2] [glFramebufferPixelLocalStorageSizeEXT]</b>  </summary>
            public static void FramebufferPixelLocalStorageSize(uint target, int size) => GLPointers._glFramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2] [glGetFramebufferPixelLocalStorageSizeEXT]</b>  </summary>
            public static int GetFramebufferPixelLocalStorageSize(FramebufferTarget target) => GLPointers._glGetFramebufferPixelLocalStorageSizeEXT_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2] [glClearPixelLocalStorageuiEXT]</b>  </summary>
            public static void ClearPixelLocalStorageui(int offset, int n, uint* values) => GLPointers._glClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            
            /// <summary> <b>[requires: GL_EXT_sparse_texture] [glTexPageCommitmentEXT]</b>  </summary>
            public static void TexPageCommitment(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => GLPointers._glTexPageCommitmentEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_tessellation_shader] [glPatchParameteriEXT]</b>  </summary>
            public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteriEXT_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glTexParameterIivEXT]</b>  </summary>
            public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glTexParameterIuivEXT]</b>  </summary>
            public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glGetTexParameterIivEXT]</b>  </summary>
            public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glGetTexParameterIuivEXT]</b>  </summary>
            public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glSamplerParameterIivEXT]</b>  </summary>
            public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivEXT_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glSamplerParameterIuivEXT]</b>  </summary>
            public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glGetSamplerParameterIivEXT]</b>  </summary>
            public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivEXT_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp] [glGetSamplerParameterIuivEXT]</b>  </summary>
            public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer] [glTexBufferEXT]</b>  </summary>
            public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferEXT_fnptr((uint)target, (uint)internalformat, buffer);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer] [glTexBufferRangeEXT]</b>  </summary>
            public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeEXT_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
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
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression] [glTexStorageAttribs2DEXT]</b>  </summary>
            public static void TexStorageAttribs2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, (int*)attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression] [glTexStorageAttribs3DEXT]</b>  </summary>
            public static void TexStorageAttribs3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth, (int*)attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_texture_view] [glTextureViewEXT]</b>  </summary>
            public static void TextureView(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewEXT_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex] [glAcquireKeyedMutexWin32EXT]</b>  </summary>
            public static bool AcquireKeyedMutexWin32(uint memory, ulong key, uint timeout) => GLPointers._glAcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout) != 0;
            
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex] [glReleaseKeyedMutexWin32EXT]</b>  </summary>
            public static bool ReleaseKeyedMutexWin32(uint memory, ulong key) => GLPointers._glReleaseKeyedMutexWin32EXT_fnptr(memory, key) != 0;
            
            /// <summary> <b>[requires: GL_EXT_window_rectangles] [glWindowRectanglesEXT]</b>  </summary>
            public static void WindowRectangles(All mode, int count, int* box) => GLPointers._glWindowRectanglesEXT_fnptr((uint)mode, count, box);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GL_NV_timeline_semaphore] [glCreateSemaphoresNV]</b>  </summary>
            public static void CreateSemaphores(int n, uint* semaphores) => GLPointers._glCreateSemaphoresNV_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore] [glSemaphoreParameterivNV]</b>  </summary>
            public static void SemaphoreParameteriv(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore] [glGetSemaphoreParameterivNV]</b>  </summary>
            public static void GetSemaphoreParameteriv(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glGetSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glGetTextureHandleNV]</b>  </summary>
            public static ulong GetTextureHandle(int texture) => GLPointers._glGetTextureHandleNV_fnptr(texture);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glGetTextureSamplerHandleNV]</b>  </summary>
            public static ulong GetTextureSamplerHandle(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleNV_fnptr(texture, sampler);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glMakeTextureHandleResidentNV]</b>  </summary>
            public static void MakeTextureHandleResident(ulong handle) => GLPointers._glMakeTextureHandleResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glMakeTextureHandleNonResidentNV]</b>  </summary>
            public static void MakeTextureHandleNonResident(ulong handle) => GLPointers._glMakeTextureHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glGetImageHandleNV]</b>  </summary>
            public static ulong GetImageHandle(int texture, int level, bool layered, int layer, PixelFormat format) => GLPointers._glGetImageHandleNV_fnptr(texture, level, (byte)(layered ? 1 : 0), layer, (uint)format);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glMakeImageHandleResidentNV]</b>  </summary>
            public static void MakeImageHandleResident(ulong handle, All access) => GLPointers._glMakeImageHandleResidentNV_fnptr(handle, (uint)access);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glMakeImageHandleNonResidentNV]</b>  </summary>
            public static void MakeImageHandleNonResident(ulong handle) => GLPointers._glMakeImageHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glUniformHandleui64NV]</b>  </summary>
            public static void UniformHandleui64(int location, ulong value) => GLPointers._glUniformHandleui64NV_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glUniformHandleui64vNV]</b>  </summary>
            public static void UniformHandleui64v(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glProgramUniformHandleui64NV]</b>  </summary>
            public static void ProgramUniformHandleui64(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64NV_fnptr(program, location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glProgramUniformHandleui64vNV]</b>  </summary>
            public static void ProgramUniformHandleui64v(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glIsTextureHandleResidentNV]</b>  </summary>
            public static bool IsTextureHandleResident(ulong handle) => GLPointers._glIsTextureHandleResidentNV_fnptr(handle) != 0;
            
            /// <summary> <b>[requires: GL_NV_bindless_texture] [glIsImageHandleResidentNV]</b>  </summary>
            public static bool IsImageHandleResident(ulong handle) => GLPointers._glIsImageHandleResidentNV_fnptr(handle) != 0;
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced] [glBlendParameteriNV]</b>  </summary>
            public static void BlendParameteri(All pname, int value) => GLPointers._glBlendParameteriNV_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced] [glBlendBarrierNV]</b>  </summary>
            public static void BlendBarrier() => GLPointers._glBlendBarrierNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_clip_space_w_scaling] [glViewportPositionWScaleNV]</b>  </summary>
            public static void ViewportPositionWScale(uint index, float xcoeff, float ycoeff) => GLPointers._glViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            
            /// <summary> <b>[requires: GL_NV_conditional_render] [glBeginConditionalRenderNV]</b>  </summary>
            public static void BeginConditionalRender(uint id, ConditionalRenderMode mode) => GLPointers._glBeginConditionalRenderNV_fnptr(id, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_conditional_render] [glEndConditionalRenderNV]</b>  </summary>
            public static void EndConditionalRender() => GLPointers._glEndConditionalRenderNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_conservative_raster] [glSubpixelPrecisionBiasNV]</b>  </summary>
            public static void SubpixelPrecisionBias(uint xbits, uint ybits) => GLPointers._glSubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            
            /// <summary> <b>[requires: GL_NV_conservative_raster_pre_snap_triangles] [glConservativeRasterParameteriNV]</b>  </summary>
            public static void ConservativeRasterParameteri(All pname, int param) => GLPointers._glConservativeRasterParameteriNV_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_NV_copy_buffer] [glCopyBufferSubDataNV]</b>  </summary>
            public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubDataNV_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GL_NV_coverage_sample] [glCoverageMaskNV]</b>  </summary>
            public static void CoverageMask(bool mask) => GLPointers._glCoverageMaskNV_fnptr((byte)(mask ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_coverage_sample] [glCoverageOperationNV]</b>  </summary>
            public static void CoverageOperation(All operation) => GLPointers._glCoverageOperationNV_fnptr((uint)operation);
            
            /// <summary> <b>[requires: GL_NV_draw_buffers] [glDrawBuffersNV]</b>  </summary>
            public static void DrawBuffers(int n, All* bufs) => GLPointers._glDrawBuffersNV_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced] [glDrawArraysInstancedNV]</b>  </summary>
            public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedNV_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced] [glDrawElementsInstancedNV]</b>  </summary>
            public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedNV_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image] [glDrawVkImageNV]</b>  </summary>
            public static void DrawVkImage(ulong vkImage, int sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._glDrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image] [glGetVkProcAddrNV]</b>  </summary>
            public static IntPtr GetVkProcAddr(byte* name) => GLPointers._glGetVkProcAddrNV_fnptr(name);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image] [glWaitVkSemaphoreNV]</b>  </summary>
            public static void WaitVkSemaphore(ulong vkSemaphore) => GLPointers._glWaitVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image] [glSignalVkSemaphoreNV]</b>  </summary>
            public static void SignalVkSemaphore(ulong vkSemaphore) => GLPointers._glSignalVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image] [glSignalVkFenceNV]</b>  </summary>
            public static void SignalVkFence(ulong vkFence) => GLPointers._glSignalVkFenceNV_fnptr(vkFence);
            
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
            
            /// <summary> <b>[requires: GL_NV_fragment_coverage_to_color] [glFragmentCoverageColorNV]</b>  </summary>
            public static void FragmentCoverageColor(uint color) => GLPointers._glFragmentCoverageColorNV_fnptr(color);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_blit] [glBlitFramebufferNV]</b>  </summary>
            public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples] [glRasterSamplesEXT]</b>  </summary>
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples] [glCoverageModulationTableNV]</b>  </summary>
            public static void CoverageModulationTable(int n, float* v) => GLPointers._glCoverageModulationTableNV_fnptr(n, v);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples] [glGetCoverageModulationTableNV]</b>  </summary>
            public static void GetCoverageModulationTable(int bufSize, float* v) => GLPointers._glGetCoverageModulationTableNV_fnptr(bufSize, v);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples] [glCoverageModulationNV]</b>  </summary>
            public static void CoverageModulation(All components) => GLPointers._glCoverageModulationNV_fnptr((uint)components);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_multisample] [glRenderbufferStorageMultisampleNV]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleNV_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform1i64NV]</b>  </summary>
            public static void Uniform1i64(int location, long x) => GLPointers._glUniform1i64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform2i64NV]</b>  </summary>
            public static void Uniform2i64(int location, long x, long y) => GLPointers._glUniform2i64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform3i64NV]</b>  </summary>
            public static void Uniform3i64(int location, long x, long y, long z) => GLPointers._glUniform3i64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform4i64NV]</b>  </summary>
            public static void Uniform4i64(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform1i64vNV]</b>  </summary>
            public static void Uniform1i64v(int location, int count, long* value) => GLPointers._glUniform1i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform2i64vNV]</b>  </summary>
            public static void Uniform2i64v(int location, int count, long* value) => GLPointers._glUniform2i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform3i64vNV]</b>  </summary>
            public static void Uniform3i64v(int location, int count, long* value) => GLPointers._glUniform3i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform4i64vNV]</b>  </summary>
            public static void Uniform4i64v(int location, int count, long* value) => GLPointers._glUniform4i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform1ui64NV]</b>  </summary>
            public static void Uniform1ui64(int location, ulong x) => GLPointers._glUniform1ui64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform2ui64NV]</b>  </summary>
            public static void Uniform2ui64(int location, ulong x, ulong y) => GLPointers._glUniform2ui64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform3ui64NV]</b>  </summary>
            public static void Uniform3ui64(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform4ui64NV]</b>  </summary>
            public static void Uniform4ui64(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform1ui64vNV]</b>  </summary>
            public static void Uniform1ui64v(int location, int count, ulong* value) => GLPointers._glUniform1ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform2ui64vNV]</b>  </summary>
            public static void Uniform2ui64v(int location, int count, ulong* value) => GLPointers._glUniform2ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform3ui64vNV]</b>  </summary>
            public static void Uniform3ui64v(int location, int count, ulong* value) => GLPointers._glUniform3ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glUniform4ui64vNV]</b>  </summary>
            public static void Uniform4ui64v(int location, int count, ulong* value) => GLPointers._glUniform4ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glGetUniformi64vNV]</b>  </summary>
            public static void GetUniformi64v(int program, int location, long* parameters) => GLPointers._glGetUniformi64vNV_fnptr(program, location, parameters);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform1i64NV]</b>  </summary>
            public static void ProgramUniform1i64(int program, int location, long x) => GLPointers._glProgramUniform1i64NV_fnptr(program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform2i64NV]</b>  </summary>
            public static void ProgramUniform2i64(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64NV_fnptr(program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform3i64NV]</b>  </summary>
            public static void ProgramUniform3i64(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64NV_fnptr(program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform4i64NV]</b>  </summary>
            public static void ProgramUniform4i64(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform1i64vNV]</b>  </summary>
            public static void ProgramUniform1i64v(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform2i64vNV]</b>  </summary>
            public static void ProgramUniform2i64v(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform3i64vNV]</b>  </summary>
            public static void ProgramUniform3i64v(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform4i64vNV]</b>  </summary>
            public static void ProgramUniform4i64v(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform1ui64NV]</b>  </summary>
            public static void ProgramUniform1ui64(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64NV_fnptr(program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform2ui64NV]</b>  </summary>
            public static void ProgramUniform2ui64(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64NV_fnptr(program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform3ui64NV]</b>  </summary>
            public static void ProgramUniform3ui64(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform4ui64NV]</b>  </summary>
            public static void ProgramUniform4ui64(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform1ui64vNV]</b>  </summary>
            public static void ProgramUniform1ui64v(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform2ui64vNV]</b>  </summary>
            public static void ProgramUniform2ui64v(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform3ui64vNV]</b>  </summary>
            public static void ProgramUniform3ui64v(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5] [glProgramUniform4ui64vNV]</b>  </summary>
            public static void ProgramUniform4ui64v(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_instanced_arrays] [glVertexAttribDivisorNV]</b>  </summary>
            public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisorNV_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_NV_internalformat_sample_query] [glGetInternalformatSampleivNV]</b>  </summary>
            public static void GetInternalformatSampleiv(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformatSampleivNV_fnptr((uint)target, (uint)internalformat, samples, (uint)pname, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glGetMemoryObjectDetachedResourcesuivNV]</b>  </summary>
            public static void GetMemoryObjectDetachedResourcesuiv(uint memory, All pname, int first, int count, uint* parameters) => GLPointers._glGetMemoryObjectDetachedResourcesuivNV_fnptr(memory, (uint)pname, first, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glResetMemoryObjectParameterNV]</b>  </summary>
            public static void ResetMemoryObjectParameter(uint memory, All pname) => GLPointers._glResetMemoryObjectParameterNV_fnptr(memory, (uint)pname);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glTexAttachMemoryNV]</b>  </summary>
            public static void TexAttachMemory(TextureTarget target, uint memory, ulong offset) => GLPointers._glTexAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glBufferAttachMemoryNV]</b>  </summary>
            public static void BufferAttachMemory(BufferTargetARB target, uint memory, ulong offset) => GLPointers._glBufferAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glTextureAttachMemoryNV]</b>  </summary>
            public static void TextureAttachMemory(int texture, uint memory, ulong offset) => GLPointers._glTextureAttachMemoryNV_fnptr(texture, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment] [glNamedBufferAttachMemoryNV]</b>  </summary>
            public static void NamedBufferAttachMemory(int buffer, uint memory, ulong offset) => GLPointers._glNamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse] [glBufferPageCommitmentMemNV]</b>  </summary>
            public static void BufferPageCommitmentMem(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glBufferPageCommitmentMemNV_fnptr((uint)target, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse] [glTexPageCommitmentMemNV]</b>  </summary>
            public static void TexPageCommitmentMem(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexPageCommitmentMemNV_fnptr((uint)target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse] [glNamedBufferPageCommitmentMemNV]</b>  </summary>
            public static void NamedBufferPageCommitmentMem(int buffer, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glNamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse] [glTexturePageCommitmentMemNV]</b>  </summary>
            public static void TexturePageCommitmentMem(int texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_mesh_shader] [glDrawMeshTasksNV]</b>  </summary>
            public static void DrawMeshTasks(uint first, uint count) => GLPointers._glDrawMeshTasksNV_fnptr(first, count);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader] [glDrawMeshTasksIndirectNV]</b>  </summary>
            public static void DrawMeshTasksIndirect(IntPtr indirect) => GLPointers._glDrawMeshTasksIndirectNV_fnptr(indirect);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader] [glMultiDrawMeshTasksIndirectNV]</b>  </summary>
            public static void MultiDrawMeshTasksIndirect(IntPtr indirect, int drawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader] [glMultiDrawMeshTasksIndirectCountNV]</b>  </summary>
            public static void MultiDrawMeshTasksIndirectCount(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix2x3fvNV]</b>  </summary>
            public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix3x2fvNV]</b>  </summary>
            public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix2x4fvNV]</b>  </summary>
            public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix4x2fvNV]</b>  </summary>
            public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix3x4fvNV]</b>  </summary>
            public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices] [glUniformMatrix4x3fvNV]</b>  </summary>
            public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGenPathsNV]</b>  </summary>
            public static uint GenPaths(int range) => GLPointers._glGenPathsNV_fnptr(range);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glDeletePathsNV]</b>  </summary>
            public static void DeletePaths(uint path, int range) => GLPointers._glDeletePathsNV_fnptr(path, range);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glIsPathNV]</b>  </summary>
            public static bool IsPath(uint path) => GLPointers._glIsPathNV_fnptr(path) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathCommandsNV]</b>  </summary>
            public static void PathCommands(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCommandsNV_fnptr(path, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathCoordsNV]</b>  </summary>
            public static void PathCoords(uint path, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCoordsNV_fnptr(path, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathSubCommandsNV]</b>  </summary>
            public static void PathSubCommands(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathSubCoordsNV]</b>  </summary>
            public static void PathSubCoords(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCoordsNV_fnptr(path, coordStart, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathStringNV]</b>  </summary>
            public static void PathString(uint path, PathStringFormat format, int length, void* pathString) => GLPointers._glPathStringNV_fnptr(path, (uint)format, length, pathString);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathGlyphsNV]</b>  </summary>
            public static void PathGlyphs(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphsNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, numGlyphs, (uint)type, charcodes, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathGlyphRangeNV]</b>  </summary>
            public static void PathGlyphRange(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphRangeNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyph, numGlyphs, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glWeightPathsNV]</b>  </summary>
            public static void WeightPaths(uint resultPath, int numPaths, uint* paths, float* weights) => GLPointers._glWeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glCopyPathNV]</b>  </summary>
            public static void CopyPath(uint resultPath, uint srcPath) => GLPointers._glCopyPathNV_fnptr(resultPath, srcPath);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glInterpolatePathsNV]</b>  </summary>
            public static void InterpolatePaths(uint resultPath, uint pathA, uint pathB, float weight) => GLPointers._glInterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glTransformPathNV]</b>  </summary>
            public static void TransformPath(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => GLPointers._glTransformPathNV_fnptr(resultPath, srcPath, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathParameterivNV]</b>  </summary>
            public static void PathParameteriv(uint path, PathParameter pname, int* value) => GLPointers._glPathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathParameteriNV]</b>  </summary>
            public static void PathParameteri(uint path, PathParameter pname, int value) => GLPointers._glPathParameteriNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathParameterfvNV]</b>  </summary>
            public static void PathParameterfv(uint path, PathParameter pname, float* value) => GLPointers._glPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathParameterfNV]</b>  </summary>
            public static void PathParameterf(uint path, PathParameter pname, float value) => GLPointers._glPathParameterfNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathDashArrayNV]</b>  </summary>
            public static void PathDashArray(uint path, int dashCount, float* dashArray) => GLPointers._glPathDashArrayNV_fnptr(path, dashCount, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathStencilFuncNV]</b>  </summary>
            public static void PathStencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glPathStencilFuncNV_fnptr((uint)func, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathStencilDepthOffsetNV]</b>  </summary>
            public static void PathStencilDepthOffset(float factor, float units) => GLPointers._glPathStencilDepthOffsetNV_fnptr(factor, units);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilFillPathNV]</b>  </summary>
            public static void StencilFillPath(uint path, PathFillMode fillMode, uint mask) => GLPointers._glStencilFillPathNV_fnptr(path, (uint)fillMode, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilStrokePathNV]</b>  </summary>
            public static void StencilStrokePath(uint path, int reference, uint mask) => GLPointers._glStencilStrokePathNV_fnptr(path, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilFillPathInstancedNV]</b>  </summary>
            public static void StencilFillPathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilStrokePathInstancedNV]</b>  </summary>
            public static void StencilStrokePathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathCoverDepthFuncNV]</b>  </summary>
            public static void PathCoverDepthFunc(DepthFunction func) => GLPointers._glPathCoverDepthFuncNV_fnptr((uint)func);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glCoverFillPathNV]</b>  </summary>
            public static void CoverFillPath(uint path, PathCoverMode coverMode) => GLPointers._glCoverFillPathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glCoverStrokePathNV]</b>  </summary>
            public static void CoverStrokePath(uint path, PathCoverMode coverMode) => GLPointers._glCoverStrokePathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glCoverFillPathInstancedNV]</b>  </summary>
            public static void CoverFillPathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glCoverStrokePathInstancedNV]</b>  </summary>
            public static void CoverStrokePathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathParameterivNV]</b>  </summary>
            public static void GetPathParameteriv(uint path, PathParameter pname, int* value) => GLPointers._glGetPathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathParameterfvNV]</b>  </summary>
            public static void GetPathParameterfv(uint path, PathParameter pname, float* value) => GLPointers._glGetPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathCommandsNV]</b>  </summary>
            public static void GetPathCommands(uint path, byte* commands) => GLPointers._glGetPathCommandsNV_fnptr(path, commands);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathCoordsNV]</b>  </summary>
            public static void GetPathCoords(uint path, float* coords) => GLPointers._glGetPathCoordsNV_fnptr(path, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathDashArrayNV]</b>  </summary>
            public static void GetPathDashArray(uint path, float* dashArray) => GLPointers._glGetPathDashArrayNV_fnptr(path, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathMetricsNV]</b>  </summary>
            public static void GetPathMetrics(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => GLPointers._glGetPathMetricsNV_fnptr((uint)metricQueryMask, numPaths, (uint)pathNameType, paths, pathBase, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathMetricRangeNV]</b>  </summary>
            public static void GetPathMetricRange(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => GLPointers._glGetPathMetricRangeNV_fnptr((uint)metricQueryMask, firstPathName, numPaths, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathSpacingNV]</b>  </summary>
            public static void GetPathSpacing(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => GLPointers._glGetPathSpacingNV_fnptr((uint)pathListMode, numPaths, (uint)pathNameType, paths, pathBase, advanceScale, kerningScale, (uint)transformType, returnedSpacing);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glIsPointInFillPathNV]</b>  </summary>
            public static bool IsPointInFillPath(uint path, uint mask, float x, float y) => GLPointers._glIsPointInFillPathNV_fnptr(path, mask, x, y) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glIsPointInStrokePathNV]</b>  </summary>
            public static bool IsPointInStrokePath(uint path, float x, float y) => GLPointers._glIsPointInStrokePathNV_fnptr(path, x, y) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetPathLengthNV]</b>  </summary>
            public static float GetPathLength(uint path, int startSegment, int numSegments) => GLPointers._glGetPathLengthNV_fnptr(path, startSegment, numSegments);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPointAlongPathNV]</b>  </summary>
            public static bool PointAlongPath(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => GLPointers._glPointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoad3x2fNV]</b>  </summary>
            public static void MatrixLoad3x2f(All matrixMode, float* m) => GLPointers._glMatrixLoad3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoad3x3fNV]</b>  </summary>
            public static void MatrixLoad3x3f(All matrixMode, float* m) => GLPointers._glMatrixLoad3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoadTranspose3x3fNV]</b>  </summary>
            public static void MatrixLoadTranspose3x3f(All matrixMode, float* m) => GLPointers._glMatrixLoadTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMult3x2fNV]</b>  </summary>
            public static void MatrixMult3x2f(All matrixMode, float* m) => GLPointers._glMatrixMult3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMult3x3fNV]</b>  </summary>
            public static void MatrixMult3x3f(All matrixMode, float* m) => GLPointers._glMatrixMult3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMultTranspose3x3fNV]</b>  </summary>
            public static void MatrixMultTranspose3x3f(All matrixMode, float* m) => GLPointers._glMatrixMultTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilThenCoverFillPathNV]</b>  </summary>
            public static void StencilThenCoverFillPath(uint path, PathFillMode fillMode, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverFillPathNV_fnptr(path, (uint)fillMode, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilThenCoverStrokePathNV]</b>  </summary>
            public static void StencilThenCoverStrokePath(uint path, int reference, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverStrokePathNV_fnptr(path, reference, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilThenCoverFillPathInstancedNV]</b>  </summary>
            public static void StencilThenCoverFillPathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glStencilThenCoverStrokePathInstancedNV]</b>  </summary>
            public static void StencilThenCoverStrokePathInstanced(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathGlyphIndexRangeNV]</b>  </summary>
            public static All PathGlyphIndexRange(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => (All) GLPointers._glPathGlyphIndexRangeNV_fnptr((uint)fontTarget, fontName, (uint)fontStyle, pathParameterTemplate, emScale, baseAndCount);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathGlyphIndexArrayNV]</b>  </summary>
            public static All PathGlyphIndexArray(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glPathMemoryGlyphIndexArrayNV]</b>  </summary>
            public static All PathMemoryGlyphIndexArray(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathMemoryGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glProgramPathFragmentInputGenNV]</b>  </summary>
            public static void ProgramPathFragmentInputGen(int program, int location, All genMode, int components, float* coeffs) => GLPointers._glProgramPathFragmentInputGenNV_fnptr(program, location, (uint)genMode, components, coeffs);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glGetProgramResourcefvNV]</b>  </summary>
            public static void GetProgramResourcefv(int program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => GLPointers._glGetProgramResourcefvNV_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixFrustumEXT]</b>  </summary>
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoadIdentityEXT]</b>  </summary>
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._glMatrixLoadIdentityEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoadTransposefEXT]</b>  </summary>
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoadTransposedEXT]</b>  </summary>
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoadfEXT]</b>  </summary>
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixLoaddEXT]</b>  </summary>
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoaddEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMultTransposefEXT]</b>  </summary>
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMultTransposedEXT]</b>  </summary>
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMultfEXT]</b>  </summary>
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixMultdEXT]</b>  </summary>
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultdEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixOrthoEXT]</b>  </summary>
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixPopEXT]</b>  </summary>
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._glMatrixPopEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixPushEXT]</b>  </summary>
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._glMatrixPushEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixRotatefEXT]</b>  </summary>
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._glMatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixRotatedEXT]</b>  </summary>
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._glMatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixScalefEXT]</b>  </summary>
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixScaledEXT]</b>  </summary>
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixTranslatefEXT]</b>  </summary>
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering] [glMatrixTranslatedEXT]</b>  </summary>
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_polygon_mode] [glPolygonModeNV]</b>  </summary>
            public static void PolygonMode(TriangleFace face, PolygonMode mode) => GLPointers._glPolygonModeNV_fnptr((uint)face, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_read_buffer] [glReadBufferNV]</b>  </summary>
            public static void ReadBuffer(All mode) => GLPointers._glReadBufferNV_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_sample_locations] [glFramebufferSampleLocationsfvNV]</b>  </summary>
            public static void FramebufferSampleLocationsfv(FramebufferTarget target, uint start, int count, float* v) => GLPointers._glFramebufferSampleLocationsfvNV_fnptr((uint)target, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_sample_locations] [glNamedFramebufferSampleLocationsfvNV]</b>  </summary>
            public static void NamedFramebufferSampleLocationsfv(int framebuffer, uint start, int count, float* v) => GLPointers._glNamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_sample_locations] [glResolveDepthValuesNV]</b>  </summary>
            public static void ResolveDepthValues() => GLPointers._glResolveDepthValuesNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive] [glScissorExclusiveNV]</b>  </summary>
            public static void ScissorExclusive(int x, int y, int width, int height) => GLPointers._glScissorExclusiveNV_fnptr(x, y, width, height);
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive] [glScissorExclusiveArrayvNV]</b>  </summary>
            public static void ScissorExclusiveArrayv(uint first, int count, int* v) => GLPointers._glScissorExclusiveArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glBindShadingRateImageNV]</b>  </summary>
            public static void BindShadingRateImage(int texture) => GLPointers._glBindShadingRateImageNV_fnptr(texture);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glGetShadingRateImagePaletteNV]</b>  </summary>
            public static void GetShadingRateImagePalette(uint viewport, uint entry, All* rate) => GLPointers._glGetShadingRateImagePaletteNV_fnptr(viewport, entry, (uint*)rate);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glGetShadingRateSampleLocationivNV]</b>  </summary>
            public static void GetShadingRateSampleLocationiv(All rate, uint samples, uint index, int* location) => GLPointers._glGetShadingRateSampleLocationivNV_fnptr((uint)rate, samples, index, location);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glShadingRateImageBarrierNV]</b>  </summary>
            public static void ShadingRateImageBarrier(bool synchronize) => GLPointers._glShadingRateImageBarrierNV_fnptr((byte)(synchronize ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glShadingRateImagePaletteNV]</b>  </summary>
            public static void ShadingRateImagePalette(uint viewport, uint first, int count, All* rates) => GLPointers._glShadingRateImagePaletteNV_fnptr(viewport, first, count, (uint*)rates);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glShadingRateSampleOrderNV]</b>  </summary>
            public static void ShadingRateSampleOrder(All order) => GLPointers._glShadingRateSampleOrderNV_fnptr((uint)order);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image] [glShadingRateSampleOrderCustomNV]</b>  </summary>
            public static void ShadingRateSampleOrderCustom(All rate, uint samples, int* locations) => GLPointers._glShadingRateSampleOrderCustomNV_fnptr((uint)rate, samples, locations);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glViewportArrayvNV]</b>  </summary>
            public static void ViewportArrayv(uint first, int count, float* v) => GLPointers._glViewportArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glViewportIndexedfNV]</b>  </summary>
            public static void ViewportIndexedf(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfNV_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glViewportIndexedfvNV]</b>  </summary>
            public static void ViewportIndexedfv(uint index, float* v) => GLPointers._glViewportIndexedfvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glScissorArrayvNV]</b>  </summary>
            public static void ScissorArrayv(uint first, int count, int* v) => GLPointers._glScissorArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glScissorIndexedNV]</b>  </summary>
            public static void ScissorIndexed(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedNV_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glScissorIndexedvNV]</b>  </summary>
            public static void ScissorIndexedv(uint index, int* v) => GLPointers._glScissorIndexedvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glDepthRangeArrayfvNV]</b>  </summary>
            public static void DepthRangeArrayfv(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glDepthRangeIndexedfNV]</b>  </summary>
            public static void DepthRangeIndexedf(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfNV_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glGetFloati_vNV]</b>  </summary>
            public static void GetFloati_v(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vNV_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glEnableiNV]</b>  </summary>
            public static void Enablei(EnableCap target, uint index) => GLPointers._glEnableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glDisableiNV]</b>  </summary>
            public static void Disablei(EnableCap target, uint index) => GLPointers._glDisableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_viewport_array] [glIsEnablediNV]</b>  </summary>
            public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnablediNV_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_NV_viewport_swizzle] [glViewportSwizzleNV]</b>  </summary>
            public static void ViewportSwizzle(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => GLPointers._glViewportSwizzleNV_fnptr(index, (uint)swizzlex, (uint)swizzley, (uint)swizzlez, (uint)swizzlew);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glGetTextureHandleIMG]</b>  </summary>
            public static ulong GetTextureHandle(int texture) => GLPointers._glGetTextureHandleIMG_fnptr(texture);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glGetTextureSamplerHandleIMG]</b>  </summary>
            public static ulong GetTextureSamplerHandle(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleIMG_fnptr(texture, sampler);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glUniformHandleui64IMG]</b>  </summary>
            public static void UniformHandleui64(int location, ulong value) => GLPointers._glUniformHandleui64IMG_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glUniformHandleui64vIMG]</b>  </summary>
            public static void UniformHandleui64v(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vIMG_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glProgramUniformHandleui64IMG]</b>  </summary>
            public static void ProgramUniformHandleui64(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64IMG_fnptr(program, location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture] [glProgramUniformHandleui64vIMG]</b>  </summary>
            public static void ProgramUniformHandleui64v(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vIMG_fnptr(program, location, count, values);
            
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample] [glFramebufferTexture2DDownsampleIMG]</b>  </summary>
            public static void FramebufferTexture2DDownsample(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int xscale, int yscale) => GLPointers._glFramebufferTexture2DDownsampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample] [glFramebufferTextureLayerDownsampleIMG]</b>  </summary>
            public static void FramebufferTextureLayerDownsample(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer, int xscale, int yscale) => GLPointers._glFramebufferTextureLayerDownsampleIMG_fnptr((uint)target, (uint)attachment, texture, level, layer, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture] [glRenderbufferStorageMultisampleIMG]</b>  </summary>
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture] [glFramebufferTexture2DMultisampleIMG]</b>  </summary>
            public static void FramebufferTexture2DMultisample(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
        }
        /// <summary>INTEL extensions.</summary>
        public static unsafe partial class INTEL
        {
            /// <summary> <b>[requires: GL_INTEL_framebuffer_CMAA] [glApplyFramebufferAttachmentCMAAINTEL]</b>  </summary>
            public static void ApplyFramebufferAttachmentCMAA() => GLPointers._glApplyFramebufferAttachmentCMAAINTEL_fnptr();
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glBeginPerfQueryINTEL]</b>  </summary>
            public static void BeginPerfQuery(uint queryHandle) => GLPointers._glBeginPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glCreatePerfQueryINTEL]</b>  </summary>
            public static void CreatePerfQuery(uint queryId, uint* queryHandle) => GLPointers._glCreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glDeletePerfQueryINTEL]</b>  </summary>
            public static void DeletePerfQuery(uint queryHandle) => GLPointers._glDeletePerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glEndPerfQueryINTEL]</b>  </summary>
            public static void EndPerfQuery(uint queryHandle) => GLPointers._glEndPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetFirstPerfQueryIdINTEL]</b>  </summary>
            public static void GetFirstPerfQueryId(uint* queryId) => GLPointers._glGetFirstPerfQueryIdINTEL_fnptr(queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetNextPerfQueryIdINTEL]</b>  </summary>
            public static void GetNextPerfQueryId(uint queryId, uint* nextQueryId) => GLPointers._glGetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetPerfCounterInfoINTEL]</b>  </summary>
            public static void GetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => GLPointers._glGetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetPerfQueryDataINTEL]</b>  </summary>
            public static void GetPerfQueryData(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => GLPointers._glGetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetPerfQueryIdByNameINTEL]</b>  </summary>
            public static void GetPerfQueryIdByName(byte* queryName, uint* queryId) => GLPointers._glGetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query] [glGetPerfQueryInfoINTEL]</b>  </summary>
            public static void GetPerfQueryInfo(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, PerformanceQueryCapsMaskINTEL* capsMask) => GLPointers._glGetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, (uint*)capsMask);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: GL_KHR_blend_equation_advanced] [glBlendBarrierKHR]</b>  </summary>
            public static void BlendBarrier() => GLPointers._glBlendBarrierKHR_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageControl]</b> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="count"> The length of the array ids. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageInsert]</b> Inject an application-supplied message into the debug message queue. </summary>
            /// <param name="source"> The source of the debug message to insert. </param>
            /// <param name="type"> The type of the debug message insert. </param>
            /// <param name="id"> The user-supplied identifier of the message to insert. </param>
            /// <param name="severity"> The severity of the debug messages to insert. </param>
            /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
            /// <param name="message"> The address of a character array containing the message to insert. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glDebugMessageCallback]</b> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetDebugMessageLog]</b> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetDebugMessageLog.xhtml" /></remarks>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glPushDebugGroup]</b> Push a named debug group into the command stream. </summary>
            /// <param name="source"> The source of the debug message. </param>
            /// <param name="id"> The identifier of the message. </param>
            /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
            /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glPopDebugGroup]</b> Pop the active debug group. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glObjectLabel]</b> Label a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object to label. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetObjectLabel]</b> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glObjectPtrLabel]</b> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetObjectPtrLabel]</b> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug] [glGetPointerv]</b> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
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
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetGraphicsResetStatus]</b> Check if the rendering context has not been lost due to software or hardware issues. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glReadnPixels]</b> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
            /// <param name="data"> Returns the pixel data. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformfv]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformiv]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness] [glGetnUniformuiv]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness] [glGetGraphicsResetStatusKHR]</b>  </summary>
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusKHR_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_robustness] [glReadnPixelsKHR]</b>  </summary>
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsKHR_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_KHR_robustness] [glGetnUniformfvKHR]</b>  </summary>
            public static void GetnUniformfvKHR(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness] [glGetnUniformivKHR]</b>  </summary>
            public static void GetnUniformivKHR(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness] [glGetnUniformuivKHR]</b>  </summary>
            public static void GetnUniformuivKHR(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_parallel_shader_compile] [glMaxShaderCompilerThreadsKHR]</b>  </summary>
            public static void MaxShaderCompilerThreads(uint count) => GLPointers._glMaxShaderCompilerThreadsKHR_fnptr(count);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y] [glFramebufferParameteriMESA]</b>  </summary>
            public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteriMESA_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y] [glGetFramebufferParameterivMESA]</b>  </summary>
            public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameterivMESA_fnptr((uint)target, (uint)pname, parameters);
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            /// <summary> <b>[requires: GL_OES_EGL_image] [glEGLImageTargetTexture2DOES]</b>  </summary>
            public static void EGLImageTargetTexture2D(All target, void* image) => GLPointers._glEGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_EGL_image] [glEGLImageTargetRenderbufferStorageOES]</b>  </summary>
            public static void EGLImageTargetRenderbufferStorage(All target, void* image) => GLPointers._glEGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_copy_image] [glCopyImageSubDataOES]</b>  </summary>
            public static void CopyImageSubData(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataOES_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array] [glEnableiOES]</b>  </summary>
            public static void Enablei(EnableCap target, uint index) => GLPointers._glEnableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array] [glDisableiOES]</b>  </summary>
            public static void Disablei(EnableCap target, uint index) => GLPointers._glDisableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed] [glBlendEquationiOES]</b>  </summary>
            public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiOES_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed] [glBlendEquationSeparateiOES]</b>  </summary>
            public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiOES_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed] [glBlendFunciOES]</b>  </summary>
            public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciOES_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed] [glBlendFuncSeparateiOES]</b>  </summary>
            public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiOES_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed] [glColorMaskiOES]</b>  </summary>
            public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiOES_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array] [glIsEnablediOES]</b>  </summary>
            public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnablediOES_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex] [glDrawElementsBaseVertexOES]</b>  </summary>
            public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex] [glDrawRangeElementsBaseVertexOES]</b>  </summary>
            public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexOES_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex] [glDrawElementsInstancedBaseVertexOES]</b>  </summary>
            public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex] [glMultiDrawElementsBaseVertexEXT]</b>  </summary>
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_OES_geometry_shader] [glFramebufferTextureOES]</b>  </summary>
            public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureOES_fnptr((uint)target, (uint)attachment, texture, level);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary] [glGetProgramBinaryOES]</b>  </summary>
            public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinaryOES_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary] [glProgramBinaryOES]</b>  </summary>
            public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinaryOES_fnptr(program, (uint)binaryFormat, binary, length);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glMapBufferOES]</b>  </summary>
            public static void* MapBuffer(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferOES_fnptr((uint)target, (uint)access);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glUnmapBufferOES]</b>  </summary>
            public static bool UnmapBuffer(All target) => GLPointers._glUnmapBufferOES_fnptr((uint)target) != 0;
            
            /// <summary> <b>[requires: GL_OES_mapbuffer] [glGetBufferPointervOES]</b>  </summary>
            public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_primitive_bounding_box] [glPrimitiveBoundingBoxOES]</b>  </summary>
            public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_OES_sample_shading] [glMinSampleShadingOES]</b>  </summary>
            public static void MinSampleShading(float value) => GLPointers._glMinSampleShadingOES_fnptr(value);
            
            /// <summary> <b>[requires: GL_OES_tessellation_shader] [glPatchParameteriOES]</b>  </summary>
            public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteriOES_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glTexImage3DOES]</b>  </summary>
            public static void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glTexSubImage3DOES]</b>  </summary>
            public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glCopyTexSubImage3DOES]</b>  </summary>
            public static void CopyTexSubImage3D(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glCompressedTexImage3DOES]</b>  </summary>
            public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glCompressedTexSubImage3DOES]</b>  </summary>
            public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_texture_3D] [glFramebufferTexture3DOES]</b>  </summary>
            public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glTexParameterIivOES]</b>  </summary>
            public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glTexParameterIuivOES]</b>  </summary>
            public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glGetTexParameterIivOES]</b>  </summary>
            public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glGetTexParameterIuivOES]</b>  </summary>
            public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glSamplerParameterIivOES]</b>  </summary>
            public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivOES_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glSamplerParameterIuivOES]</b>  </summary>
            public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivOES_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glGetSamplerParameterIivOES]</b>  </summary>
            public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivOES_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp] [glGetSamplerParameterIuivOES]</b>  </summary>
            public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivOES_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer] [glTexBufferOES]</b>  </summary>
            public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferOES_fnptr((uint)target, (uint)internalformat, buffer);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer] [glTexBufferRangeOES]</b>  </summary>
            public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeOES_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            /// <summary> <b>[requires: GL_OES_texture_storage_multisample_2d_array] [glTexStorage3DMultisampleOES]</b>  </summary>
            public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisampleOES_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_texture_view] [glTextureViewOES]</b>  </summary>
            public static void TextureView(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewOES_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glBindVertexArrayOES]</b>  </summary>
            public static void BindVertexArray(int array) => GLPointers._glBindVertexArrayOES_fnptr(array);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glDeleteVertexArraysOES]</b>  </summary>
            public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glGenVertexArraysOES]</b>  </summary>
            public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object] [glIsVertexArrayOES]</b>  </summary>
            public static bool IsVertexArray(int array) => GLPointers._glIsVertexArrayOES_fnptr(array) != 0;
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glViewportArrayvOES]</b>  </summary>
            public static void ViewportArrayv(uint first, int count, float* v) => GLPointers._glViewportArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glViewportIndexedfOES]</b>  </summary>
            public static void ViewportIndexedf(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfOES_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glViewportIndexedfvOES]</b>  </summary>
            public static void ViewportIndexedfv(uint index, float* v) => GLPointers._glViewportIndexedfvOES_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glScissorArrayvOES]</b>  </summary>
            public static void ScissorArrayv(uint first, int count, int* v) => GLPointers._glScissorArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glScissorIndexedOES]</b>  </summary>
            public static void ScissorIndexed(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedOES_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glScissorIndexedvOES]</b>  </summary>
            public static void ScissorIndexedv(uint index, int* v) => GLPointers._glScissorIndexedvOES_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glDepthRangeArrayfvOES]</b>  </summary>
            public static void DepthRangeArrayfv(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glDepthRangeIndexedfOES]</b>  </summary>
            public static void DepthRangeIndexedf(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfOES_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_OES_viewport_array] [glGetFloati_vOES]</b>  </summary>
            public static void GetFloati_v(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vOES_fnptr((uint)target, index, data);
            
        }
        /// <summary>OVR extensions.</summary>
        public static unsafe partial class OVR
        {
            /// <summary> <b>[requires: GL_OVR_multiview] [glFramebufferTextureMultiviewOVR]</b>  </summary>
            public static void FramebufferTextureMultiview(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, baseViewIndex, numViews);
            
            /// <summary> <b>[requires: GL_OVR_multiview_multisampled_render_to_texture] [glFramebufferTextureMultisampleMultiviewOVR]</b>  </summary>
            public static void FramebufferTextureMultisampleMultiview(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int samples, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultisampleMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, samples, baseViewIndex, numViews);
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: GL_QCOM_alpha_test] [glAlphaFuncQCOM]</b>  </summary>
            public static void AlphaFunc(All func, float reference) => GLPointers._glAlphaFuncQCOM_fnptr((uint)func, reference);
            
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
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated] [glFramebufferFoveationConfigQCOM]</b>  </summary>
            public static void FramebufferFoveationConfig(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures) => GLPointers._glFramebufferFoveationConfigQCOM_fnptr(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated] [glFramebufferFoveationParametersQCOM]</b>  </summary>
            public static void FramebufferFoveationParameters(int framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glFramebufferFoveationParametersQCOM_fnptr(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation] [glTexEstimateMotionQCOM]</b>  </summary>
            public static void TexEstimateMotion(int reference, int target, int output) => GLPointers._glTexEstimateMotionQCOM_fnptr(reference, target, output);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation] [glTexEstimateMotionRegionsQCOM]</b>  </summary>
            public static void TexEstimateMotionRegions(int reference, int target, int output, int mask) => GLPointers._glTexEstimateMotionRegionsQCOM_fnptr(reference, target, output, mask);
            
            /// <summary> <b>[requires: GL_QCOM_frame_extrapolation] [glExtrapolateTex2DQCOM]</b>  </summary>
            public static void ExtrapolateTex2D(int src1, int src2, int output, float scaleFactor) => GLPointers._glExtrapolateTex2DQCOM_fnptr(src1, src2, output, scaleFactor);
            
            /// <summary> <b>[requires: GL_QCOM_texture_foveated] [glTextureFoveationParametersQCOM]</b>  </summary>
            public static void TextureFoveationParameters(int texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glTextureFoveationParametersQCOM_fnptr(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            /// <summary> <b>[requires: GL_QCOM_shader_framebuffer_fetch_noncoherent] [glFramebufferFetchBarrierQCOM]</b>  </summary>
            public static void FramebufferFetchBarrier() => GLPointers._glFramebufferFetchBarrierQCOM_fnptr();
            
            /// <summary> <b>[requires: GL_QCOM_shading_rate] [glShadingRateQCOM]</b>  </summary>
            public static void ShadingRate(ShadingRateQCOM rate) => GLPointers._glShadingRateQCOM_fnptr((uint)rate);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering] [glStartTilingQCOM]</b>  </summary>
            public static void StartTiling(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._glStartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering] [glEndTilingQCOM]</b>  </summary>
            public static void EndTiling(BufferBitQCOM preserveMask) => GLPointers._glEndTilingQCOM_fnptr((uint)preserveMask);
            
        }
    }
}
