// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES3
{
    public static unsafe partial class GL
    {
        /// <summary> <b>[requires: v2.0]</b> Select active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation-dependent, but must be at least 32. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveTexture.xhtml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => GLPointers._ActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v2.0]</b> Attaches a shader object to a program object. </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglAttachShader.xhtml" /></remarks>
        public static void AttachShader(ProgramHandle program, ShaderHandle shader) => GLPointers._AttachShader_fnptr((int)program, (int)shader);
        
        /// <summary> <b>[requires: v2.0]</b> Associates a generic vertex attribute index with a named attribute variable. </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindAttribLocation.xhtml" /></remarks>
        public static void BindAttribLocation(ProgramHandle program, uint index, byte* name) => GLPointers._BindAttribLocation_fnptr((int)program, index, name);
        
        /// <summary> <b>[requires: v2.0]</b> Bind a named buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="buffer"> Specifies the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBuffer.xhtml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, BufferHandle buffer) => GLPointers._BindBuffer_fnptr((uint)target, (int)buffer);
        
        /// <summary> <b>[requires: v2.0]</b> Bind a framebuffer to a framebuffer target. </summary>
        /// <param name="target"> Specifies the framebuffer target of the binding operation. </param>
        /// <param name="framebuffer"> Specifies the name of the framebuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindFramebuffer.xhtml" /></remarks>
        public static void BindFramebuffer(FramebufferTarget target, FramebufferHandle framebuffer) => GLPointers._BindFramebuffer_fnptr((uint)target, (int)framebuffer);
        
        /// <summary> <b>[requires: v2.0]</b> Bind a renderbuffer to a renderbuffer target. </summary>
        /// <param name="target"> Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of the renderbuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindRenderbuffer.xhtml" /></remarks>
        public static void BindRenderbuffer(RenderbufferTarget target, RenderbufferHandle renderbuffer) => GLPointers._BindRenderbuffer_fnptr((uint)target, (int)renderbuffer);
        
        /// <summary> <b>[requires: v2.0]</b> Bind a named texture to a texturing target. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound. Must be either GL_TEXTURE_2D, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="texture"> Specifies the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTexture.xhtml" /></remarks>
        public static void BindTexture(TextureTarget target, TextureHandle texture) => GLPointers._BindTexture_fnptr((uint)target, (int)texture);
        
        /// <summary> <b>[requires: v2.0]</b> Set the blend color. </summary>
        /// <param name="red"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="green"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="blue"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="alpha"> specify the components of GL_BLEND_COLOR </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendColor.xhtml" /></remarks>
        public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._BlendColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._BlendEquation_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._BlendEquationSeparate_fnptr((uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v2.0]</b> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._BlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        /// <summary> <b>[requires: v2.0]</b> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._BlendFuncSeparate_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
        
        /// <summary> <b>[requires: v2.0]</b> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object's new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferData.xhtml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._BufferData_fnptr((uint)target, size, data, (uint)usage);
        
        /// <summary> <b>[requires: v2.0]</b> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferSubData.xhtml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._BufferSubData_fnptr((uint)target, offset, size, data);
        
        /// <summary> <b>[requires: v2.0]</b> Check the completeness status of a framebuffer. </summary>
        /// <param name="target"> Specify the target of the framebuffer completeness check. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCheckFramebufferStatus.xhtml" /></remarks>
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._CheckFramebufferStatus_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0]</b> Clear buffers to preset values. </summary>
        /// <param name="mask"> Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClear.xhtml" /></remarks>
        public static void Clear(ClearBufferMask mask) => GLPointers._Clear_fnptr((uint)mask);
        
        /// <summary> <b>[requires: v2.0]</b> Specify clear values for the color buffers. </summary>
        /// <param name="red"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="green"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="blue"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="alpha"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearColor.xhtml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._ClearColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth"> Specifies the depth value used when the depth buffer is cleared. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearDepthf.xhtml" /></remarks>
        public static void ClearDepthf(float d) => GLPointers._ClearDepthf_fnptr(d);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s"> Specifies the index used when the stencil buffer is cleared. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearStencil.xhtml" /></remarks>
        public static void ClearStencil(int s) => GLPointers._ClearStencil_fnptr(s);
        
        /// <summary> <b>[requires: v2.0]</b> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMask(byte red, byte green, byte blue, byte alpha) => GLPointers._ColorMask_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0]</b> Compiles a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompileShader.xhtml" /></remarks>
        public static void CompileShader(ShaderHandle shader) => GLPointers._CompileShader_fnptr((int)shader);
        
        /// <summary> <b>[requires: v2.0]</b> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompressedTexImage2D.xhtml" /></remarks>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._CompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        /// <summary> <b>[requires: v2.0]</b> Specify a two-dimensional texture subimage in a compressed format. </summary>
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
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._CompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v2.0]</b> Copy pixels into a 2D texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_ALPHA, GL_LUMINANCE, GL_LUMINANCE_ALPHA, GL_RGB, GL_RGBA, GL_R8, GL_RG8, GL_RGB565, GL_RGB8, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_SRGB8, GL_SRGB8_ALPHA8, GL_R8I, GL_R8UI, GL_R16I, GL_R16UI, GL_R32I, GL_R32UI, GL_RG8I, GL_RG8UI, GL_RG16I, GL_RG16UI, GL_RG32I, GL_RG32UI, GL_RGBA8I, GL_RGBA8UI, GL_RGB10_A2UI, GL_RGBA16I, GL_RGBA16UI, GL_RGBA32I, GL_RGBA32UI. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="border"> Specifies the width of the border. Must be 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyTexImage2D.xhtml" /></remarks>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._CopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        /// <summary> <b>[requires: v2.0]</b> Copy a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyTexSubImage2D.xhtml" /></remarks>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._CopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v2.0]</b> Creates a program object. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateProgram.xhtml" /></remarks>
        public static ProgramHandle CreateProgram() => (ProgramHandle) GLPointers._CreateProgram_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> Creates a shader object. </summary>
        /// <param name="shaderType"> Specifies the type of shader to be created. Must be one of GL_COMPUTE_SHADER, GL_VERTEX_SHADER, GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER, or GL_FRAGMENT_SHADER. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShader.xhtml" /></remarks>
        public static ShaderHandle CreateShader(ShaderType type) => (ShaderHandle) GLPointers._CreateShader_fnptr((uint)type);
        
        /// <summary> <b>[requires: v2.0]</b> Specify whether front- or back-facing polygons can be culled. </summary>
        /// <param name="mode"> Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCullFace.xhtml" /></remarks>
        public static void CullFace(CullFaceMode mode) => GLPointers._CullFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> Delete named buffer objects. </summary>
        /// <param name="n"> Specifies the number of buffer objects to be deleted. </param>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteBuffers.xhtml" /></remarks>
        public static void DeleteBuffers(int n, BufferHandle* buffers) => GLPointers._DeleteBuffers_fnptr(n, (int*)buffers);
        
        /// <summary> <b>[requires: v2.0]</b> Delete framebuffer objects. </summary>
        /// <param name="n"> Specifies the number of framebuffer objects to be deleted. </param>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteFramebuffers.xhtml" /></remarks>
        public static void DeleteFramebuffers(int n, FramebufferHandle* framebuffers) => GLPointers._DeleteFramebuffers_fnptr(n, (int*)framebuffers);
        
        /// <summary> <b>[requires: v2.0]</b> Deletes a program object. </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgram.xhtml" /></remarks>
        public static void DeleteProgram(ProgramHandle program) => GLPointers._DeleteProgram_fnptr((int)program);
        
        /// <summary> <b>[requires: v2.0]</b> Delete renderbuffer objects. </summary>
        /// <param name="n"> Specifies the number of renderbuffer objects to be deleted. </param>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteRenderbuffers.xhtml" /></remarks>
        public static void DeleteRenderbuffers(int n, RenderbufferHandle* renderbuffers) => GLPointers._DeleteRenderbuffers_fnptr(n, (int*)renderbuffers);
        
        /// <summary> <b>[requires: v2.0]</b> Deletes a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteShader.xhtml" /></remarks>
        public static void DeleteShader(ShaderHandle shader) => GLPointers._DeleteShader_fnptr((int)shader);
        
        /// <summary> <b>[requires: v2.0]</b> Delete named textures. </summary>
        /// <param name="n"> Specifies the number of textures to be deleted. </param>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTextures.xhtml" /></remarks>
        public static void DeleteTextures(int n, TextureHandle* textures) => GLPointers._DeleteTextures_fnptr(n, (int*)textures);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func"> Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthFunc.xhtml" /></remarks>
        public static void DepthFunc(DepthFunction func) => GLPointers._DepthFunc_fnptr((uint)func);
        
        /// <summary> <b>[requires: v2.0]</b> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag"> Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthMask.xhtml" /></remarks>
        public static void DepthMask(byte flag) => GLPointers._DepthMask_fnptr(flag);
        
        /// <summary> <b>[requires: v2.0]</b> Specify mapping of depth values from normalized device coordinates to window coordinates. </summary>
        /// <param name="n"> Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0. </param>
        /// <param name="f"> Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthRangef.xhtml" /></remarks>
        public static void DepthRangef(float n, float f) => GLPointers._DepthRangef_fnptr(n, f);
        
        /// <summary> <b>[requires: v2.0]</b> Detaches a shader object from a program object to which it is attached. </summary>
        /// <param name="program">Specifies the program object from which to detach the shader object.</param>
        /// <param name="shader">Specifies the shader object to be detached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDetachShader.xhtml" /></remarks>
        public static void DetachShader(ProgramHandle program, ShaderHandle shader) => GLPointers._DetachShader_fnptr((int)program, (int)shader);
        
        /// <summary> <b>[requires: v2.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disable(EnableCap cap) => GLPointers._Disable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v2.0]</b> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void DisableVertexAttribArray(uint index) => GLPointers._DisableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v2.0]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArrays.xhtml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._DrawArrays_fnptr((uint)mode, first, count);
        
        /// <summary> <b>[requires: v2.0]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElements.xhtml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._DrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v2.0]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enable(EnableCap cap) => GLPointers._Enable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v2.0]</b> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void EnableVertexAttribArray(uint index) => GLPointers._EnableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v2.0]</b> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFinish.xhtml" /></remarks>
        public static void Finish() => GLPointers._Finish_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlush.xhtml" /></remarks>
        public static void Flush() => GLPointers._Flush_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> Attach a renderbuffer as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="renderbuffertarget"> Specifies the renderbuffer target and must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferRenderbuffer.xhtml" /></remarks>
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer) => GLPointers._FramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, (int)renderbuffer);
        
        /// <summary> <b>[requires: v2.0]</b> Attach a level of a texture object as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="textarget"> Specifies a 2D texture target, 2D multisample texture target, or for cube map textures, which face is to be attached. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture2D.xhtml" /></remarks>
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level) => GLPointers._FramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, (int)texture, level);
        
        /// <summary> <b>[requires: v2.0]</b> Define front- and back-facing polygons. </summary>
        /// <param name="mode"> Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFrontFace.xhtml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._FrontFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> Generate buffer object names. </summary>
        /// <param name="n"> Specifies the number of buffer object names to be generated. </param>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenBuffers.xhtml" /></remarks>
        public static void GenBuffers(int n, BufferHandle* buffers) => GLPointers._GenBuffers_fnptr(n, (int*)buffers);
        
        /// <summary> <b>[requires: v2.0]</b> Generate mipmaps for a specified texture target. </summary>
        /// <param name="target"> Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenerateMipmap.xhtml" /></remarks>
        public static void GenerateMipmap(TextureTarget target) => GLPointers._GenerateMipmap_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0]</b> Generate framebuffer object names. </summary>
        /// <param name="n"> Specifies the number of framebuffer object names to generate. </param>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenFramebuffers.xhtml" /></remarks>
        public static void GenFramebuffers(int n, FramebufferHandle* framebuffers) => GLPointers._GenFramebuffers_fnptr(n, (int*)framebuffers);
        
        /// <summary> <b>[requires: v2.0]</b> Generate renderbuffer object names. </summary>
        /// <param name="n"> Specifies the number of renderbuffer object names to generate. </param>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenRenderbuffers.xhtml" /></remarks>
        public static void GenRenderbuffers(int n, RenderbufferHandle* renderbuffers) => GLPointers._GenRenderbuffers_fnptr(n, (int*)renderbuffers);
        
        /// <summary> <b>[requires: v2.0]</b> Generate texture names. </summary>
        /// <param name="n"> Specifies the number of texture names to be generated. </param>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTextures.xhtml" /></remarks>
        public static void GenTextures(int n, TextureHandle* textures) => GLPointers._GenTextures_fnptr(n, (int*)textures);
        
        /// <summary> <b>[requires: v2.0]</b> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveAttrib.xhtml" /></remarks>
        public static void GetActiveAttrib(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._GetActiveAttrib_fnptr((int)program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v2.0]</b> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniform.xhtml" /></remarks>
        public static void GetActiveUniform(ProgramHandle program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => GLPointers._GetActiveUniform_fnptr((int)program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttachedShaders.xhtml" /></remarks>
        public static void GetAttachedShaders(ProgramHandle program, int maxCount, int* count, ShaderHandle* shaders) => GLPointers._GetAttachedShaders_fnptr((int)program, maxCount, count, (int*)shaders);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the location of an attribute variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttribLocation.xhtml" /></remarks>
        public static int GetAttribLocation(ProgramHandle program, byte* name) => GLPointers._GetAttribLocation_fnptr((int)program, name);
        
        /// <summary> <b>[requires: v2.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleanv(GetPName pname, byte* data) => GLPointers._GetBooleanv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v2.0]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._GetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetError.xhtml" /></remarks>
        public static ErrorCode GetError() => (ErrorCode) GLPointers._GetError_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._GetFloatv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v2.0]</b> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        /// <param name="parameters"> Specifies the address of a variable receive the value of pname for attachment. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferAttachmentParameteriv.xhtml" /></remarks>
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._GetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._GetIntegerv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v2.0]</b> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramiv.xhtml" /></remarks>
        public static void GetProgramiv(ProgramHandle program, ProgramPropertyARB pname, int* parameters) => GLPointers._GetProgramiv_fnptr((int)program, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInfoLog.xhtml" /></remarks>
        public static void GetProgramInfoLog(ProgramHandle program, int bufSize, int* length, byte* infoLog) => GLPointers._GetProgramInfoLog_fnptr((int)program, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v2.0]</b> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        /// <param name="parameters"> Specifies the address of an array to receive the value of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetRenderbufferParameteriv.xhtml" /></remarks>
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._GetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderiv.xhtml" /></remarks>
        public static void GetShaderiv(ShaderHandle shader, ShaderParameterName pname, int* parameters) => GLPointers._GetShaderiv_fnptr((int)shader, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderInfoLog.xhtml" /></remarks>
        public static void GetShaderInfoLog(ShaderHandle shader, int bufSize, int* length, byte* infoLog) => GLPointers._GetShaderInfoLog_fnptr((int)shader, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v2.0]</b> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="shaderType"> Specifies the type of shader whose precision to query. shaderType must be GL_VERTEX_SHADER or GL_FRAGMENT_SHADER. </param>
        /// <param name="precisionType"> Specifies the numeric format whose precision and range to query. </param>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderPrecisionFormat.xhtml" /></remarks>
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._GetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderSource.xhtml" /></remarks>
        public static void GetShaderSource(ShaderHandle shader, int bufSize, int* length, byte* source) => GLPointers._GetShaderSource_fnptr((int)shader, bufSize, length, source);
        
        /// <summary> <b>[requires: v2.0]</b> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetString_(StringName name) => GLPointers._GetString_fnptr((uint)name);
        
        /// <summary> <b>[requires: v2.0]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._GetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformfv(ProgramHandle program, int location, float* parameters) => GLPointers._GetUniformfv_fnptr((int)program, location, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformiv(ProgramHandle program, int location, int* parameters) => GLPointers._GetUniformiv_fnptr((int)program, location, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Returns the location of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformLocation.xhtml" /></remarks>
        public static int GetUniformLocation(ProgramHandle program, byte* name) => GLPointers._GetUniformLocation_fnptr((int)program, name);
        
        /// <summary> <b>[requires: v2.0]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._GetVertexAttribfv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._GetVertexAttribiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Return the address of the specified generic vertex attribute pointer. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</param>
        /// <param name="pointer">Returns the pointer value.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttribPointerv.xhtml" /></remarks>
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._GetVertexAttribPointerv_fnptr(index, (uint)pname, pointer);
        
        /// <summary> <b>[requires: v2.0]</b> Specify implementation-specific hints. </summary>
        /// <param name="target"> Specifies a symbolic constant indicating the behavior to be controlled. GL_FRAGMENT_SHADER_DERIVATIVE_HINT, and GL_GENERATE_MIPMAP_HINT are accepted. </param>
        /// <param name="mode"> Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglHint.xhtml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._Hint_fnptr((uint)target, (uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsBuffer.xhtml" /></remarks>
        public static byte IsBuffer(BufferHandle buffer) => GLPointers._IsBuffer_fnptr((int)buffer);
        
        /// <summary> <b>[requires: v2.0]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static byte IsEnabled(EnableCap cap) => GLPointers._IsEnabled_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v2.0]</b> Determine if a name corresponds to a framebuffer object. </summary>
        /// <param name="framebuffer"> Specifies a value that may be the name of a framebuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsFramebuffer.xhtml" /></remarks>
        public static byte IsFramebuffer(FramebufferHandle framebuffer) => GLPointers._IsFramebuffer_fnptr((int)framebuffer);
        
        /// <summary> <b>[requires: v2.0]</b> Determines if a name corresponds to a program object. </summary>
        /// <param name="program">Specifies a potential program object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgram.xhtml" /></remarks>
        public static byte IsProgram(ProgramHandle program) => GLPointers._IsProgram_fnptr((int)program);
        
        /// <summary> <b>[requires: v2.0]</b> Determine if a name corresponds to a renderbuffer object. </summary>
        /// <param name="renderbuffer"> Specifies a value that may be the name of a renderbuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsRenderbuffer.xhtml" /></remarks>
        public static byte IsRenderbuffer(RenderbufferHandle renderbuffer) => GLPointers._IsRenderbuffer_fnptr((int)renderbuffer);
        
        /// <summary> <b>[requires: v2.0]</b> Determines if a name corresponds to a shader object. </summary>
        /// <param name="shader">Specifies a potential shader object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsShader.xhtml" /></remarks>
        public static byte IsShader(ShaderHandle shader) => GLPointers._IsShader_fnptr((int)shader);
        
        /// <summary> <b>[requires: v2.0]</b> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTexture.xhtml" /></remarks>
        public static byte IsTexture(TextureHandle texture) => GLPointers._IsTexture_fnptr((int)texture);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the width of rasterized lines. </summary>
        /// <param name="width"> Specifies the width of rasterized lines. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLineWidth.xhtml" /></remarks>
        public static void LineWidth(float width) => GLPointers._LineWidth_fnptr(width);
        
        /// <summary> <b>[requires: v2.0]</b> Links a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLinkProgram.xhtml" /></remarks>
        public static void LinkProgram(ProgramHandle program) => GLPointers._LinkProgram_fnptr((int)program);
        
        /// <summary> <b>[requires: v2.0]</b> Set pixel storage modes. </summary>
        /// <param name="pname"> Specifies the symbolic name of the parameter to be set. Four values affect the packing of pixel data into memory: GL_PACK_ROW_LENGTH, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT. </param>
        /// <param name="param"> Specifies the value that pname is set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPixelStorei.xhtml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._PixelStorei_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> Set the scale and units used to calculate depth values. </summary>
        /// <param name="factor"> Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0. </param>
        /// <param name="units"> Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPolygonOffset.xhtml" /></remarks>
        public static void PolygonOffset(float factor, float units) => GLPointers._PolygonOffset_fnptr(factor, units);
        
        /// <summary> <b>[requires: v2.0]</b> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._ReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0]</b> Release resources consumed by the implementation's shader compiler. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReleaseShaderCompiler.xhtml" /></remarks>
        public static void ReleaseShaderCompiler() => GLPointers._ReleaseShaderCompiler_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> Establish data storage, format and dimensions of a renderbuffer object's image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object's image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorage.xhtml" /></remarks>
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v2.0]</b> Specify multisample coverage parameters. </summary>
        /// <param name="value"> Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0. </param>
        /// <param name="invert"> Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleCoverage.xhtml" /></remarks>
        public static void SampleCoverage(float value, byte invert) => GLPointers._SampleCoverage_fnptr(value, invert);
        
        /// <summary> <b>[requires: v2.0]</b> Define the scissor box. </summary>
        /// <param name="x"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="y"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="width"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglScissor.xhtml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => GLPointers._Scissor_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v2.0]</b> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderBinary.xhtml" /></remarks>
        public static void ShaderBinary(int count, ShaderHandle* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._ShaderBinary_fnptr(count, (int*)shaders, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v2.0]</b> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="str">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderSource.xhtml" /></remarks>
        public static void ShaderSource(ShaderHandle shader, int count, byte** str, int* length) => GLPointers._ShaderSource_fnptr((int)shader, count, str, length);
        
        /// <summary> <b>[requires: v2.0]</b> Set front and back function and reference value for stencil testing. </summary>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFunc.xhtml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._StencilFunc_fnptr((uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0]</b> Set front and/or back function and reference value for stencil testing. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFuncSeparate.xhtml" /></remarks>
        public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int reference, uint mask) => GLPointers._StencilFuncSeparate_fnptr((uint)face, (uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0]</b> Control the front and back writing of individual bits in the stencil planes. </summary>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMask.xhtml" /></remarks>
        public static void StencilMask(uint mask) => GLPointers._StencilMask_fnptr(mask);
        
        /// <summary> <b>[requires: v2.0]</b> Control the front and/or back writing of individual bits in the stencil planes. </summary>
        /// <param name="face"> Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMaskSeparate.xhtml" /></remarks>
        public static void StencilMaskSeparate(StencilFaceDirection face, uint mask) => GLPointers._StencilMaskSeparate_fnptr((uint)face, mask);
        
        /// <summary> <b>[requires: v2.0]</b> Set front and back stencil test actions. </summary>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOp.xhtml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._StencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        /// <summary> <b>[requires: v2.0]</b> Set front and/or back stencil test actions. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOpSeparate.xhtml" /></remarks>
        public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._StencilOpSeparate_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
        
        /// <summary> <b>[requires: v2.0]</b> Specify a two-dimensional texture image. </summary>
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
        public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexImage2D_fnptr((uint)target, level, internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._TexParameterf_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._TexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._TexParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._TexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> Specify a two-dimensional texture subimage. </summary>
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
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1f(int location, float v0) => GLPointers._Uniform1f_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1fv(int location, int count, float* value) => GLPointers._Uniform1fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1i(int location, int v0) => GLPointers._Uniform1i_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1iv(int location, int count, int* value) => GLPointers._Uniform1iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2f(int location, float v0, float v1) => GLPointers._Uniform2f_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2fv(int location, int count, float* value) => GLPointers._Uniform2fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2i(int location, int v0, int v1) => GLPointers._Uniform2i_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2iv(int location, int count, int* value) => GLPointers._Uniform2iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3f(int location, float v0, float v1, float v2) => GLPointers._Uniform3f_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3fv(int location, int count, float* value) => GLPointers._Uniform3fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3i(int location, int v0, int v1, int v2) => GLPointers._Uniform3i_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3iv(int location, int count, int* value) => GLPointers._Uniform3iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => GLPointers._Uniform4f_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4fv(int location, int count, float* value) => GLPointers._Uniform4fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => GLPointers._Uniform4i_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4iv(int location, int count, int* value) => GLPointers._Uniform4iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix2fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix3fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v2.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix4fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v2.0]</b> Installs a program object as part of current rendering state. </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgram.xhtml" /></remarks>
        public static void UseProgram(ProgramHandle program) => GLPointers._UseProgram_fnptr((int)program);
        
        /// <summary> <b>[requires: v2.0]</b> Validates a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be validated.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgram.xhtml" /></remarks>
        public static void ValidateProgram(ProgramHandle program) => GLPointers._ValidateProgram_fnptr((int)program);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1f(uint index, float x) => GLPointers._VertexAttrib1f_fnptr(index, x);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1fv(uint index, float* v) => GLPointers._VertexAttrib1fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2f(uint index, float x, float y) => GLPointers._VertexAttrib2f_fnptr(index, x, y);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2fv(uint index, float* v) => GLPointers._VertexAttrib2fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3f(uint index, float x, float y, float z) => GLPointers._VertexAttrib3f_fnptr(index, x, y, z);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3fv(uint index, float* v) => GLPointers._VertexAttrib3fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => GLPointers._VertexAttrib4f_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v2.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4fv(uint index, float* v) => GLPointers._VertexAttrib4fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="normalized">For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, byte normalized, int stride, void* pointer) => GLPointers._VertexAttribPointer_fnptr(index, size, (uint)type, normalized, stride, pointer);
        
        /// <summary> <b>[requires: v2.0]</b> Set the viewport. </summary>
        /// <param name="x"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="y"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="width"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglViewport.xhtml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => GLPointers._Viewport_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> Select a color buffer source for pixels. </summary>
        /// <param name="src"> Specifies a color buffer. Accepted values are GL_BACK, GL_NONE, and GL_COLOR_ATTACHMENTi. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadBuffer.xhtml" /></remarks>
        public static void ReadBuffer(ReadBufferMode src) => GLPointers._ReadBuffer_fnptr((uint)src);
        
        /// <summary> <b>[requires: v3.0]</b> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElements.xhtml" /></remarks>
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._DrawRangeElements_fnptr((uint)mode, start, end, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v3.0]</b> Specify a three-dimensional texture image. </summary>
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
        public static void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexImage3D_fnptr((uint)target, level, internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v3.0]</b> Specify a three-dimensional texture subimage. </summary>
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
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v3.0]</b> Copy a three-dimensional texture subimage. </summary>
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
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._CopyTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> Specify a three-dimensional texture image in a compressed format. </summary>
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
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._CompressedTexImage3D_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
        
        /// <summary> <b>[requires: v3.0]</b> Specify a three-dimensional texture subimage in a compressed format. </summary>
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
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._CompressedTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
        
        /// <summary> <b>[requires: v3.0]</b> Generate query object names. </summary>
        /// <param name="n"> Specifies the number of query object names to be generated. </param>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenQueries.xhtml" /></remarks>
        public static void GenQueries(int n, QueryHandle* ids) => GLPointers._GenQueries_fnptr(n, (int*)ids);
        
        /// <summary> <b>[requires: v3.0]</b> Delete named query objects. </summary>
        /// <param name="n"> Specifies the number of query objects to be deleted. </param>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteQueries.xhtml" /></remarks>
        public static void DeleteQueries(int n, QueryHandle* ids) => GLPointers._DeleteQueries_fnptr(n, (int*)ids);
        
        /// <summary> <b>[requires: v3.0]</b> Determine if a name corresponds to a query object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsQuery.xhtml" /></remarks>
        public static byte IsQuery(QueryHandle id) => GLPointers._IsQuery_fnptr((int)id);
        
        /// <summary> <b>[requires: v3.0]</b> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void BeginQuery(QueryTarget target, QueryHandle id) => GLPointers._BeginQuery_fnptr((uint)target, (int)id);
        
        /// <summary> <b>[requires: v3.0]</b> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void EndQuery(QueryTarget target) => GLPointers._EndQuery_fnptr((uint)target);
        
        /// <summary> <b>[requires: v3.0]</b> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryiv.xhtml" /></remarks>
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._GetQueryiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryObjectuiv.xhtml" /></remarks>
        public static void GetQueryObjectuiv(QueryHandle id, QueryObjectParameterName pname, uint* parameters) => GLPointers._GetQueryObjectuiv_fnptr((int)id, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Map a section of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static byte UnmapBuffer(BufferTargetARB target) => GLPointers._UnmapBuffer_fnptr((uint)target);
        
        /// <summary> <b>[requires: v3.0]</b> Return the pointer to a mapped buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="pname"> Specifies the pointer to be returned. The symbolic constant must be GL_BUFFER_MAP_POINTER. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferPointerv.xhtml" /></remarks>
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._GetBufferPointerv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="n">Specifies the number of buffers in bufs.</param>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawBuffers.xhtml" /></remarks>
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => GLPointers._DrawBuffers_fnptr(n, (uint*)bufs);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x3fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix2x3fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x2fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix3x2fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x4fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix2x4fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x2fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix4x2fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x4fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix3x4fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x3fv(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix4x3fv_fnptr(location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.0]</b> Copy a block of pixels from the read framebuffer to the draw framebuffer. </summary>
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
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._BlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
        
        /// <summary> <b>[requires: v3.0]</b> Establish data storage, format, dimensions and sample count of a renderbuffer object's image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="samples"> Specifies the number of samples to be used for the renderbuffer object's storage. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object's image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorageMultisample.xhtml" /></remarks>
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> Attach a single layer of a texture to a framebuffer. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <param name="layer"> Specifies the layer of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTextureLayer.xhtml" /></remarks>
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer) => GLPointers._FramebufferTextureLayer_fnptr((uint)target, (uint)attachment, (int)texture, level, layer);
        
        /// <summary> <b>[requires: v3.0]</b> Map a section of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the starting offset within the buffer of the range to be mapped. </param>
        /// <param name="length"> Specifies the length of the range to be mapped. </param>
        /// <param name="access"> Specifies a combination of access flags indicating the desired access to the range. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._MapBufferRange_fnptr((uint)target, offset, length, (uint)access);
        
        /// <summary> <b>[requires: v3.0]</b> Indicate modifications to a range of a mapped buffer. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the start of the buffer subrange, in basic machine units. </param>
        /// <param name="length"> Specifies the length of the buffer subrange, in basic machine units. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlushMappedBufferRange.xhtml" /></remarks>
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._FlushMappedBufferRange_fnptr((uint)target, offset, length);
        
        /// <summary> <b>[requires: v3.0]</b> Bind a vertex array object. </summary>
        /// <param name="array"> Specifies the name of the vertex array to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexArray.xhtml" /></remarks>
        public static void BindVertexArray(VertexArrayHandle array) => GLPointers._BindVertexArray_fnptr((int)array);
        
        /// <summary> <b>[requires: v3.0]</b> Delete vertex array objects. </summary>
        /// <param name="n"> Specifies the number of vertex array objects to be deleted. </param>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteVertexArrays.xhtml" /></remarks>
        public static void DeleteVertexArrays(int n, VertexArrayHandle* arrays) => GLPointers._DeleteVertexArrays_fnptr(n, (int*)arrays);
        
        /// <summary> <b>[requires: v3.0]</b> Generate vertex array object names. </summary>
        /// <param name="n"> Specifies the number of vertex array object names to generate. </param>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenVertexArrays.xhtml" /></remarks>
        public static void GenVertexArrays(int n, VertexArrayHandle* arrays) => GLPointers._GenVertexArrays_fnptr(n, (int*)arrays);
        
        /// <summary> <b>[requires: v3.0]</b> Determine if a name corresponds to a vertex array object. </summary>
        /// <param name="array"> Specifies a value that may be the name of a vertex array object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsVertexArray.xhtml" /></remarks>
        public static byte IsVertexArray(VertexArrayHandle array) => GLPointers._IsVertexArray_fnptr((int)array);
        
        /// <summary> <b>[requires: v3.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._GetIntegeri_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.0]</b> Start transform feedback operation. </summary>
        /// <param name="primitiveMode"> Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform feedback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => GLPointers._BeginTransformFeedback_fnptr((uint)primitiveMode);
        
        /// <summary> <b>[requires: v3.0]</b> Start transform feedback operation. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void EndTransformFeedback() => GLPointers._EndTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> Bind a range within a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <param name="offset"> The starting offset in basic machine units into the buffer object buffer. </param>
        /// <param name="size"> The amount of data in machine units that can be read from the buffet object while used as an indexed target. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferRange.xhtml" /></remarks>
        public static void BindBufferRange(BufferTargetARB target, uint index, BufferHandle buffer, IntPtr offset, nint size) => GLPointers._BindBufferRange_fnptr((uint)target, index, (int)buffer, offset, size);
        
        /// <summary> <b>[requires: v3.0]</b> Bind a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferBase.xhtml" /></remarks>
        public static void BindBufferBase(BufferTargetARB target, uint index, BufferHandle buffer) => GLPointers._BindBufferBase_fnptr((uint)target, index, (int)buffer);
        
        /// <summary> <b>[requires: v3.0]</b> Specify values to record in transform feedback buffers. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="count"> The number of varying variables used for transform feedback. </param>
        /// <param name="varyings"> An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback. </param>
        /// <param name="bufferMode"> Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTransformFeedbackVaryings.xhtml" /></remarks>
        public static void TransformFeedbackVaryings(ProgramHandle program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._TransformFeedbackVaryings_fnptr((int)program, count, varyings, (uint)bufferMode);
        
        /// <summary> <b>[requires: v3.0]</b> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTransformFeedbackVarying.xhtml" /></remarks>
        public static void GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._GetTransformFeedbackVarying_fnptr((int)program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v3.0]</b> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._VertexAttribIPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v3.0]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._GetVertexAttribIiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._GetVertexAttribIuiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => GLPointers._VertexAttribI4i_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => GLPointers._VertexAttribI4ui_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4iv(uint index, int* v) => GLPointers._VertexAttribI4iv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.0]</b> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4uiv(uint index, uint* v) => GLPointers._VertexAttribI4uiv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.0]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformuiv(ProgramHandle program, int location, uint* parameters) => GLPointers._GetUniformuiv_fnptr((int)program, location, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Query the bindings of color numbers to user-defined varying out variables. </summary>
        /// <param name="program"> The name of the program containing varying out variable whose binding to query </param>
        /// <param name="name"> The name of the user-defined varying out variable whose binding to query </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFragDataLocation.xhtml" /></remarks>
        public static int GetFragDataLocation(ProgramHandle program, byte* name) => GLPointers._GetFragDataLocation_fnptr((int)program, name);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1ui(int location, uint v0) => GLPointers._Uniform1ui_fnptr(location, v0);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2ui(int location, uint v0, uint v1) => GLPointers._Uniform2ui_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => GLPointers._Uniform3ui_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._Uniform4ui_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1uiv(int location, int count, uint* value) => GLPointers._Uniform1uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2uiv(int location, int count, uint* value) => GLPointers._Uniform2uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3uiv(int location, int count, uint* value) => GLPointers._Uniform3uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4uiv(int location, int count, uint* value) => GLPointers._Uniform4uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => GLPointers._ClearBufferiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => GLPointers._ClearBufferuiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => GLPointers._ClearBufferfv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0]</b> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="depth"> The value to clear a depth render buffer to. </param>
        /// <param name="stencil"> The value to clear a stencil render buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._ClearBufferfi_fnptr((uint)buffer, drawbuffer, depth, stencil);
        
        /// <summary> <b>[requires: v3.0]</b> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <param name="index"> For glGetStringi, specifies the index of the string to return. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetStringi_(StringName name, uint index) => GLPointers._GetStringi_fnptr((uint)name, index);
        
        /// <summary> <b>[requires: v3.0]</b> Copy part of the data store of a buffer object to the data store of another buffer object. </summary>
        /// <param name="readtarget"> Specifies the target from whose data store data should be read. </param>
        /// <param name="writetarget"> Specifies the target to whose data store data should be written. </param>
        /// <param name="readoffset"> Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read. </param>
        /// <param name="writeoffset"> Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written. </param>
        /// <param name="size"> Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyBufferSubData.xhtml" /></remarks>
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._CopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
        
        /// <summary> <b>[requires: v3.0]</b> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformIndices.xhtml" /></remarks>
        public static void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._GetUniformIndices_fnptr((int)program, uniformCount, uniformNames, uniformIndices);
        
        /// <summary> <b>[requires: v3.0]</b> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
        /// <param name="parameters">Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformsiv.xhtml" /></remarks>
        public static void GetActiveUniformsiv(ProgramHandle program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._GetActiveUniformsiv_fnptr((int)program, uniformCount, uniformIndices, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters containing the name of the uniform block whose index to retrieve. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformBlockIndex.xhtml" /></remarks>
        public static uint GetUniformBlockIndex(ProgramHandle program, byte* uniformBlockName) => GLPointers._GetUniformBlockIndex_fnptr((int)program, uniformBlockName);
        
        /// <summary> <b>[requires: v3.0]</b> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        /// <param name="parameters"> Specifies the address of a variable to receive the result of the query. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockiv.xhtml" /></remarks>
        public static void GetActiveUniformBlockiv(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._GetActiveUniformBlockiv_fnptr((int)program, uniformBlockIndex, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockName.xhtml" /></remarks>
        public static void GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._GetActiveUniformBlockName_fnptr((int)program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        /// <summary> <b>[requires: v3.0]</b> Assign a binding point to an active uniform block. </summary>
        /// <param name="program"> The name of a program object containing the active uniform block whose binding to assign. </param>
        /// <param name="uniformBlockIndex"> The index of the active uniform block within program whose binding to assign. </param>
        /// <param name="uniformBlockBinding"> Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniformBlockBinding.xhtml" /></remarks>
        public static void UniformBlockBinding(ProgramHandle program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._UniformBlockBinding_fnptr((int)program, uniformBlockIndex, uniformBlockBinding);
        
        /// <summary> <b>[requires: v3.0]</b> Draw multiple instances of a range of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysInstanced.xhtml" /></remarks>
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => GLPointers._DrawArraysInstanced_fnptr((uint)mode, first, count, instancecount);
        
        /// <summary> <b>[requires: v3.0]</b> Draw multiple instances of a set of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstanced.xhtml" /></remarks>
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => GLPointers._DrawElementsInstanced_fnptr((uint)mode, count, (uint)type, indices, instancecount);
        
        /// <summary> <b>[requires: v3.0]</b> Create a new sync object and insert it into the GL command stream. </summary>
        /// <param name="condition"> Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. </param>
        /// <param name="flags"> Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFenceSync.xhtml" /></remarks>
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._FenceSync_fnptr((uint)condition, (uint)flags);
        
        /// <summary> <b>[requires: v3.0]</b> Determine if a name corresponds to a sync object. </summary>
        /// <param name="sync"> Specifies a value that may be the name of a sync object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSync.xhtml" /></remarks>
        public static byte IsSync(GLSync sync) => GLPointers._IsSync_fnptr((IntPtr)sync);
        
        /// <summary> <b>[requires: v3.0]</b> Delete a sync object. </summary>
        /// <param name="sync"> The sync object to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSync.xhtml" /></remarks>
        public static void DeleteSync(GLSync sync) => GLPointers._DeleteSync_fnptr((IntPtr)sync);
        
        /// <summary> <b>[requires: v3.0]</b> Block and wait for a sync object to become signaled. </summary>
        /// <param name="sync"> The sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT. </param>
        /// <param name="timeout"> The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClientWaitSync.xhtml" /></remarks>
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._ClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary> <b>[requires: v3.0]</b> Instruct the GL server to block until the specified sync object becomes signaled. </summary>
        /// <param name="sync"> Specifies the sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags must be zero. </param>
        /// <param name="timeout"> Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglWaitSync.xhtml" /></remarks>
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._WaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary> <b>[requires: v3.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64v(GetPName pname, long* data) => GLPointers._GetInteger64v_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v3.0]</b> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="bufSize"> Specifies the size of the buffer whose address is given in values. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSynciv.xhtml" /></remarks>
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._GetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
        
        /// <summary> <b>[requires: v3.0]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => GLPointers._GetInteger64i_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.0]</b> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => GLPointers._GetBufferParameteri64v_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Generate sampler object names. </summary>
        /// <param name="n"> Specifies the number of sampler object names to generate. </param>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenSamplers.xhtml" /></remarks>
        public static void GenSamplers(int count, SamplerHandle* samplers) => GLPointers._GenSamplers_fnptr(count, (int*)samplers);
        
        /// <summary> <b>[requires: v3.0]</b> Delete named sampler objects. </summary>
        /// <param name="n"> Specifies the number of sampler objects to be deleted. </param>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSamplers.xhtml" /></remarks>
        public static void DeleteSamplers(int count, SamplerHandle* samplers) => GLPointers._DeleteSamplers_fnptr(count, (int*)samplers);
        
        /// <summary> <b>[requires: v3.0]</b> Determine if a name corresponds to a sampler object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a sampler object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSampler.xhtml" /></remarks>
        public static byte IsSampler(SamplerHandle sampler) => GLPointers._IsSampler_fnptr((int)sampler);
        
        /// <summary> <b>[requires: v3.0]</b> Bind a named sampler to a texturing target. </summary>
        /// <param name="unit"> Specifies the index of the texture unit to which the sampler is bound. </param>
        /// <param name="sampler"> Specifies the name of a sampler. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindSampler.xhtml" /></remarks>
        public static void BindSampler(uint unit, SamplerHandle sampler) => GLPointers._BindSampler_fnptr(unit, (int)sampler);
        
        /// <summary> <b>[requires: v3.0]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int param) => GLPointers._SamplerParameteri_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteriv(SamplerHandle sampler, SamplerParameterI pname, int* param) => GLPointers._SamplerParameteriv_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float param) => GLPointers._SamplerParameterf_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterfv(SamplerHandle sampler, SamplerParameterF pname, float* param) => GLPointers._SamplerParameterfv_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameteriv(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => GLPointers._GetSamplerParameteriv_fnptr((int)sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterfv(SamplerHandle sampler, SamplerParameterF pname, float* parameters) => GLPointers._GetSamplerParameterfv_fnptr((int)sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> Modify the rate at which generic vertex attributes advance during instanced rendering. </summary>
        /// <param name="index"> Specify the index of the generic vertex attribute. </param>
        /// <param name="divisor"> Specify the number of instances that will pass between updates of the generic attribute at slot index. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribDivisor.xhtml" /></remarks>
        public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._VertexAttribDivisor_fnptr(index, divisor);
        
        /// <summary> <b>[requires: v3.0]</b> Bind a transform feedback object. </summary>
        /// <param name="target"> Specifies the target to which to bind the transform feedback object id. target must be GL_TRANSFORM_FEEDBACK. </param>
        /// <param name="id"> Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTransformFeedback.xhtml" /></remarks>
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, TransformFeedbackHandle id) => GLPointers._BindTransformFeedback_fnptr((uint)target, (int)id);
        
        /// <summary> <b>[requires: v3.0]</b> Delete transform feedback objects. </summary>
        /// <param name="n"> Specifies the number of transform feedback objects to delete. </param>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTransformFeedbacks.xhtml" /></remarks>
        public static void DeleteTransformFeedbacks(int n, TransformFeedbackHandle* ids) => GLPointers._DeleteTransformFeedbacks_fnptr(n, (int*)ids);
        
        /// <summary> <b>[requires: v3.0]</b> Reserve transform feedback object names. </summary>
        /// <param name="n"> Specifies the number of transform feedback object names to reserve. </param>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTransformFeedbacks.xhtml" /></remarks>
        public static void GenTransformFeedbacks(int n, TransformFeedbackHandle* ids) => GLPointers._GenTransformFeedbacks_fnptr(n, (int*)ids);
        
        /// <summary> <b>[requires: v3.0]</b> Determine if a name corresponds to a transform feedback object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a transform feedback object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTransformFeedback.xhtml" /></remarks>
        public static byte IsTransformFeedback(TransformFeedbackHandle id) => GLPointers._IsTransformFeedback_fnptr((int)id);
        
        /// <summary> <b>[requires: v3.0]</b> Pause transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPauseTransformFeedback.xhtml" /></remarks>
        public static void PauseTransformFeedback() => GLPointers._PauseTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> Resume transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglResumeTransformFeedback.xhtml" /></remarks>
        public static void ResumeTransformFeedback() => GLPointers._ResumeTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="bufsize">!!missing documentation!!</param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramBinary.xhtml" /></remarks>
        public static void GetProgramBinary(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._GetProgramBinary_fnptr((int)program, bufSize, length, (uint*)binaryFormat, binary);
        
        /// <summary> <b>[requires: v3.0]</b> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramBinary.xhtml" /></remarks>
        public static void ProgramBinary(ProgramHandle program, All binaryFormat, void* binary, int length) => GLPointers._ProgramBinary_fnptr((int)program, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v3.0]</b> Specify a parameter for a program object. </summary>
        /// <param name="program"> Specifies the name of a program object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the name of the parameter to modify. </param>
        /// <param name="value"> Specifies the new value of the parameter specified by pname for program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramParameteri.xhtml" /></remarks>
        public static void ProgramParameteri(ProgramHandle program, ProgramParameterPName pname, int value) => GLPointers._ProgramParameteri_fnptr((int)program, (uint)pname, value);
        
        /// <summary> <b>[requires: v3.0]</b> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateFramebuffer.xhtml" /></remarks>
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._InvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
        
        /// <summary> <b>[requires: v3.0]</b> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateSubFramebuffer.xhtml" /></remarks>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._InvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> Simultaneously specify storage for all levels of a two-dimensional texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_2D, or GL_TEXTURE_CUBE_MAP. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2D.xhtml" /></remarks>
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._TexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array, or cube map array texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3D.xhtml" /></remarks>
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._TexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
        
        /// <summary> <b>[requires: v3.0]</b> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        /// <param name="bufSize"> Specifies the maximum number of integers that may be written to params by the function. </param>
        /// <param name="parameters"> Specifies the address of a variable into which to write the retrieved information. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetInternalformativ.xhtml" /></remarks>
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._GetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Launch one or more compute work groups. </summary>
        /// <param name="num_groups_x"> The number of work groups to be launched in the X dimension. </param>
        /// <param name="num_groups_y"> The number of work groups to be launched in the Y dimension. </param>
        /// <param name="num_groups_z"> The number of work groups to be launched in the Z dimension. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchCompute.xhtml" /></remarks>
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._DispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        
        /// <summary> <b>[requires: v3.1]</b> Launch one or more compute work groups using parameters stored in a buffer. </summary>
        /// <param name="indirect"> The offset into the buffer object currently bound to the GL_DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch parameters are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchComputeIndirect.xhtml" /></remarks>
        public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._DispatchComputeIndirect_fnptr(indirect);
        
        /// <summary> <b>[requires: v3.1]</b> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysIndirect.xhtml" /></remarks>
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._DrawArraysIndirect_fnptr((uint)mode, indirect);
        
        /// <summary> <b>[requires: v3.1]</b> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsIndirect.xhtml" /></remarks>
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._DrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
        
        /// <summary> <b>[requires: v3.1]</b> Set a named parameter of a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be modified. </param>
        /// <param name="param"> The new value for the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferParameteri.xhtml" /></remarks>
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._FramebufferParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.1]</b> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        /// <param name="parameters"> The address of a variable to receive the value of the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferParameteriv.xhtml" /></remarks>
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._GetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        /// <param name="parameters"> The address of a variable to retrieve the value of pname for the program interface. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInterface.xhtml" /></remarks>
        public static void GetProgramInterfaceiv(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._GetProgramInterfaceiv_fnptr((int)program, (uint)programInterface, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Query the index of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the index of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceIndex.xhtml" /></remarks>
        public static uint GetProgramResourceIndex(ProgramHandle program, ProgramInterface programInterface, byte* name) => GLPointers._GetProgramResourceIndex_fnptr((int)program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1]</b> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceName.xhtml" /></remarks>
        public static void GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._GetProgramResourceName_fnptr((int)program, (uint)programInterface, index, bufSize, length, name);
        
        /// <summary> <b>[requires: v3.1]</b> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="propCount">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="bufSize">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
        /// <param name="parameters">!!missing documentation!!</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResource.xhtml" /></remarks>
        public static void GetProgramResourceiv(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => GLPointers._GetProgramResourceiv_fnptr((int)program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Query the location of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the location of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceLocation.xhtml" /></remarks>
        public static int GetProgramResourceLocation(ProgramHandle program, ProgramInterface programInterface, byte* name) => GLPointers._GetProgramResourceLocation_fnptr((int)program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1]</b> Bind stages of a program object to a program pipeline. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to which to bind stages from program. </param>
        /// <param name="stages"> Specifies a set of program stages to bind to the program pipeline object. </param>
        /// <param name="program"> Specifies the program object containing the shader executables to use in pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgramStages.xhtml" /></remarks>
        public static void UseProgramStages(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program) => GLPointers._UseProgramStages_fnptr((int)pipeline, (uint)stages, (int)program);
        
        /// <summary> <b>[requires: v3.1]</b> Set the active program object for a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to set the active program object for. </param>
        /// <param name="program"> Specifies the program object to set as the active program pipeline object pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveShaderProgram.xhtml" /></remarks>
        public static void ActiveShaderProgram(ProgramPipelineHandle pipeline, ProgramHandle program) => GLPointers._ActiveShaderProgram_fnptr((int)pipeline, (int)program);
        
        /// <summary> <b>[requires: v3.1]</b> Create a stand-alone program from an array of null-terminated source code strings. </summary>
        /// <param name="type"> Specifies the type of shader to create. </param>
        /// <param name="count"> Specifies the number of source code strings in the array strings. </param>
        /// <param name="strings"> Specifies the address of an array of pointers to source code strings from which to create the program object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShaderProgram.xhtml" /></remarks>
        public static ProgramHandle CreateShaderProgramv(ShaderType type, int count, byte** strings) => (ProgramHandle) GLPointers._CreateShaderProgramv_fnptr((uint)type, count, strings);
        
        /// <summary> <b>[requires: v3.1]</b> Bind a program pipeline to the current context. </summary>
        /// <param name="pipeline"> Specifies the name of the pipeline object to bind to the context. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindProgramPipeline.xhtml" /></remarks>
        public static void BindProgramPipeline(ProgramPipelineHandle pipeline) => GLPointers._BindProgramPipeline_fnptr((int)pipeline);
        
        /// <summary> <b>[requires: v3.1]</b> Delete program pipeline objects. </summary>
        /// <param name="n"> Specifies the number of program pipeline objects to delete. </param>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgramPipelines.xhtml" /></remarks>
        public static void DeleteProgramPipelines(int n, ProgramPipelineHandle* pipelines) => GLPointers._DeleteProgramPipelines_fnptr(n, (int*)pipelines);
        
        /// <summary> <b>[requires: v3.1]</b> Reserve program pipeline object names. </summary>
        /// <param name="n"> Specifies the number of program pipeline object names to reserve. </param>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenProgramPipelines.xhtml" /></remarks>
        public static void GenProgramPipelines(int n, ProgramPipelineHandle* pipelines) => GLPointers._GenProgramPipelines_fnptr(n, (int*)pipelines);
        
        /// <summary> <b>[requires: v3.1]</b> Determine if a name corresponds to a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies a value that may be the name of a program pipeline object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgramPipeline.xhtml" /></remarks>
        public static byte IsProgramPipeline(ProgramPipelineHandle pipeline) => GLPointers._IsProgramPipeline_fnptr((int)pipeline);
        
        /// <summary> <b>[requires: v3.1]</b> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        /// <param name="parameters"> Specifies the address of a variable into which will be written the value or values of pname for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipeline.xhtml" /></remarks>
        public static void GetProgramPipelineiv(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters) => GLPointers._GetProgramPipelineiv_fnptr((int)pipeline, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1i(ProgramHandle program, int location, int v0) => GLPointers._ProgramUniform1i_fnptr((int)program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2i(ProgramHandle program, int location, int v0, int v1) => GLPointers._ProgramUniform2i_fnptr((int)program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3i(ProgramHandle program, int location, int v0, int v1, int v2) => GLPointers._ProgramUniform3i_fnptr((int)program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4i(ProgramHandle program, int location, int v0, int v1, int v2, int v3) => GLPointers._ProgramUniform4i_fnptr((int)program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1ui(ProgramHandle program, int location, uint v0) => GLPointers._ProgramUniform1ui_fnptr((int)program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2ui(ProgramHandle program, int location, uint v0, uint v1) => GLPointers._ProgramUniform2ui_fnptr((int)program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3ui(ProgramHandle program, int location, uint v0, uint v1, uint v2) => GLPointers._ProgramUniform3ui_fnptr((int)program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4ui(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._ProgramUniform4ui_fnptr((int)program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1f(ProgramHandle program, int location, float v0) => GLPointers._ProgramUniform1f_fnptr((int)program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2f(ProgramHandle program, int location, float v0, float v1) => GLPointers._ProgramUniform2f_fnptr((int)program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3f(ProgramHandle program, int location, float v0, float v1, float v2) => GLPointers._ProgramUniform3f_fnptr((int)program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4f(ProgramHandle program, int location, float v0, float v1, float v2, float v3) => GLPointers._ProgramUniform4f_fnptr((int)program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1iv(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform1iv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2iv(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform2iv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3iv(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform3iv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4iv(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform4iv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1uiv(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform1uiv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2uiv(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform2uiv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3uiv(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform3uiv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4uiv(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform4uiv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1fv(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform1fv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2fv(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform2fv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3fv(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform3fv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4fv(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform4fv_fnptr((int)program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2x3fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3x2fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2x4fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4x2fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3x4fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4x3fv_fnptr((int)program, location, count, transpose, value);
        
        /// <summary> <b>[requires: v3.1]</b> Validate a program pipeline object against current GL state. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object to validate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgramPipeline.xhtml" /></remarks>
        public static void ValidateProgramPipeline(ProgramPipelineHandle pipeline) => GLPointers._ValidateProgramPipeline_fnptr((int)pipeline);
        
        /// <summary> <b>[requires: v3.1]</b> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipelineInfoLog.xhtml" /></remarks>
        public static void GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._GetProgramPipelineInfoLog_fnptr((int)pipeline, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v3.1]</b> Bind a level of a texture to an image unit. </summary>
        /// <param name="unit"> Specifies the index of the image unit to which to bind the texture </param>
        /// <param name="texture"> Specifies the name of the texture to bind to the image unit. </param>
        /// <param name="level"> Specifies the level of the texture that is to be bound. </param>
        /// <param name="layered"> Specifies whether a layered texture binding is to be established. </param>
        /// <param name="layer"> If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise. </param>
        /// <param name="access"> Specifies a token indicating the type of access that will be performed on the image. </param>
        /// <param name="format"> Specifies the format that the elements of the image will be treated as for the purposes of formatted loads and stores. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindImageTexture.xhtml" /></remarks>
        public static void BindImageTexture(uint unit, TextureHandle texture, int level, byte layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._BindImageTexture_fnptr(unit, (int)texture, level, layered, layer, (uint)access, (uint)format);
        
        /// <summary> <b>[requires: v3.1]</b> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleani_v(BufferTargetARB target, uint index, byte* data) => GLPointers._GetBooleani_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.1]</b> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._MemoryBarrier_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.1]</b> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._MemoryBarrierByRegion_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.1]</b> Specify storage for a two-dimensional multisample texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2DMultisample.xhtml" /></remarks>
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, byte fixedsamplelocations) => GLPointers._TexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, fixedsamplelocations);
        
        /// <summary> <b>[requires: v3.1]</b> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetMultisamplefv.xhtml" /></remarks>
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._GetMultisamplefv_fnptr((uint)pname, index, val);
        
        /// <summary> <b>[requires: v3.1]</b> Set the value of a sub-word of the sample mask. </summary>
        /// <param name="maskNumber"> Specifies which 32-bit sub-word of the sample mask to update. </param>
        /// <param name="mask"> Specifies the new value of the mask sub-word. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleMaski.xhtml" /></remarks>
        public static void SampleMaski(uint maskNumber, All mask) => GLPointers._SampleMaski_fnptr(maskNumber, (uint)mask);
        
        /// <summary> <b>[requires: v3.1]</b> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._GetTexLevelParameteriv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._GetTexLevelParameterfv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> Bind a buffer to a vertex buffer bind point. </summary>
        /// <param name="bindingindex"> The index of the vertex buffer binding point to which to bind the buffer. </param>
        /// <param name="buffer"> The name of an existing buffer to bind to the vertex buffer binding point. </param>
        /// <param name="offset"> The offset of the first element of the buffer. </param>
        /// <param name="stride"> The distance between elements within the buffer. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexBuffer.xhtml" /></remarks>
        public static void BindVertexBuffer(uint bindingindex, BufferHandle buffer, IntPtr offset, int stride) => GLPointers._BindVertexBuffer_fnptr(bindingindex, (int)buffer, offset, stride);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="normalized"> Specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, byte normalized, uint relativeoffset) => GLPointers._VertexAttribFormat_fnptr(attribindex, size, (uint)type, normalized, relativeoffset);
        
        /// <summary> <b>[requires: v3.1]</b> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._VertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        /// <summary> <b>[requires: v3.1]</b> Associate a vertex attribute and a vertex buffer binding. </summary>
        /// <param name="attribindex"> The index of the attribute to associate with a vertex buffer binding. </param>
        /// <param name="bindingindex"> The index of the vertex buffer binding with which to associate the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribBinding.xhtml" /></remarks>
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._VertexAttribBinding_fnptr(attribindex, bindingindex);
        
        /// <summary> <b>[requires: v3.1]</b> Modify the rate at which generic vertex attributes advance. </summary>
        /// <param name="bindingindex"> The index of the binding whose divisor to modify. </param>
        /// <param name="divisor"> The new value for the instance step rate to apply. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexBindingDivisor.xhtml" /></remarks>
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._VertexBindingDivisor_fnptr(bindingindex, divisor);
        
        /// <summary> <b>[requires: v3.2]</b> Specifies a boundary between advanced blending passes. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendBarrier.xhtml" /></remarks>
        public static void BlendBarrier() => GLPointers._BlendBarrier_fnptr();
        
        /// <summary> <b>[requires: v3.2]</b> Perform a raw data copy between two images. </summary>
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
        public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._CopyImageSubData_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="count"> The length of the array ids. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => GLPointers._DebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, enabled);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Inject an application-supplied message into the debug message queue. </summary>
        /// <param name="source"> The source of the debug message to insert. </param>
        /// <param name="type"> The type of the debug message insert. </param>
        /// <param name="id"> The user-supplied identifier of the message to insert. </param>
        /// <param name="severity"> The severity of the debug messages to insert. </param>
        /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
        /// <param name="message"> The address of a character array containing the message to insert. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._DebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._DebugMessageCallback_fnptr(callback, userParam);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetDebugMessageLog.xhtml" /></remarks>
        public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._GetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Push a named debug group into the command stream. </summary>
        /// <param name="source"> The source of the debug message. </param>
        /// <param name="id"> The identifier of the message. </param>
        /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
        /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._PushDebugGroup_fnptr((uint)source, id, length, message);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Pop the active debug group. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
        public static void PopDebugGroup() => GLPointers._PopDebugGroup_fnptr();
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Label a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object to label. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._ObjectLabel_fnptr((uint)identifier, name, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._GetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._ObjectPtrLabel_fnptr(ptr, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._GetPointerv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enablei(EnableCap target, uint index) => GLPointers._Enablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v3.2]</b> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disablei(EnableCap target, uint index) => GLPointers._Disablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v3.2]</b> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="buf"> for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation. </param>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._BlendEquationi_fnptr(buf, (uint)mode);
        
        /// <summary> <b>[requires: v3.2]</b> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="buf"> for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations. </param>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._BlendEquationSeparatei_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v3.2]</b> Specify pixel arithmetic. </summary>
        /// <param name="buf"> For glBlendFunci, specifies the index of the draw buffer for which to set the blend function. </param>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._BlendFunci_fnptr(buf, (uint)src, (uint)dst);
        
        /// <summary> <b>[requires: v3.2]</b> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="buf"> For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions. </param>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._BlendFuncSeparatei_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
        
        /// <summary> <b>[requires: v3.2]</b> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="buf"> For glColorMaski, specifies the index of the draw buffer whose color mask to set. </param>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMaski(uint index, byte r, byte g, byte b, byte a) => GLPointers._ColorMaski_fnptr(index, r, g, b, a);
        
        /// <summary> <b>[requires: v3.2]</b> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static byte IsEnabledi(EnableCap target, uint index) => GLPointers._IsEnabledi_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v3.2]</b> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsBaseVertex.xhtml" /></remarks>
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v3.2]</b> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElementsBaseVertex.xhtml" /></remarks>
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v3.2]</b> Render multiple instances of a set of primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the indexed geometry that should be drawn. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstancedBaseVertex.xhtml" /></remarks>
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._DrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
        
        /// <summary> <b>[requires: v3.2]</b> Attach a level of a texture object as a logical buffer of a framebuffer object. </summary>
        /// <param name="target"> Specifies the target to which the framebuffer is bound. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="texture"> Specifies the name of an existing texture object to attach. </param>
        /// <param name="level"> Specifies the mipmap level of the texture object to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture.xhtml" /></remarks>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => GLPointers._FramebufferTexture_fnptr((uint)target, (uint)attachment, (int)texture, level);
        
        /// <summary> <b>[requires: v3.2]</b> Set the bounding box for a primitive. </summary>
        /// <param name="minX"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minY"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minZ"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minW"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="maxX"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxY"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxZ"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxW"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPrimitiveBoundingBox.xhtml" /></remarks>
        public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._PrimitiveBoundingBox_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Check if the rendering context has not been lost due to software or hardware issues. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
        public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._GetGraphicsResetStatus_fnptr();
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
        /// <param name="data"> Returns the pixel data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
        public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._ReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformfv(ProgramHandle program, int location, int bufSize, float* parameters) => GLPointers._GetnUniformfv_fnptr((int)program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformiv(ProgramHandle program, int location, int bufSize, int* parameters) => GLPointers._GetnUniformiv_fnptr((int)program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformuiv(ProgramHandle program, int location, int bufSize, uint* parameters) => GLPointers._GetnUniformuiv_fnptr((int)program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Specifies minimum rate at which sample shading takes place. </summary>
        /// <param name="value"> Specifies the rate at which samples are shaded within each covered pixel. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMinSampleShading.xhtml" /></remarks>
        public static void MinSampleShading(float value) => GLPointers._MinSampleShading_fnptr(value);
        
        /// <summary> <b>[requires: v3.2]</b> Specifies the parameters for patch primitives. </summary>
        /// <param name="pname"> Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES is accepted. </param>
        /// <param name="value"> Specifies the new value for the parameter given by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPatchParameteri.xhtml" /></remarks>
        public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._PatchParameteri_fnptr((uint)pname, value);
        
        /// <summary> <b>[requires: v3.2]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._TexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._TexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._GetTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIiv(SamplerHandle sampler, SamplerParameterI pname, int* param) => GLPointers._SamplerParameterIiv_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2]</b> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIuiv(SamplerHandle sampler, SamplerParameterI pname, uint* param) => GLPointers._SamplerParameterIuiv_fnptr((int)sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIiv(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => GLPointers._GetSamplerParameterIiv_fnptr((int)sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIuiv(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => GLPointers._GetSamplerParameterIuiv_fnptr((int)sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> Attach a buffer object's data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBuffer.xhtml" /></remarks>
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => GLPointers._TexBuffer_fnptr((uint)target, (uint)internalformat, (int)buffer);
        
        /// <summary> <b>[requires: v3.2]</b> Attach a range of a buffer object's data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexBufferRange. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <param name="offset"> Specifies the offset of the start of the range of the buffer's data store to attach. </param>
        /// <param name="size"> Specifies the size of the range of the buffer's data store to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBufferRange.xhtml" /></remarks>
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => GLPointers._TexBufferRange_fnptr((uint)target, (uint)internalformat, (int)buffer, offset, size);
        
        /// <summary> <b>[requires: v3.2]</b> Specify storage for a two-dimensional multisample array texture. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in layers. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3DMultisample.xhtml" /></remarks>
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations) => GLPointers._TexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, fixedsamplelocations);
        
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleAdvancedAMD_fnptr((uint)target, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedRenderbufferStorageMultisampleAdvancedAMD(RenderbufferHandle renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._NamedRenderbufferStorageMultisampleAdvancedAMD_fnptr((int)renderbuffer, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => GLPointers._GetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => GLPointers._GetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => GLPointers._GetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => GLPointers._GetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, void* data) => GLPointers._GetPerfMonitorCounterInfoAMD_fnptr(group, counter, (uint)pname, data);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenPerfMonitorsAMD(int n, uint* monitors) => GLPointers._GenPerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeletePerfMonitorsAMD(int n, uint* monitors) => GLPointers._DeletePerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SelectPerfMonitorCountersAMD(uint monitor, byte enable, uint group, int numCounters, uint* counterList) => GLPointers._SelectPerfMonitorCountersAMD_fnptr(monitor, enable, group, numCounters, counterList);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BeginPerfMonitorAMD(uint monitor) => GLPointers._BeginPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndPerfMonitorAMD(uint monitor) => GLPointers._EndPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => GLPointers._GetPerfMonitorCounterDataAMD_fnptr(monitor, (uint)pname, dataSize, data, bytesWritten);
            
        }
        public static unsafe partial class ANGLE
        {
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_blit]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._BlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleANGLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleANGLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawArraysInstancedANGLE(PrimitiveType mode, int first, int count, int primcount) => GLPointers._DrawArraysInstancedANGLE_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedANGLE(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount) => GLPointers._DrawElementsInstancedANGLE_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void VertexAttribDivisorANGLE(uint index, uint divisor) => GLPointers._VertexAttribDivisorANGLE_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_ANGLE_translated_shader_source]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int* length, byte* source) => GLPointers._GetTranslatedShaderSourceANGLE_fnptr((int)shader, bufSize, length, source);
            
        }
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
            public static byte IsSyncAPPLE(GLSync sync) => GLPointers._IsSyncAPPLE_fnptr((IntPtr)sync);
            
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
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetTexStorageEXT(All target, void* image, int* attrib_list) => GLPointers._EGLImageTargetTexStorageEXT_fnptr((uint)target, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetTextureStorageEXT(TextureHandle texture, void* image, int* attrib_list) => GLPointers._EGLImageTargetTextureStorageEXT_fnptr((int)texture, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._DrawArraysInstancedBaseInstanceEXT_fnptr((uint)mode, first, count, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, PrimitiveType type, void* indices, int instancecount, uint baseinstance) => GLPointers._DrawElementsInstancedBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._DrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindFragDataLocationIndexedEXT(ProgramHandle program, uint colorNumber, uint index, byte* name) => GLPointers._BindFragDataLocationIndexedEXT_fnptr((int)program, colorNumber, index, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindFragDataLocationEXT(ProgramHandle program, uint color, byte* name) => GLPointers._BindFragDataLocationEXT_fnptr((int)program, color, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static int GetProgramResourceLocationIndexEXT(ProgramHandle program, ProgramInterface programInterface, byte* name) => GLPointers._GetProgramResourceLocationIndexEXT_fnptr((int)program, (uint)programInterface, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static int GetFragDataIndexEXT(ProgramHandle program, byte* name) => GLPointers._GetFragDataIndexEXT_fnptr((int)program, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_minmax]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._BlendEquationEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_buffer_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BufferStorageEXT(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._BufferStorageEXT_fnptr((uint)target, size, data, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearTexImageEXT(TextureHandle texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._ClearTexImageEXT_fnptr((int)texture, level, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearTexSubImageEXT(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._ClearTexSubImageEXT_fnptr((int)texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clip_control]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClipControlEXT(All origin, All depth) => GLPointers._ClipControlEXT_fnptr((uint)origin, (uint)depth);
            
            /// <summary> <b>[requires: GL_EXT_copy_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._CopyImageSubDataEXT_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_EXT_debug_label]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void LabelObjectEXT(All type, uint obj, int length, byte* label) => GLPointers._LabelObjectEXT_fnptr((uint)type, obj, length, label);
            
            /// <summary> <b>[requires: GL_EXT_debug_label]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetObjectLabelEXT(All type, uint obj, int bufSize, int* length, byte* label) => GLPointers._GetObjectLabelEXT_fnptr((uint)type, obj, bufSize, length, label);
            
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
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenQueriesEXT(int n, QueryHandle* ids) => GLPointers._GenQueriesEXT_fnptr(n, (int*)ids);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteQueriesEXT(int n, QueryHandle* ids) => GLPointers._DeleteQueriesEXT_fnptr(n, (int*)ids);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsQueryEXT(QueryHandle id) => GLPointers._IsQueryEXT_fnptr((int)id);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BeginQueryEXT(QueryTarget target, QueryHandle id) => GLPointers._BeginQueryEXT_fnptr((uint)target, (int)id);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndQueryEXT(QueryTarget target) => GLPointers._EndQueryEXT_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void QueryCounterEXT(QueryHandle id, QueryCounterTarget target) => GLPointers._QueryCounterEXT_fnptr((int)id, (uint)target);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._GetQueryivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, int* parameters) => GLPointers._GetQueryObjectivEXT_fnptr((int)id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, uint* parameters) => GLPointers._GetQueryObjectuivEXT_fnptr((int)id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, long* parameters) => GLPointers._GetQueryObjecti64vEXT_fnptr((int)id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._GetQueryObjectui64vEXT_fnptr((int)id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetInteger64vEXT(GetPName pname, long* data) => GLPointers._GetInteger64vEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawBuffersEXT(int n, All* bufs) => GLPointers._DrawBuffersEXT_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EnableiEXT(EnableCap target, uint index) => GLPointers._EnableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DisableiEXT(EnableCap target, uint index) => GLPointers._DisableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationiEXT(uint buf, BlendEquationModeEXT mode) => GLPointers._BlendEquationiEXT_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._BlendEquationSeparateiEXT_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._BlendFunciEXT_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._BlendFuncSeparateiEXT_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ColorMaskiEXT(uint index, byte r, byte g, byte b, byte a) => GLPointers._ColorMaskiEXT_fnptr(index, r, g, b, a);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsEnablediEXT(EnableCap target, uint index) => GLPointers._IsEnablediEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawRangeElementsBaseVertexEXT_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._DrawElementsInstancedBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._MultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawArraysInstancedEXT(PrimitiveType mode, int start, int count, int primcount) => GLPointers._DrawArraysInstancedEXT_fnptr((uint)mode, start, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._DrawElementsInstancedEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTransformFeedbackEXT(PrimitiveType mode, TransformFeedbackHandle id) => GLPointers._DrawTransformFeedbackEXT_fnptr((uint)mode, (int)id);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawTransformFeedbackInstancedEXT(PrimitiveType mode, TransformFeedbackHandle id, int instancecount) => GLPointers._DrawTransformFeedbackInstancedEXT_fnptr((uint)mode, (int)id, instancecount);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BufferStorageExternalEXT(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._BufferStorageExternalEXT_fnptr((uint)target, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedBufferStorageExternalEXT(BufferHandle buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._NamedBufferStorageExternalEXT_fnptr((int)buffer, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_geometry_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => GLPointers._FramebufferTextureEXT_fnptr((uint)target, (uint)attachment, (int)texture, level);
            
            /// <summary> <b>[requires: GL_EXT_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void VertexAttribDivisorEXT(uint index, uint divisor) => GLPointers._VertexAttribDivisorEXT_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._MapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._FlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetUnsignedBytevEXT(GetPName pname, byte* data) => GLPointers._GetUnsignedBytevEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetUnsignedBytei_vEXT(All target, uint index, byte* data) => GLPointers._GetUnsignedBytei_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._DeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsMemoryObjectEXT(uint memoryObject) => GLPointers._IsMemoryObjectEXT_fnptr(memoryObject);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CreateMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._CreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._MemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._GetMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageMem2DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._TexStorageMem2DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset) => GLPointers._TexStorageMem2DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, fixedSampleLocations, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageMem3DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._TexStorageMem3DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset) => GLPointers._TexStorageMem3DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BufferStorageMemEXT(BufferTargetARB target, nint size, uint memory, ulong offset) => GLPointers._BufferStorageMemEXT_fnptr((uint)target, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorageMem2DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._TextureStorageMem2DEXT_fnptr((int)texture, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorageMem2DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset) => GLPointers._TextureStorageMem2DMultisampleEXT_fnptr((int)texture, samples, (uint)internalFormat, width, height, fixedSampleLocations, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorageMem3DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._TextureStorageMem3DEXT_fnptr((int)texture, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorageMem3DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset) => GLPointers._TextureStorageMem3DMultisampleEXT_fnptr((int)texture, samples, (uint)internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedBufferStorageMemEXT(BufferHandle buffer, nint size, uint memory, ulong offset) => GLPointers._NamedBufferStorageMemEXT_fnptr((int)buffer, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageMem1DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._TexStorageMem1DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorageMem1DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._TextureStorageMem1DEXT_fnptr((int)texture, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_fd]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => GLPointers._ImportMemoryFdEXT_fnptr(memory, size, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void* handle) => GLPointers._ImportMemoryWin32HandleEXT_fnptr(memory, size, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void* name) => GLPointers._ImportMemoryWin32NameEXT_fnptr(memory, size, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._MultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._MultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawArraysIndirectEXT(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._MultiDrawArraysIndirectEXT_fnptr((uint)mode, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._MultiDrawElementsIndirectEXT_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => GLPointers._FramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, (int)texture, level, samples);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadBufferIndexedEXT(ReadBufferMode src, int index) => GLPointers._ReadBufferIndexedEXT_fnptr((uint)src, index);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawBuffersIndexedEXT(int n, All* location, int* indices) => GLPointers._DrawBuffersIndexedEXT_fnptr(n, (uint*)location, indices);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetIntegeri_vEXT(GetPName target, uint index, int* data) => GLPointers._GetIntegeri_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_polygon_offset_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PolygonOffsetClampEXT(float factor, float units, float clamp) => GLPointers._PolygonOffsetClampEXT_fnptr(factor, units, clamp);
            
            /// <summary> <b>[requires: GL_EXT_primitive_bounding_box]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._PrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterSamplesEXT(uint samples, byte fixedsamplelocations) => GLPointers._RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => (GraphicsResetStatus) GLPointers._GetGraphicsResetStatusEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._ReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, float* parameters) => GLPointers._GetnUniformfvEXT_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, int* parameters) => GLPointers._GetnUniformivEXT_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenSemaphoresEXT(int n, uint* semaphores) => GLPointers._GenSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteSemaphoresEXT(int n, uint* semaphores) => GLPointers._DeleteSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsSemaphoreEXT(uint semaphore) => GLPointers._IsSemaphoreEXT_fnptr(semaphore);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._SemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._GetSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* srcLayouts) => GLPointers._WaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, (int*)buffers, numTextureBarriers, (int*)textures, (uint*)srcLayouts);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* dstLayouts) => GLPointers._SignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, (int*)buffers, numTextureBarriers, (int*)textures, (uint*)dstLayouts);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_fd]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => GLPointers._ImportSemaphoreFdEXT_fnptr(semaphore, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void* handle) => GLPointers._ImportSemaphoreWin32HandleEXT_fnptr(semaphore, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void* name) => GLPointers._ImportSemaphoreWin32NameEXT_fnptr(semaphore, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UseShaderProgramEXT(All type, ProgramHandle program) => GLPointers._UseShaderProgramEXT_fnptr((uint)type, (int)program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ActiveProgramEXT(ProgramHandle program) => GLPointers._ActiveProgramEXT_fnptr((int)program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ProgramHandle CreateShaderProgramEXT(ShaderType type, byte* str) => (ProgramHandle) GLPointers._CreateShaderProgramEXT_fnptr((uint)type, str);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ActiveShaderProgramEXT(ProgramPipelineHandle pipeline, ProgramHandle program) => GLPointers._ActiveShaderProgramEXT_fnptr((int)pipeline, (int)program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindProgramPipelineEXT(ProgramPipelineHandle pipeline) => GLPointers._BindProgramPipelineEXT_fnptr((int)pipeline);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ProgramHandle CreateShaderProgramvEXT(ShaderType type, int count, byte** strings) => (ProgramHandle) GLPointers._CreateShaderProgramvEXT_fnptr((uint)type, count, strings);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteProgramPipelinesEXT(int n, ProgramPipelineHandle* pipelines) => GLPointers._DeleteProgramPipelinesEXT_fnptr(n, (int*)pipelines);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenProgramPipelinesEXT(int n, ProgramPipelineHandle* pipelines) => GLPointers._GenProgramPipelinesEXT_fnptr(n, (int*)pipelines);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._GetProgramPipelineInfoLogEXT_fnptr((int)pipeline, bufSize, length, infoLog);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetProgramPipelineivEXT(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters) => GLPointers._GetProgramPipelineivEXT_fnptr((int)pipeline, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsProgramPipelineEXT(ProgramPipelineHandle pipeline) => GLPointers._IsProgramPipelineEXT_fnptr((int)pipeline);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramParameteriEXT(ProgramHandle program, ProgramParameterPName pname, int value) => GLPointers._ProgramParameteriEXT_fnptr((int)program, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1fEXT(ProgramHandle program, int location, float v0) => GLPointers._ProgramUniform1fEXT_fnptr((int)program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1fvEXT(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform1fvEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1iEXT(ProgramHandle program, int location, int v0) => GLPointers._ProgramUniform1iEXT_fnptr((int)program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1ivEXT(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform1ivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2fEXT(ProgramHandle program, int location, float v0, float v1) => GLPointers._ProgramUniform2fEXT_fnptr((int)program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2fvEXT(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform2fvEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2iEXT(ProgramHandle program, int location, int v0, int v1) => GLPointers._ProgramUniform2iEXT_fnptr((int)program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2ivEXT(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform2ivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3fEXT(ProgramHandle program, int location, float v0, float v1, float v2) => GLPointers._ProgramUniform3fEXT_fnptr((int)program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3fvEXT(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform3fvEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3iEXT(ProgramHandle program, int location, int v0, int v1, int v2) => GLPointers._ProgramUniform3iEXT_fnptr((int)program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3ivEXT(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform3ivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4fEXT(ProgramHandle program, int location, float v0, float v1, float v2, float v3) => GLPointers._ProgramUniform4fEXT_fnptr((int)program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4fvEXT(ProgramHandle program, int location, int count, float* value) => GLPointers._ProgramUniform4fvEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4iEXT(ProgramHandle program, int location, int v0, int v1, int v2, int v3) => GLPointers._ProgramUniform4iEXT_fnptr((int)program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4ivEXT(ProgramHandle program, int location, int count, int* value) => GLPointers._ProgramUniform4ivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UseProgramStagesEXT(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program) => GLPointers._UseProgramStagesEXT_fnptr((int)pipeline, (uint)stages, (int)program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ValidateProgramPipelineEXT(ProgramPipelineHandle pipeline) => GLPointers._ValidateProgramPipelineEXT_fnptr((int)pipeline);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1uiEXT(ProgramHandle program, int location, uint v0) => GLPointers._ProgramUniform1uiEXT_fnptr((int)program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2uiEXT(ProgramHandle program, int location, uint v0, uint v1) => GLPointers._ProgramUniform2uiEXT_fnptr((int)program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3uiEXT(ProgramHandle program, int location, uint v0, uint v1, uint v2) => GLPointers._ProgramUniform3uiEXT_fnptr((int)program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4uiEXT(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._ProgramUniform4uiEXT_fnptr((int)program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1uivEXT(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform1uivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2uivEXT(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform2uivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3uivEXT(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform3uivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4uivEXT(ProgramHandle program, int location, int count, uint* value) => GLPointers._ProgramUniform4uivEXT_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2x3fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3x2fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix2x4fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4x2fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix3x4fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => GLPointers._ProgramUniformMatrix4x3fvEXT_fnptr((int)program, location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_EXT_shader_framebuffer_fetch_non_coherent]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferFetchBarrierEXT() => GLPointers._FramebufferFetchBarrierEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferPixelLocalStorageSizeEXT(uint target, int size) => GLPointers._FramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static int GetFramebufferPixelLocalStorageSizeEXT(uint target) => GLPointers._GetFramebufferPixelLocalStorageSizeEXT_fnptr(target);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ClearPixelLocalStorageuiEXT(int offset, int n, uint* values) => GLPointers._ClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            
            /// <summary> <b>[requires: GL_EXT_sparse_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexPageCommitmentEXT(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit) => GLPointers._TexPageCommitmentEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
            
            /// <summary> <b>[requires: GL_EXT_tessellation_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PatchParameteriEXT(PatchParameterName pname, int value) => GLPointers._PatchParameteriEXT_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._TexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._TexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._GetTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int* param) => GLPointers._SamplerParameterIivEXT_fnptr((int)sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint* param) => GLPointers._SamplerParameterIuivEXT_fnptr((int)sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => GLPointers._GetSamplerParameterIivEXT_fnptr((int)sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => GLPointers._GetSamplerParameterIuivEXT_fnptr((int)sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexBufferEXT(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => GLPointers._TexBufferEXT_fnptr((uint)target, (uint)internalformat, (int)buffer);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexBufferRangeEXT(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => GLPointers._TexBufferRangeEXT_fnptr((uint)target, (uint)internalformat, (int)buffer, offset, size);
            
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
            public static void TextureStorage1DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._TextureStorage1DEXT_fnptr((int)texture, (uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage2DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._TextureStorage2DEXT_fnptr((int)texture, (uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureStorage3DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._TextureStorage3DEXT_fnptr((int)texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageAttribs2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int* attrib_list) => GLPointers._TexStorageAttribs2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorageAttribs3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, int* attrib_list) => GLPointers._TexStorageAttribs3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_texture_view]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureViewEXT(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._TextureViewEXT_fnptr((int)texture, (uint)target, (int)origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte AcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => GLPointers._AcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout);
            
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte ReleaseKeyedMutexWin32EXT(uint memory, ulong key) => GLPointers._ReleaseKeyedMutexWin32EXT_fnptr(memory, key);
            
            /// <summary> <b>[requires: GL_EXT_window_rectangles]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WindowRectanglesEXT(All mode, int count, int* box) => GLPointers._WindowRectanglesEXT_fnptr((uint)mode, count, box);
            
        }
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CreateSemaphoresNV(int n, uint* semaphores) => GLPointers._CreateSemaphoresNV_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._SemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._GetSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ulong GetTextureHandleNV(TextureHandle texture) => GLPointers._GetTextureHandleNV_fnptr((int)texture);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ulong GetTextureSamplerHandleNV(TextureHandle texture, SamplerHandle sampler) => GLPointers._GetTextureSamplerHandleNV_fnptr((int)texture, (int)sampler);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MakeTextureHandleResidentNV(ulong handle) => GLPointers._MakeTextureHandleResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MakeTextureHandleNonResidentNV(ulong handle) => GLPointers._MakeTextureHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ulong GetImageHandleNV(TextureHandle texture, int level, byte layered, int layer, PixelFormat format) => GLPointers._GetImageHandleNV_fnptr((int)texture, level, layered, layer, (uint)format);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MakeImageHandleResidentNV(ulong handle, All access) => GLPointers._MakeImageHandleResidentNV_fnptr(handle, (uint)access);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MakeImageHandleNonResidentNV(ulong handle) => GLPointers._MakeImageHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformHandleui64NV(int location, ulong value) => GLPointers._UniformHandleui64NV_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformHandleui64vNV(int location, int count, ulong* value) => GLPointers._UniformHandleui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformHandleui64NV(ProgramHandle program, int location, ulong value) => GLPointers._ProgramUniformHandleui64NV_fnptr((int)program, location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformHandleui64vNV(ProgramHandle program, int location, int count, ulong* values) => GLPointers._ProgramUniformHandleui64vNV_fnptr((int)program, location, count, values);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsTextureHandleResidentNV(ulong handle) => GLPointers._IsTextureHandleResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsImageHandleResidentNV(ulong handle) => GLPointers._IsImageHandleResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendParameteriNV(All pname, int value) => GLPointers._BlendParameteriNV_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendBarrierNV() => GLPointers._BlendBarrierNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_clip_space_w_scaling]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => GLPointers._ViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            
            /// <summary> <b>[requires: GL_NV_conditional_render]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => GLPointers._BeginConditionalRenderNV_fnptr(id, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_conditional_render]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndConditionalRenderNV() => GLPointers._EndConditionalRenderNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_conservative_raster]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SubpixelPrecisionBiasNV(uint xbits, uint ybits) => GLPointers._SubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            
            /// <summary> <b>[requires: GL_NV_conservative_raster_pre_snap_triangles]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ConservativeRasterParameteriNV(All pname, int param) => GLPointers._ConservativeRasterParameteriNV_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_NV_copy_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._CopyBufferSubDataNV_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GL_NV_coverage_sample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverageMaskNV(byte mask) => GLPointers._CoverageMaskNV_fnptr(mask);
            
            /// <summary> <b>[requires: GL_NV_coverage_sample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverageOperationNV(All operation) => GLPointers._CoverageOperationNV_fnptr((uint)operation);
            
            /// <summary> <b>[requires: GL_NV_draw_buffers]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawBuffersNV(int n, All* bufs) => GLPointers._DrawBuffersNV_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawArraysInstancedNV(PrimitiveType mode, int first, int count, int primcount) => GLPointers._DrawArraysInstancedNV_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedNV(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount) => GLPointers._DrawElementsInstancedNV_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawVkImageNV(ulong vkImage, SamplerHandle sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._DrawVkImageNV_fnptr(vkImage, (int)sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static IntPtr GetVkProcAddrNV(byte* name) => GLPointers._GetVkProcAddrNV_fnptr(name);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WaitVkSemaphoreNV(ulong vkSemaphore) => GLPointers._WaitVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SignalVkSemaphoreNV(ulong vkSemaphore) => GLPointers._SignalVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SignalVkFenceNV(ulong vkFence) => GLPointers._SignalVkFenceNV_fnptr(vkFence);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._DeleteFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenFencesNV(int n, uint* fences) => GLPointers._GenFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsFenceNV(uint fence) => GLPointers._IsFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte TestFenceNV(uint fence) => GLPointers._TestFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._GetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FinishFenceNV(uint fence) => GLPointers._FinishFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fence]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._SetFenceNV_fnptr(fence, (uint)condition);
            
            /// <summary> <b>[requires: GL_NV_fragment_coverage_to_color]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FragmentCoverageColorNV(uint color) => GLPointers._FragmentCoverageColorNV_fnptr(color);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_blit]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._BlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RasterSamplesEXT(uint samples, byte fixedsamplelocations) => GLPointers._RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverageModulationTableNV(int n, float* v) => GLPointers._CoverageModulationTableNV_fnptr(n, v);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetCoverageModulationTableNV(int bufSize, float* v) => GLPointers._GetCoverageModulationTableNV_fnptr(bufSize, v);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverageModulationNV(All components) => GLPointers._CoverageModulationNV_fnptr((uint)components);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_multisample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleNV(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleNV_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform1i64NV(int location, long x) => GLPointers._Uniform1i64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform2i64NV(int location, long x, long y) => GLPointers._Uniform2i64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform3i64NV(int location, long x, long y, long z) => GLPointers._Uniform3i64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => GLPointers._Uniform4i64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform1i64vNV(int location, int count, long* value) => GLPointers._Uniform1i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform2i64vNV(int location, int count, long* value) => GLPointers._Uniform2i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform3i64vNV(int location, int count, long* value) => GLPointers._Uniform3i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform4i64vNV(int location, int count, long* value) => GLPointers._Uniform4i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform1ui64NV(int location, ulong x) => GLPointers._Uniform1ui64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => GLPointers._Uniform2ui64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => GLPointers._Uniform3ui64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._Uniform4ui64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => GLPointers._Uniform1ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => GLPointers._Uniform2ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => GLPointers._Uniform3ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => GLPointers._Uniform4ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetUniformi64vNV(ProgramHandle program, int location, long* parameters) => GLPointers._GetUniformi64vNV_fnptr((int)program, location, parameters);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1i64NV(ProgramHandle program, int location, long x) => GLPointers._ProgramUniform1i64NV_fnptr((int)program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2i64NV(ProgramHandle program, int location, long x, long y) => GLPointers._ProgramUniform2i64NV_fnptr((int)program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3i64NV(ProgramHandle program, int location, long x, long y, long z) => GLPointers._ProgramUniform3i64NV_fnptr((int)program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4i64NV(ProgramHandle program, int location, long x, long y, long z, long w) => GLPointers._ProgramUniform4i64NV_fnptr((int)program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1i64vNV(ProgramHandle program, int location, int count, long* value) => GLPointers._ProgramUniform1i64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2i64vNV(ProgramHandle program, int location, int count, long* value) => GLPointers._ProgramUniform2i64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3i64vNV(ProgramHandle program, int location, int count, long* value) => GLPointers._ProgramUniform3i64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4i64vNV(ProgramHandle program, int location, int count, long* value) => GLPointers._ProgramUniform4i64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1ui64NV(ProgramHandle program, int location, ulong x) => GLPointers._ProgramUniform1ui64NV_fnptr((int)program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2ui64NV(ProgramHandle program, int location, ulong x, ulong y) => GLPointers._ProgramUniform2ui64NV_fnptr((int)program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z) => GLPointers._ProgramUniform3ui64NV_fnptr((int)program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._ProgramUniform4ui64NV_fnptr((int)program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform1ui64vNV(ProgramHandle program, int location, int count, ulong* value) => GLPointers._ProgramUniform1ui64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform2ui64vNV(ProgramHandle program, int location, int count, ulong* value) => GLPointers._ProgramUniform2ui64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform3ui64vNV(ProgramHandle program, int location, int count, ulong* value) => GLPointers._ProgramUniform3ui64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniform4ui64vNV(ProgramHandle program, int location, int count, ulong* value) => GLPointers._ProgramUniform4ui64vNV_fnptr((int)program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_instanced_arrays]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void VertexAttribDivisorNV(uint index, uint divisor) => GLPointers._VertexAttribDivisorNV_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_NV_internalformat_sample_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => GLPointers._GetInternalformatSampleivNV_fnptr((uint)target, (uint)internalformat, samples, (uint)pname, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, uint* parameters) => GLPointers._GetMemoryObjectDetachedResourcesuivNV_fnptr(memory, (uint)pname, first, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ResetMemoryObjectParameterNV(uint memory, All pname) => GLPointers._ResetMemoryObjectParameterNV_fnptr(memory, (uint)pname);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => GLPointers._TexAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => GLPointers._BufferAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureAttachMemoryNV(TextureHandle texture, uint memory, ulong offset) => GLPointers._TextureAttachMemoryNV_fnptr((int)texture, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedBufferAttachMemoryNV(BufferHandle buffer, uint memory, ulong offset) => GLPointers._NamedBufferAttachMemoryNV_fnptr((int)buffer, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit) => GLPointers._BufferPageCommitmentMemNV_fnptr((uint)target, offset, size, memory, memOffset, commit);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit) => GLPointers._TexPageCommitmentMemNV_fnptr((uint)target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedBufferPageCommitmentMemNV(BufferHandle buffer, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit) => GLPointers._NamedBufferPageCommitmentMemNV_fnptr((int)buffer, offset, size, memory, memOffset, commit);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexturePageCommitmentMemNV(TextureHandle texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit) => GLPointers._TexturePageCommitmentMemNV_fnptr((int)texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawMeshTasksNV(uint first, uint count) => GLPointers._DrawMeshTasksNV_fnptr(first, count);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawMeshTasksIndirectNV(IntPtr indirect) => GLPointers._DrawMeshTasksIndirectNV_fnptr(indirect);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride) => GLPointers._MultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._MultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix2x3fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix2x3fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix3x2fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix3x2fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix2x4fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix2x4fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix4x2fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix4x2fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix3x4fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix3x4fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformMatrix4x3fvNV(int location, int count, byte transpose, float* value) => GLPointers._UniformMatrix4x3fvNV_fnptr(location, count, transpose, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static uint GenPathsNV(int range) => GLPointers._GenPathsNV_fnptr(range);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeletePathsNV(uint path, int range) => GLPointers._DeletePathsNV_fnptr(path, range);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsPathNV(uint path) => GLPointers._IsPathNV_fnptr(path);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._PathCommandsNV_fnptr(path, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, void* coords) => GLPointers._PathCoordsNV_fnptr(path, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._PathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => GLPointers._PathSubCoordsNV_fnptr(path, coordStart, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathStringNV(uint path, PathStringFormat format, int length, void* pathString) => GLPointers._PathStringNV_fnptr(path, (uint)format, length, pathString);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._PathGlyphsNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, numGlyphs, (uint)type, charcodes, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._PathGlyphRangeNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyph, numGlyphs, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void WeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights) => GLPointers._WeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyPathNV(uint resultPath, uint srcPath) => GLPointers._CopyPathNV_fnptr(resultPath, srcPath);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void InterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => GLPointers._InterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => GLPointers._TransformPathNV_fnptr(resultPath, srcPath, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._PathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathParameteriNV(uint path, PathParameter pname, int value) => GLPointers._PathParameteriNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._PathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathParameterfNV(uint path, PathParameter pname, float value) => GLPointers._PathParameterfNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathDashArrayNV(uint path, int dashCount, float* dashArray) => GLPointers._PathDashArrayNV_fnptr(path, dashCount, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathStencilFuncNV(StencilFunction func, int reference, uint mask) => GLPointers._PathStencilFuncNV_fnptr((uint)func, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathStencilDepthOffsetNV(float factor, float units) => GLPointers._PathStencilDepthOffsetNV_fnptr(factor, units);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => GLPointers._StencilFillPathNV_fnptr(path, (uint)fillMode, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilStrokePathNV(uint path, int reference, uint mask) => GLPointers._StencilStrokePathNV_fnptr(path, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._StencilFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._StencilStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PathCoverDepthFuncNV(DepthFunction func) => GLPointers._PathCoverDepthFuncNV_fnptr((uint)func);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverFillPathNV(uint path, PathCoverMode coverMode) => GLPointers._CoverFillPathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverStrokePathNV(uint path, PathCoverMode coverMode) => GLPointers._CoverStrokePathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._CoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._CoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._GetPathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._GetPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathCommandsNV(uint path, byte* commands) => GLPointers._GetPathCommandsNV_fnptr(path, commands);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathCoordsNV(uint path, float* coords) => GLPointers._GetPathCoordsNV_fnptr(path, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathDashArrayNV(uint path, float* dashArray) => GLPointers._GetPathDashArrayNV_fnptr(path, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => GLPointers._GetPathMetricsNV_fnptr((uint)metricQueryMask, numPaths, (uint)pathNameType, paths, pathBase, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => GLPointers._GetPathMetricRangeNV_fnptr((uint)metricQueryMask, firstPathName, numPaths, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => GLPointers._GetPathSpacingNV_fnptr((uint)pathListMode, numPaths, (uint)pathNameType, paths, pathBase, advanceScale, kerningScale, (uint)transformType, returnedSpacing);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsPointInFillPathNV(uint path, uint mask, float x, float y) => GLPointers._IsPointInFillPathNV_fnptr(path, mask, x, y);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsPointInStrokePathNV(uint path, float x, float y) => GLPointers._IsPointInStrokePathNV_fnptr(path, x, y);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static float GetPathLengthNV(uint path, int startSegment, int numSegments) => GLPointers._GetPathLengthNV_fnptr(path, startSegment, numSegments);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => GLPointers._PointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoad3x2fNV(All matrixMode, float* m) => GLPointers._MatrixLoad3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoad3x3fNV(All matrixMode, float* m) => GLPointers._MatrixLoad3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoadTranspose3x3fNV(All matrixMode, float* m) => GLPointers._MatrixLoadTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMult3x2fNV(All matrixMode, float* m) => GLPointers._MatrixMult3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMult3x3fNV(All matrixMode, float* m) => GLPointers._MatrixMult3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMultTranspose3x3fNV(All matrixMode, float* m) => GLPointers._MatrixMultTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilThenCoverFillPathNV(uint path, All fillMode, uint mask, All coverMode) => GLPointers._StencilThenCoverFillPathNV_fnptr(path, (uint)fillMode, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilThenCoverStrokePathNV(uint path, int reference, uint mask, All coverMode) => GLPointers._StencilThenCoverStrokePathNV_fnptr(path, reference, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilThenCoverFillPathInstancedNV(int numPaths, All pathNameType, void* paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, float* transformValues) => GLPointers._StencilThenCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StencilThenCoverStrokePathInstancedNV(int numPaths, All pathNameType, void* paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, float* transformValues) => GLPointers._StencilThenCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static All PathGlyphIndexRangeNV(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => (All) GLPointers._PathGlyphIndexRangeNV_fnptr((uint)fontTarget, fontName, (uint)fontStyle, pathParameterTemplate, emScale, baseAndCount);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._PathGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._PathMemoryGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramPathFragmentInputGenNV(ProgramHandle program, int location, All genMode, int components, float* coeffs) => GLPointers._ProgramPathFragmentInputGenNV_fnptr((int)program, location, (uint)genMode, components, coeffs);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => GLPointers._GetProgramResourcefvNV_fnptr((int)program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._MatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._MatrixLoadIdentityEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._MatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._MatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._MatrixLoadfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._MatrixLoaddEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._MatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._MatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._MatrixMultfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._MatrixMultdEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._MatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._MatrixPopEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._MatrixPushEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._MatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._MatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._MatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._MatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._MatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._MatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_polygon_mode]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PolygonModeNV(MaterialFace face, PolygonMode mode) => GLPointers._PolygonModeNV_fnptr((uint)face, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_read_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadBufferNV(All mode) => GLPointers._ReadBufferNV_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, float* v) => GLPointers._FramebufferSampleLocationsfvNV_fnptr((uint)target, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void NamedFramebufferSampleLocationsfvNV(FramebufferHandle framebuffer, uint start, int count, float* v) => GLPointers._NamedFramebufferSampleLocationsfvNV_fnptr((int)framebuffer, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ResolveDepthValuesNV() => GLPointers._ResolveDepthValuesNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorExclusiveNV(int x, int y, int width, int height) => GLPointers._ScissorExclusiveNV_fnptr(x, y, width, height);
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorExclusiveArrayvNV(uint first, int count, int* v) => GLPointers._ScissorExclusiveArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindShadingRateImageNV(TextureHandle texture) => GLPointers._BindShadingRateImageNV_fnptr((int)texture);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetShadingRateImagePaletteNV(uint viewport, uint entry, All* rate) => GLPointers._GetShadingRateImagePaletteNV_fnptr(viewport, entry, (uint*)rate);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int* location) => GLPointers._GetShadingRateSampleLocationivNV_fnptr((uint)rate, samples, index, location);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ShadingRateImageBarrierNV(byte synchronize) => GLPointers._ShadingRateImageBarrierNV_fnptr(synchronize);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ShadingRateImagePaletteNV(uint viewport, uint first, int count, All* rates) => GLPointers._ShadingRateImagePaletteNV_fnptr(viewport, first, count, (uint*)rates);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ShadingRateSampleOrderNV(All order) => GLPointers._ShadingRateSampleOrderNV_fnptr((uint)order);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ShadingRateSampleOrderCustomNV(All rate, uint samples, int* locations) => GLPointers._ShadingRateSampleOrderCustomNV_fnptr((uint)rate, samples, locations);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportArrayvNV(uint first, int count, float* v) => GLPointers._ViewportArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportIndexedfNV(uint index, float x, float y, float w, float h) => GLPointers._ViewportIndexedfNV_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportIndexedfvNV(uint index, float* v) => GLPointers._ViewportIndexedfvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorArrayvNV(uint first, int count, int* v) => GLPointers._ScissorArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorIndexedNV(uint index, int left, int bottom, int width, int height) => GLPointers._ScissorIndexedNV_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorIndexedvNV(uint index, int* v) => GLPointers._ScissorIndexedvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangeArrayfvNV(uint first, int count, float* v) => GLPointers._DepthRangeArrayfvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangeIndexedfNV(uint index, float n, float f) => GLPointers._DepthRangeIndexedfNV_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFloati_vNV(GetPName target, uint index, float* data) => GLPointers._GetFloati_vNV_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EnableiNV(EnableCap target, uint index) => GLPointers._EnableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DisableiNV(EnableCap target, uint index) => GLPointers._DisableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsEnablediNV(EnableCap target, uint index) => GLPointers._IsEnablediNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_viewport_swizzle]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportSwizzleNV(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => GLPointers._ViewportSwizzleNV_fnptr(index, (uint)swizzlex, (uint)swizzley, (uint)swizzlez, (uint)swizzlew);
            
        }
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ulong GetTextureHandleIMG(TextureHandle texture) => GLPointers._GetTextureHandleIMG_fnptr((int)texture);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static ulong GetTextureSamplerHandleIMG(TextureHandle texture, SamplerHandle sampler) => GLPointers._GetTextureSamplerHandleIMG_fnptr((int)texture, (int)sampler);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformHandleui64IMG(int location, ulong value) => GLPointers._UniformHandleui64IMG_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void UniformHandleui64vIMG(int location, int count, ulong* value) => GLPointers._UniformHandleui64vIMG_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformHandleui64IMG(ProgramHandle program, int location, ulong value) => GLPointers._ProgramUniformHandleui64IMG_fnptr((int)program, location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, int count, ulong* values) => GLPointers._ProgramUniformHandleui64vIMG_fnptr((int)program, location, count, values);
            
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int xscale, int yscale) => GLPointers._FramebufferTexture2DDownsampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, (int)texture, level, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer, int xscale, int yscale) => GLPointers._FramebufferTextureLayerDownsampleIMG_fnptr((uint)target, (uint)attachment, (int)texture, level, layer, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._RenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => GLPointers._FramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, (int)texture, level, samples);
            
        }
        public static unsafe partial class INTEL
        {
            /// <summary> <b>[requires: GL_INTEL_framebuffer_CMAA]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ApplyFramebufferAttachmentCMAAINTEL() => GLPointers._ApplyFramebufferAttachmentCMAAINTEL_fnptr();
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BeginPerfQueryINTEL(uint queryHandle) => GLPointers._BeginPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CreatePerfQueryINTEL(uint queryId, uint* queryHandle) => GLPointers._CreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeletePerfQueryINTEL(uint queryHandle) => GLPointers._DeletePerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndPerfQueryINTEL(uint queryHandle) => GLPointers._EndPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFirstPerfQueryIdINTEL(uint* queryId) => GLPointers._GetFirstPerfQueryIdINTEL_fnptr(queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => GLPointers._GetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => GLPointers._GetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => GLPointers._GetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => GLPointers._GetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask) => GLPointers._GetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
            
        }
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: GL_KHR_blend_equation_advanced]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendBarrierKHR() => GLPointers._BlendBarrierKHR_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="count"> The length of the array ids. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => GLPointers._DebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, enabled);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Inject an application-supplied message into the debug message queue. </summary>
            /// <param name="source"> The source of the debug message to insert. </param>
            /// <param name="type"> The type of the debug message insert. </param>
            /// <param name="id"> The user-supplied identifier of the message to insert. </param>
            /// <param name="severity"> The severity of the debug messages to insert. </param>
            /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
            /// <param name="message"> The address of a character array containing the message to insert. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._DebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._DebugMessageCallback_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetDebugMessageLog.xhtml" /></remarks>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._GetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Push a named debug group into the command stream. </summary>
            /// <param name="source"> The source of the debug message. </param>
            /// <param name="id"> The identifier of the message. </param>
            /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
            /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._PushDebugGroup_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Pop the active debug group. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
            public static void PopDebugGroup() => GLPointers._PopDebugGroup_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Label a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object to label. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._ObjectLabel_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._GetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._ObjectPtrLabel_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._GetPointerv_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => GLPointers._DebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, enabled);
            
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
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Check if the rendering context has not been lost due to software or hardware issues. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._GetGraphicsResetStatus_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
            /// <param name="data"> Returns the pixel data. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._ReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformfv(ProgramHandle program, int location, int bufSize, float* parameters) => GLPointers._GetnUniformfv_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformiv(ProgramHandle program, int location, int bufSize, int* parameters) => GLPointers._GetnUniformiv_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformuiv(ProgramHandle program, int location, int bufSize, uint* parameters) => GLPointers._GetnUniformuiv_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => (GraphicsResetStatus) GLPointers._GetGraphicsResetStatusKHR_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._ReadnPixelsKHR_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformfvKHR(ProgramHandle program, int location, int bufSize, float* parameters) => GLPointers._GetnUniformfvKHR_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformivKHR(ProgramHandle program, int location, int bufSize, int* parameters) => GLPointers._GetnUniformivKHR_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetnUniformuivKHR(ProgramHandle program, int location, int bufSize, uint* parameters) => GLPointers._GetnUniformuivKHR_fnptr((int)program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_parallel_shader_compile]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MaxShaderCompilerThreadsKHR(uint count) => GLPointers._MaxShaderCompilerThreadsKHR_fnptr(count);
            
        }
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._FramebufferParameteriMESA_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._GetFramebufferParameterivMESA_fnptr((uint)target, (uint)pname, parameters);
            
        }
        public static unsafe partial class OES
        {
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetTexture2DOES(All target, void* image) => GLPointers._EGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => GLPointers._EGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_copy_image]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._CopyImageSubDataOES_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EnableiOES(EnableCap target, uint index) => GLPointers._EnableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DisableiOES(EnableCap target, uint index) => GLPointers._DisableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationiOES(uint buf, BlendEquationModeEXT mode) => GLPointers._BlendEquationiOES_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._BlendEquationSeparateiOES_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._BlendFunciOES_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._BlendFuncSeparateiOES_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ColorMaskiOES(uint index, byte r, byte g, byte b, byte a) => GLPointers._ColorMaskiOES_fnptr(index, r, g, b, a);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsEnablediOES(EnableCap target, uint index) => GLPointers._IsEnablediOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawElementsBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._DrawRangeElementsBaseVertexOES_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._DrawElementsInstancedBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._MultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_OES_geometry_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => GLPointers._FramebufferTextureOES_fnptr((uint)target, (uint)attachment, (int)texture, level);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetProgramBinaryOES(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._GetProgramBinaryOES_fnptr((int)program, bufSize, length, (uint*)binaryFormat, binary);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ProgramBinaryOES(ProgramHandle program, All binaryFormat, void* binary, int length) => GLPointers._ProgramBinaryOES_fnptr((int)program, (uint)binaryFormat, binary, length);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => GLPointers._MapBufferOES_fnptr((uint)target, (uint)access);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte UnmapBufferOES(All target) => GLPointers._UnmapBufferOES_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._GetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_primitive_bounding_box]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._PrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_OES_sample_shading]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void MinSampleShadingOES(float value) => GLPointers._MinSampleShadingOES_fnptr(value);
            
            /// <summary> <b>[requires: GL_OES_tessellation_shader]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void PatchParameteriOES(PatchParameterName pname, int value) => GLPointers._PatchParameteriOES_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._TexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CopyTexSubImage3DOES(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._CopyTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._CompressedTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._CompressedTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int zoffset) => GLPointers._FramebufferTexture3DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, (int)texture, level, zoffset);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._TexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._TexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._GetTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._GetTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* param) => GLPointers._SamplerParameterIivOES_fnptr((int)sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* param) => GLPointers._SamplerParameterIuivOES_fnptr((int)sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => GLPointers._GetSamplerParameterIivOES_fnptr((int)sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => GLPointers._GetSamplerParameterIuivOES_fnptr((int)sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexBufferOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => GLPointers._TexBufferOES_fnptr((uint)target, (uint)internalformat, (int)buffer);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexBufferRangeOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => GLPointers._TexBufferRangeOES_fnptr((uint)target, (uint)internalformat, (int)buffer, offset, size);
            
            /// <summary> <b>[requires: GL_OES_texture_storage_multisample_2d_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations) => GLPointers._TexStorage3DMultisampleOES_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, fixedsamplelocations);
            
            /// <summary> <b>[requires: GL_OES_texture_view]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureViewOES(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._TextureViewOES_fnptr((int)texture, (uint)target, (int)origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void BindVertexArrayOES(VertexArrayHandle array) => GLPointers._BindVertexArrayOES_fnptr((int)array);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DeleteVertexArraysOES(int n, VertexArrayHandle* arrays) => GLPointers._DeleteVertexArraysOES_fnptr(n, (int*)arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GenVertexArraysOES(int n, VertexArrayHandle* arrays) => GLPointers._GenVertexArraysOES_fnptr(n, (int*)arrays);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte IsVertexArrayOES(VertexArrayHandle array) => GLPointers._IsVertexArrayOES_fnptr((int)array);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportArrayvOES(uint first, int count, float* v) => GLPointers._ViewportArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportIndexedfOES(uint index, float x, float y, float w, float h) => GLPointers._ViewportIndexedfOES_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ViewportIndexedfvOES(uint index, float* v) => GLPointers._ViewportIndexedfvOES_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorArrayvOES(uint first, int count, int* v) => GLPointers._ScissorArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorIndexedOES(uint index, int left, int bottom, int width, int height) => GLPointers._ScissorIndexedOES_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ScissorIndexedvOES(uint index, int* v) => GLPointers._ScissorIndexedvOES_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangeArrayfvOES(uint first, int count, float* v) => GLPointers._DepthRangeArrayfvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void DepthRangeIndexedfOES(uint index, float n, float f) => GLPointers._DepthRangeIndexedfOES_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void GetFloati_vOES(GetPName target, uint index, float* data) => GLPointers._GetFloati_vOES_fnptr((uint)target, index, data);
            
        }
        public static unsafe partial class OVR
        {
            /// <summary> <b>[requires: GL_OVR_multiview]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int baseViewIndex, int numViews) => GLPointers._FramebufferTextureMultiviewOVR_fnptr((uint)target, (uint)attachment, (int)texture, level, baseViewIndex, numViews);
            
            /// <summary> <b>[requires: GL_OVR_multiview_multisampled_render_to_texture]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int samples, int baseViewIndex, int numViews) => GLPointers._FramebufferTextureMultisampleMultiviewOVR_fnptr((uint)target, (uint)attachment, (int)texture, level, samples, baseViewIndex, numViews);
            
        }
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: GL_QCOM_alpha_test]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void AlphaFuncQCOM(All func, float reference) => GLPointers._AlphaFuncQCOM_fnptr((uint)func, reference);
            
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
            public static void ExtGetTexturesQCOM(TextureHandle* textures, int maxTextures, int* numTextures) => GLPointers._ExtGetTexturesQCOM_fnptr((int*)textures, maxTextures, numTextures);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetBuffersQCOM(BufferHandle* buffers, int maxBuffers, int* numBuffers) => GLPointers._ExtGetBuffersQCOM_fnptr((int*)buffers, maxBuffers, numBuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetRenderbuffersQCOM(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => GLPointers._ExtGetRenderbuffersQCOM_fnptr((int*)renderbuffers, maxRenderbuffers, numRenderbuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetFramebuffersQCOM(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers) => GLPointers._ExtGetFramebuffersQCOM_fnptr((int*)framebuffers, maxFramebuffers, numFramebuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, int* parameters) => GLPointers._ExtGetTexLevelParameterivQCOM_fnptr((int)texture, (uint)face, level, (uint)pname, parameters);
            
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
            public static void ExtGetShadersQCOM(ShaderHandle* shaders, int maxShaders, int* numShaders) => GLPointers._ExtGetShadersQCOM_fnptr((int*)shaders, maxShaders, numShaders);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramsQCOM(ProgramHandle* programs, int maxPrograms, int* numPrograms) => GLPointers._ExtGetProgramsQCOM_fnptr((int*)programs, maxPrograms, numPrograms);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static byte ExtIsProgramBinaryQCOM(ProgramHandle program) => GLPointers._ExtIsProgramBinaryQCOM_fnptr((int)program);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, int* length) => GLPointers._ExtGetProgramBinarySourceQCOM_fnptr((int)program, (uint)shadertype, source, length);
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures) => GLPointers._FramebufferFoveationConfigQCOM_fnptr((int)framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferFoveationParametersQCOM(FramebufferHandle framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._FramebufferFoveationParametersQCOM_fnptr((int)framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEstimateMotionQCOM(TextureHandle reference, TextureHandle target, TextureHandle output) => GLPointers._TexEstimateMotionQCOM_fnptr((int)reference, (int)target, (int)output);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TexEstimateMotionRegionsQCOM(TextureHandle reference, TextureHandle target, TextureHandle output, TextureHandle mask) => GLPointers._TexEstimateMotionRegionsQCOM_fnptr((int)reference, (int)target, (int)output, (int)mask);
            
            /// <summary> <b>[requires: GL_QCOM_frame_extrapolation]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ExtrapolateTex2DQCOM(TextureHandle src1, TextureHandle src2, TextureHandle output, float scaleFactor) => GLPointers._ExtrapolateTex2DQCOM_fnptr((int)src1, (int)src2, (int)output, scaleFactor);
            
            /// <summary> <b>[requires: GL_QCOM_texture_foveated]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void TextureFoveationParametersQCOM(TextureHandle texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._TextureFoveationParametersQCOM_fnptr((int)texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            /// <summary> <b>[requires: GL_QCOM_shader_framebuffer_fetch_noncoherent]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void FramebufferFetchBarrierQCOM() => GLPointers._FramebufferFetchBarrierQCOM_fnptr();
            
            /// <summary> <b>[requires: GL_QCOM_shading_rate]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void ShadingRateQCOM(ShadingRateQCOM rate) => GLPointers._ShadingRateQCOM_fnptr((uint)rate);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._StartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b>  </summary>
            /// <remarks><see href="" /></remarks>
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => GLPointers._EndTilingQCOM_fnptr((uint)preserveMask);
            
        }
    }
}
