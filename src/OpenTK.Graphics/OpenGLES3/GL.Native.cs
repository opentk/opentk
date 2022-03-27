// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES3
{
    public static unsafe partial class GL
    {
        private static delegate* unmanaged<TextureUnit, void> _ActiveTexture_fnptr = &ActiveTexture_Lazy;
        /// <summary> Select active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation-dependent, but must be at least 32. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0. </param>
        public static void ActiveTexture(TextureUnit texture) => _ActiveTexture_fnptr(texture);
        [UnmanagedCallersOnly]
        private static void ActiveTexture_Lazy(TextureUnit texture)
        {
            _ActiveTexture_fnptr = (delegate* unmanaged<TextureUnit, void>)GLLoader.BindingsContext.GetProcAddress("glActiveTexture");
            _ActiveTexture_fnptr(texture);
        }
        
        private static delegate* unmanaged<ProgramHandle, ShaderHandle, void> _AttachShader_fnptr = &AttachShader_Lazy;
        /// <summary> Attaches a shader object to a program object. </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        public static void AttachShader(ProgramHandle program, ShaderHandle shader) => _AttachShader_fnptr(program, shader);
        [UnmanagedCallersOnly]
        private static void AttachShader_Lazy(ProgramHandle program, ShaderHandle shader)
        {
            _AttachShader_fnptr = (delegate* unmanaged<ProgramHandle, ShaderHandle, void>)GLLoader.BindingsContext.GetProcAddress("glAttachShader");
            _AttachShader_fnptr(program, shader);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, byte*, void> _BindAttribLocation_fnptr = &BindAttribLocation_Lazy;
        /// <summary> Associates a generic vertex attribute index with a named attribute variable. </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        public static void BindAttribLocation(ProgramHandle program, uint index, byte* name) => _BindAttribLocation_fnptr(program, index, name);
        [UnmanagedCallersOnly]
        private static void BindAttribLocation_Lazy(ProgramHandle program, uint index, byte* name)
        {
            _BindAttribLocation_fnptr = (delegate* unmanaged<ProgramHandle, uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glBindAttribLocation");
            _BindAttribLocation_fnptr(program, index, name);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferHandle, void> _BindBuffer_fnptr = &BindBuffer_Lazy;
        /// <summary> Bind a named buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="buffer"> Specifies the name of a buffer object. </param>
        public static void BindBuffer(BufferTargetARB target, BufferHandle buffer) => _BindBuffer_fnptr(target, buffer);
        [UnmanagedCallersOnly]
        private static void BindBuffer_Lazy(BufferTargetARB target, BufferHandle buffer)
        {
            _BindBuffer_fnptr = (delegate* unmanaged<BufferTargetARB, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindBuffer");
            _BindBuffer_fnptr(target, buffer);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferHandle, void> _BindFramebuffer_fnptr = &BindFramebuffer_Lazy;
        /// <summary> Bind a framebuffer to a framebuffer target. </summary>
        /// <param name="target"> Specifies the framebuffer target of the binding operation. </param>
        /// <param name="framebuffer"> Specifies the name of the framebuffer object to bind. </param>
        public static void BindFramebuffer(FramebufferTarget target, FramebufferHandle framebuffer) => _BindFramebuffer_fnptr(target, framebuffer);
        [UnmanagedCallersOnly]
        private static void BindFramebuffer_Lazy(FramebufferTarget target, FramebufferHandle framebuffer)
        {
            _BindFramebuffer_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindFramebuffer");
            _BindFramebuffer_fnptr(target, framebuffer);
        }
        
        private static delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void> _BindRenderbuffer_fnptr = &BindRenderbuffer_Lazy;
        /// <summary> Bind a renderbuffer to a renderbuffer target. </summary>
        /// <param name="target"> Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of the renderbuffer object to bind. </param>
        public static void BindRenderbuffer(RenderbufferTarget target, RenderbufferHandle renderbuffer) => _BindRenderbuffer_fnptr(target, renderbuffer);
        [UnmanagedCallersOnly]
        private static void BindRenderbuffer_Lazy(RenderbufferTarget target, RenderbufferHandle renderbuffer)
        {
            _BindRenderbuffer_fnptr = (delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindRenderbuffer");
            _BindRenderbuffer_fnptr(target, renderbuffer);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureHandle, void> _BindTexture_fnptr = &BindTexture_Lazy;
        /// <summary> Bind a named texture to a texturing target. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound. Must be either GL_TEXTURE_2D, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="texture"> Specifies the name of a texture. </param>
        public static void BindTexture(TextureTarget target, TextureHandle texture) => _BindTexture_fnptr(target, texture);
        [UnmanagedCallersOnly]
        private static void BindTexture_Lazy(TextureTarget target, TextureHandle texture)
        {
            _BindTexture_fnptr = (delegate* unmanaged<TextureTarget, TextureHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindTexture");
            _BindTexture_fnptr(target, texture);
        }
        
        private static delegate* unmanaged<float, float, float, float, void> _BlendColor_fnptr = &BlendColor_Lazy;
        /// <summary> Set the blend color. </summary>
        /// <param name="red"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="green"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="blue"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="alpha"> specify the components of GL_BLEND_COLOR </param>
        public static void BlendColor(float red, float green, float blue, float alpha) => _BlendColor_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void BlendColor_Lazy(float red, float green, float blue, float alpha)
        {
            _BlendColor_fnptr = (delegate* unmanaged<float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glBlendColor");
            _BlendColor_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<BlendEquationModeEXT, void> _BlendEquation_fnptr = &BlendEquation_Lazy;
        /// <summary> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        public static void BlendEquation(BlendEquationModeEXT mode) => _BlendEquation_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void BlendEquation_Lazy(BlendEquationModeEXT mode)
        {
            _BlendEquation_fnptr = (delegate* unmanaged<BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquation");
            _BlendEquation_fnptr(mode);
        }
        
        private static delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void> _BlendEquationSeparate_fnptr = &BlendEquationSeparate_Lazy;
        /// <summary> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => _BlendEquationSeparate_fnptr(modeRGB, modeAlpha);
        [UnmanagedCallersOnly]
        private static void BlendEquationSeparate_Lazy(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
        {
            _BlendEquationSeparate_fnptr = (delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparate");
            _BlendEquationSeparate_fnptr(modeRGB, modeAlpha);
        }
        
        private static delegate* unmanaged<BlendingFactor, BlendingFactor, void> _BlendFunc_fnptr = &BlendFunc_Lazy;
        /// <summary> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => _BlendFunc_fnptr(sfactor, dfactor);
        [UnmanagedCallersOnly]
        private static void BlendFunc_Lazy(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            _BlendFunc_fnptr = (delegate* unmanaged<BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFunc");
            _BlendFunc_fnptr(sfactor, dfactor);
        }
        
        private static delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> _BlendFuncSeparate_fnptr = &BlendFuncSeparate_Lazy;
        /// <summary> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => _BlendFuncSeparate_fnptr(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        [UnmanagedCallersOnly]
        private static void BlendFuncSeparate_Lazy(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
        {
            _BlendFuncSeparate_fnptr = (delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparate");
            _BlendFuncSeparate_fnptr(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        private static delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void> _BufferData_fnptr = &BufferData_Lazy;
        /// <summary> Creates and initializes a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object's new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => _BufferData_fnptr(target, size, data, usage);
        [UnmanagedCallersOnly]
        private static void BufferData_Lazy(BufferTargetARB target, nint size, void* data, BufferUsageARB usage)
        {
            _BufferData_fnptr = (delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void>)GLLoader.BindingsContext.GetProcAddress("glBufferData");
            _BufferData_fnptr(target, size, data, usage);
        }
        
        private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void> _BufferSubData_fnptr = &BufferSubData_Lazy;
        /// <summary> Updates a subset of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => _BufferSubData_fnptr(target, offset, size, data);
        [UnmanagedCallersOnly]
        private static void BufferSubData_Lazy(BufferTargetARB target, IntPtr offset, nint size, void* data)
        {
            _BufferSubData_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void>)GLLoader.BindingsContext.GetProcAddress("glBufferSubData");
            _BufferSubData_fnptr(target, offset, size, data);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferStatus> _CheckFramebufferStatus_fnptr = &CheckFramebufferStatus_Lazy;
        /// <summary> Check the completeness status of a framebuffer. </summary>
        /// <param name="target"> Specify the target of the framebuffer completeness check. </param>
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => _CheckFramebufferStatus_fnptr(target);
        [UnmanagedCallersOnly]
        private static FramebufferStatus CheckFramebufferStatus_Lazy(FramebufferTarget target)
        {
            _CheckFramebufferStatus_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferStatus>)GLLoader.BindingsContext.GetProcAddress("glCheckFramebufferStatus");
            return _CheckFramebufferStatus_fnptr(target);
        }
        
        private static delegate* unmanaged<ClearBufferMask, void> _Clear_fnptr = &Clear_Lazy;
        /// <summary> Clear buffers to preset values. </summary>
        /// <param name="mask"> Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. </param>
        public static void Clear(ClearBufferMask mask) => _Clear_fnptr(mask);
        [UnmanagedCallersOnly]
        private static void Clear_Lazy(ClearBufferMask mask)
        {
            _Clear_fnptr = (delegate* unmanaged<ClearBufferMask, void>)GLLoader.BindingsContext.GetProcAddress("glClear");
            _Clear_fnptr(mask);
        }
        
        private static delegate* unmanaged<float, float, float, float, void> _ClearColor_fnptr = &ClearColor_Lazy;
        /// <summary> Specify clear values for the color buffers. </summary>
        /// <param name="red"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="green"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="blue"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="alpha"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        public static void ClearColor(float red, float green, float blue, float alpha) => _ClearColor_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ClearColor_Lazy(float red, float green, float blue, float alpha)
        {
            _ClearColor_fnptr = (delegate* unmanaged<float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glClearColor");
            _ClearColor_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<float, void> _ClearDepthf_fnptr = &ClearDepthf_Lazy;
        /// <summary> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth"> Specifies the depth value used when the depth buffer is cleared. The initial value is 1. </param>
        public static void ClearDepthf(float d) => _ClearDepthf_fnptr(d);
        [UnmanagedCallersOnly]
        private static void ClearDepthf_Lazy(float d)
        {
            _ClearDepthf_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glClearDepthf");
            _ClearDepthf_fnptr(d);
        }
        
        private static delegate* unmanaged<int, void> _ClearStencil_fnptr = &ClearStencil_Lazy;
        /// <summary> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s"> Specifies the index used when the stencil buffer is cleared. The initial value is 0. </param>
        public static void ClearStencil(int s) => _ClearStencil_fnptr(s);
        [UnmanagedCallersOnly]
        private static void ClearStencil_Lazy(int s)
        {
            _ClearStencil_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glClearStencil");
            _ClearStencil_fnptr(s);
        }
        
        private static delegate* unmanaged<byte, byte, byte, byte, void> _ColorMask_fnptr = &ColorMask_Lazy;
        /// <summary> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        public static void ColorMask(byte red, byte green, byte blue, byte alpha) => _ColorMask_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ColorMask_Lazy(byte red, byte green, byte blue, byte alpha)
        {
            _ColorMask_fnptr = (delegate* unmanaged<byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColorMask");
            _ColorMask_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<ShaderHandle, void> _CompileShader_fnptr = &CompileShader_Lazy;
        /// <summary> Compiles a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        public static void CompileShader(ShaderHandle shader) => _CompileShader_fnptr(shader);
        [UnmanagedCallersOnly]
        private static void CompileShader_Lazy(ShaderHandle shader)
        {
            _CompileShader_fnptr = (delegate* unmanaged<ShaderHandle, void>)GLLoader.BindingsContext.GetProcAddress("glCompileShader");
            _CompileShader_fnptr(shader);
        }
        
        private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void> _CompressedTexImage2D_fnptr = &CompressedTexImage2D_Lazy;
        /// <summary> Specify a two-dimensional texture image in a compressed format. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the format of the compressed image data stored at address data. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support 2D and cube-mapped texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="imageSize"> Specifies the number of unsigned bytes of image data starting at the address specified by data. </param>
        /// <param name="data"> Specifies a pointer to the compressed image data in memory. </param>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => _CompressedTexImage2D_fnptr(target, level, internalformat, width, height, border, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data)
        {
            _CompressedTexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexImage2D");
            _CompressedTexImage2D_fnptr(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, int, void*, void> _CompressedTexSubImage2D_fnptr = &CompressedTexSubImage2D_Lazy;
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
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data) => _CompressedTexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data)
        {
            _CompressedTexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexSubImage2D");
            _CompressedTexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void> _CopyTexImage2D_fnptr = &CopyTexImage2D_Lazy;
        /// <summary> Copy pixels into a 2D texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalformat"> Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_ALPHA, GL_LUMINANCE, GL_LUMINANCE_ALPHA, GL_RGB, GL_RGBA, GL_R8, GL_RG8, GL_RGB565, GL_RGB8, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_SRGB8, GL_SRGB8_ALPHA8, GL_R8I, GL_R8UI, GL_R16I, GL_R16UI, GL_R32I, GL_R32UI, GL_RG8I, GL_RG8UI, GL_RG16I, GL_RG16UI, GL_RG32I, GL_RG32UI, GL_RGBA8I, GL_RGBA8UI, GL_RGB10_A2UI, GL_RGBA16I, GL_RGBA16UI, GL_RGBA32I, GL_RGBA32UI. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture image. </param>
        /// <param name="height"> Specifies the height of the texture image. </param>
        /// <param name="border"> Specifies the width of the border. Must be 0. </param>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => _CopyTexImage2D_fnptr(target, level, internalformat, x, y, width, height, border);
        [UnmanagedCallersOnly]
        private static void CopyTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
        {
            _CopyTexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexImage2D");
            _CopyTexImage2D_fnptr(target, level, internalformat, x, y, width, height, border);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void> _CopyTexSubImage2D_fnptr = &CopyTexSubImage2D_Lazy;
        /// <summary> Copy a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => _CopyTexSubImage2D_fnptr(target, level, xoffset, yoffset, x, y, width, height);
        [UnmanagedCallersOnly]
        private static void CopyTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            _CopyTexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexSubImage2D");
            _CopyTexSubImage2D_fnptr(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        private static delegate* unmanaged<int> _CreateProgram_fnptr = &CreateProgram_Lazy;
        /// <summary> Creates a program object. </summary>
        public static ProgramHandle CreateProgram() => (ProgramHandle) _CreateProgram_fnptr();
        [UnmanagedCallersOnly]
        private static int CreateProgram_Lazy()
        {
            _CreateProgram_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("glCreateProgram");
            return _CreateProgram_fnptr();
        }
        
        private static delegate* unmanaged<ShaderType, int> _CreateShader_fnptr = &CreateShader_Lazy;
        /// <summary> Creates a shader object. </summary>
        /// <param name="shaderType"> Specifies the type of shader to be created. Must be one of GL_COMPUTE_SHADER, GL_VERTEX_SHADER, GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER, or GL_FRAGMENT_SHADER. </param>
        public static ShaderHandle CreateShader(ShaderType type) => (ShaderHandle) _CreateShader_fnptr(type);
        [UnmanagedCallersOnly]
        private static int CreateShader_Lazy(ShaderType type)
        {
            _CreateShader_fnptr = (delegate* unmanaged<ShaderType, int>)GLLoader.BindingsContext.GetProcAddress("glCreateShader");
            return _CreateShader_fnptr(type);
        }
        
        private static delegate* unmanaged<CullFaceMode, void> _CullFace_fnptr = &CullFace_Lazy;
        /// <summary> Specify whether front- or back-facing polygons can be culled. </summary>
        /// <param name="mode"> Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK. </param>
        public static void CullFace(CullFaceMode mode) => _CullFace_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void CullFace_Lazy(CullFaceMode mode)
        {
            _CullFace_fnptr = (delegate* unmanaged<CullFaceMode, void>)GLLoader.BindingsContext.GetProcAddress("glCullFace");
            _CullFace_fnptr(mode);
        }
        
        private static delegate* unmanaged<int, BufferHandle*, void> _DeleteBuffers_fnptr = &DeleteBuffers_Lazy;
        /// <summary> Delete named buffer objects. </summary>
        /// <param name="n"> Specifies the number of buffer objects to be deleted. </param>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        public static void DeleteBuffers(int n, BufferHandle* buffers) => _DeleteBuffers_fnptr(n, buffers);
        [UnmanagedCallersOnly]
        private static void DeleteBuffers_Lazy(int n, BufferHandle* buffers)
        {
            _DeleteBuffers_fnptr = (delegate* unmanaged<int, BufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteBuffers");
            _DeleteBuffers_fnptr(n, buffers);
        }
        
        private static delegate* unmanaged<int, FramebufferHandle*, void> _DeleteFramebuffers_fnptr = &DeleteFramebuffers_Lazy;
        /// <summary> Delete framebuffer objects. </summary>
        /// <param name="n"> Specifies the number of framebuffer objects to be deleted. </param>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        public static void DeleteFramebuffers(int n, FramebufferHandle* framebuffers) => _DeleteFramebuffers_fnptr(n, framebuffers);
        [UnmanagedCallersOnly]
        private static void DeleteFramebuffers_Lazy(int n, FramebufferHandle* framebuffers)
        {
            _DeleteFramebuffers_fnptr = (delegate* unmanaged<int, FramebufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteFramebuffers");
            _DeleteFramebuffers_fnptr(n, framebuffers);
        }
        
        private static delegate* unmanaged<ProgramHandle, void> _DeleteProgram_fnptr = &DeleteProgram_Lazy;
        /// <summary> Deletes a program object. </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        public static void DeleteProgram(ProgramHandle program) => _DeleteProgram_fnptr(program);
        [UnmanagedCallersOnly]
        private static void DeleteProgram_Lazy(ProgramHandle program)
        {
            _DeleteProgram_fnptr = (delegate* unmanaged<ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteProgram");
            _DeleteProgram_fnptr(program);
        }
        
        private static delegate* unmanaged<int, RenderbufferHandle*, void> _DeleteRenderbuffers_fnptr = &DeleteRenderbuffers_Lazy;
        /// <summary> Delete renderbuffer objects. </summary>
        /// <param name="n"> Specifies the number of renderbuffer objects to be deleted. </param>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        public static void DeleteRenderbuffers(int n, RenderbufferHandle* renderbuffers) => _DeleteRenderbuffers_fnptr(n, renderbuffers);
        [UnmanagedCallersOnly]
        private static void DeleteRenderbuffers_Lazy(int n, RenderbufferHandle* renderbuffers)
        {
            _DeleteRenderbuffers_fnptr = (delegate* unmanaged<int, RenderbufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteRenderbuffers");
            _DeleteRenderbuffers_fnptr(n, renderbuffers);
        }
        
        private static delegate* unmanaged<ShaderHandle, void> _DeleteShader_fnptr = &DeleteShader_Lazy;
        /// <summary> Deletes a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        public static void DeleteShader(ShaderHandle shader) => _DeleteShader_fnptr(shader);
        [UnmanagedCallersOnly]
        private static void DeleteShader_Lazy(ShaderHandle shader)
        {
            _DeleteShader_fnptr = (delegate* unmanaged<ShaderHandle, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteShader");
            _DeleteShader_fnptr(shader);
        }
        
        private static delegate* unmanaged<int, TextureHandle*, void> _DeleteTextures_fnptr = &DeleteTextures_Lazy;
        /// <summary> Delete named textures. </summary>
        /// <param name="n"> Specifies the number of textures to be deleted. </param>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        public static void DeleteTextures(int n, TextureHandle* textures) => _DeleteTextures_fnptr(n, textures);
        [UnmanagedCallersOnly]
        private static void DeleteTextures_Lazy(int n, TextureHandle* textures)
        {
            _DeleteTextures_fnptr = (delegate* unmanaged<int, TextureHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteTextures");
            _DeleteTextures_fnptr(n, textures);
        }
        
        private static delegate* unmanaged<DepthFunction, void> _DepthFunc_fnptr = &DepthFunc_Lazy;
        /// <summary> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func"> Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. </param>
        public static void DepthFunc(DepthFunction func) => _DepthFunc_fnptr(func);
        [UnmanagedCallersOnly]
        private static void DepthFunc_Lazy(DepthFunction func)
        {
            _DepthFunc_fnptr = (delegate* unmanaged<DepthFunction, void>)GLLoader.BindingsContext.GetProcAddress("glDepthFunc");
            _DepthFunc_fnptr(func);
        }
        
        private static delegate* unmanaged<byte, void> _DepthMask_fnptr = &DepthMask_Lazy;
        /// <summary> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag"> Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled. </param>
        public static void DepthMask(byte flag) => _DepthMask_fnptr(flag);
        [UnmanagedCallersOnly]
        private static void DepthMask_Lazy(byte flag)
        {
            _DepthMask_fnptr = (delegate* unmanaged<byte, void>)GLLoader.BindingsContext.GetProcAddress("glDepthMask");
            _DepthMask_fnptr(flag);
        }
        
        private static delegate* unmanaged<float, float, void> _DepthRangef_fnptr = &DepthRangef_Lazy;
        /// <summary> Specify mapping of depth values from normalized device coordinates to window coordinates. </summary>
        /// <param name="n"> Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0. </param>
        /// <param name="f"> Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1. </param>
        public static void DepthRangef(float n, float f) => _DepthRangef_fnptr(n, f);
        [UnmanagedCallersOnly]
        private static void DepthRangef_Lazy(float n, float f)
        {
            _DepthRangef_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangef");
            _DepthRangef_fnptr(n, f);
        }
        
        private static delegate* unmanaged<ProgramHandle, ShaderHandle, void> _DetachShader_fnptr = &DetachShader_Lazy;
        /// <summary> Detaches a shader object from a program object to which it is attached. </summary>
        /// <param name="program">Specifies the program object from which to detach the shader object.</param>
        /// <param name="shader">Specifies the shader object to be detached.</param>
        public static void DetachShader(ProgramHandle program, ShaderHandle shader) => _DetachShader_fnptr(program, shader);
        [UnmanagedCallersOnly]
        private static void DetachShader_Lazy(ProgramHandle program, ShaderHandle shader)
        {
            _DetachShader_fnptr = (delegate* unmanaged<ProgramHandle, ShaderHandle, void>)GLLoader.BindingsContext.GetProcAddress("glDetachShader");
            _DetachShader_fnptr(program, shader);
        }
        
        private static delegate* unmanaged<EnableCap, void> _Disable_fnptr = &Disable_Lazy;
        /// <summary> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        public static void Disable(EnableCap cap) => _Disable_fnptr(cap);
        [UnmanagedCallersOnly]
        private static void Disable_Lazy(EnableCap cap)
        {
            _Disable_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glDisable");
            _Disable_fnptr(cap);
        }
        
        private static delegate* unmanaged<uint, void> _DisableVertexAttribArray_fnptr = &DisableVertexAttribArray_Lazy;
        /// <summary> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        public static void DisableVertexAttribArray(uint index) => _DisableVertexAttribArray_fnptr(index);
        [UnmanagedCallersOnly]
        private static void DisableVertexAttribArray_Lazy(uint index)
        {
            _DisableVertexAttribArray_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableVertexAttribArray");
            _DisableVertexAttribArray_fnptr(index);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, int, void> _DrawArrays_fnptr = &DrawArrays_Lazy;
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => _DrawArrays_fnptr(mode, first, count);
        [UnmanagedCallersOnly]
        private static void DrawArrays_Lazy(PrimitiveType mode, int first, int count)
        {
            _DrawArrays_fnptr = (delegate* unmanaged<PrimitiveType, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArrays");
            _DrawArrays_fnptr(mode, first, count);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void> _DrawElements_fnptr = &DrawElements_Lazy;
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => _DrawElements_fnptr(mode, count, type, indices);
        [UnmanagedCallersOnly]
        private static void DrawElements_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices)
        {
            _DrawElements_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElements");
            _DrawElements_fnptr(mode, count, type, indices);
        }
        
        private static delegate* unmanaged<EnableCap, void> _Enable_fnptr = &Enable_Lazy;
        /// <summary> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        public static void Enable(EnableCap cap) => _Enable_fnptr(cap);
        [UnmanagedCallersOnly]
        private static void Enable_Lazy(EnableCap cap)
        {
            _Enable_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glEnable");
            _Enable_fnptr(cap);
        }
        
        private static delegate* unmanaged<uint, void> _EnableVertexAttribArray_fnptr = &EnableVertexAttribArray_Lazy;
        /// <summary> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        public static void EnableVertexAttribArray(uint index) => _EnableVertexAttribArray_fnptr(index);
        [UnmanagedCallersOnly]
        private static void EnableVertexAttribArray_Lazy(uint index)
        {
            _EnableVertexAttribArray_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableVertexAttribArray");
            _EnableVertexAttribArray_fnptr(index);
        }
        
        private static delegate* unmanaged<void> _Finish_fnptr = &Finish_Lazy;
        /// <summary> Block until all GL execution is complete. </summary>
        public static void Finish() => _Finish_fnptr();
        [UnmanagedCallersOnly]
        private static void Finish_Lazy()
        {
            _Finish_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFinish");
            _Finish_fnptr();
        }
        
        private static delegate* unmanaged<void> _Flush_fnptr = &Flush_Lazy;
        /// <summary> Force execution of GL commands in finite time. </summary>
        public static void Flush() => _Flush_fnptr();
        [UnmanagedCallersOnly]
        private static void Flush_Lazy()
        {
            _Flush_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFlush");
            _Flush_fnptr();
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void> _FramebufferRenderbuffer_fnptr = &FramebufferRenderbuffer_Lazy;
        /// <summary> Attach a renderbuffer as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="renderbuffertarget"> Specifies the renderbuffer target and must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. </param>
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer) => _FramebufferRenderbuffer_fnptr(target, attachment, renderbuffertarget, renderbuffer);
        [UnmanagedCallersOnly]
        private static void FramebufferRenderbuffer_Lazy(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer)
        {
            _FramebufferRenderbuffer_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferRenderbuffer");
            _FramebufferRenderbuffer_fnptr(target, attachment, renderbuffertarget, renderbuffer);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void> _FramebufferTexture2D_fnptr = &FramebufferTexture2D_Lazy;
        /// <summary> Attach a level of a texture object as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="textarget"> Specifies a 2D texture target, 2D multisample texture target, or for cube map textures, which face is to be attached. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level) => _FramebufferTexture2D_fnptr(target, attachment, textarget, texture, level);
        [UnmanagedCallersOnly]
        private static void FramebufferTexture2D_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level)
        {
            _FramebufferTexture2D_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2D");
            _FramebufferTexture2D_fnptr(target, attachment, textarget, texture, level);
        }
        
        private static delegate* unmanaged<FrontFaceDirection, void> _FrontFace_fnptr = &FrontFace_Lazy;
        /// <summary> Define front- and back-facing polygons. </summary>
        /// <param name="mode"> Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. </param>
        public static void FrontFace(FrontFaceDirection mode) => _FrontFace_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void FrontFace_Lazy(FrontFaceDirection mode)
        {
            _FrontFace_fnptr = (delegate* unmanaged<FrontFaceDirection, void>)GLLoader.BindingsContext.GetProcAddress("glFrontFace");
            _FrontFace_fnptr(mode);
        }
        
        private static delegate* unmanaged<int, BufferHandle*, void> _GenBuffers_fnptr = &GenBuffers_Lazy;
        /// <summary> Generate buffer object names. </summary>
        /// <param name="n"> Specifies the number of buffer object names to be generated. </param>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        public static void GenBuffers(int n, BufferHandle* buffers) => _GenBuffers_fnptr(n, buffers);
        [UnmanagedCallersOnly]
        private static void GenBuffers_Lazy(int n, BufferHandle* buffers)
        {
            _GenBuffers_fnptr = (delegate* unmanaged<int, BufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenBuffers");
            _GenBuffers_fnptr(n, buffers);
        }
        
        private static delegate* unmanaged<TextureTarget, void> _GenerateMipmap_fnptr = &GenerateMipmap_Lazy;
        /// <summary> Generate mipmaps for a specified texture target. </summary>
        /// <param name="target"> Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        public static void GenerateMipmap(TextureTarget target) => _GenerateMipmap_fnptr(target);
        [UnmanagedCallersOnly]
        private static void GenerateMipmap_Lazy(TextureTarget target)
        {
            _GenerateMipmap_fnptr = (delegate* unmanaged<TextureTarget, void>)GLLoader.BindingsContext.GetProcAddress("glGenerateMipmap");
            _GenerateMipmap_fnptr(target);
        }
        
        private static delegate* unmanaged<int, FramebufferHandle*, void> _GenFramebuffers_fnptr = &GenFramebuffers_Lazy;
        /// <summary> Generate framebuffer object names. </summary>
        /// <param name="n"> Specifies the number of framebuffer object names to generate. </param>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        public static void GenFramebuffers(int n, FramebufferHandle* framebuffers) => _GenFramebuffers_fnptr(n, framebuffers);
        [UnmanagedCallersOnly]
        private static void GenFramebuffers_Lazy(int n, FramebufferHandle* framebuffers)
        {
            _GenFramebuffers_fnptr = (delegate* unmanaged<int, FramebufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenFramebuffers");
            _GenFramebuffers_fnptr(n, framebuffers);
        }
        
        private static delegate* unmanaged<int, RenderbufferHandle*, void> _GenRenderbuffers_fnptr = &GenRenderbuffers_Lazy;
        /// <summary> Generate renderbuffer object names. </summary>
        /// <param name="n"> Specifies the number of renderbuffer object names to generate. </param>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        public static void GenRenderbuffers(int n, RenderbufferHandle* renderbuffers) => _GenRenderbuffers_fnptr(n, renderbuffers);
        [UnmanagedCallersOnly]
        private static void GenRenderbuffers_Lazy(int n, RenderbufferHandle* renderbuffers)
        {
            _GenRenderbuffers_fnptr = (delegate* unmanaged<int, RenderbufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenRenderbuffers");
            _GenRenderbuffers_fnptr(n, renderbuffers);
        }
        
        private static delegate* unmanaged<int, TextureHandle*, void> _GenTextures_fnptr = &GenTextures_Lazy;
        /// <summary> Generate texture names. </summary>
        /// <param name="n"> Specifies the number of texture names to be generated. </param>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        public static void GenTextures(int n, TextureHandle* textures) => _GenTextures_fnptr(n, textures);
        [UnmanagedCallersOnly]
        private static void GenTextures_Lazy(int n, TextureHandle* textures)
        {
            _GenTextures_fnptr = (delegate* unmanaged<int, TextureHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenTextures");
            _GenTextures_fnptr(n, textures);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, int, int*, int*, AttributeType*, byte*, void> _GetActiveAttrib_fnptr = &GetActiveAttrib_Lazy;
        /// <summary> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
        public static void GetActiveAttrib(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => _GetActiveAttrib_fnptr(program, index, bufSize, length, size, type, name);
        [UnmanagedCallersOnly]
        private static void GetActiveAttrib_Lazy(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name)
        {
            _GetActiveAttrib_fnptr = (delegate* unmanaged<ProgramHandle, uint, int, int*, int*, AttributeType*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetActiveAttrib");
            _GetActiveAttrib_fnptr(program, index, bufSize, length, size, type, name);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, int, int*, int*, UniformType*, byte*, void> _GetActiveUniform_fnptr = &GetActiveUniform_Lazy;
        /// <summary> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
        public static void GetActiveUniform(ProgramHandle program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => _GetActiveUniform_fnptr(program, index, bufSize, length, size, type, name);
        [UnmanagedCallersOnly]
        private static void GetActiveUniform_Lazy(ProgramHandle program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name)
        {
            _GetActiveUniform_fnptr = (delegate* unmanaged<ProgramHandle, uint, int, int*, int*, UniformType*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetActiveUniform");
            _GetActiveUniform_fnptr(program, index, bufSize, length, size, type, name);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int*, ShaderHandle*, void> _GetAttachedShaders_fnptr = &GetAttachedShaders_Lazy;
        /// <summary> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        public static void GetAttachedShaders(ProgramHandle program, int maxCount, int* count, ShaderHandle* shaders) => _GetAttachedShaders_fnptr(program, maxCount, count, shaders);
        [UnmanagedCallersOnly]
        private static void GetAttachedShaders_Lazy(ProgramHandle program, int maxCount, int* count, ShaderHandle* shaders)
        {
            _GetAttachedShaders_fnptr = (delegate* unmanaged<ProgramHandle, int, int*, ShaderHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGetAttachedShaders");
            _GetAttachedShaders_fnptr(program, maxCount, count, shaders);
        }
        
        private static delegate* unmanaged<ProgramHandle, byte*, int> _GetAttribLocation_fnptr = &GetAttribLocation_Lazy;
        /// <summary> Returns the location of an attribute variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        public static int GetAttribLocation(ProgramHandle program, byte* name) => _GetAttribLocation_fnptr(program, name);
        [UnmanagedCallersOnly]
        private static int GetAttribLocation_Lazy(ProgramHandle program, byte* name)
        {
            _GetAttribLocation_fnptr = (delegate* unmanaged<ProgramHandle, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetAttribLocation");
            return _GetAttribLocation_fnptr(program, name);
        }
        
        private static delegate* unmanaged<GetPName, byte*, void> _GetBooleanv_fnptr = &GetBooleanv_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetBooleanv(GetPName pname, byte* data) => _GetBooleanv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetBooleanv_Lazy(GetPName pname, byte* data)
        {
            _GetBooleanv_fnptr = (delegate* unmanaged<GetPName, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBooleanv");
            _GetBooleanv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void> _GetBufferParameteriv_fnptr = &GetBufferParameteriv_Lazy;
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => _GetBufferParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetBufferParameteriv_Lazy(BufferTargetARB target, BufferPNameARB pname, int* parameters)
        {
            _GetBufferParameteriv_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferParameteriv");
            _GetBufferParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<ErrorCode> _GetError_fnptr = &GetError_Lazy;
        /// <summary> Return error information. </summary>
        public static ErrorCode GetError() => _GetError_fnptr();
        [UnmanagedCallersOnly]
        private static ErrorCode GetError_Lazy()
        {
            _GetError_fnptr = (delegate* unmanaged<ErrorCode>)GLLoader.BindingsContext.GetProcAddress("glGetError");
            return _GetError_fnptr();
        }
        
        private static delegate* unmanaged<GetPName, float*, void> _GetFloatv_fnptr = &GetFloatv_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetFloatv(GetPName pname, float* data) => _GetFloatv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetFloatv_Lazy(GetPName pname, float* data)
        {
            _GetFloatv_fnptr = (delegate* unmanaged<GetPName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFloatv");
            _GetFloatv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void> _GetFramebufferAttachmentParameteriv_fnptr = &GetFramebufferAttachmentParameteriv_Lazy;
        /// <summary> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        /// <param name="parameters"> Specifies the address of a variable receive the value of pname for attachment. </param>
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => _GetFramebufferAttachmentParameteriv_fnptr(target, attachment, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetFramebufferAttachmentParameteriv_Lazy(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters)
        {
            _GetFramebufferAttachmentParameteriv_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFramebufferAttachmentParameteriv");
            _GetFramebufferAttachmentParameteriv_fnptr(target, attachment, pname, parameters);
        }
        
        private static delegate* unmanaged<GetPName, int*, void> _GetIntegerv_fnptr = &GetIntegerv_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetIntegerv(GetPName pname, int* data) => _GetIntegerv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetIntegerv_Lazy(GetPName pname, int* data)
        {
            _GetIntegerv_fnptr = (delegate* unmanaged<GetPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetIntegerv");
            _GetIntegerv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramPropertyARB, int*, void> _GetProgramiv_fnptr = &GetProgramiv_Lazy;
        /// <summary> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        public static void GetProgramiv(ProgramHandle program, ProgramPropertyARB pname, int* parameters) => _GetProgramiv_fnptr(program, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetProgramiv_Lazy(ProgramHandle program, ProgramPropertyARB pname, int* parameters)
        {
            _GetProgramiv_fnptr = (delegate* unmanaged<ProgramHandle, ProgramPropertyARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramiv");
            _GetProgramiv_fnptr(program, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int*, byte*, void> _GetProgramInfoLog_fnptr = &GetProgramInfoLog_Lazy;
        /// <summary> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        public static void GetProgramInfoLog(ProgramHandle program, int bufSize, int* length, byte* infoLog) => _GetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        [UnmanagedCallersOnly]
        private static void GetProgramInfoLog_Lazy(ProgramHandle program, int bufSize, int* length, byte* infoLog)
        {
            _GetProgramInfoLog_fnptr = (delegate* unmanaged<ProgramHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramInfoLog");
            _GetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        }
        
        private static delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void> _GetRenderbufferParameteriv_fnptr = &GetRenderbufferParameteriv_Lazy;
        /// <summary> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        /// <param name="parameters"> Specifies the address of an array to receive the value of the queried parameter. </param>
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => _GetRenderbufferParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetRenderbufferParameteriv_Lazy(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters)
        {
            _GetRenderbufferParameteriv_fnptr = (delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetRenderbufferParameteriv");
            _GetRenderbufferParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<ShaderHandle, ShaderParameterName, int*, void> _GetShaderiv_fnptr = &GetShaderiv_Lazy;
        /// <summary> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        public static void GetShaderiv(ShaderHandle shader, ShaderParameterName pname, int* parameters) => _GetShaderiv_fnptr(shader, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetShaderiv_Lazy(ShaderHandle shader, ShaderParameterName pname, int* parameters)
        {
            _GetShaderiv_fnptr = (delegate* unmanaged<ShaderHandle, ShaderParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShaderiv");
            _GetShaderiv_fnptr(shader, pname, parameters);
        }
        
        private static delegate* unmanaged<ShaderHandle, int, int*, byte*, void> _GetShaderInfoLog_fnptr = &GetShaderInfoLog_Lazy;
        /// <summary> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        public static void GetShaderInfoLog(ShaderHandle shader, int bufSize, int* length, byte* infoLog) => _GetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        [UnmanagedCallersOnly]
        private static void GetShaderInfoLog_Lazy(ShaderHandle shader, int bufSize, int* length, byte* infoLog)
        {
            _GetShaderInfoLog_fnptr = (delegate* unmanaged<ShaderHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShaderInfoLog");
            _GetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        }
        
        private static delegate* unmanaged<ShaderType, PrecisionType, int*, int*, void> _GetShaderPrecisionFormat_fnptr = &GetShaderPrecisionFormat_Lazy;
        /// <summary> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="shaderType"> Specifies the type of shader whose precision to query. shaderType must be GL_VERTEX_SHADER or GL_FRAGMENT_SHADER. </param>
        /// <param name="precisionType"> Specifies the numeric format whose precision and range to query. </param>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => _GetShaderPrecisionFormat_fnptr(shadertype, precisiontype, range, precision);
        [UnmanagedCallersOnly]
        private static void GetShaderPrecisionFormat_Lazy(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision)
        {
            _GetShaderPrecisionFormat_fnptr = (delegate* unmanaged<ShaderType, PrecisionType, int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShaderPrecisionFormat");
            _GetShaderPrecisionFormat_fnptr(shadertype, precisiontype, range, precision);
        }
        
        private static delegate* unmanaged<ShaderHandle, int, int*, byte*, void> _GetShaderSource_fnptr = &GetShaderSource_Lazy;
        /// <summary> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
        public static void GetShaderSource(ShaderHandle shader, int bufSize, int* length, byte* source) => _GetShaderSource_fnptr(shader, bufSize, length, source);
        [UnmanagedCallersOnly]
        private static void GetShaderSource_Lazy(ShaderHandle shader, int bufSize, int* length, byte* source)
        {
            _GetShaderSource_fnptr = (delegate* unmanaged<ShaderHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShaderSource");
            _GetShaderSource_fnptr(shader, bufSize, length, source);
        }
        
        private static delegate* unmanaged<StringName, byte*> _GetString__fnptr = &GetString__Lazy;
        /// <summary> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        public static byte* GetString_(StringName name) => _GetString__fnptr(name);
        [UnmanagedCallersOnly]
        private static byte* GetString__Lazy(StringName name)
        {
            _GetString__fnptr = (delegate* unmanaged<StringName, byte*>)GLLoader.BindingsContext.GetProcAddress("glGetString");
            return _GetString__fnptr(name);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void> _GetTexParameterfv_fnptr = &GetTexParameterfv_Lazy;
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => _GetTexParameterfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterfv_Lazy(TextureTarget target, GetTextureParameter pname, float* parameters)
        {
            _GetTexParameterfv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterfv");
            _GetTexParameterfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameteriv_fnptr = &GetTexParameteriv_Lazy;
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameteriv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            _GetTexParameteriv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameteriv");
            _GetTexParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, float*, void> _GetUniformfv_fnptr = &GetUniformfv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetUniformfv(ProgramHandle program, int location, float* parameters) => _GetUniformfv_fnptr(program, location, parameters);
        [UnmanagedCallersOnly]
        private static void GetUniformfv_Lazy(ProgramHandle program, int location, float* parameters)
        {
            _GetUniformfv_fnptr = (delegate* unmanaged<ProgramHandle, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUniformfv");
            _GetUniformfv_fnptr(program, location, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int*, void> _GetUniformiv_fnptr = &GetUniformiv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetUniformiv(ProgramHandle program, int location, int* parameters) => _GetUniformiv_fnptr(program, location, parameters);
        [UnmanagedCallersOnly]
        private static void GetUniformiv_Lazy(ProgramHandle program, int location, int* parameters)
        {
            _GetUniformiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUniformiv");
            _GetUniformiv_fnptr(program, location, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, byte*, int> _GetUniformLocation_fnptr = &GetUniformLocation_Lazy;
        /// <summary> Returns the location of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        public static int GetUniformLocation(ProgramHandle program, byte* name) => _GetUniformLocation_fnptr(program, name);
        [UnmanagedCallersOnly]
        private static int GetUniformLocation_Lazy(ProgramHandle program, byte* name)
        {
            _GetUniformLocation_fnptr = (delegate* unmanaged<ProgramHandle, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetUniformLocation");
            return _GetUniformLocation_fnptr(program, name);
        }
        
        private static delegate* unmanaged<uint, VertexAttribPropertyARB, float*, void> _GetVertexAttribfv_fnptr = &GetVertexAttribfv_Lazy;
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => _GetVertexAttribfv_fnptr(index, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetVertexAttribfv_Lazy(uint index, VertexAttribPropertyARB pname, float* parameters)
        {
            _GetVertexAttribfv_fnptr = (delegate* unmanaged<uint, VertexAttribPropertyARB, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetVertexAttribfv");
            _GetVertexAttribfv_fnptr(index, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, VertexAttribPropertyARB, int*, void> _GetVertexAttribiv_fnptr = &GetVertexAttribiv_Lazy;
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => _GetVertexAttribiv_fnptr(index, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetVertexAttribiv_Lazy(uint index, VertexAttribPropertyARB pname, int* parameters)
        {
            _GetVertexAttribiv_fnptr = (delegate* unmanaged<uint, VertexAttribPropertyARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetVertexAttribiv");
            _GetVertexAttribiv_fnptr(index, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, VertexAttribPointerPropertyARB, void**, void> _GetVertexAttribPointerv_fnptr = &GetVertexAttribPointerv_Lazy;
        /// <summary> Return the address of the specified generic vertex attribute pointer. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</param>
        /// <param name="pointer">Returns the pointer value.</param>
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => _GetVertexAttribPointerv_fnptr(index, pname, pointer);
        [UnmanagedCallersOnly]
        private static void GetVertexAttribPointerv_Lazy(uint index, VertexAttribPointerPropertyARB pname, void** pointer)
        {
            _GetVertexAttribPointerv_fnptr = (delegate* unmanaged<uint, VertexAttribPointerPropertyARB, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetVertexAttribPointerv");
            _GetVertexAttribPointerv_fnptr(index, pname, pointer);
        }
        
        private static delegate* unmanaged<HintTarget, HintMode, void> _Hint_fnptr = &Hint_Lazy;
        /// <summary> Specify implementation-specific hints. </summary>
        /// <param name="target"> Specifies a symbolic constant indicating the behavior to be controlled. GL_FRAGMENT_SHADER_DERIVATIVE_HINT, and GL_GENERATE_MIPMAP_HINT are accepted. </param>
        /// <param name="mode"> Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. </param>
        public static void Hint(HintTarget target, HintMode mode) => _Hint_fnptr(target, mode);
        [UnmanagedCallersOnly]
        private static void Hint_Lazy(HintTarget target, HintMode mode)
        {
            _Hint_fnptr = (delegate* unmanaged<HintTarget, HintMode, void>)GLLoader.BindingsContext.GetProcAddress("glHint");
            _Hint_fnptr(target, mode);
        }
        
        private static delegate* unmanaged<BufferHandle, byte> _IsBuffer_fnptr = &IsBuffer_Lazy;
        /// <summary> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        public static byte IsBuffer(BufferHandle buffer) => _IsBuffer_fnptr(buffer);
        [UnmanagedCallersOnly]
        private static byte IsBuffer_Lazy(BufferHandle buffer)
        {
            _IsBuffer_fnptr = (delegate* unmanaged<BufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsBuffer");
            return _IsBuffer_fnptr(buffer);
        }
        
        private static delegate* unmanaged<EnableCap, byte> _IsEnabled_fnptr = &IsEnabled_Lazy;
        /// <summary> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        public static byte IsEnabled(EnableCap cap) => _IsEnabled_fnptr(cap);
        [UnmanagedCallersOnly]
        private static byte IsEnabled_Lazy(EnableCap cap)
        {
            _IsEnabled_fnptr = (delegate* unmanaged<EnableCap, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnabled");
            return _IsEnabled_fnptr(cap);
        }
        
        private static delegate* unmanaged<FramebufferHandle, byte> _IsFramebuffer_fnptr = &IsFramebuffer_Lazy;
        /// <summary> Determine if a name corresponds to a framebuffer object. </summary>
        /// <param name="framebuffer"> Specifies a value that may be the name of a framebuffer object. </param>
        public static byte IsFramebuffer(FramebufferHandle framebuffer) => _IsFramebuffer_fnptr(framebuffer);
        [UnmanagedCallersOnly]
        private static byte IsFramebuffer_Lazy(FramebufferHandle framebuffer)
        {
            _IsFramebuffer_fnptr = (delegate* unmanaged<FramebufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsFramebuffer");
            return _IsFramebuffer_fnptr(framebuffer);
        }
        
        private static delegate* unmanaged<ProgramHandle, byte> _IsProgram_fnptr = &IsProgram_Lazy;
        /// <summary> Determines if a name corresponds to a program object. </summary>
        /// <param name="program">Specifies a potential program object.</param>
        public static byte IsProgram(ProgramHandle program) => _IsProgram_fnptr(program);
        [UnmanagedCallersOnly]
        private static byte IsProgram_Lazy(ProgramHandle program)
        {
            _IsProgram_fnptr = (delegate* unmanaged<ProgramHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsProgram");
            return _IsProgram_fnptr(program);
        }
        
        private static delegate* unmanaged<RenderbufferHandle, byte> _IsRenderbuffer_fnptr = &IsRenderbuffer_Lazy;
        /// <summary> Determine if a name corresponds to a renderbuffer object. </summary>
        /// <param name="renderbuffer"> Specifies a value that may be the name of a renderbuffer object. </param>
        public static byte IsRenderbuffer(RenderbufferHandle renderbuffer) => _IsRenderbuffer_fnptr(renderbuffer);
        [UnmanagedCallersOnly]
        private static byte IsRenderbuffer_Lazy(RenderbufferHandle renderbuffer)
        {
            _IsRenderbuffer_fnptr = (delegate* unmanaged<RenderbufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsRenderbuffer");
            return _IsRenderbuffer_fnptr(renderbuffer);
        }
        
        private static delegate* unmanaged<ShaderHandle, byte> _IsShader_fnptr = &IsShader_Lazy;
        /// <summary> Determines if a name corresponds to a shader object. </summary>
        /// <param name="shader">Specifies a potential shader object.</param>
        public static byte IsShader(ShaderHandle shader) => _IsShader_fnptr(shader);
        [UnmanagedCallersOnly]
        private static byte IsShader_Lazy(ShaderHandle shader)
        {
            _IsShader_fnptr = (delegate* unmanaged<ShaderHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsShader");
            return _IsShader_fnptr(shader);
        }
        
        private static delegate* unmanaged<TextureHandle, byte> _IsTexture_fnptr = &IsTexture_Lazy;
        /// <summary> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        public static byte IsTexture(TextureHandle texture) => _IsTexture_fnptr(texture);
        [UnmanagedCallersOnly]
        private static byte IsTexture_Lazy(TextureHandle texture)
        {
            _IsTexture_fnptr = (delegate* unmanaged<TextureHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsTexture");
            return _IsTexture_fnptr(texture);
        }
        
        private static delegate* unmanaged<float, void> _LineWidth_fnptr = &LineWidth_Lazy;
        /// <summary> Specify the width of rasterized lines. </summary>
        /// <param name="width"> Specifies the width of rasterized lines. The initial value is 1. </param>
        public static void LineWidth(float width) => _LineWidth_fnptr(width);
        [UnmanagedCallersOnly]
        private static void LineWidth_Lazy(float width)
        {
            _LineWidth_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glLineWidth");
            _LineWidth_fnptr(width);
        }
        
        private static delegate* unmanaged<ProgramHandle, void> _LinkProgram_fnptr = &LinkProgram_Lazy;
        /// <summary> Links a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        public static void LinkProgram(ProgramHandle program) => _LinkProgram_fnptr(program);
        [UnmanagedCallersOnly]
        private static void LinkProgram_Lazy(ProgramHandle program)
        {
            _LinkProgram_fnptr = (delegate* unmanaged<ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glLinkProgram");
            _LinkProgram_fnptr(program);
        }
        
        private static delegate* unmanaged<PixelStoreParameter, int, void> _PixelStorei_fnptr = &PixelStorei_Lazy;
        /// <summary> Set pixel storage modes. </summary>
        /// <param name="pname"> Specifies the symbolic name of the parameter to be set. Four values affect the packing of pixel data into memory: GL_PACK_ROW_LENGTH, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT. </param>
        /// <param name="param"> Specifies the value that pname is set to. </param>
        public static void PixelStorei(PixelStoreParameter pname, int param) => _PixelStorei_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void PixelStorei_Lazy(PixelStoreParameter pname, int param)
        {
            _PixelStorei_fnptr = (delegate* unmanaged<PixelStoreParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glPixelStorei");
            _PixelStorei_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<float, float, void> _PolygonOffset_fnptr = &PolygonOffset_Lazy;
        /// <summary> Set the scale and units used to calculate depth values. </summary>
        /// <param name="factor"> Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0. </param>
        /// <param name="units"> Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0. </param>
        public static void PolygonOffset(float factor, float units) => _PolygonOffset_fnptr(factor, units);
        [UnmanagedCallersOnly]
        private static void PolygonOffset_Lazy(float factor, float units)
        {
            _PolygonOffset_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonOffset");
            _PolygonOffset_fnptr(factor, units);
        }
        
        private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void> _ReadPixels_fnptr = &ReadPixels_Lazy;
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => _ReadPixels_fnptr(x, y, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void ReadPixels_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            _ReadPixels_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadPixels");
            _ReadPixels_fnptr(x, y, width, height, format, type, pixels);
        }
        
        private static delegate* unmanaged<void> _ReleaseShaderCompiler_fnptr = &ReleaseShaderCompiler_Lazy;
        /// <summary> Release resources consumed by the implementation's shader compiler. </summary>
        public static void ReleaseShaderCompiler() => _ReleaseShaderCompiler_fnptr();
        [UnmanagedCallersOnly]
        private static void ReleaseShaderCompiler_Lazy()
        {
            _ReleaseShaderCompiler_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glReleaseShaderCompiler");
            _ReleaseShaderCompiler_fnptr();
        }
        
        private static delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void> _RenderbufferStorage_fnptr = &RenderbufferStorage_Lazy;
        /// <summary> Establish data storage, format and dimensions of a renderbuffer object's image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object's image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => _RenderbufferStorage_fnptr(target, internalformat, width, height);
        [UnmanagedCallersOnly]
        private static void RenderbufferStorage_Lazy(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
        {
            _RenderbufferStorage_fnptr = (delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorage");
            _RenderbufferStorage_fnptr(target, internalformat, width, height);
        }
        
        private static delegate* unmanaged<float, byte, void> _SampleCoverage_fnptr = &SampleCoverage_Lazy;
        /// <summary> Specify multisample coverage parameters. </summary>
        /// <param name="value"> Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0. </param>
        /// <param name="invert"> Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE. </param>
        public static void SampleCoverage(float value, byte invert) => _SampleCoverage_fnptr(value, invert);
        [UnmanagedCallersOnly]
        private static void SampleCoverage_Lazy(float value, byte invert)
        {
            _SampleCoverage_fnptr = (delegate* unmanaged<float, byte, void>)GLLoader.BindingsContext.GetProcAddress("glSampleCoverage");
            _SampleCoverage_fnptr(value, invert);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Scissor_fnptr = &Scissor_Lazy;
        /// <summary> Define the scissor box. </summary>
        /// <param name="x"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="y"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="width"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        public static void Scissor(int x, int y, int width, int height) => _Scissor_fnptr(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Scissor_Lazy(int x, int y, int width, int height)
        {
            _Scissor_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScissor");
            _Scissor_fnptr(x, y, width, height);
        }
        
        private static delegate* unmanaged<int, ShaderHandle*, ShaderBinaryFormat, void*, int, void> _ShaderBinary_fnptr = &ShaderBinary_Lazy;
        /// <summary> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        public static void ShaderBinary(int count, ShaderHandle* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => _ShaderBinary_fnptr(count, shaders, binaryFormat, binary, length);
        [UnmanagedCallersOnly]
        private static void ShaderBinary_Lazy(int count, ShaderHandle* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length)
        {
            _ShaderBinary_fnptr = (delegate* unmanaged<int, ShaderHandle*, ShaderBinaryFormat, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glShaderBinary");
            _ShaderBinary_fnptr(count, shaders, binaryFormat, binary, length);
        }
        
        private static delegate* unmanaged<ShaderHandle, int, byte**, int*, void> _ShaderSource_fnptr = &ShaderSource_Lazy;
        /// <summary> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="str">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        public static void ShaderSource(ShaderHandle shader, int count, byte** str, int* length) => _ShaderSource_fnptr(shader, count, str, length);
        [UnmanagedCallersOnly]
        private static void ShaderSource_Lazy(ShaderHandle shader, int count, byte** str, int* length)
        {
            _ShaderSource_fnptr = (delegate* unmanaged<ShaderHandle, int, byte**, int*, void>)GLLoader.BindingsContext.GetProcAddress("glShaderSource");
            _ShaderSource_fnptr(shader, count, str, length);
        }
        
        private static delegate* unmanaged<StencilFunction, int, uint, void> _StencilFunc_fnptr = &StencilFunc_Lazy;
        /// <summary> Set front and back function and reference value for stencil testing. </summary>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's. </param>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => _StencilFunc_fnptr(func, reference, mask);
        [UnmanagedCallersOnly]
        private static void StencilFunc_Lazy(StencilFunction func, int reference, uint mask)
        {
            _StencilFunc_fnptr = (delegate* unmanaged<StencilFunction, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilFunc");
            _StencilFunc_fnptr(func, reference, mask);
        }
        
        private static delegate* unmanaged<StencilFaceDirection, StencilFunction, int, uint, void> _StencilFuncSeparate_fnptr = &StencilFuncSeparate_Lazy;
        /// <summary> Set front and/or back function and reference value for stencil testing. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's. </param>
        public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int reference, uint mask) => _StencilFuncSeparate_fnptr(face, func, reference, mask);
        [UnmanagedCallersOnly]
        private static void StencilFuncSeparate_Lazy(StencilFaceDirection face, StencilFunction func, int reference, uint mask)
        {
            _StencilFuncSeparate_fnptr = (delegate* unmanaged<StencilFaceDirection, StencilFunction, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilFuncSeparate");
            _StencilFuncSeparate_fnptr(face, func, reference, mask);
        }
        
        private static delegate* unmanaged<uint, void> _StencilMask_fnptr = &StencilMask_Lazy;
        /// <summary> Control the front and back writing of individual bits in the stencil planes. </summary>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's. </param>
        public static void StencilMask(uint mask) => _StencilMask_fnptr(mask);
        [UnmanagedCallersOnly]
        private static void StencilMask_Lazy(uint mask)
        {
            _StencilMask_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilMask");
            _StencilMask_fnptr(mask);
        }
        
        private static delegate* unmanaged<StencilFaceDirection, uint, void> _StencilMaskSeparate_fnptr = &StencilMaskSeparate_Lazy;
        /// <summary> Control the front and/or back writing of individual bits in the stencil planes. </summary>
        /// <param name="face"> Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's. </param>
        public static void StencilMaskSeparate(StencilFaceDirection face, uint mask) => _StencilMaskSeparate_fnptr(face, mask);
        [UnmanagedCallersOnly]
        private static void StencilMaskSeparate_Lazy(StencilFaceDirection face, uint mask)
        {
            _StencilMaskSeparate_fnptr = (delegate* unmanaged<StencilFaceDirection, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilMaskSeparate");
            _StencilMaskSeparate_fnptr(face, mask);
        }
        
        private static delegate* unmanaged<StencilOp, StencilOp, StencilOp, void> _StencilOp_fnptr = &StencilOp_Lazy;
        /// <summary> Set front and back stencil test actions. </summary>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => _StencilOp_fnptr(fail, zfail, zpass);
        [UnmanagedCallersOnly]
        private static void StencilOp_Lazy(StencilOp fail, StencilOp zfail, StencilOp zpass)
        {
            _StencilOp_fnptr = (delegate* unmanaged<StencilOp, StencilOp, StencilOp, void>)GLLoader.BindingsContext.GetProcAddress("glStencilOp");
            _StencilOp_fnptr(fail, zfail, zpass);
        }
        
        private static delegate* unmanaged<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> _StencilOpSeparate_fnptr = &StencilOpSeparate_Lazy;
        /// <summary> Set front and/or back stencil test actions. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => _StencilOpSeparate_fnptr(face, sfail, dpfail, dppass);
        [UnmanagedCallersOnly]
        private static void StencilOpSeparate_Lazy(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            _StencilOpSeparate_fnptr = (delegate* unmanaged<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void>)GLLoader.BindingsContext.GetProcAddress("glStencilOpSeparate");
            _StencilOpSeparate_fnptr(face, sfail, dpfail, dppass);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexImage2D_fnptr = &TexImage2D_Lazy;
        /// <summary> Specify a two-dimensional texture image. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="internalFormat"> Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, or one of the sized internal formats given in Table 2, below. </param>
        /// <param name="width"> Specifies the width of the texture image. All implementations support texture images that are at least 2048 texels wide. </param>
        /// <param name="height"> Specifies the height of the texture image. All implementations support texture images that are at least 2048 texels high. </param>
        /// <param name="border"> This value must be 0. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL,GL_STENCIL_INDEX, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => _TexImage2D_fnptr(target, level, internalformat, width, height, border, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexImage2D_Lazy(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels)
        {
            _TexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexImage2D");
            _TexImage2D_fnptr(target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, float, void> _TexParameterf_fnptr = &TexParameterf_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => _TexParameterf_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameterf_Lazy(TextureTarget target, TextureParameterName pname, float param)
        {
            _TexParameterf_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, float, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterf");
            _TexParameterf_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, float*, void> _TexParameterfv_fnptr = &TexParameterfv_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => _TexParameterfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterfv_Lazy(TextureTarget target, TextureParameterName pname, float* parameters)
        {
            _TexParameterfv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterfv");
            _TexParameterfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, int, void> _TexParameteri_fnptr = &TexParameteri_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => _TexParameteri_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameteri_Lazy(TextureTarget target, TextureParameterName pname, int param)
        {
            _TexParameteri_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameteri");
            _TexParameteri_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, int*, void> _TexParameteriv_fnptr = &TexParameteriv_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => _TexParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameteriv_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
        {
            _TexParameteriv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameteriv");
            _TexParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexSubImage2D_fnptr = &TexSubImage2D_Lazy;
        /// <summary> Specify a two-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RED_INTEGER, GL_RG, GL_RG_INTEGER, GL_RGB, GL_RGB_INTEGER, GL_RGBA, GL_RGBA_INTEGER, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_LUMINANCE_ALPHA, GL_LUMINANCE, and GL_ALPHA. </param>
        /// <param name="type"> Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, GL_UNSIGNED_INT_24_8, and GL_FLOAT_32_UNSIGNED_INT_24_8_REV. </param>
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => _TexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            _TexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexSubImage2D");
            _TexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        private static delegate* unmanaged<int, float, void> _Uniform1f_fnptr = &Uniform1f_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform1f(int location, float v0) => _Uniform1f_fnptr(location, v0);
        [UnmanagedCallersOnly]
        private static void Uniform1f_Lazy(int location, float v0)
        {
            _Uniform1f_fnptr = (delegate* unmanaged<int, float, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1f");
            _Uniform1f_fnptr(location, v0);
        }
        
        private static delegate* unmanaged<int, int, float*, void> _Uniform1fv_fnptr = &Uniform1fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform1fv(int location, int count, float* value) => _Uniform1fv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform1fv_Lazy(int location, int count, float* value)
        {
            _Uniform1fv_fnptr = (delegate* unmanaged<int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1fv");
            _Uniform1fv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, void> _Uniform1i_fnptr = &Uniform1i_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform1i(int location, int v0) => _Uniform1i_fnptr(location, v0);
        [UnmanagedCallersOnly]
        private static void Uniform1i_Lazy(int location, int v0)
        {
            _Uniform1i_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1i");
            _Uniform1i_fnptr(location, v0);
        }
        
        private static delegate* unmanaged<int, int, int*, void> _Uniform1iv_fnptr = &Uniform1iv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform1iv(int location, int count, int* value) => _Uniform1iv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform1iv_Lazy(int location, int count, int* value)
        {
            _Uniform1iv_fnptr = (delegate* unmanaged<int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1iv");
            _Uniform1iv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, float, float, void> _Uniform2f_fnptr = &Uniform2f_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform2f(int location, float v0, float v1) => _Uniform2f_fnptr(location, v0, v1);
        [UnmanagedCallersOnly]
        private static void Uniform2f_Lazy(int location, float v0, float v1)
        {
            _Uniform2f_fnptr = (delegate* unmanaged<int, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2f");
            _Uniform2f_fnptr(location, v0, v1);
        }
        
        private static delegate* unmanaged<int, int, float*, void> _Uniform2fv_fnptr = &Uniform2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform2fv(int location, int count, float* value) => _Uniform2fv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform2fv_Lazy(int location, int count, float* value)
        {
            _Uniform2fv_fnptr = (delegate* unmanaged<int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2fv");
            _Uniform2fv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, int, void> _Uniform2i_fnptr = &Uniform2i_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform2i(int location, int v0, int v1) => _Uniform2i_fnptr(location, v0, v1);
        [UnmanagedCallersOnly]
        private static void Uniform2i_Lazy(int location, int v0, int v1)
        {
            _Uniform2i_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2i");
            _Uniform2i_fnptr(location, v0, v1);
        }
        
        private static delegate* unmanaged<int, int, int*, void> _Uniform2iv_fnptr = &Uniform2iv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform2iv(int location, int count, int* value) => _Uniform2iv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform2iv_Lazy(int location, int count, int* value)
        {
            _Uniform2iv_fnptr = (delegate* unmanaged<int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2iv");
            _Uniform2iv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, float, float, float, void> _Uniform3f_fnptr = &Uniform3f_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform3f(int location, float v0, float v1, float v2) => _Uniform3f_fnptr(location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void Uniform3f_Lazy(int location, float v0, float v1, float v2)
        {
            _Uniform3f_fnptr = (delegate* unmanaged<int, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3f");
            _Uniform3f_fnptr(location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<int, int, float*, void> _Uniform3fv_fnptr = &Uniform3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform3fv(int location, int count, float* value) => _Uniform3fv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform3fv_Lazy(int location, int count, float* value)
        {
            _Uniform3fv_fnptr = (delegate* unmanaged<int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3fv");
            _Uniform3fv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Uniform3i_fnptr = &Uniform3i_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform3i(int location, int v0, int v1, int v2) => _Uniform3i_fnptr(location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void Uniform3i_Lazy(int location, int v0, int v1, int v2)
        {
            _Uniform3i_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3i");
            _Uniform3i_fnptr(location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<int, int, int*, void> _Uniform3iv_fnptr = &Uniform3iv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform3iv(int location, int count, int* value) => _Uniform3iv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform3iv_Lazy(int location, int count, int* value)
        {
            _Uniform3iv_fnptr = (delegate* unmanaged<int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3iv");
            _Uniform3iv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, float, float, float, float, void> _Uniform4f_fnptr = &Uniform4f_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => _Uniform4f_fnptr(location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void Uniform4f_Lazy(int location, float v0, float v1, float v2, float v3)
        {
            _Uniform4f_fnptr = (delegate* unmanaged<int, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4f");
            _Uniform4f_fnptr(location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<int, int, float*, void> _Uniform4fv_fnptr = &Uniform4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform4fv(int location, int count, float* value) => _Uniform4fv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform4fv_Lazy(int location, int count, float* value)
        {
            _Uniform4fv_fnptr = (delegate* unmanaged<int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4fv");
            _Uniform4fv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, int, int, int, void> _Uniform4i_fnptr = &Uniform4i_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => _Uniform4i_fnptr(location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void Uniform4i_Lazy(int location, int v0, int v1, int v2, int v3)
        {
            _Uniform4i_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4i");
            _Uniform4i_fnptr(location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<int, int, int*, void> _Uniform4iv_fnptr = &Uniform4iv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform4iv(int location, int count, int* value) => _Uniform4iv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform4iv_Lazy(int location, int count, int* value)
        {
            _Uniform4iv_fnptr = (delegate* unmanaged<int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4iv");
            _Uniform4iv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix2fv_fnptr = &UniformMatrix2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix2fv(int location, int count, byte transpose, float* value) => _UniformMatrix2fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix2fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix2fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix2fv");
            _UniformMatrix2fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix3fv_fnptr = &UniformMatrix3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix3fv(int location, int count, byte transpose, float* value) => _UniformMatrix3fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix3fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix3fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix3fv");
            _UniformMatrix3fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix4fv_fnptr = &UniformMatrix4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix4fv(int location, int count, byte transpose, float* value) => _UniformMatrix4fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix4fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix4fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix4fv");
            _UniformMatrix4fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, void> _UseProgram_fnptr = &UseProgram_Lazy;
        /// <summary> Installs a program object as part of current rendering state. </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        public static void UseProgram(ProgramHandle program) => _UseProgram_fnptr(program);
        [UnmanagedCallersOnly]
        private static void UseProgram_Lazy(ProgramHandle program)
        {
            _UseProgram_fnptr = (delegate* unmanaged<ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glUseProgram");
            _UseProgram_fnptr(program);
        }
        
        private static delegate* unmanaged<ProgramHandle, void> _ValidateProgram_fnptr = &ValidateProgram_Lazy;
        /// <summary> Validates a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be validated.</param>
        public static void ValidateProgram(ProgramHandle program) => _ValidateProgram_fnptr(program);
        [UnmanagedCallersOnly]
        private static void ValidateProgram_Lazy(ProgramHandle program)
        {
            _ValidateProgram_fnptr = (delegate* unmanaged<ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glValidateProgram");
            _ValidateProgram_fnptr(program);
        }
        
        private static delegate* unmanaged<uint, float, void> _VertexAttrib1f_fnptr = &VertexAttrib1f_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttrib1f(uint index, float x) => _VertexAttrib1f_fnptr(index, x);
        [UnmanagedCallersOnly]
        private static void VertexAttrib1f_Lazy(uint index, float x)
        {
            _VertexAttrib1f_fnptr = (delegate* unmanaged<uint, float, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib1f");
            _VertexAttrib1f_fnptr(index, x);
        }
        
        private static delegate* unmanaged<uint, float*, void> _VertexAttrib1fv_fnptr = &VertexAttrib1fv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttrib1fv(uint index, float* v) => _VertexAttrib1fv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttrib1fv_Lazy(uint index, float* v)
        {
            _VertexAttrib1fv_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib1fv");
            _VertexAttrib1fv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<uint, float, float, void> _VertexAttrib2f_fnptr = &VertexAttrib2f_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttrib2f(uint index, float x, float y) => _VertexAttrib2f_fnptr(index, x, y);
        [UnmanagedCallersOnly]
        private static void VertexAttrib2f_Lazy(uint index, float x, float y)
        {
            _VertexAttrib2f_fnptr = (delegate* unmanaged<uint, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib2f");
            _VertexAttrib2f_fnptr(index, x, y);
        }
        
        private static delegate* unmanaged<uint, float*, void> _VertexAttrib2fv_fnptr = &VertexAttrib2fv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttrib2fv(uint index, float* v) => _VertexAttrib2fv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttrib2fv_Lazy(uint index, float* v)
        {
            _VertexAttrib2fv_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib2fv");
            _VertexAttrib2fv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<uint, float, float, float, void> _VertexAttrib3f_fnptr = &VertexAttrib3f_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttrib3f(uint index, float x, float y, float z) => _VertexAttrib3f_fnptr(index, x, y, z);
        [UnmanagedCallersOnly]
        private static void VertexAttrib3f_Lazy(uint index, float x, float y, float z)
        {
            _VertexAttrib3f_fnptr = (delegate* unmanaged<uint, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib3f");
            _VertexAttrib3f_fnptr(index, x, y, z);
        }
        
        private static delegate* unmanaged<uint, float*, void> _VertexAttrib3fv_fnptr = &VertexAttrib3fv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttrib3fv(uint index, float* v) => _VertexAttrib3fv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttrib3fv_Lazy(uint index, float* v)
        {
            _VertexAttrib3fv_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib3fv");
            _VertexAttrib3fv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<uint, float, float, float, float, void> _VertexAttrib4f_fnptr = &VertexAttrib4f_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => _VertexAttrib4f_fnptr(index, x, y, z, w);
        [UnmanagedCallersOnly]
        private static void VertexAttrib4f_Lazy(uint index, float x, float y, float z, float w)
        {
            _VertexAttrib4f_fnptr = (delegate* unmanaged<uint, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib4f");
            _VertexAttrib4f_fnptr(index, x, y, z, w);
        }
        
        private static delegate* unmanaged<uint, float*, void> _VertexAttrib4fv_fnptr = &VertexAttrib4fv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttrib4fv(uint index, float* v) => _VertexAttrib4fv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttrib4fv_Lazy(uint index, float* v)
        {
            _VertexAttrib4fv_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttrib4fv");
            _VertexAttrib4fv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<uint, int, VertexAttribPointerType, byte, int, void*, void> _VertexAttribPointer_fnptr = &VertexAttribPointer_Lazy;
        /// <summary> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="normalized">For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, byte normalized, int stride, void* pointer) => _VertexAttribPointer_fnptr(index, size, type, normalized, stride, pointer);
        [UnmanagedCallersOnly]
        private static void VertexAttribPointer_Lazy(uint index, int size, VertexAttribPointerType type, byte normalized, int stride, void* pointer)
        {
            _VertexAttribPointer_fnptr = (delegate* unmanaged<uint, int, VertexAttribPointerType, byte, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribPointer");
            _VertexAttribPointer_fnptr(index, size, type, normalized, stride, pointer);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Viewport_fnptr = &Viewport_Lazy;
        /// <summary> Set the viewport. </summary>
        /// <param name="x"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="y"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="width"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        public static void Viewport(int x, int y, int width, int height) => _Viewport_fnptr(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Viewport_Lazy(int x, int y, int width, int height)
        {
            _Viewport_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glViewport");
            _Viewport_fnptr(x, y, width, height);
        }
        
        private static delegate* unmanaged<ReadBufferMode, void> _ReadBuffer_fnptr = &ReadBuffer_Lazy;
        /// <summary> Select a color buffer source for pixels. </summary>
        /// <param name="src"> Specifies a color buffer. Accepted values are GL_BACK, GL_NONE, and GL_COLOR_ATTACHMENTi. </param>
        public static void ReadBuffer(ReadBufferMode src) => _ReadBuffer_fnptr(src);
        [UnmanagedCallersOnly]
        private static void ReadBuffer_Lazy(ReadBufferMode src)
        {
            _ReadBuffer_fnptr = (delegate* unmanaged<ReadBufferMode, void>)GLLoader.BindingsContext.GetProcAddress("glReadBuffer");
            _ReadBuffer_fnptr(src);
        }
        
        private static delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, void> _DrawRangeElements_fnptr = &DrawRangeElements_Lazy;
        /// <summary> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => _DrawRangeElements_fnptr(mode, start, end, count, type, indices);
        [UnmanagedCallersOnly]
        private static void DrawRangeElements_Lazy(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices)
        {
            _DrawRangeElements_fnptr = (delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawRangeElements");
            _DrawRangeElements_fnptr(mode, start, end, count, type, indices);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexImage3D_fnptr = &TexImage3D_Lazy;
        /// <summary> Specify a three-dimensional texture image. </summary>
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
        public static void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => _TexImage3D_fnptr(target, level, internalformat, width, height, depth, border, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexImage3D_Lazy(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels)
        {
            _TexImage3D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexImage3D");
            _TexImage3D_fnptr(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexSubImage3D_fnptr = &TexSubImage3D_Lazy;
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
        /// <param name="data"> Specifies a pointer to the image data in memory. </param>
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => _TexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexSubImage3D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels)
        {
            _TexSubImage3D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexSubImage3D");
            _TexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, int, void> _CopyTexSubImage3D_fnptr = &CopyTexSubImage3D_Lazy;
        /// <summary> Copy a three-dimensional texture subimage. </summary>
        /// <param name="target"> Specifies the target texture. Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="level"> Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="xoffset"> Specifies a texel offset in the x direction within the texture array. </param>
        /// <param name="yoffset"> Specifies a texel offset in the y direction within the texture array. </param>
        /// <param name="zoffset"> Specifies a texel offset in the z direction within the texture array. </param>
        /// <param name="x"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="y"> Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. </param>
        /// <param name="width"> Specifies the width of the texture subimage. </param>
        /// <param name="height"> Specifies the height of the texture subimage. </param>
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => _CopyTexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        [UnmanagedCallersOnly]
        private static void CopyTexSubImage3D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            _CopyTexSubImage3D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexSubImage3D");
            _CopyTexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void> _CompressedTexImage3D_fnptr = &CompressedTexImage3D_Lazy;
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
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => _CompressedTexImage3D_fnptr(target, level, internalformat, width, height, depth, border, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexImage3D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data)
        {
            _CompressedTexImage3D_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexImage3D");
            _CompressedTexImage3D_fnptr(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, int, void*, void> _CompressedTexSubImage3D_fnptr = &CompressedTexSubImage3D_Lazy;
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
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data) => _CompressedTexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexSubImage3D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data)
        {
            _CompressedTexSubImage3D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexSubImage3D");
            _CompressedTexSubImage3D_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        
        private static delegate* unmanaged<int, QueryHandle*, void> _GenQueries_fnptr = &GenQueries_Lazy;
        /// <summary> Generate query object names. </summary>
        /// <param name="n"> Specifies the number of query object names to be generated. </param>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        public static void GenQueries(int n, QueryHandle* ids) => _GenQueries_fnptr(n, ids);
        [UnmanagedCallersOnly]
        private static void GenQueries_Lazy(int n, QueryHandle* ids)
        {
            _GenQueries_fnptr = (delegate* unmanaged<int, QueryHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenQueries");
            _GenQueries_fnptr(n, ids);
        }
        
        private static delegate* unmanaged<int, QueryHandle*, void> _DeleteQueries_fnptr = &DeleteQueries_Lazy;
        /// <summary> Delete named query objects. </summary>
        /// <param name="n"> Specifies the number of query objects to be deleted. </param>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        public static void DeleteQueries(int n, QueryHandle* ids) => _DeleteQueries_fnptr(n, ids);
        [UnmanagedCallersOnly]
        private static void DeleteQueries_Lazy(int n, QueryHandle* ids)
        {
            _DeleteQueries_fnptr = (delegate* unmanaged<int, QueryHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteQueries");
            _DeleteQueries_fnptr(n, ids);
        }
        
        private static delegate* unmanaged<QueryHandle, byte> _IsQuery_fnptr = &IsQuery_Lazy;
        /// <summary> Determine if a name corresponds to a query object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a query object. </param>
        public static byte IsQuery(QueryHandle id) => _IsQuery_fnptr(id);
        [UnmanagedCallersOnly]
        private static byte IsQuery_Lazy(QueryHandle id)
        {
            _IsQuery_fnptr = (delegate* unmanaged<QueryHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsQuery");
            return _IsQuery_fnptr(id);
        }
        
        private static delegate* unmanaged<QueryTarget, QueryHandle, void> _BeginQuery_fnptr = &BeginQuery_Lazy;
        /// <summary> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="id"> Specifies the name of a query object. </param>
        public static void BeginQuery(QueryTarget target, QueryHandle id) => _BeginQuery_fnptr(target, id);
        [UnmanagedCallersOnly]
        private static void BeginQuery_Lazy(QueryTarget target, QueryHandle id)
        {
            _BeginQuery_fnptr = (delegate* unmanaged<QueryTarget, QueryHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBeginQuery");
            _BeginQuery_fnptr(target, id);
        }
        
        private static delegate* unmanaged<QueryTarget, void> _EndQuery_fnptr = &EndQuery_Lazy;
        /// <summary> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        public static void EndQuery(QueryTarget target) => _EndQuery_fnptr(target);
        [UnmanagedCallersOnly]
        private static void EndQuery_Lazy(QueryTarget target)
        {
            _EndQuery_fnptr = (delegate* unmanaged<QueryTarget, void>)GLLoader.BindingsContext.GetProcAddress("glEndQuery");
            _EndQuery_fnptr(target);
        }
        
        private static delegate* unmanaged<QueryTarget, QueryParameterName, int*, void> _GetQueryiv_fnptr = &GetQueryiv_Lazy;
        /// <summary> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => _GetQueryiv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetQueryiv_Lazy(QueryTarget target, QueryParameterName pname, int* parameters)
        {
            _GetQueryiv_fnptr = (delegate* unmanaged<QueryTarget, QueryParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryiv");
            _GetQueryiv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<QueryHandle, QueryObjectParameterName, uint*, void> _GetQueryObjectuiv_fnptr = &GetQueryObjectuiv_Lazy;
        /// <summary> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        public static void GetQueryObjectuiv(QueryHandle id, QueryObjectParameterName pname, uint* parameters) => _GetQueryObjectuiv_fnptr(id, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetQueryObjectuiv_Lazy(QueryHandle id, QueryObjectParameterName pname, uint* parameters)
        {
            _GetQueryObjectuiv_fnptr = (delegate* unmanaged<QueryHandle, QueryObjectParameterName, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryObjectuiv");
            _GetQueryObjectuiv_fnptr(id, pname, parameters);
        }
        
        private static delegate* unmanaged<BufferTargetARB, byte> _UnmapBuffer_fnptr = &UnmapBuffer_Lazy;
        /// <summary> Map a section of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        public static byte UnmapBuffer(BufferTargetARB target) => _UnmapBuffer_fnptr(target);
        [UnmanagedCallersOnly]
        private static byte UnmapBuffer_Lazy(BufferTargetARB target)
        {
            _UnmapBuffer_fnptr = (delegate* unmanaged<BufferTargetARB, byte>)GLLoader.BindingsContext.GetProcAddress("glUnmapBuffer");
            return _UnmapBuffer_fnptr(target);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void> _GetBufferPointerv_fnptr = &GetBufferPointerv_Lazy;
        /// <summary> Return the pointer to a mapped buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="pname"> Specifies the pointer to be returned. The symbolic constant must be GL_BUFFER_MAP_POINTER. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => _GetBufferPointerv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetBufferPointerv_Lazy(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
        {
            _GetBufferPointerv_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferPointerv");
            _GetBufferPointerv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<int, DrawBufferMode*, void> _DrawBuffers_fnptr = &DrawBuffers_Lazy;
        /// <summary> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="n">Specifies the number of buffers in bufs.</param>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => _DrawBuffers_fnptr(n, bufs);
        [UnmanagedCallersOnly]
        private static void DrawBuffers_Lazy(int n, DrawBufferMode* bufs)
        {
            _DrawBuffers_fnptr = (delegate* unmanaged<int, DrawBufferMode*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawBuffers");
            _DrawBuffers_fnptr(n, bufs);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix2x3fv_fnptr = &UniformMatrix2x3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix2x3fv(int location, int count, byte transpose, float* value) => _UniformMatrix2x3fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix2x3fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix2x3fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix2x3fv");
            _UniformMatrix2x3fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix3x2fv_fnptr = &UniformMatrix3x2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix3x2fv(int location, int count, byte transpose, float* value) => _UniformMatrix3x2fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix3x2fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix3x2fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix3x2fv");
            _UniformMatrix3x2fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix2x4fv_fnptr = &UniformMatrix2x4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix2x4fv(int location, int count, byte transpose, float* value) => _UniformMatrix2x4fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix2x4fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix2x4fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix2x4fv");
            _UniformMatrix2x4fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix4x2fv_fnptr = &UniformMatrix4x2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix4x2fv(int location, int count, byte transpose, float* value) => _UniformMatrix4x2fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix4x2fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix4x2fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix4x2fv");
            _UniformMatrix4x2fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix3x4fv_fnptr = &UniformMatrix3x4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix3x4fv(int location, int count, byte transpose, float* value) => _UniformMatrix3x4fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix3x4fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix3x4fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix3x4fv");
            _UniformMatrix3x4fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix4x3fv_fnptr = &UniformMatrix4x3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void UniformMatrix4x3fv(int location, int count, byte transpose, float* value) => _UniformMatrix4x3fv_fnptr(location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void UniformMatrix4x3fv_Lazy(int location, int count, byte transpose, float* value)
        {
            _UniformMatrix4x3fv_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix4x3fv");
            _UniformMatrix4x3fv_fnptr(location, count, transpose, value);
        }
        
        private static delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void> _BlitFramebuffer_fnptr = &BlitFramebuffer_Lazy;
        /// <summary> Copy a block of pixels from the read framebuffer to the draw framebuffer. </summary>
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
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => _BlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        [UnmanagedCallersOnly]
        private static void BlitFramebuffer_Lazy(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            _BlitFramebuffer_fnptr = (delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void>)GLLoader.BindingsContext.GetProcAddress("glBlitFramebuffer");
            _BlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisample_fnptr = &RenderbufferStorageMultisample_Lazy;
        /// <summary> Establish data storage, format, dimensions and sample count of a renderbuffer object's image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="samples"> Specifies the number of samples to be used for the renderbuffer object's storage. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object's image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisample_fnptr(target, samples, internalformat, width, height);
        [UnmanagedCallersOnly]
        private static void RenderbufferStorageMultisample_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
        {
            _RenderbufferStorageMultisample_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisample");
            _RenderbufferStorageMultisample_fnptr(target, samples, internalformat, width, height);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, void> _FramebufferTextureLayer_fnptr = &FramebufferTextureLayer_Lazy;
        /// <summary> Attach a single layer of a texture to a framebuffer. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <param name="layer"> Specifies the layer of texture to attach. </param>
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer) => _FramebufferTextureLayer_fnptr(target, attachment, texture, level, layer);
        [UnmanagedCallersOnly]
        private static void FramebufferTextureLayer_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer)
        {
            _FramebufferTextureLayer_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureLayer");
            _FramebufferTextureLayer_fnptr(target, attachment, texture, level, layer);
        }
        
        private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*> _MapBufferRange_fnptr = &MapBufferRange_Lazy;
        /// <summary> Map a section of a buffer object's data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the starting offset within the buffer of the range to be mapped. </param>
        /// <param name="length"> Specifies the length of the range to be mapped. </param>
        /// <param name="access"> Specifies a combination of access flags indicating the desired access to the range. </param>
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => _MapBufferRange_fnptr(target, offset, length, access);
        [UnmanagedCallersOnly]
        private static void* MapBufferRange_Lazy(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access)
        {
            _MapBufferRange_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)GLLoader.BindingsContext.GetProcAddress("glMapBufferRange");
            return _MapBufferRange_fnptr(target, offset, length, access);
        }
        
        private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, void> _FlushMappedBufferRange_fnptr = &FlushMappedBufferRange_Lazy;
        /// <summary> Indicate modifications to a range of a mapped buffer. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the start of the buffer subrange, in basic machine units. </param>
        /// <param name="length"> Specifies the length of the buffer subrange, in basic machine units. </param>
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => _FlushMappedBufferRange_fnptr(target, offset, length);
        [UnmanagedCallersOnly]
        private static void FlushMappedBufferRange_Lazy(BufferTargetARB target, IntPtr offset, nint length)
        {
            _FlushMappedBufferRange_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glFlushMappedBufferRange");
            _FlushMappedBufferRange_fnptr(target, offset, length);
        }
        
        private static delegate* unmanaged<VertexArrayHandle, void> _BindVertexArray_fnptr = &BindVertexArray_Lazy;
        /// <summary> Bind a vertex array object. </summary>
        /// <param name="array"> Specifies the name of the vertex array to bind. </param>
        public static void BindVertexArray(VertexArrayHandle array) => _BindVertexArray_fnptr(array);
        [UnmanagedCallersOnly]
        private static void BindVertexArray_Lazy(VertexArrayHandle array)
        {
            _BindVertexArray_fnptr = (delegate* unmanaged<VertexArrayHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindVertexArray");
            _BindVertexArray_fnptr(array);
        }
        
        private static delegate* unmanaged<int, VertexArrayHandle*, void> _DeleteVertexArrays_fnptr = &DeleteVertexArrays_Lazy;
        /// <summary> Delete vertex array objects. </summary>
        /// <param name="n"> Specifies the number of vertex array objects to be deleted. </param>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        public static void DeleteVertexArrays(int n, VertexArrayHandle* arrays) => _DeleteVertexArrays_fnptr(n, arrays);
        [UnmanagedCallersOnly]
        private static void DeleteVertexArrays_Lazy(int n, VertexArrayHandle* arrays)
        {
            _DeleteVertexArrays_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteVertexArrays");
            _DeleteVertexArrays_fnptr(n, arrays);
        }
        
        private static delegate* unmanaged<int, VertexArrayHandle*, void> _GenVertexArrays_fnptr = &GenVertexArrays_Lazy;
        /// <summary> Generate vertex array object names. </summary>
        /// <param name="n"> Specifies the number of vertex array object names to generate. </param>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        public static void GenVertexArrays(int n, VertexArrayHandle* arrays) => _GenVertexArrays_fnptr(n, arrays);
        [UnmanagedCallersOnly]
        private static void GenVertexArrays_Lazy(int n, VertexArrayHandle* arrays)
        {
            _GenVertexArrays_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenVertexArrays");
            _GenVertexArrays_fnptr(n, arrays);
        }
        
        private static delegate* unmanaged<VertexArrayHandle, byte> _IsVertexArray_fnptr = &IsVertexArray_Lazy;
        /// <summary> Determine if a name corresponds to a vertex array object. </summary>
        /// <param name="array"> Specifies a value that may be the name of a vertex array object. </param>
        public static byte IsVertexArray(VertexArrayHandle array) => _IsVertexArray_fnptr(array);
        [UnmanagedCallersOnly]
        private static byte IsVertexArray_Lazy(VertexArrayHandle array)
        {
            _IsVertexArray_fnptr = (delegate* unmanaged<VertexArrayHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsVertexArray");
            return _IsVertexArray_fnptr(array);
        }
        
        private static delegate* unmanaged<GetPName, uint, int*, void> _GetIntegeri_v_fnptr = &GetIntegeri_v_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => _GetIntegeri_v_fnptr(target, index, data);
        [UnmanagedCallersOnly]
        private static void GetIntegeri_v_Lazy(GetPName target, uint index, int* data)
        {
            _GetIntegeri_v_fnptr = (delegate* unmanaged<GetPName, uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetIntegeri_v");
            _GetIntegeri_v_fnptr(target, index, data);
        }
        
        private static delegate* unmanaged<PrimitiveType, void> _BeginTransformFeedback_fnptr = &BeginTransformFeedback_Lazy;
        /// <summary> Start transform feedback operation. </summary>
        /// <param name="primitiveMode"> Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform feedback. </param>
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => _BeginTransformFeedback_fnptr(primitiveMode);
        [UnmanagedCallersOnly]
        private static void BeginTransformFeedback_Lazy(PrimitiveType primitiveMode)
        {
            _BeginTransformFeedback_fnptr = (delegate* unmanaged<PrimitiveType, void>)GLLoader.BindingsContext.GetProcAddress("glBeginTransformFeedback");
            _BeginTransformFeedback_fnptr(primitiveMode);
        }
        
        private static delegate* unmanaged<void> _EndTransformFeedback_fnptr = &EndTransformFeedback_Lazy;
        /// <summary> Start transform feedback operation. </summary>
        public static void EndTransformFeedback() => _EndTransformFeedback_fnptr();
        [UnmanagedCallersOnly]
        private static void EndTransformFeedback_Lazy()
        {
            _EndTransformFeedback_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glEndTransformFeedback");
            _EndTransformFeedback_fnptr();
        }
        
        private static delegate* unmanaged<BufferTargetARB, uint, BufferHandle, IntPtr, nint, void> _BindBufferRange_fnptr = &BindBufferRange_Lazy;
        /// <summary> Bind a range within a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <param name="offset"> The starting offset in basic machine units into the buffer object buffer. </param>
        /// <param name="size"> The amount of data in machine units that can be read from the buffet object while used as an indexed target. </param>
        public static void BindBufferRange(BufferTargetARB target, uint index, BufferHandle buffer, IntPtr offset, nint size) => _BindBufferRange_fnptr(target, index, buffer, offset, size);
        [UnmanagedCallersOnly]
        private static void BindBufferRange_Lazy(BufferTargetARB target, uint index, BufferHandle buffer, IntPtr offset, nint size)
        {
            _BindBufferRange_fnptr = (delegate* unmanaged<BufferTargetARB, uint, BufferHandle, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glBindBufferRange");
            _BindBufferRange_fnptr(target, index, buffer, offset, size);
        }
        
        private static delegate* unmanaged<BufferTargetARB, uint, BufferHandle, void> _BindBufferBase_fnptr = &BindBufferBase_Lazy;
        /// <summary> Bind a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        public static void BindBufferBase(BufferTargetARB target, uint index, BufferHandle buffer) => _BindBufferBase_fnptr(target, index, buffer);
        [UnmanagedCallersOnly]
        private static void BindBufferBase_Lazy(BufferTargetARB target, uint index, BufferHandle buffer)
        {
            _BindBufferBase_fnptr = (delegate* unmanaged<BufferTargetARB, uint, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindBufferBase");
            _BindBufferBase_fnptr(target, index, buffer);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, byte**, TransformFeedbackBufferMode, void> _TransformFeedbackVaryings_fnptr = &TransformFeedbackVaryings_Lazy;
        /// <summary> Specify values to record in transform feedback buffers. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="count"> The number of varying variables used for transform feedback. </param>
        /// <param name="varyings"> An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback. </param>
        /// <param name="bufferMode"> Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS. </param>
        public static void TransformFeedbackVaryings(ProgramHandle program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => _TransformFeedbackVaryings_fnptr(program, count, varyings, bufferMode);
        [UnmanagedCallersOnly]
        private static void TransformFeedbackVaryings_Lazy(ProgramHandle program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode)
        {
            _TransformFeedbackVaryings_fnptr = (delegate* unmanaged<ProgramHandle, int, byte**, TransformFeedbackBufferMode, void>)GLLoader.BindingsContext.GetProcAddress("glTransformFeedbackVaryings");
            _TransformFeedbackVaryings_fnptr(program, count, varyings, bufferMode);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, int, int*, int*, AttributeType*, byte*, void> _GetTransformFeedbackVarying_fnptr = &GetTransformFeedbackVarying_Lazy;
        /// <summary> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
        public static void GetTransformFeedbackVarying(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => _GetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, type, name);
        [UnmanagedCallersOnly]
        private static void GetTransformFeedbackVarying_Lazy(ProgramHandle program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name)
        {
            _GetTransformFeedbackVarying_fnptr = (delegate* unmanaged<ProgramHandle, uint, int, int*, int*, AttributeType*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTransformFeedbackVarying");
            _GetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, type, name);
        }
        
        private static delegate* unmanaged<uint, int, VertexAttribIType, int, void*, void> _VertexAttribIPointer_fnptr = &VertexAttribIPointer_Lazy;
        /// <summary> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => _VertexAttribIPointer_fnptr(index, size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void VertexAttribIPointer_Lazy(uint index, int size, VertexAttribIType type, int stride, void* pointer)
        {
            _VertexAttribIPointer_fnptr = (delegate* unmanaged<uint, int, VertexAttribIType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribIPointer");
            _VertexAttribIPointer_fnptr(index, size, type, stride, pointer);
        }
        
        private static delegate* unmanaged<uint, VertexAttribEnum, int*, void> _GetVertexAttribIiv_fnptr = &GetVertexAttribIiv_Lazy;
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => _GetVertexAttribIiv_fnptr(index, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetVertexAttribIiv_Lazy(uint index, VertexAttribEnum pname, int* parameters)
        {
            _GetVertexAttribIiv_fnptr = (delegate* unmanaged<uint, VertexAttribEnum, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetVertexAttribIiv");
            _GetVertexAttribIiv_fnptr(index, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, VertexAttribEnum, uint*, void> _GetVertexAttribIuiv_fnptr = &GetVertexAttribIuiv_Lazy;
        /// <summary> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => _GetVertexAttribIuiv_fnptr(index, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetVertexAttribIuiv_Lazy(uint index, VertexAttribEnum pname, uint* parameters)
        {
            _GetVertexAttribIuiv_fnptr = (delegate* unmanaged<uint, VertexAttribEnum, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetVertexAttribIuiv");
            _GetVertexAttribIuiv_fnptr(index, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, int, int, int, int, void> _VertexAttribI4i_fnptr = &VertexAttribI4i_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => _VertexAttribI4i_fnptr(index, x, y, z, w);
        [UnmanagedCallersOnly]
        private static void VertexAttribI4i_Lazy(uint index, int x, int y, int z, int w)
        {
            _VertexAttribI4i_fnptr = (delegate* unmanaged<uint, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribI4i");
            _VertexAttribI4i_fnptr(index, x, y, z, w);
        }
        
        private static delegate* unmanaged<uint, uint, uint, uint, uint, void> _VertexAttribI4ui_fnptr = &VertexAttribI4ui_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => _VertexAttribI4ui_fnptr(index, x, y, z, w);
        [UnmanagedCallersOnly]
        private static void VertexAttribI4ui_Lazy(uint index, uint x, uint y, uint z, uint w)
        {
            _VertexAttribI4ui_fnptr = (delegate* unmanaged<uint, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribI4ui");
            _VertexAttribI4ui_fnptr(index, x, y, z, w);
        }
        
        private static delegate* unmanaged<uint, int*, void> _VertexAttribI4iv_fnptr = &VertexAttribI4iv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttribI4iv(uint index, int* v) => _VertexAttribI4iv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttribI4iv_Lazy(uint index, int* v)
        {
            _VertexAttribI4iv_fnptr = (delegate* unmanaged<uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribI4iv");
            _VertexAttribI4iv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<uint, uint*, void> _VertexAttribI4uiv_fnptr = &VertexAttribI4uiv_Lazy;
        /// <summary> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        public static void VertexAttribI4uiv(uint index, uint* v) => _VertexAttribI4uiv_fnptr(index, v);
        [UnmanagedCallersOnly]
        private static void VertexAttribI4uiv_Lazy(uint index, uint* v)
        {
            _VertexAttribI4uiv_fnptr = (delegate* unmanaged<uint, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribI4uiv");
            _VertexAttribI4uiv_fnptr(index, v);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint*, void> _GetUniformuiv_fnptr = &GetUniformuiv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetUniformuiv(ProgramHandle program, int location, uint* parameters) => _GetUniformuiv_fnptr(program, location, parameters);
        [UnmanagedCallersOnly]
        private static void GetUniformuiv_Lazy(ProgramHandle program, int location, uint* parameters)
        {
            _GetUniformuiv_fnptr = (delegate* unmanaged<ProgramHandle, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUniformuiv");
            _GetUniformuiv_fnptr(program, location, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, byte*, int> _GetFragDataLocation_fnptr = &GetFragDataLocation_Lazy;
        /// <summary> Query the bindings of color numbers to user-defined varying out variables. </summary>
        /// <param name="program"> The name of the program containing varying out variable whose binding to query </param>
        /// <param name="name"> The name of the user-defined varying out variable whose binding to query </param>
        public static int GetFragDataLocation(ProgramHandle program, byte* name) => _GetFragDataLocation_fnptr(program, name);
        [UnmanagedCallersOnly]
        private static int GetFragDataLocation_Lazy(ProgramHandle program, byte* name)
        {
            _GetFragDataLocation_fnptr = (delegate* unmanaged<ProgramHandle, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetFragDataLocation");
            return _GetFragDataLocation_fnptr(program, name);
        }
        
        private static delegate* unmanaged<int, uint, void> _Uniform1ui_fnptr = &Uniform1ui_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform1ui(int location, uint v0) => _Uniform1ui_fnptr(location, v0);
        [UnmanagedCallersOnly]
        private static void Uniform1ui_Lazy(int location, uint v0)
        {
            _Uniform1ui_fnptr = (delegate* unmanaged<int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1ui");
            _Uniform1ui_fnptr(location, v0);
        }
        
        private static delegate* unmanaged<int, uint, uint, void> _Uniform2ui_fnptr = &Uniform2ui_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform2ui(int location, uint v0, uint v1) => _Uniform2ui_fnptr(location, v0, v1);
        [UnmanagedCallersOnly]
        private static void Uniform2ui_Lazy(int location, uint v0, uint v1)
        {
            _Uniform2ui_fnptr = (delegate* unmanaged<int, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2ui");
            _Uniform2ui_fnptr(location, v0, v1);
        }
        
        private static delegate* unmanaged<int, uint, uint, uint, void> _Uniform3ui_fnptr = &Uniform3ui_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => _Uniform3ui_fnptr(location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void Uniform3ui_Lazy(int location, uint v0, uint v1, uint v2)
        {
            _Uniform3ui_fnptr = (delegate* unmanaged<int, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3ui");
            _Uniform3ui_fnptr(location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<int, uint, uint, uint, uint, void> _Uniform4ui_fnptr = &Uniform4ui_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => _Uniform4ui_fnptr(location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void Uniform4ui_Lazy(int location, uint v0, uint v1, uint v2, uint v3)
        {
            _Uniform4ui_fnptr = (delegate* unmanaged<int, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4ui");
            _Uniform4ui_fnptr(location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<int, int, uint*, void> _Uniform1uiv_fnptr = &Uniform1uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform1uiv(int location, int count, uint* value) => _Uniform1uiv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform1uiv_Lazy(int location, int count, uint* value)
        {
            _Uniform1uiv_fnptr = (delegate* unmanaged<int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1uiv");
            _Uniform1uiv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, uint*, void> _Uniform2uiv_fnptr = &Uniform2uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform2uiv(int location, int count, uint* value) => _Uniform2uiv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform2uiv_Lazy(int location, int count, uint* value)
        {
            _Uniform2uiv_fnptr = (delegate* unmanaged<int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2uiv");
            _Uniform2uiv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, uint*, void> _Uniform3uiv_fnptr = &Uniform3uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform3uiv(int location, int count, uint* value) => _Uniform3uiv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform3uiv_Lazy(int location, int count, uint* value)
        {
            _Uniform3uiv_fnptr = (delegate* unmanaged<int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3uiv");
            _Uniform3uiv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<int, int, uint*, void> _Uniform4uiv_fnptr = &Uniform4uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void Uniform4uiv(int location, int count, uint* value) => _Uniform4uiv_fnptr(location, count, value);
        [UnmanagedCallersOnly]
        private static void Uniform4uiv_Lazy(int location, int count, uint* value)
        {
            _Uniform4uiv_fnptr = (delegate* unmanaged<int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4uiv");
            _Uniform4uiv_fnptr(location, count, value);
        }
        
        private static delegate* unmanaged<Buffer, int, int*, void> _ClearBufferiv_fnptr = &ClearBufferiv_Lazy;
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => _ClearBufferiv_fnptr(buffer, drawbuffer, value);
        [UnmanagedCallersOnly]
        private static void ClearBufferiv_Lazy(Buffer buffer, int drawbuffer, int* value)
        {
            _ClearBufferiv_fnptr = (delegate* unmanaged<Buffer, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glClearBufferiv");
            _ClearBufferiv_fnptr(buffer, drawbuffer, value);
        }
        
        private static delegate* unmanaged<Buffer, int, uint*, void> _ClearBufferuiv_fnptr = &ClearBufferuiv_Lazy;
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => _ClearBufferuiv_fnptr(buffer, drawbuffer, value);
        [UnmanagedCallersOnly]
        private static void ClearBufferuiv_Lazy(Buffer buffer, int drawbuffer, uint* value)
        {
            _ClearBufferuiv_fnptr = (delegate* unmanaged<Buffer, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glClearBufferuiv");
            _ClearBufferuiv_fnptr(buffer, drawbuffer, value);
        }
        
        private static delegate* unmanaged<Buffer, int, float*, void> _ClearBufferfv_fnptr = &ClearBufferfv_Lazy;
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => _ClearBufferfv_fnptr(buffer, drawbuffer, value);
        [UnmanagedCallersOnly]
        private static void ClearBufferfv_Lazy(Buffer buffer, int drawbuffer, float* value)
        {
            _ClearBufferfv_fnptr = (delegate* unmanaged<Buffer, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glClearBufferfv");
            _ClearBufferfv_fnptr(buffer, drawbuffer, value);
        }
        
        private static delegate* unmanaged<Buffer, int, float, int, void> _ClearBufferfi_fnptr = &ClearBufferfi_Lazy;
        /// <summary> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="depth"> The value to clear a depth render buffer to. </param>
        /// <param name="stencil"> The value to clear a stencil render buffer to. </param>
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => _ClearBufferfi_fnptr(buffer, drawbuffer, depth, stencil);
        [UnmanagedCallersOnly]
        private static void ClearBufferfi_Lazy(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            _ClearBufferfi_fnptr = (delegate* unmanaged<Buffer, int, float, int, void>)GLLoader.BindingsContext.GetProcAddress("glClearBufferfi");
            _ClearBufferfi_fnptr(buffer, drawbuffer, depth, stencil);
        }
        
        private static delegate* unmanaged<StringName, uint, byte*> _GetStringi__fnptr = &GetStringi__Lazy;
        /// <summary> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <param name="index"> For glGetStringi, specifies the index of the string to return. </param>
        public static byte* GetStringi_(StringName name, uint index) => _GetStringi__fnptr(name, index);
        [UnmanagedCallersOnly]
        private static byte* GetStringi__Lazy(StringName name, uint index)
        {
            _GetStringi__fnptr = (delegate* unmanaged<StringName, uint, byte*>)GLLoader.BindingsContext.GetProcAddress("glGetStringi");
            return _GetStringi__fnptr(name, index);
        }
        
        private static delegate* unmanaged<CopyBufferSubDataTarget, CopyBufferSubDataTarget, IntPtr, IntPtr, nint, void> _CopyBufferSubData_fnptr = &CopyBufferSubData_Lazy;
        /// <summary> Copy part of the data store of a buffer object to the data store of another buffer object. </summary>
        /// <param name="readtarget"> Specifies the target from whose data store data should be read. </param>
        /// <param name="writetarget"> Specifies the target to whose data store data should be written. </param>
        /// <param name="readoffset"> Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read. </param>
        /// <param name="writeoffset"> Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written. </param>
        /// <param name="size"> Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget. </param>
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => _CopyBufferSubData_fnptr(readTarget, writeTarget, readOffset, writeOffset, size);
        [UnmanagedCallersOnly]
        private static void CopyBufferSubData_Lazy(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            _CopyBufferSubData_fnptr = (delegate* unmanaged<CopyBufferSubDataTarget, CopyBufferSubDataTarget, IntPtr, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glCopyBufferSubData");
            _CopyBufferSubData_fnptr(readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, byte**, uint*, void> _GetUniformIndices_fnptr = &GetUniformIndices_Lazy;
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        public static void GetUniformIndices(ProgramHandle program, int uniformCount, byte** uniformNames, uint* uniformIndices) => _GetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        [UnmanagedCallersOnly]
        private static void GetUniformIndices_Lazy(ProgramHandle program, int uniformCount, byte** uniformNames, uint* uniformIndices)
        {
            _GetUniformIndices_fnptr = (delegate* unmanaged<ProgramHandle, int, byte**, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUniformIndices");
            _GetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint*, UniformPName, int*, void> _GetActiveUniformsiv_fnptr = &GetActiveUniformsiv_Lazy;
        /// <summary> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
        /// <param name="parameters">Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.</param>
        public static void GetActiveUniformsiv(ProgramHandle program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => _GetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetActiveUniformsiv_Lazy(ProgramHandle program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters)
        {
            _GetActiveUniformsiv_fnptr = (delegate* unmanaged<ProgramHandle, int, uint*, UniformPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetActiveUniformsiv");
            _GetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, byte*, uint> _GetUniformBlockIndex_fnptr = &GetUniformBlockIndex_Lazy;
        /// <summary> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters containing the name of the uniform block whose index to retrieve. </param>
        public static uint GetUniformBlockIndex(ProgramHandle program, byte* uniformBlockName) => _GetUniformBlockIndex_fnptr(program, uniformBlockName);
        [UnmanagedCallersOnly]
        private static uint GetUniformBlockIndex_Lazy(ProgramHandle program, byte* uniformBlockName)
        {
            _GetUniformBlockIndex_fnptr = (delegate* unmanaged<ProgramHandle, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetUniformBlockIndex");
            return _GetUniformBlockIndex_fnptr(program, uniformBlockName);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, UniformBlockPName, int*, void> _GetActiveUniformBlockiv_fnptr = &GetActiveUniformBlockiv_Lazy;
        /// <summary> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        /// <param name="parameters"> Specifies the address of a variable to receive the result of the query. </param>
        public static void GetActiveUniformBlockiv(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => _GetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetActiveUniformBlockiv_Lazy(ProgramHandle program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters)
        {
            _GetActiveUniformBlockiv_fnptr = (delegate* unmanaged<ProgramHandle, uint, UniformBlockPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetActiveUniformBlockiv");
            _GetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, int, int*, byte*, void> _GetActiveUniformBlockName_fnptr = &GetActiveUniformBlockName_Lazy;
        /// <summary> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
        public static void GetActiveUniformBlockName(ProgramHandle program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => _GetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        [UnmanagedCallersOnly]
        private static void GetActiveUniformBlockName_Lazy(ProgramHandle program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName)
        {
            _GetActiveUniformBlockName_fnptr = (delegate* unmanaged<ProgramHandle, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetActiveUniformBlockName");
            _GetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        }
        
        private static delegate* unmanaged<ProgramHandle, uint, uint, void> _UniformBlockBinding_fnptr = &UniformBlockBinding_Lazy;
        /// <summary> Assign a binding point to an active uniform block. </summary>
        /// <param name="program"> The name of a program object containing the active uniform block whose binding to assign. </param>
        /// <param name="uniformBlockIndex"> The index of the active uniform block within program whose binding to assign. </param>
        /// <param name="uniformBlockBinding"> Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program. </param>
        public static void UniformBlockBinding(ProgramHandle program, uint uniformBlockIndex, uint uniformBlockBinding) => _UniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        [UnmanagedCallersOnly]
        private static void UniformBlockBinding_Lazy(ProgramHandle program, uint uniformBlockIndex, uint uniformBlockBinding)
        {
            _UniformBlockBinding_fnptr = (delegate* unmanaged<ProgramHandle, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glUniformBlockBinding");
            _UniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, int, int, void> _DrawArraysInstanced_fnptr = &DrawArraysInstanced_Lazy;
        /// <summary> Draw multiple instances of a range of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => _DrawArraysInstanced_fnptr(mode, first, count, instancecount);
        [UnmanagedCallersOnly]
        private static void DrawArraysInstanced_Lazy(PrimitiveType mode, int first, int count, int instancecount)
        {
            _DrawArraysInstanced_fnptr = (delegate* unmanaged<PrimitiveType, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysInstanced");
            _DrawArraysInstanced_fnptr(mode, first, count, instancecount);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void> _DrawElementsInstanced_fnptr = &DrawElementsInstanced_Lazy;
        /// <summary> Draw multiple instances of a set of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => _DrawElementsInstanced_fnptr(mode, count, type, indices, instancecount);
        [UnmanagedCallersOnly]
        private static void DrawElementsInstanced_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount)
        {
            _DrawElementsInstanced_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstanced");
            _DrawElementsInstanced_fnptr(mode, count, type, indices, instancecount);
        }
        
        private static delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr> _FenceSync_fnptr = &FenceSync_Lazy;
        /// <summary> Create a new sync object and insert it into the GL command stream. </summary>
        /// <param name="condition"> Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. </param>
        /// <param name="flags"> Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities. </param>
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) _FenceSync_fnptr(condition, flags);
        [UnmanagedCallersOnly]
        private static IntPtr FenceSync_Lazy(SyncCondition condition, SyncBehaviorFlags flags)
        {
            _FenceSync_fnptr = (delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glFenceSync");
            return _FenceSync_fnptr(condition, flags);
        }
        
        private static delegate* unmanaged<GLSync, byte> _IsSync_fnptr = &IsSync_Lazy;
        /// <summary> Determine if a name corresponds to a sync object. </summary>
        /// <param name="sync"> Specifies a value that may be the name of a sync object. </param>
        public static byte IsSync(GLSync sync) => _IsSync_fnptr(sync);
        [UnmanagedCallersOnly]
        private static byte IsSync_Lazy(GLSync sync)
        {
            _IsSync_fnptr = (delegate* unmanaged<GLSync, byte>)GLLoader.BindingsContext.GetProcAddress("glIsSync");
            return _IsSync_fnptr(sync);
        }
        
        private static delegate* unmanaged<GLSync, void> _DeleteSync_fnptr = &DeleteSync_Lazy;
        /// <summary> Delete a sync object. </summary>
        /// <param name="sync"> The sync object to be deleted. </param>
        public static void DeleteSync(GLSync sync) => _DeleteSync_fnptr(sync);
        [UnmanagedCallersOnly]
        private static void DeleteSync_Lazy(GLSync sync)
        {
            _DeleteSync_fnptr = (delegate* unmanaged<GLSync, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteSync");
            _DeleteSync_fnptr(sync);
        }
        
        private static delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus> _ClientWaitSync_fnptr = &ClientWaitSync_Lazy;
        /// <summary> Block and wait for a sync object to become signaled. </summary>
        /// <param name="sync"> The sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT. </param>
        /// <param name="timeout"> The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled. </param>
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => _ClientWaitSync_fnptr(sync, flags, timeout);
        [UnmanagedCallersOnly]
        private static SyncStatus ClientWaitSync_Lazy(GLSync sync, SyncObjectMask flags, ulong timeout)
        {
            _ClientWaitSync_fnptr = (delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)GLLoader.BindingsContext.GetProcAddress("glClientWaitSync");
            return _ClientWaitSync_fnptr(sync, flags, timeout);
        }
        
        private static delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void> _WaitSync_fnptr = &WaitSync_Lazy;
        /// <summary> Instruct the GL server to block until the specified sync object becomes signaled. </summary>
        /// <param name="sync"> Specifies the sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags must be zero. </param>
        /// <param name="timeout"> Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED. </param>
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => _WaitSync_fnptr(sync, flags, timeout);
        [UnmanagedCallersOnly]
        private static void WaitSync_Lazy(GLSync sync, SyncBehaviorFlags flags, ulong timeout)
        {
            _WaitSync_fnptr = (delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glWaitSync");
            _WaitSync_fnptr(sync, flags, timeout);
        }
        
        private static delegate* unmanaged<GetPName, long*, void> _GetInteger64v_fnptr = &GetInteger64v_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetInteger64v(GetPName pname, long* data) => _GetInteger64v_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetInteger64v_Lazy(GetPName pname, long* data)
        {
            _GetInteger64v_fnptr = (delegate* unmanaged<GetPName, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInteger64v");
            _GetInteger64v_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void> _GetSynciv_fnptr = &GetSynciv_Lazy;
        /// <summary> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="bufSize"> Specifies the size of the buffer whose address is given in values. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => _GetSynciv_fnptr(sync, pname, count, length, values);
        [UnmanagedCallersOnly]
        private static void GetSynciv_Lazy(GLSync sync, SyncParameterName pname, int count, int* length, int* values)
        {
            _GetSynciv_fnptr = (delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSynciv");
            _GetSynciv_fnptr(sync, pname, count, length, values);
        }
        
        private static delegate* unmanaged<GetPName, uint, long*, void> _GetInteger64i_v_fnptr = &GetInteger64i_v_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => _GetInteger64i_v_fnptr(target, index, data);
        [UnmanagedCallersOnly]
        private static void GetInteger64i_v_Lazy(GetPName target, uint index, long* data)
        {
            _GetInteger64i_v_fnptr = (delegate* unmanaged<GetPName, uint, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInteger64i_v");
            _GetInteger64i_v_fnptr(target, index, data);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferPNameARB, long*, void> _GetBufferParameteri64v_fnptr = &GetBufferParameteri64v_Lazy;
        /// <summary> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => _GetBufferParameteri64v_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetBufferParameteri64v_Lazy(BufferTargetARB target, BufferPNameARB pname, long* parameters)
        {
            _GetBufferParameteri64v_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPNameARB, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferParameteri64v");
            _GetBufferParameteri64v_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<int, SamplerHandle*, void> _GenSamplers_fnptr = &GenSamplers_Lazy;
        /// <summary> Generate sampler object names. </summary>
        /// <param name="n"> Specifies the number of sampler object names to generate. </param>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        public static void GenSamplers(int count, SamplerHandle* samplers) => _GenSamplers_fnptr(count, samplers);
        [UnmanagedCallersOnly]
        private static void GenSamplers_Lazy(int count, SamplerHandle* samplers)
        {
            _GenSamplers_fnptr = (delegate* unmanaged<int, SamplerHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenSamplers");
            _GenSamplers_fnptr(count, samplers);
        }
        
        private static delegate* unmanaged<int, SamplerHandle*, void> _DeleteSamplers_fnptr = &DeleteSamplers_Lazy;
        /// <summary> Delete named sampler objects. </summary>
        /// <param name="n"> Specifies the number of sampler objects to be deleted. </param>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        public static void DeleteSamplers(int count, SamplerHandle* samplers) => _DeleteSamplers_fnptr(count, samplers);
        [UnmanagedCallersOnly]
        private static void DeleteSamplers_Lazy(int count, SamplerHandle* samplers)
        {
            _DeleteSamplers_fnptr = (delegate* unmanaged<int, SamplerHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteSamplers");
            _DeleteSamplers_fnptr(count, samplers);
        }
        
        private static delegate* unmanaged<SamplerHandle, byte> _IsSampler_fnptr = &IsSampler_Lazy;
        /// <summary> Determine if a name corresponds to a sampler object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a sampler object. </param>
        public static byte IsSampler(SamplerHandle sampler) => _IsSampler_fnptr(sampler);
        [UnmanagedCallersOnly]
        private static byte IsSampler_Lazy(SamplerHandle sampler)
        {
            _IsSampler_fnptr = (delegate* unmanaged<SamplerHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsSampler");
            return _IsSampler_fnptr(sampler);
        }
        
        private static delegate* unmanaged<uint, SamplerHandle, void> _BindSampler_fnptr = &BindSampler_Lazy;
        /// <summary> Bind a named sampler to a texturing target. </summary>
        /// <param name="unit"> Specifies the index of the texture unit to which the sampler is bound. </param>
        /// <param name="sampler"> Specifies the name of a sampler. </param>
        public static void BindSampler(uint unit, SamplerHandle sampler) => _BindSampler_fnptr(unit, sampler);
        [UnmanagedCallersOnly]
        private static void BindSampler_Lazy(uint unit, SamplerHandle sampler)
        {
            _BindSampler_fnptr = (delegate* unmanaged<uint, SamplerHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindSampler");
            _BindSampler_fnptr(unit, sampler);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int, void> _SamplerParameteri_fnptr = &SamplerParameteri_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        public static void SamplerParameteri(SamplerHandle sampler, SamplerParameterI pname, int param) => _SamplerParameteri_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameteri_Lazy(SamplerHandle sampler, SamplerParameterI pname, int param)
        {
            _SamplerParameteri_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameteri");
            _SamplerParameteri_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _SamplerParameteriv_fnptr = &SamplerParameteriv_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void SamplerParameteriv(SamplerHandle sampler, SamplerParameterI pname, int* param) => _SamplerParameteriv_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameteriv_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* param)
        {
            _SamplerParameteriv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameteriv");
            _SamplerParameteriv_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterF, float, void> _SamplerParameterf_fnptr = &SamplerParameterf_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        public static void SamplerParameterf(SamplerHandle sampler, SamplerParameterF pname, float param) => _SamplerParameterf_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameterf_Lazy(SamplerHandle sampler, SamplerParameterF pname, float param)
        {
            _SamplerParameterf_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterF, float, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterf");
            _SamplerParameterf_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterF, float*, void> _SamplerParameterfv_fnptr = &SamplerParameterfv_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void SamplerParameterfv(SamplerHandle sampler, SamplerParameterF pname, float* param) => _SamplerParameterfv_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameterfv_Lazy(SamplerHandle sampler, SamplerParameterF pname, float* param)
        {
            _SamplerParameterfv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterF, float*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterfv");
            _SamplerParameterfv_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _GetSamplerParameteriv_fnptr = &GetSamplerParameteriv_Lazy;
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        public static void GetSamplerParameteriv(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => _GetSamplerParameteriv_fnptr(sampler, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetSamplerParameteriv_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* parameters)
        {
            _GetSamplerParameteriv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameteriv");
            _GetSamplerParameteriv_fnptr(sampler, pname, parameters);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterF, float*, void> _GetSamplerParameterfv_fnptr = &GetSamplerParameterfv_Lazy;
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        public static void GetSamplerParameterfv(SamplerHandle sampler, SamplerParameterF pname, float* parameters) => _GetSamplerParameterfv_fnptr(sampler, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetSamplerParameterfv_Lazy(SamplerHandle sampler, SamplerParameterF pname, float* parameters)
        {
            _GetSamplerParameterfv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterF, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterfv");
            _GetSamplerParameterfv_fnptr(sampler, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, uint, void> _VertexAttribDivisor_fnptr = &VertexAttribDivisor_Lazy;
        /// <summary> Modify the rate at which generic vertex attributes advance during instanced rendering. </summary>
        /// <param name="index"> Specify the index of the generic vertex attribute. </param>
        /// <param name="divisor"> Specify the number of instances that will pass between updates of the generic attribute at slot index. </param>
        public static void VertexAttribDivisor(uint index, uint divisor) => _VertexAttribDivisor_fnptr(index, divisor);
        [UnmanagedCallersOnly]
        private static void VertexAttribDivisor_Lazy(uint index, uint divisor)
        {
            _VertexAttribDivisor_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribDivisor");
            _VertexAttribDivisor_fnptr(index, divisor);
        }
        
        private static delegate* unmanaged<BindTransformFeedbackTarget, TransformFeedbackHandle, void> _BindTransformFeedback_fnptr = &BindTransformFeedback_Lazy;
        /// <summary> Bind a transform feedback object. </summary>
        /// <param name="target"> Specifies the target to which to bind the transform feedback object id. target must be GL_TRANSFORM_FEEDBACK. </param>
        /// <param name="id"> Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks. </param>
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, TransformFeedbackHandle id) => _BindTransformFeedback_fnptr(target, id);
        [UnmanagedCallersOnly]
        private static void BindTransformFeedback_Lazy(BindTransformFeedbackTarget target, TransformFeedbackHandle id)
        {
            _BindTransformFeedback_fnptr = (delegate* unmanaged<BindTransformFeedbackTarget, TransformFeedbackHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindTransformFeedback");
            _BindTransformFeedback_fnptr(target, id);
        }
        
        private static delegate* unmanaged<int, TransformFeedbackHandle*, void> _DeleteTransformFeedbacks_fnptr = &DeleteTransformFeedbacks_Lazy;
        /// <summary> Delete transform feedback objects. </summary>
        /// <param name="n"> Specifies the number of transform feedback objects to delete. </param>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        public static void DeleteTransformFeedbacks(int n, TransformFeedbackHandle* ids) => _DeleteTransformFeedbacks_fnptr(n, ids);
        [UnmanagedCallersOnly]
        private static void DeleteTransformFeedbacks_Lazy(int n, TransformFeedbackHandle* ids)
        {
            _DeleteTransformFeedbacks_fnptr = (delegate* unmanaged<int, TransformFeedbackHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteTransformFeedbacks");
            _DeleteTransformFeedbacks_fnptr(n, ids);
        }
        
        private static delegate* unmanaged<int, TransformFeedbackHandle*, void> _GenTransformFeedbacks_fnptr = &GenTransformFeedbacks_Lazy;
        /// <summary> Reserve transform feedback object names. </summary>
        /// <param name="n"> Specifies the number of transform feedback object names to reserve. </param>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        public static void GenTransformFeedbacks(int n, TransformFeedbackHandle* ids) => _GenTransformFeedbacks_fnptr(n, ids);
        [UnmanagedCallersOnly]
        private static void GenTransformFeedbacks_Lazy(int n, TransformFeedbackHandle* ids)
        {
            _GenTransformFeedbacks_fnptr = (delegate* unmanaged<int, TransformFeedbackHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenTransformFeedbacks");
            _GenTransformFeedbacks_fnptr(n, ids);
        }
        
        private static delegate* unmanaged<TransformFeedbackHandle, byte> _IsTransformFeedback_fnptr = &IsTransformFeedback_Lazy;
        /// <summary> Determine if a name corresponds to a transform feedback object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a transform feedback object. </param>
        public static byte IsTransformFeedback(TransformFeedbackHandle id) => _IsTransformFeedback_fnptr(id);
        [UnmanagedCallersOnly]
        private static byte IsTransformFeedback_Lazy(TransformFeedbackHandle id)
        {
            _IsTransformFeedback_fnptr = (delegate* unmanaged<TransformFeedbackHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsTransformFeedback");
            return _IsTransformFeedback_fnptr(id);
        }
        
        private static delegate* unmanaged<void> _PauseTransformFeedback_fnptr = &PauseTransformFeedback_Lazy;
        /// <summary> Pause transform feedback operations. </summary>
        public static void PauseTransformFeedback() => _PauseTransformFeedback_fnptr();
        [UnmanagedCallersOnly]
        private static void PauseTransformFeedback_Lazy()
        {
            _PauseTransformFeedback_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPauseTransformFeedback");
            _PauseTransformFeedback_fnptr();
        }
        
        private static delegate* unmanaged<void> _ResumeTransformFeedback_fnptr = &ResumeTransformFeedback_Lazy;
        /// <summary> Resume transform feedback operations. </summary>
        public static void ResumeTransformFeedback() => _ResumeTransformFeedback_fnptr();
        [UnmanagedCallersOnly]
        private static void ResumeTransformFeedback_Lazy()
        {
            _ResumeTransformFeedback_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glResumeTransformFeedback");
            _ResumeTransformFeedback_fnptr();
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int*, All*, void*, void> _GetProgramBinary_fnptr = &GetProgramBinary_Lazy;
        /// <summary> Return a binary representation of a program object's compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="bufsize">!!missing documentation!!</param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program's binary representation. </param>
        public static void GetProgramBinary(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary) => _GetProgramBinary_fnptr(program, bufSize, length, binaryFormat, binary);
        [UnmanagedCallersOnly]
        private static void GetProgramBinary_Lazy(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary)
        {
            _GetProgramBinary_fnptr = (delegate* unmanaged<ProgramHandle, int, int*, All*, void*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramBinary");
            _GetProgramBinary_fnptr(program, bufSize, length, binaryFormat, binary);
        }
        
        private static delegate* unmanaged<ProgramHandle, All, void*, int, void> _ProgramBinary_fnptr = &ProgramBinary_Lazy;
        /// <summary> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        public static void ProgramBinary(ProgramHandle program, All binaryFormat, void* binary, int length) => _ProgramBinary_fnptr(program, binaryFormat, binary, length);
        [UnmanagedCallersOnly]
        private static void ProgramBinary_Lazy(ProgramHandle program, All binaryFormat, void* binary, int length)
        {
            _ProgramBinary_fnptr = (delegate* unmanaged<ProgramHandle, All, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramBinary");
            _ProgramBinary_fnptr(program, binaryFormat, binary, length);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramParameterPName, int, void> _ProgramParameteri_fnptr = &ProgramParameteri_Lazy;
        /// <summary> Specify a parameter for a program object. </summary>
        /// <param name="program"> Specifies the name of a program object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the name of the parameter to modify. </param>
        /// <param name="value"> Specifies the new value of the parameter specified by pname for program. </param>
        public static void ProgramParameteri(ProgramHandle program, ProgramParameterPName pname, int value) => _ProgramParameteri_fnptr(program, pname, value);
        [UnmanagedCallersOnly]
        private static void ProgramParameteri_Lazy(ProgramHandle program, ProgramParameterPName pname, int value)
        {
            _ProgramParameteri_fnptr = (delegate* unmanaged<ProgramHandle, ProgramParameterPName, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramParameteri");
            _ProgramParameteri_fnptr(program, pname, value);
        }
        
        private static delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void> _InvalidateFramebuffer_fnptr = &InvalidateFramebuffer_Lazy;
        /// <summary> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => _InvalidateFramebuffer_fnptr(target, numAttachments, attachments);
        [UnmanagedCallersOnly]
        private static void InvalidateFramebuffer_Lazy(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
        {
            _InvalidateFramebuffer_fnptr = (delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)GLLoader.BindingsContext.GetProcAddress("glInvalidateFramebuffer");
            _InvalidateFramebuffer_fnptr(target, numAttachments, attachments);
        }
        
        private static delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, int, int, int, int, void> _InvalidateSubFramebuffer_fnptr = &InvalidateSubFramebuffer_Lazy;
        /// <summary> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => _InvalidateSubFramebuffer_fnptr(target, numAttachments, attachments, x, y, width, height);
        [UnmanagedCallersOnly]
        private static void InvalidateSubFramebuffer_Lazy(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height)
        {
            _InvalidateSubFramebuffer_fnptr = (delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glInvalidateSubFramebuffer");
            _InvalidateSubFramebuffer_fnptr(target, numAttachments, attachments, x, y, width, height);
        }
        
        private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void> _TexStorage2D_fnptr = &TexStorage2D_Lazy;
        /// <summary> Simultaneously specify storage for all levels of a two-dimensional texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_2D, or GL_TEXTURE_CUBE_MAP. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => _TexStorage2D_fnptr(target, levels, internalformat, width, height);
        [UnmanagedCallersOnly]
        private static void TexStorage2D_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
        {
            _TexStorage2D_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage2D");
            _TexStorage2D_fnptr(target, levels, internalformat, width, height);
        }
        
        private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void> _TexStorage3D_fnptr = &TexStorage3D_Lazy;
        /// <summary> Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array, or cube map array texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in texels. </param>
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => _TexStorage3D_fnptr(target, levels, internalformat, width, height, depth);
        [UnmanagedCallersOnly]
        private static void TexStorage3D_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
        {
            _TexStorage3D_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage3D");
            _TexStorage3D_fnptr(target, levels, internalformat, width, height, depth);
        }
        
        private static delegate* unmanaged<TextureTarget, InternalFormat, InternalFormatPName, int, int*, void> _GetInternalformativ_fnptr = &GetInternalformativ_Lazy;
        /// <summary> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        /// <param name="bufSize"> Specifies the maximum number of integers that may be written to params by the function. </param>
        /// <param name="parameters"> Specifies the address of a variable into which to write the retrieved information. </param>
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => _GetInternalformativ_fnptr(target, internalformat, pname, count, parameters);
        [UnmanagedCallersOnly]
        private static void GetInternalformativ_Lazy(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters)
        {
            _GetInternalformativ_fnptr = (delegate* unmanaged<TextureTarget, InternalFormat, InternalFormatPName, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInternalformativ");
            _GetInternalformativ_fnptr(target, internalformat, pname, count, parameters);
        }
        
        private static delegate* unmanaged<uint, uint, uint, void> _DispatchCompute_fnptr = &DispatchCompute_Lazy;
        /// <summary> Launch one or more compute work groups. </summary>
        /// <param name="num_groups_x"> The number of work groups to be launched in the X dimension. </param>
        /// <param name="num_groups_y"> The number of work groups to be launched in the Y dimension. </param>
        /// <param name="num_groups_z"> The number of work groups to be launched in the Z dimension. </param>
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => _DispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        [UnmanagedCallersOnly]
        private static void DispatchCompute_Lazy(uint num_groups_x, uint num_groups_y, uint num_groups_z)
        {
            _DispatchCompute_fnptr = (delegate* unmanaged<uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDispatchCompute");
            _DispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        }
        
        private static delegate* unmanaged<IntPtr, void> _DispatchComputeIndirect_fnptr = &DispatchComputeIndirect_Lazy;
        /// <summary> Launch one or more compute work groups using parameters stored in a buffer. </summary>
        /// <param name="indirect"> The offset into the buffer object currently bound to the GL_DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch parameters are stored. </param>
        public static void DispatchComputeIndirect(IntPtr indirect) => _DispatchComputeIndirect_fnptr(indirect);
        [UnmanagedCallersOnly]
        private static void DispatchComputeIndirect_Lazy(IntPtr indirect)
        {
            _DispatchComputeIndirect_fnptr = (delegate* unmanaged<IntPtr, void>)GLLoader.BindingsContext.GetProcAddress("glDispatchComputeIndirect");
            _DispatchComputeIndirect_fnptr(indirect);
        }
        
        private static delegate* unmanaged<PrimitiveType, void*, void> _DrawArraysIndirect_fnptr = &DrawArraysIndirect_Lazy;
        /// <summary> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => _DrawArraysIndirect_fnptr(mode, indirect);
        [UnmanagedCallersOnly]
        private static void DrawArraysIndirect_Lazy(PrimitiveType mode, void* indirect)
        {
            _DrawArraysIndirect_fnptr = (delegate* unmanaged<PrimitiveType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysIndirect");
            _DrawArraysIndirect_fnptr(mode, indirect);
        }
        
        private static delegate* unmanaged<PrimitiveType, DrawElementsType, void*, void> _DrawElementsIndirect_fnptr = &DrawElementsIndirect_Lazy;
        /// <summary> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => _DrawElementsIndirect_fnptr(mode, type, indirect);
        [UnmanagedCallersOnly]
        private static void DrawElementsIndirect_Lazy(PrimitiveType mode, DrawElementsType type, void* indirect)
        {
            _DrawElementsIndirect_fnptr = (delegate* unmanaged<PrimitiveType, DrawElementsType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsIndirect");
            _DrawElementsIndirect_fnptr(mode, type, indirect);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferParameterName, int, void> _FramebufferParameteri_fnptr = &FramebufferParameteri_Lazy;
        /// <summary> Set a named parameter of a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be modified. </param>
        /// <param name="param"> The new value for the parameter named pname. </param>
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => _FramebufferParameteri_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void FramebufferParameteri_Lazy(FramebufferTarget target, FramebufferParameterName pname, int param)
        {
            _FramebufferParameteri_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferParameteri");
            _FramebufferParameteri_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachmentParameterName, int*, void> _GetFramebufferParameteriv_fnptr = &GetFramebufferParameteriv_Lazy;
        /// <summary> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        /// <param name="parameters"> The address of a variable to receive the value of the parameter named pname. </param>
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => _GetFramebufferParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetFramebufferParameteriv_Lazy(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters)
        {
            _GetFramebufferParameteriv_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachmentParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFramebufferParameteriv");
            _GetFramebufferParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramInterface, ProgramInterfacePName, int*, void> _GetProgramInterfaceiv_fnptr = &GetProgramInterfaceiv_Lazy;
        /// <summary> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        /// <param name="parameters"> The address of a variable to retrieve the value of pname for the program interface. </param>
        public static void GetProgramInterfaceiv(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => _GetProgramInterfaceiv_fnptr(program, programInterface, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetProgramInterfaceiv_Lazy(ProgramHandle program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters)
        {
            _GetProgramInterfaceiv_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, ProgramInterfacePName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramInterfaceiv");
            _GetProgramInterfaceiv_fnptr(program, programInterface, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, uint> _GetProgramResourceIndex_fnptr = &GetProgramResourceIndex_Lazy;
        /// <summary> Query the index of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the index of. </param>
        public static uint GetProgramResourceIndex(ProgramHandle program, ProgramInterface programInterface, byte* name) => _GetProgramResourceIndex_fnptr(program, programInterface, name);
        [UnmanagedCallersOnly]
        private static uint GetProgramResourceIndex_Lazy(ProgramHandle program, ProgramInterface programInterface, byte* name)
        {
            _GetProgramResourceIndex_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourceIndex");
            return _GetProgramResourceIndex_fnptr(program, programInterface, name);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, int*, byte*, void> _GetProgramResourceName_fnptr = &GetProgramResourceName_Lazy;
        /// <summary> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
        public static void GetProgramResourceName(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => _GetProgramResourceName_fnptr(program, programInterface, index, bufSize, length, name);
        [UnmanagedCallersOnly]
        private static void GetProgramResourceName_Lazy(ProgramHandle program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
        {
            _GetProgramResourceName_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourceName");
            _GetProgramResourceName_fnptr(program, programInterface, index, bufSize, length, name);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, ProgramResourceProperty*, int, int*, int*, void> _GetProgramResourceiv_fnptr = &GetProgramResourceiv_Lazy;
        /// <summary> Retrieve values for multiple properties of a single active resource within a program object. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="index">!!missing documentation!!</param>
        /// <param name="propCount">!!missing documentation!!</param>
        /// <param name="props">!!missing documentation!!</param>
        /// <param name="bufSize">!!missing documentation!!</param>
        /// <param name="length">!!missing documentation!!</param>
        /// <param name="parameters">!!missing documentation!!</param>
        public static void GetProgramResourceiv(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => _GetProgramResourceiv_fnptr(program, programInterface, index, propCount, props, count, length, parameters);
        [UnmanagedCallersOnly]
        private static void GetProgramResourceiv_Lazy(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters)
        {
            _GetProgramResourceiv_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, ProgramResourceProperty*, int, int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourceiv");
            _GetProgramResourceiv_fnptr(program, programInterface, index, propCount, props, count, length, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, int> _GetProgramResourceLocation_fnptr = &GetProgramResourceLocation_Lazy;
        /// <summary> Query the location of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the location of. </param>
        public static int GetProgramResourceLocation(ProgramHandle program, ProgramInterface programInterface, byte* name) => _GetProgramResourceLocation_fnptr(program, programInterface, name);
        [UnmanagedCallersOnly]
        private static int GetProgramResourceLocation_Lazy(ProgramHandle program, ProgramInterface programInterface, byte* name)
        {
            _GetProgramResourceLocation_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourceLocation");
            return _GetProgramResourceLocation_fnptr(program, programInterface, name);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, UseProgramStageMask, ProgramHandle, void> _UseProgramStages_fnptr = &UseProgramStages_Lazy;
        /// <summary> Bind stages of a program object to a program pipeline. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to which to bind stages from program. </param>
        /// <param name="stages"> Specifies a set of program stages to bind to the program pipeline object. </param>
        /// <param name="program"> Specifies the program object containing the shader executables to use in pipeline. </param>
        public static void UseProgramStages(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program) => _UseProgramStages_fnptr(pipeline, stages, program);
        [UnmanagedCallersOnly]
        private static void UseProgramStages_Lazy(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program)
        {
            _UseProgramStages_fnptr = (delegate* unmanaged<ProgramPipelineHandle, UseProgramStageMask, ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glUseProgramStages");
            _UseProgramStages_fnptr(pipeline, stages, program);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, ProgramHandle, void> _ActiveShaderProgram_fnptr = &ActiveShaderProgram_Lazy;
        /// <summary> Set the active program object for a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to set the active program object for. </param>
        /// <param name="program"> Specifies the program object to set as the active program pipeline object pipeline. </param>
        public static void ActiveShaderProgram(ProgramPipelineHandle pipeline, ProgramHandle program) => _ActiveShaderProgram_fnptr(pipeline, program);
        [UnmanagedCallersOnly]
        private static void ActiveShaderProgram_Lazy(ProgramPipelineHandle pipeline, ProgramHandle program)
        {
            _ActiveShaderProgram_fnptr = (delegate* unmanaged<ProgramPipelineHandle, ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glActiveShaderProgram");
            _ActiveShaderProgram_fnptr(pipeline, program);
        }
        
        private static delegate* unmanaged<ShaderType, int, byte**, int> _CreateShaderProgramv_fnptr = &CreateShaderProgramv_Lazy;
        /// <summary> Create a stand-alone program from an array of null-terminated source code strings. </summary>
        /// <param name="type"> Specifies the type of shader to create. </param>
        /// <param name="count"> Specifies the number of source code strings in the array strings. </param>
        /// <param name="strings"> Specifies the address of an array of pointers to source code strings from which to create the program object. </param>
        public static ProgramHandle CreateShaderProgramv(ShaderType type, int count, byte** strings) => (ProgramHandle) _CreateShaderProgramv_fnptr(type, count, strings);
        [UnmanagedCallersOnly]
        private static int CreateShaderProgramv_Lazy(ShaderType type, int count, byte** strings)
        {
            _CreateShaderProgramv_fnptr = (delegate* unmanaged<ShaderType, int, byte**, int>)GLLoader.BindingsContext.GetProcAddress("glCreateShaderProgramv");
            return _CreateShaderProgramv_fnptr(type, count, strings);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, void> _BindProgramPipeline_fnptr = &BindProgramPipeline_Lazy;
        /// <summary> Bind a program pipeline to the current context. </summary>
        /// <param name="pipeline"> Specifies the name of the pipeline object to bind to the context. </param>
        public static void BindProgramPipeline(ProgramPipelineHandle pipeline) => _BindProgramPipeline_fnptr(pipeline);
        [UnmanagedCallersOnly]
        private static void BindProgramPipeline_Lazy(ProgramPipelineHandle pipeline)
        {
            _BindProgramPipeline_fnptr = (delegate* unmanaged<ProgramPipelineHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindProgramPipeline");
            _BindProgramPipeline_fnptr(pipeline);
        }
        
        private static delegate* unmanaged<int, ProgramPipelineHandle*, void> _DeleteProgramPipelines_fnptr = &DeleteProgramPipelines_Lazy;
        /// <summary> Delete program pipeline objects. </summary>
        /// <param name="n"> Specifies the number of program pipeline objects to delete. </param>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        public static void DeleteProgramPipelines(int n, ProgramPipelineHandle* pipelines) => _DeleteProgramPipelines_fnptr(n, pipelines);
        [UnmanagedCallersOnly]
        private static void DeleteProgramPipelines_Lazy(int n, ProgramPipelineHandle* pipelines)
        {
            _DeleteProgramPipelines_fnptr = (delegate* unmanaged<int, ProgramPipelineHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteProgramPipelines");
            _DeleteProgramPipelines_fnptr(n, pipelines);
        }
        
        private static delegate* unmanaged<int, ProgramPipelineHandle*, void> _GenProgramPipelines_fnptr = &GenProgramPipelines_Lazy;
        /// <summary> Reserve program pipeline object names. </summary>
        /// <param name="n"> Specifies the number of program pipeline object names to reserve. </param>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        public static void GenProgramPipelines(int n, ProgramPipelineHandle* pipelines) => _GenProgramPipelines_fnptr(n, pipelines);
        [UnmanagedCallersOnly]
        private static void GenProgramPipelines_Lazy(int n, ProgramPipelineHandle* pipelines)
        {
            _GenProgramPipelines_fnptr = (delegate* unmanaged<int, ProgramPipelineHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenProgramPipelines");
            _GenProgramPipelines_fnptr(n, pipelines);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, byte> _IsProgramPipeline_fnptr = &IsProgramPipeline_Lazy;
        /// <summary> Determine if a name corresponds to a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies a value that may be the name of a program pipeline object. </param>
        public static byte IsProgramPipeline(ProgramPipelineHandle pipeline) => _IsProgramPipeline_fnptr(pipeline);
        [UnmanagedCallersOnly]
        private static byte IsProgramPipeline_Lazy(ProgramPipelineHandle pipeline)
        {
            _IsProgramPipeline_fnptr = (delegate* unmanaged<ProgramPipelineHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsProgramPipeline");
            return _IsProgramPipeline_fnptr(pipeline);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, PipelineParameterName, int*, void> _GetProgramPipelineiv_fnptr = &GetProgramPipelineiv_Lazy;
        /// <summary> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        /// <param name="parameters"> Specifies the address of a variable into which will be written the value or values of pname for pipeline. </param>
        public static void GetProgramPipelineiv(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters) => _GetProgramPipelineiv_fnptr(pipeline, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetProgramPipelineiv_Lazy(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters)
        {
            _GetProgramPipelineiv_fnptr = (delegate* unmanaged<ProgramPipelineHandle, PipelineParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramPipelineiv");
            _GetProgramPipelineiv_fnptr(pipeline, pname, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, void> _ProgramUniform1i_fnptr = &ProgramUniform1i_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform1i(ProgramHandle program, int location, int v0) => _ProgramUniform1i_fnptr(program, location, v0);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1i_Lazy(ProgramHandle program, int location, int v0)
        {
            _ProgramUniform1i_fnptr = (delegate* unmanaged<ProgramHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1i");
            _ProgramUniform1i_fnptr(program, location, v0);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int, void> _ProgramUniform2i_fnptr = &ProgramUniform2i_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform2i(ProgramHandle program, int location, int v0, int v1) => _ProgramUniform2i_fnptr(program, location, v0, v1);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2i_Lazy(ProgramHandle program, int location, int v0, int v1)
        {
            _ProgramUniform2i_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2i");
            _ProgramUniform2i_fnptr(program, location, v0, v1);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int, int, void> _ProgramUniform3i_fnptr = &ProgramUniform3i_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform3i(ProgramHandle program, int location, int v0, int v1, int v2) => _ProgramUniform3i_fnptr(program, location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3i_Lazy(ProgramHandle program, int location, int v0, int v1, int v2)
        {
            _ProgramUniform3i_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3i");
            _ProgramUniform3i_fnptr(program, location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int, int, int, void> _ProgramUniform4i_fnptr = &ProgramUniform4i_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform4i(ProgramHandle program, int location, int v0, int v1, int v2, int v3) => _ProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4i_Lazy(ProgramHandle program, int location, int v0, int v1, int v2, int v3)
        {
            _ProgramUniform4i_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4i");
            _ProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint, void> _ProgramUniform1ui_fnptr = &ProgramUniform1ui_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform1ui(ProgramHandle program, int location, uint v0) => _ProgramUniform1ui_fnptr(program, location, v0);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1ui_Lazy(ProgramHandle program, int location, uint v0)
        {
            _ProgramUniform1ui_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1ui");
            _ProgramUniform1ui_fnptr(program, location, v0);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint, uint, void> _ProgramUniform2ui_fnptr = &ProgramUniform2ui_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform2ui(ProgramHandle program, int location, uint v0, uint v1) => _ProgramUniform2ui_fnptr(program, location, v0, v1);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2ui_Lazy(ProgramHandle program, int location, uint v0, uint v1)
        {
            _ProgramUniform2ui_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2ui");
            _ProgramUniform2ui_fnptr(program, location, v0, v1);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint, uint, uint, void> _ProgramUniform3ui_fnptr = &ProgramUniform3ui_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform3ui(ProgramHandle program, int location, uint v0, uint v1, uint v2) => _ProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3ui_Lazy(ProgramHandle program, int location, uint v0, uint v1, uint v2)
        {
            _ProgramUniform3ui_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3ui");
            _ProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, uint, uint, uint, uint, void> _ProgramUniform4ui_fnptr = &ProgramUniform4ui_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform4ui(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3) => _ProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4ui_Lazy(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3)
        {
            _ProgramUniform4ui_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4ui");
            _ProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, float, void> _ProgramUniform1f_fnptr = &ProgramUniform1f_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform1f(ProgramHandle program, int location, float v0) => _ProgramUniform1f_fnptr(program, location, v0);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1f_Lazy(ProgramHandle program, int location, float v0)
        {
            _ProgramUniform1f_fnptr = (delegate* unmanaged<ProgramHandle, int, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1f");
            _ProgramUniform1f_fnptr(program, location, v0);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, float, float, void> _ProgramUniform2f_fnptr = &ProgramUniform2f_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform2f(ProgramHandle program, int location, float v0, float v1) => _ProgramUniform2f_fnptr(program, location, v0, v1);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2f_Lazy(ProgramHandle program, int location, float v0, float v1)
        {
            _ProgramUniform2f_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2f");
            _ProgramUniform2f_fnptr(program, location, v0, v1);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, float, float, float, void> _ProgramUniform3f_fnptr = &ProgramUniform3f_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform3f(ProgramHandle program, int location, float v0, float v1, float v2) => _ProgramUniform3f_fnptr(program, location, v0, v1, v2);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3f_Lazy(ProgramHandle program, int location, float v0, float v1, float v2)
        {
            _ProgramUniform3f_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3f");
            _ProgramUniform3f_fnptr(program, location, v0, v1, v2);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, float, float, float, float, void> _ProgramUniform4f_fnptr = &ProgramUniform4f_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        public static void ProgramUniform4f(ProgramHandle program, int location, float v0, float v1, float v2, float v3) => _ProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4f_Lazy(ProgramHandle program, int location, float v0, float v1, float v2, float v3)
        {
            _ProgramUniform4f_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4f");
            _ProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform1iv_fnptr = &ProgramUniform1iv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform1iv(ProgramHandle program, int location, int count, int* value) => _ProgramUniform1iv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1iv_Lazy(ProgramHandle program, int location, int count, int* value)
        {
            _ProgramUniform1iv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1iv");
            _ProgramUniform1iv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform2iv_fnptr = &ProgramUniform2iv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform2iv(ProgramHandle program, int location, int count, int* value) => _ProgramUniform2iv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2iv_Lazy(ProgramHandle program, int location, int count, int* value)
        {
            _ProgramUniform2iv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2iv");
            _ProgramUniform2iv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform3iv_fnptr = &ProgramUniform3iv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform3iv(ProgramHandle program, int location, int count, int* value) => _ProgramUniform3iv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3iv_Lazy(ProgramHandle program, int location, int count, int* value)
        {
            _ProgramUniform3iv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3iv");
            _ProgramUniform3iv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform4iv_fnptr = &ProgramUniform4iv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform4iv(ProgramHandle program, int location, int count, int* value) => _ProgramUniform4iv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4iv_Lazy(ProgramHandle program, int location, int count, int* value)
        {
            _ProgramUniform4iv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4iv");
            _ProgramUniform4iv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform1uiv_fnptr = &ProgramUniform1uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform1uiv(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform1uiv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1uiv_Lazy(ProgramHandle program, int location, int count, uint* value)
        {
            _ProgramUniform1uiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1uiv");
            _ProgramUniform1uiv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform2uiv_fnptr = &ProgramUniform2uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform2uiv(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform2uiv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2uiv_Lazy(ProgramHandle program, int location, int count, uint* value)
        {
            _ProgramUniform2uiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2uiv");
            _ProgramUniform2uiv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform3uiv_fnptr = &ProgramUniform3uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform3uiv(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform3uiv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3uiv_Lazy(ProgramHandle program, int location, int count, uint* value)
        {
            _ProgramUniform3uiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3uiv");
            _ProgramUniform3uiv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform4uiv_fnptr = &ProgramUniform4uiv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform4uiv(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform4uiv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4uiv_Lazy(ProgramHandle program, int location, int count, uint* value)
        {
            _ProgramUniform4uiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4uiv");
            _ProgramUniform4uiv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform1fv_fnptr = &ProgramUniform1fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform1fv(ProgramHandle program, int location, int count, float* value) => _ProgramUniform1fv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform1fv_Lazy(ProgramHandle program, int location, int count, float* value)
        {
            _ProgramUniform1fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1fv");
            _ProgramUniform1fv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform2fv_fnptr = &ProgramUniform2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform2fv(ProgramHandle program, int location, int count, float* value) => _ProgramUniform2fv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform2fv_Lazy(ProgramHandle program, int location, int count, float* value)
        {
            _ProgramUniform2fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2fv");
            _ProgramUniform2fv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform3fv_fnptr = &ProgramUniform3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform3fv(ProgramHandle program, int location, int count, float* value) => _ProgramUniform3fv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform3fv_Lazy(ProgramHandle program, int location, int count, float* value)
        {
            _ProgramUniform3fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3fv");
            _ProgramUniform3fv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform4fv_fnptr = &ProgramUniform4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniform4fv(ProgramHandle program, int location, int count, float* value) => _ProgramUniform4fv_fnptr(program, location, count, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniform4fv_Lazy(ProgramHandle program, int location, int count, float* value)
        {
            _ProgramUniform4fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4fv");
            _ProgramUniform4fv_fnptr(program, location, count, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2fv_fnptr = &ProgramUniformMatrix2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix2fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix2fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2fv");
            _ProgramUniformMatrix2fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3fv_fnptr = &ProgramUniformMatrix3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix3fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix3fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3fv");
            _ProgramUniformMatrix3fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4fv_fnptr = &ProgramUniformMatrix4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix4fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix4fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4fv");
            _ProgramUniformMatrix4fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2x3fv_fnptr = &ProgramUniformMatrix2x3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix2x3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2x3fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix2x3fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix2x3fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2x3fv");
            _ProgramUniformMatrix2x3fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3x2fv_fnptr = &ProgramUniformMatrix3x2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix3x2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3x2fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix3x2fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix3x2fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3x2fv");
            _ProgramUniformMatrix3x2fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2x4fv_fnptr = &ProgramUniformMatrix2x4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix2x4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2x4fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix2x4fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix2x4fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2x4fv");
            _ProgramUniformMatrix2x4fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4x2fv_fnptr = &ProgramUniformMatrix4x2fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix4x2fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4x2fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix4x2fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix4x2fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4x2fv");
            _ProgramUniformMatrix4x2fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3x4fv_fnptr = &ProgramUniformMatrix3x4fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix3x4fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3x4fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix3x4fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix3x4fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3x4fv");
            _ProgramUniformMatrix3x4fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4x3fv_fnptr = &ProgramUniformMatrix4x3fv_Lazy;
        /// <summary> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        public static void ProgramUniformMatrix4x3fv(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4x3fv_fnptr(program, location, count, transpose, value);
        [UnmanagedCallersOnly]
        private static void ProgramUniformMatrix4x3fv_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
        {
            _ProgramUniformMatrix4x3fv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4x3fv");
            _ProgramUniformMatrix4x3fv_fnptr(program, location, count, transpose, value);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, void> _ValidateProgramPipeline_fnptr = &ValidateProgramPipeline_Lazy;
        /// <summary> Validate a program pipeline object against current GL state. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object to validate. </param>
        public static void ValidateProgramPipeline(ProgramPipelineHandle pipeline) => _ValidateProgramPipeline_fnptr(pipeline);
        [UnmanagedCallersOnly]
        private static void ValidateProgramPipeline_Lazy(ProgramPipelineHandle pipeline)
        {
            _ValidateProgramPipeline_fnptr = (delegate* unmanaged<ProgramPipelineHandle, void>)GLLoader.BindingsContext.GetProcAddress("glValidateProgramPipeline");
            _ValidateProgramPipeline_fnptr(pipeline);
        }
        
        private static delegate* unmanaged<ProgramPipelineHandle, int, int*, byte*, void> _GetProgramPipelineInfoLog_fnptr = &GetProgramPipelineInfoLog_Lazy;
        /// <summary> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
        public static void GetProgramPipelineInfoLog(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog) => _GetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        [UnmanagedCallersOnly]
        private static void GetProgramPipelineInfoLog_Lazy(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog)
        {
            _GetProgramPipelineInfoLog_fnptr = (delegate* unmanaged<ProgramPipelineHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramPipelineInfoLog");
            _GetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        }
        
        private static delegate* unmanaged<uint, TextureHandle, int, byte, int, BufferAccessARB, InternalFormat, void> _BindImageTexture_fnptr = &BindImageTexture_Lazy;
        /// <summary> Bind a level of a texture to an image unit. </summary>
        /// <param name="unit"> Specifies the index of the image unit to which to bind the texture </param>
        /// <param name="texture"> Specifies the name of the texture to bind to the image unit. </param>
        /// <param name="level"> Specifies the level of the texture that is to be bound. </param>
        /// <param name="layered"> Specifies whether a layered texture binding is to be established. </param>
        /// <param name="layer"> If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise. </param>
        /// <param name="access"> Specifies a token indicating the type of access that will be performed on the image. </param>
        /// <param name="format"> Specifies the format that the elements of the image will be treated as for the purposes of formatted loads and stores. </param>
        public static void BindImageTexture(uint unit, TextureHandle texture, int level, byte layered, int layer, BufferAccessARB access, InternalFormat format) => _BindImageTexture_fnptr(unit, texture, level, layered, layer, access, format);
        [UnmanagedCallersOnly]
        private static void BindImageTexture_Lazy(uint unit, TextureHandle texture, int level, byte layered, int layer, BufferAccessARB access, InternalFormat format)
        {
            _BindImageTexture_fnptr = (delegate* unmanaged<uint, TextureHandle, int, byte, int, BufferAccessARB, InternalFormat, void>)GLLoader.BindingsContext.GetProcAddress("glBindImageTexture");
            _BindImageTexture_fnptr(unit, texture, level, layered, layer, access, format);
        }
        
        private static delegate* unmanaged<BufferTargetARB, uint, byte*, void> _GetBooleani_v_fnptr = &GetBooleani_v_Lazy;
        /// <summary> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        public static void GetBooleani_v(BufferTargetARB target, uint index, byte* data) => _GetBooleani_v_fnptr(target, index, data);
        [UnmanagedCallersOnly]
        private static void GetBooleani_v_Lazy(BufferTargetARB target, uint index, byte* data)
        {
            _GetBooleani_v_fnptr = (delegate* unmanaged<BufferTargetARB, uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBooleani_v");
            _GetBooleani_v_fnptr(target, index, data);
        }
        
        private static delegate* unmanaged<MemoryBarrierMask, void> _MemoryBarrier_fnptr = &MemoryBarrier_Lazy;
        /// <summary> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        public static void MemoryBarrier(MemoryBarrierMask barriers) => _MemoryBarrier_fnptr(barriers);
        [UnmanagedCallersOnly]
        private static void MemoryBarrier_Lazy(MemoryBarrierMask barriers)
        {
            _MemoryBarrier_fnptr = (delegate* unmanaged<MemoryBarrierMask, void>)GLLoader.BindingsContext.GetProcAddress("glMemoryBarrier");
            _MemoryBarrier_fnptr(barriers);
        }
        
        private static delegate* unmanaged<MemoryBarrierMask, void> _MemoryBarrierByRegion_fnptr = &MemoryBarrierByRegion_Lazy;
        /// <summary> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => _MemoryBarrierByRegion_fnptr(barriers);
        [UnmanagedCallersOnly]
        private static void MemoryBarrierByRegion_Lazy(MemoryBarrierMask barriers)
        {
            _MemoryBarrierByRegion_fnptr = (delegate* unmanaged<MemoryBarrierMask, void>)GLLoader.BindingsContext.GetProcAddress("glMemoryBarrierByRegion");
            _MemoryBarrierByRegion_fnptr(barriers);
        }
        
        private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, byte, void> _TexStorage2DMultisample_fnptr = &TexStorage2DMultisample_Lazy;
        /// <summary> Specify storage for a two-dimensional multisample texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, byte fixedsamplelocations) => _TexStorage2DMultisample_fnptr(target, samples, internalformat, width, height, fixedsamplelocations);
        [UnmanagedCallersOnly]
        private static void TexStorage2DMultisample_Lazy(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, byte fixedsamplelocations)
        {
            _TexStorage2DMultisample_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage2DMultisample");
            _TexStorage2DMultisample_fnptr(target, samples, internalformat, width, height, fixedsamplelocations);
        }
        
        private static delegate* unmanaged<GetMultisamplePNameNV, uint, float*, void> _GetMultisamplefv_fnptr = &GetMultisamplefv_Lazy;
        /// <summary> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => _GetMultisamplefv_fnptr(pname, index, val);
        [UnmanagedCallersOnly]
        private static void GetMultisamplefv_Lazy(GetMultisamplePNameNV pname, uint index, float* val)
        {
            _GetMultisamplefv_fnptr = (delegate* unmanaged<GetMultisamplePNameNV, uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMultisamplefv");
            _GetMultisamplefv_fnptr(pname, index, val);
        }
        
        private static delegate* unmanaged<uint, All, void> _SampleMaski_fnptr = &SampleMaski_Lazy;
        /// <summary> Set the value of a sub-word of the sample mask. </summary>
        /// <param name="maskNumber"> Specifies which 32-bit sub-word of the sample mask to update. </param>
        /// <param name="mask"> Specifies the new value of the mask sub-word. </param>
        public static void SampleMaski(uint maskNumber, All mask) => _SampleMaski_fnptr(maskNumber, mask);
        [UnmanagedCallersOnly]
        private static void SampleMaski_Lazy(uint maskNumber, All mask)
        {
            _SampleMaski_fnptr = (delegate* unmanaged<uint, All, void>)GLLoader.BindingsContext.GetProcAddress("glSampleMaski");
            _SampleMaski_fnptr(maskNumber, mask);
        }
        
        private static delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void> _GetTexLevelParameteriv_fnptr = &GetTexLevelParameteriv_Lazy;
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => _GetTexLevelParameteriv_fnptr(target, level, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexLevelParameteriv_Lazy(TextureTarget target, int level, GetTextureParameter pname, int* parameters)
        {
            _GetTexLevelParameteriv_fnptr = (delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexLevelParameteriv");
            _GetTexLevelParameteriv_fnptr(target, level, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, int, GetTextureParameter, float*, void> _GetTexLevelParameterfv_fnptr = &GetTexLevelParameterfv_Lazy;
        /// <summary> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => _GetTexLevelParameterfv_fnptr(target, level, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexLevelParameterfv_Lazy(TextureTarget target, int level, GetTextureParameter pname, float* parameters)
        {
            _GetTexLevelParameterfv_fnptr = (delegate* unmanaged<TextureTarget, int, GetTextureParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexLevelParameterfv");
            _GetTexLevelParameterfv_fnptr(target, level, pname, parameters);
        }
        
        private static delegate* unmanaged<uint, BufferHandle, IntPtr, int, void> _BindVertexBuffer_fnptr = &BindVertexBuffer_Lazy;
        /// <summary> Bind a buffer to a vertex buffer bind point. </summary>
        /// <param name="bindingindex"> The index of the vertex buffer binding point to which to bind the buffer. </param>
        /// <param name="buffer"> The name of an existing buffer to bind to the vertex buffer binding point. </param>
        /// <param name="offset"> The offset of the first element of the buffer. </param>
        /// <param name="stride"> The distance between elements within the buffer. </param>
        public static void BindVertexBuffer(uint bindingindex, BufferHandle buffer, IntPtr offset, int stride) => _BindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        [UnmanagedCallersOnly]
        private static void BindVertexBuffer_Lazy(uint bindingindex, BufferHandle buffer, IntPtr offset, int stride)
        {
            _BindVertexBuffer_fnptr = (delegate* unmanaged<uint, BufferHandle, IntPtr, int, void>)GLLoader.BindingsContext.GetProcAddress("glBindVertexBuffer");
            _BindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        }
        
        private static delegate* unmanaged<uint, int, VertexAttribType, byte, uint, void> _VertexAttribFormat_fnptr = &VertexAttribFormat_Lazy;
        /// <summary> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="normalized"> Specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, byte normalized, uint relativeoffset) => _VertexAttribFormat_fnptr(attribindex, size, type, normalized, relativeoffset);
        [UnmanagedCallersOnly]
        private static void VertexAttribFormat_Lazy(uint attribindex, int size, VertexAttribType type, byte normalized, uint relativeoffset)
        {
            _VertexAttribFormat_fnptr = (delegate* unmanaged<uint, int, VertexAttribType, byte, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribFormat");
            _VertexAttribFormat_fnptr(attribindex, size, type, normalized, relativeoffset);
        }
        
        private static delegate* unmanaged<uint, int, VertexAttribIType, uint, void> _VertexAttribIFormat_fnptr = &VertexAttribIFormat_Lazy;
        /// <summary> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => _VertexAttribIFormat_fnptr(attribindex, size, type, relativeoffset);
        [UnmanagedCallersOnly]
        private static void VertexAttribIFormat_Lazy(uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
        {
            _VertexAttribIFormat_fnptr = (delegate* unmanaged<uint, int, VertexAttribIType, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribIFormat");
            _VertexAttribIFormat_fnptr(attribindex, size, type, relativeoffset);
        }
        
        private static delegate* unmanaged<uint, uint, void> _VertexAttribBinding_fnptr = &VertexAttribBinding_Lazy;
        /// <summary> Associate a vertex attribute and a vertex buffer binding. </summary>
        /// <param name="attribindex"> The index of the attribute to associate with a vertex buffer binding. </param>
        /// <param name="bindingindex"> The index of the vertex buffer binding with which to associate the generic vertex attribute. </param>
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => _VertexAttribBinding_fnptr(attribindex, bindingindex);
        [UnmanagedCallersOnly]
        private static void VertexAttribBinding_Lazy(uint attribindex, uint bindingindex)
        {
            _VertexAttribBinding_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribBinding");
            _VertexAttribBinding_fnptr(attribindex, bindingindex);
        }
        
        private static delegate* unmanaged<uint, uint, void> _VertexBindingDivisor_fnptr = &VertexBindingDivisor_Lazy;
        /// <summary> Modify the rate at which generic vertex attributes advance. </summary>
        /// <param name="bindingindex"> The index of the binding whose divisor to modify. </param>
        /// <param name="divisor"> The new value for the instance step rate to apply. </param>
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => _VertexBindingDivisor_fnptr(bindingindex, divisor);
        [UnmanagedCallersOnly]
        private static void VertexBindingDivisor_Lazy(uint bindingindex, uint divisor)
        {
            _VertexBindingDivisor_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexBindingDivisor");
            _VertexBindingDivisor_fnptr(bindingindex, divisor);
        }
        
        private static delegate* unmanaged<void> _BlendBarrier_fnptr = &BlendBarrier_Lazy;
        /// <summary> Specifies a boundary between advanced blending passes. </summary>
        public static void BlendBarrier() => _BlendBarrier_fnptr();
        [UnmanagedCallersOnly]
        private static void BlendBarrier_Lazy()
        {
            _BlendBarrier_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glBlendBarrier");
            _BlendBarrier_fnptr();
        }
        
        private static delegate* unmanaged<uint, CopyImageSubDataTarget, int, int, int, int, uint, CopyImageSubDataTarget, int, int, int, int, int, int, int, void> _CopyImageSubData_fnptr = &CopyImageSubData_Lazy;
        /// <summary> Perform a raw data copy between two images. </summary>
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
        public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => _CopyImageSubData_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        [UnmanagedCallersOnly]
        private static void CopyImageSubData_Lazy(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
        {
            _CopyImageSubData_fnptr = (delegate* unmanaged<uint, CopyImageSubDataTarget, int, int, int, int, uint, CopyImageSubDataTarget, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyImageSubData");
            _CopyImageSubData_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        }
        
        private static delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void> _DebugMessageControl_fnptr = &DebugMessageControl_Lazy;
        /// <summary> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="count"> The length of the array ids. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
        [UnmanagedCallersOnly]
        private static void DebugMessageControl_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
        {
            _DebugMessageControl_fnptr = (delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageControl");
            _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
        }
        
        private static delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> _DebugMessageInsert_fnptr = &DebugMessageInsert_Lazy;
        /// <summary> Inject an application-supplied message into the debug message queue. </summary>
        /// <param name="source"> The source of the debug message to insert. </param>
        /// <param name="type"> The type of the debug message insert. </param>
        /// <param name="id"> The user-supplied identifier of the message to insert. </param>
        /// <param name="severity"> The severity of the debug messages to insert. </param>
        /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
        /// <param name="message"> The address of a character array containing the message to insert. </param>
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
        [UnmanagedCallersOnly]
        private static void DebugMessageInsert_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
        {
            _DebugMessageInsert_fnptr = (delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsert");
            _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
        }
        
        private static delegate* unmanaged<IntPtr, void*, void> _DebugMessageCallback_fnptr = &DebugMessageCallback_Lazy;
        /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => _DebugMessageCallback_fnptr(callback, userParam);
        [UnmanagedCallersOnly]
        private static void DebugMessageCallback_Lazy(IntPtr callback, void* userParam)
        {
            _DebugMessageCallback_fnptr = (delegate* unmanaged<IntPtr, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallback");
            _DebugMessageCallback_fnptr(callback, userParam);
        }
        
        private static delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint> _GetDebugMessageLog_fnptr = &GetDebugMessageLog_Lazy;
        /// <summary> Retrieve messages from the debug message log. </summary>
        /// <param name="count"> The number of debug messages to retrieve from the log. </param>
        /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
        /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
        /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
        /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
        /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
        /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
        /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
        public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        [UnmanagedCallersOnly]
        private static uint GetDebugMessageLog_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
        {
            _GetDebugMessageLog_fnptr = (delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLog");
            return _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        }
        
        private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _PushDebugGroup_fnptr = &PushDebugGroup_Lazy;
        /// <summary> Push a named debug group into the command stream. </summary>
        /// <param name="source"> The source of the debug message. </param>
        /// <param name="id"> The identifier of the message. </param>
        /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
        /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => _PushDebugGroup_fnptr(source, id, length, message);
        [UnmanagedCallersOnly]
        private static void PushDebugGroup_Lazy(DebugSource source, uint id, int length, byte* message)
        {
            _PushDebugGroup_fnptr = (delegate* unmanaged<DebugSource, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushDebugGroup");
            _PushDebugGroup_fnptr(source, id, length, message);
        }
        
        private static delegate* unmanaged<void> _PopDebugGroup_fnptr = &PopDebugGroup_Lazy;
        /// <summary> Pop the active debug group. </summary>
        public static void PopDebugGroup() => _PopDebugGroup_fnptr();
        [UnmanagedCallersOnly]
        private static void PopDebugGroup_Lazy()
        {
            _PopDebugGroup_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopDebugGroup");
            _PopDebugGroup_fnptr();
        }
        
        private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void> _ObjectLabel_fnptr = &ObjectLabel_Lazy;
        /// <summary> Label a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object to label. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => _ObjectLabel_fnptr(identifier, name, length, label);
        [UnmanagedCallersOnly]
        private static void ObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
        {
            _ObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectLabel");
            _ObjectLabel_fnptr(identifier, name, length, label);
        }
        
        private static delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void> _GetObjectLabel_fnptr = &GetObjectLabel_Lazy;
        /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
        [UnmanagedCallersOnly]
        private static void GetObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label)
        {
            _GetObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabel");
            _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
        }
        
        private static delegate* unmanaged<void*, int, byte*, void> _ObjectPtrLabel_fnptr = &ObjectPtrLabel_Lazy;
        /// <summary> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => _ObjectPtrLabel_fnptr(ptr, length, label);
        [UnmanagedCallersOnly]
        private static void ObjectPtrLabel_Lazy(void* ptr, int length, byte* label)
        {
            _ObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabel");
            _ObjectPtrLabel_fnptr(ptr, length, label);
        }
        
        private static delegate* unmanaged<void*, int, int*, byte*, void> _GetObjectPtrLabel_fnptr = &GetObjectPtrLabel_Lazy;
        /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        [UnmanagedCallersOnly]
        private static void GetObjectPtrLabel_Lazy(void* ptr, int bufSize, int* length, byte* label)
        {
            _GetObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabel");
            _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        }
        
        private static delegate* unmanaged<GetPointervPName, void**, void> _GetPointerv_fnptr = &GetPointerv_Lazy;
        /// <summary> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => _GetPointerv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
        {
            _GetPointerv_fnptr = (delegate* unmanaged<GetPointervPName, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
            _GetPointerv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<EnableCap, uint, void> _Enablei_fnptr = &Enablei_Lazy;
        /// <summary> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        public static void Enablei(EnableCap target, uint index) => _Enablei_fnptr(target, index);
        [UnmanagedCallersOnly]
        private static void Enablei_Lazy(EnableCap target, uint index)
        {
            _Enablei_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnablei");
            _Enablei_fnptr(target, index);
        }
        
        private static delegate* unmanaged<EnableCap, uint, void> _Disablei_fnptr = &Disablei_Lazy;
        /// <summary> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        public static void Disablei(EnableCap target, uint index) => _Disablei_fnptr(target, index);
        [UnmanagedCallersOnly]
        private static void Disablei_Lazy(EnableCap target, uint index)
        {
            _Disablei_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisablei");
            _Disablei_fnptr(target, index);
        }
        
        private static delegate* unmanaged<uint, BlendEquationModeEXT, void> _BlendEquationi_fnptr = &BlendEquationi_Lazy;
        /// <summary> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="buf"> for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation. </param>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => _BlendEquationi_fnptr(buf, mode);
        [UnmanagedCallersOnly]
        private static void BlendEquationi_Lazy(uint buf, BlendEquationModeEXT mode)
        {
            _BlendEquationi_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationi");
            _BlendEquationi_fnptr(buf, mode);
        }
        
        private static delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void> _BlendEquationSeparatei_fnptr = &BlendEquationSeparatei_Lazy;
        /// <summary> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="buf"> for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations. </param>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => _BlendEquationSeparatei_fnptr(buf, modeRGB, modeAlpha);
        [UnmanagedCallersOnly]
        private static void BlendEquationSeparatei_Lazy(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
        {
            _BlendEquationSeparatei_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparatei");
            _BlendEquationSeparatei_fnptr(buf, modeRGB, modeAlpha);
        }
        
        private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void> _BlendFunci_fnptr = &BlendFunci_Lazy;
        /// <summary> Specify pixel arithmetic. </summary>
        /// <param name="buf"> For glBlendFunci, specifies the index of the draw buffer for which to set the blend function. </param>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => _BlendFunci_fnptr(buf, src, dst);
        [UnmanagedCallersOnly]
        private static void BlendFunci_Lazy(uint buf, BlendingFactor src, BlendingFactor dst)
        {
            _BlendFunci_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFunci");
            _BlendFunci_fnptr(buf, src, dst);
        }
        
        private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> _BlendFuncSeparatei_fnptr = &BlendFuncSeparatei_Lazy;
        /// <summary> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="buf"> For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions. </param>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => _BlendFuncSeparatei_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        [UnmanagedCallersOnly]
        private static void BlendFuncSeparatei_Lazy(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
        {
            _BlendFuncSeparatei_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparatei");
            _BlendFuncSeparatei_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        }
        
        private static delegate* unmanaged<uint, byte, byte, byte, byte, void> _ColorMaski_fnptr = &ColorMaski_Lazy;
        /// <summary> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="buf"> For glColorMaski, specifies the index of the draw buffer whose color mask to set. </param>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        public static void ColorMaski(uint index, byte r, byte g, byte b, byte a) => _ColorMaski_fnptr(index, r, g, b, a);
        [UnmanagedCallersOnly]
        private static void ColorMaski_Lazy(uint index, byte r, byte g, byte b, byte a)
        {
            _ColorMaski_fnptr = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColorMaski");
            _ColorMaski_fnptr(index, r, g, b, a);
        }
        
        private static delegate* unmanaged<EnableCap, uint, byte> _IsEnabledi_fnptr = &IsEnabledi_Lazy;
        /// <summary> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the capability. </param>
        public static byte IsEnabledi(EnableCap target, uint index) => _IsEnabledi_fnptr(target, index);
        [UnmanagedCallersOnly]
        private static byte IsEnabledi_Lazy(EnableCap target, uint index)
        {
            _IsEnabledi_fnptr = (delegate* unmanaged<EnableCap, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnabledi");
            return _IsEnabledi_fnptr(target, index);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void> _DrawElementsBaseVertex_fnptr = &DrawElementsBaseVertex_Lazy;
        /// <summary> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => _DrawElementsBaseVertex_fnptr(mode, count, type, indices, basevertex);
        [UnmanagedCallersOnly]
        private static void DrawElementsBaseVertex_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex)
        {
            _DrawElementsBaseVertex_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsBaseVertex");
            _DrawElementsBaseVertex_fnptr(mode, count, type, indices, basevertex);
        }
        
        private static delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void> _DrawRangeElementsBaseVertex_fnptr = &DrawRangeElementsBaseVertex_Lazy;
        /// <summary> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => _DrawRangeElementsBaseVertex_fnptr(mode, start, end, count, type, indices, basevertex);
        [UnmanagedCallersOnly]
        private static void DrawRangeElementsBaseVertex_Lazy(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex)
        {
            _DrawRangeElementsBaseVertex_fnptr = (delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawRangeElementsBaseVertex");
            _DrawRangeElementsBaseVertex_fnptr(mode, start, end, count, type, indices, basevertex);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void> _DrawElementsInstancedBaseVertex_fnptr = &DrawElementsInstancedBaseVertex_Lazy;
        /// <summary> Render multiple instances of a set of primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the indexed geometry that should be drawn. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => _DrawElementsInstancedBaseVertex_fnptr(mode, count, type, indices, instancecount, basevertex);
        [UnmanagedCallersOnly]
        private static void DrawElementsInstancedBaseVertex_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex)
        {
            _DrawElementsInstancedBaseVertex_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedBaseVertex");
            _DrawElementsInstancedBaseVertex_fnptr(mode, count, type, indices, instancecount, basevertex);
        }
        
        private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void> _FramebufferTexture_fnptr = &FramebufferTexture_Lazy;
        /// <summary> Attach a level of a texture object as a logical buffer of a framebuffer object. </summary>
        /// <param name="target"> Specifies the target to which the framebuffer is bound. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="texture"> Specifies the name of an existing texture object to attach. </param>
        /// <param name="level"> Specifies the mipmap level of the texture object to attach. </param>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => _FramebufferTexture_fnptr(target, attachment, texture, level);
        [UnmanagedCallersOnly]
        private static void FramebufferTexture_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level)
        {
            _FramebufferTexture_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture");
            _FramebufferTexture_fnptr(target, attachment, texture, level);
        }
        
        private static delegate* unmanaged<float, float, float, float, float, float, float, float, void> _PrimitiveBoundingBox_fnptr = &PrimitiveBoundingBox_Lazy;
        /// <summary> Set the bounding box for a primitive. </summary>
        /// <param name="minX"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minY"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minZ"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="minW"> Specify the minimum clip space cooridnate of the bounding box. The initial value is (-1, -1, -1, -1). </param>
        /// <param name="maxX"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxY"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxZ"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        /// <param name="maxW"> Specify the maximum clip space cooridnate of the bounding box. The initial value is (1, 1, 1, 1). </param>
        public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => _PrimitiveBoundingBox_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        [UnmanagedCallersOnly]
        private static void PrimitiveBoundingBox_Lazy(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
        {
            _PrimitiveBoundingBox_fnptr = (delegate* unmanaged<float, float, float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPrimitiveBoundingBox");
            _PrimitiveBoundingBox_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        }
        
        private static delegate* unmanaged<GraphicsResetStatus> _GetGraphicsResetStatus_fnptr = &GetGraphicsResetStatus_Lazy;
        /// <summary> Check if the rendering context has not been lost due to software or hardware issues. </summary>
        public static GraphicsResetStatus GetGraphicsResetStatus() => _GetGraphicsResetStatus_fnptr();
        [UnmanagedCallersOnly]
        private static GraphicsResetStatus GetGraphicsResetStatus_Lazy()
        {
            _GetGraphicsResetStatus_fnptr = (delegate* unmanaged<GraphicsResetStatus>)GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatus");
            return _GetGraphicsResetStatus_fnptr();
        }
        
        private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void> _ReadnPixels_fnptr = &ReadnPixels_Lazy;
        /// <summary> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
        /// <param name="data"> Returns the pixel data. </param>
        public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => _ReadnPixels_fnptr(x, y, width, height, format, type, bufSize, data);
        [UnmanagedCallersOnly]
        private static void ReadnPixels_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
        {
            _ReadnPixels_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadnPixels");
            _ReadnPixels_fnptr(x, y, width, height, format, type, bufSize, data);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _GetnUniformfv_fnptr = &GetnUniformfv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetnUniformfv(ProgramHandle program, int location, int bufSize, float* parameters) => _GetnUniformfv_fnptr(program, location, bufSize, parameters);
        [UnmanagedCallersOnly]
        private static void GetnUniformfv_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
        {
            _GetnUniformfv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformfv");
            _GetnUniformfv_fnptr(program, location, bufSize, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _GetnUniformiv_fnptr = &GetnUniformiv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetnUniformiv(ProgramHandle program, int location, int bufSize, int* parameters) => _GetnUniformiv_fnptr(program, location, bufSize, parameters);
        [UnmanagedCallersOnly]
        private static void GetnUniformiv_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
        {
            _GetnUniformiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformiv");
            _GetnUniformiv_fnptr(program, location, bufSize, parameters);
        }
        
        private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _GetnUniformuiv_fnptr = &GetnUniformuiv_Lazy;
        /// <summary> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        public static void GetnUniformuiv(ProgramHandle program, int location, int bufSize, uint* parameters) => _GetnUniformuiv_fnptr(program, location, bufSize, parameters);
        [UnmanagedCallersOnly]
        private static void GetnUniformuiv_Lazy(ProgramHandle program, int location, int bufSize, uint* parameters)
        {
            _GetnUniformuiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformuiv");
            _GetnUniformuiv_fnptr(program, location, bufSize, parameters);
        }
        
        private static delegate* unmanaged<float, void> _MinSampleShading_fnptr = &MinSampleShading_Lazy;
        /// <summary> Specifies minimum rate at which sample shading takes place. </summary>
        /// <param name="value"> Specifies the rate at which samples are shaded within each covered pixel. </param>
        public static void MinSampleShading(float value) => _MinSampleShading_fnptr(value);
        [UnmanagedCallersOnly]
        private static void MinSampleShading_Lazy(float value)
        {
            _MinSampleShading_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glMinSampleShading");
            _MinSampleShading_fnptr(value);
        }
        
        private static delegate* unmanaged<PatchParameterName, int, void> _PatchParameteri_fnptr = &PatchParameteri_Lazy;
        /// <summary> Specifies the parameters for patch primitives. </summary>
        /// <param name="pname"> Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES is accepted. </param>
        /// <param name="value"> Specifies the new value for the parameter given by pname. </param>
        public static void PatchParameteri(PatchParameterName pname, int value) => _PatchParameteri_fnptr(pname, value);
        [UnmanagedCallersOnly]
        private static void PatchParameteri_Lazy(PatchParameterName pname, int value)
        {
            _PatchParameteri_fnptr = (delegate* unmanaged<PatchParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glPatchParameteri");
            _PatchParameteri_fnptr(pname, value);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, int*, void> _TexParameterIiv_fnptr = &TexParameterIiv_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => _TexParameterIiv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterIiv_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
        {
            _TexParameterIiv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIiv");
            _TexParameterIiv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void> _TexParameterIuiv_fnptr = &TexParameterIuiv_Lazy;
        /// <summary> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => _TexParameterIuiv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterIuiv_Lazy(TextureTarget target, TextureParameterName pname, uint* parameters)
        {
            _TexParameterIuiv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIuiv");
            _TexParameterIuiv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameterIiv_fnptr = &GetTexParameterIiv_Lazy;
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameterIiv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterIiv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            _GetTexParameterIiv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIiv");
            _GetTexParameterIiv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void> _GetTexParameterIuiv_fnptr = &GetTexParameterIuiv_Lazy;
        /// <summary> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => _GetTexParameterIuiv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterIuiv_Lazy(TextureTarget target, GetTextureParameter pname, uint* parameters)
        {
            _GetTexParameterIuiv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIuiv");
            _GetTexParameterIuiv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _SamplerParameterIiv_fnptr = &SamplerParameterIiv_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void SamplerParameterIiv(SamplerHandle sampler, SamplerParameterI pname, int* param) => _SamplerParameterIiv_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameterIiv_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* param)
        {
            _SamplerParameterIiv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIiv");
            _SamplerParameterIiv_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _SamplerParameterIuiv_fnptr = &SamplerParameterIuiv_Lazy;
        /// <summary> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        public static void SamplerParameterIuiv(SamplerHandle sampler, SamplerParameterI pname, uint* param) => _SamplerParameterIuiv_fnptr(sampler, pname, param);
        [UnmanagedCallersOnly]
        private static void SamplerParameterIuiv_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* param)
        {
            _SamplerParameterIuiv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIuiv");
            _SamplerParameterIuiv_fnptr(sampler, pname, param);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _GetSamplerParameterIiv_fnptr = &GetSamplerParameterIiv_Lazy;
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        public static void GetSamplerParameterIiv(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => _GetSamplerParameterIiv_fnptr(sampler, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetSamplerParameterIiv_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* parameters)
        {
            _GetSamplerParameterIiv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIiv");
            _GetSamplerParameterIiv_fnptr(sampler, pname, parameters);
        }
        
        private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _GetSamplerParameterIuiv_fnptr = &GetSamplerParameterIuiv_Lazy;
        /// <summary> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        public static void GetSamplerParameterIuiv(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => _GetSamplerParameterIuiv_fnptr(sampler, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetSamplerParameterIuiv_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* parameters)
        {
            _GetSamplerParameterIuiv_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIuiv");
            _GetSamplerParameterIuiv_fnptr(sampler, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void> _TexBuffer_fnptr = &TexBuffer_Lazy;
        /// <summary> Attach a buffer object's data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => _TexBuffer_fnptr(target, internalformat, buffer);
        [UnmanagedCallersOnly]
        private static void TexBuffer_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer)
        {
            _TexBuffer_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glTexBuffer");
            _TexBuffer_fnptr(target, internalformat, buffer);
        }
        
        private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void> _TexBufferRange_fnptr = &TexBufferRange_Lazy;
        /// <summary> Attach a range of a buffer object's data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexBufferRange. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <param name="offset"> Specifies the offset of the start of the range of the buffer's data store to attach. </param>
        /// <param name="size"> Specifies the size of the range of the buffer's data store to attach. </param>
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => _TexBufferRange_fnptr(target, internalformat, buffer, offset, size);
        [UnmanagedCallersOnly]
        private static void TexBufferRange_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size)
        {
            _TexBufferRange_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glTexBufferRange");
            _TexBufferRange_fnptr(target, internalformat, buffer, offset, size);
        }
        
        private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, void> _TexStorage3DMultisample_fnptr = &TexStorage3DMultisample_Lazy;
        /// <summary> Specify storage for a two-dimensional multisample array texture. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in layers. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations) => _TexStorage3DMultisample_fnptr(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        [UnmanagedCallersOnly]
        private static void TexStorage3DMultisample_Lazy(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations)
        {
            _TexStorage3DMultisample_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage3DMultisample");
            _TexStorage3DMultisample_fnptr(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        }
        
        public static unsafe partial class AMD
        {
            private static delegate* unmanaged<RenderbufferTarget, int, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleAdvancedAMD_fnptr = &RenderbufferStorageMultisampleAdvancedAMD_Lazy;
            public static void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleAdvancedAMD_fnptr(target, samples, storageSamples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleAdvancedAMD_Lazy(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleAdvancedAMD_fnptr = (delegate* unmanaged<RenderbufferTarget, int, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleAdvancedAMD");
                _RenderbufferStorageMultisampleAdvancedAMD_fnptr(target, samples, storageSamples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<RenderbufferHandle, int, int, InternalFormat, int, int, void> _NamedRenderbufferStorageMultisampleAdvancedAMD_fnptr = &NamedRenderbufferStorageMultisampleAdvancedAMD_Lazy;
            public static void NamedRenderbufferStorageMultisampleAdvancedAMD(RenderbufferHandle renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => _NamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void NamedRenderbufferStorageMultisampleAdvancedAMD_Lazy(RenderbufferHandle renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height)
            {
                _NamedRenderbufferStorageMultisampleAdvancedAMD_fnptr = (delegate* unmanaged<RenderbufferHandle, int, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glNamedRenderbufferStorageMultisampleAdvancedAMD");
                _NamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<int*, int, uint*, void> _GetPerfMonitorGroupsAMD_fnptr = &GetPerfMonitorGroupsAMD_Lazy;
            public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => _GetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorGroupsAMD_Lazy(int* numGroups, int groupsSize, uint* groups)
            {
                _GetPerfMonitorGroupsAMD_fnptr = (delegate* unmanaged<int*, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorGroupsAMD");
                _GetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            }
            
            private static delegate* unmanaged<uint, int*, int*, int, uint*, void> _GetPerfMonitorCountersAMD_fnptr = &GetPerfMonitorCountersAMD_Lazy;
            public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => _GetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorCountersAMD_Lazy(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters)
            {
                _GetPerfMonitorCountersAMD_fnptr = (delegate* unmanaged<uint, int*, int*, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorCountersAMD");
                _GetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            }
            
            private static delegate* unmanaged<uint, int, int*, byte*, void> _GetPerfMonitorGroupStringAMD_fnptr = &GetPerfMonitorGroupStringAMD_Lazy;
            public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => _GetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorGroupStringAMD_Lazy(uint group, int bufSize, int* length, byte* groupString)
            {
                _GetPerfMonitorGroupStringAMD_fnptr = (delegate* unmanaged<uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorGroupStringAMD");
                _GetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            }
            
            private static delegate* unmanaged<uint, uint, int, int*, byte*, void> _GetPerfMonitorCounterStringAMD_fnptr = &GetPerfMonitorCounterStringAMD_Lazy;
            public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => _GetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorCounterStringAMD_Lazy(uint group, uint counter, int bufSize, int* length, byte* counterString)
            {
                _GetPerfMonitorCounterStringAMD_fnptr = (delegate* unmanaged<uint, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorCounterStringAMD");
                _GetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            }
            
            private static delegate* unmanaged<uint, uint, All, void*, void> _GetPerfMonitorCounterInfoAMD_fnptr = &GetPerfMonitorCounterInfoAMD_Lazy;
            public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, void* data) => _GetPerfMonitorCounterInfoAMD_fnptr(group, counter, pname, data);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorCounterInfoAMD_Lazy(uint group, uint counter, All pname, void* data)
            {
                _GetPerfMonitorCounterInfoAMD_fnptr = (delegate* unmanaged<uint, uint, All, void*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorCounterInfoAMD");
                _GetPerfMonitorCounterInfoAMD_fnptr(group, counter, pname, data);
            }
            
            private static delegate* unmanaged<int, uint*, void> _GenPerfMonitorsAMD_fnptr = &GenPerfMonitorsAMD_Lazy;
            public static void GenPerfMonitorsAMD(int n, uint* monitors) => _GenPerfMonitorsAMD_fnptr(n, monitors);
            [UnmanagedCallersOnly]
            private static void GenPerfMonitorsAMD_Lazy(int n, uint* monitors)
            {
                _GenPerfMonitorsAMD_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGenPerfMonitorsAMD");
                _GenPerfMonitorsAMD_fnptr(n, monitors);
            }
            
            private static delegate* unmanaged<int, uint*, void> _DeletePerfMonitorsAMD_fnptr = &DeletePerfMonitorsAMD_Lazy;
            public static void DeletePerfMonitorsAMD(int n, uint* monitors) => _DeletePerfMonitorsAMD_fnptr(n, monitors);
            [UnmanagedCallersOnly]
            private static void DeletePerfMonitorsAMD_Lazy(int n, uint* monitors)
            {
                _DeletePerfMonitorsAMD_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glDeletePerfMonitorsAMD");
                _DeletePerfMonitorsAMD_fnptr(n, monitors);
            }
            
            private static delegate* unmanaged<uint, byte, uint, int, uint*, void> _SelectPerfMonitorCountersAMD_fnptr = &SelectPerfMonitorCountersAMD_Lazy;
            public static void SelectPerfMonitorCountersAMD(uint monitor, byte enable, uint group, int numCounters, uint* counterList) => _SelectPerfMonitorCountersAMD_fnptr(monitor, enable, group, numCounters, counterList);
            [UnmanagedCallersOnly]
            private static void SelectPerfMonitorCountersAMD_Lazy(uint monitor, byte enable, uint group, int numCounters, uint* counterList)
            {
                _SelectPerfMonitorCountersAMD_fnptr = (delegate* unmanaged<uint, byte, uint, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glSelectPerfMonitorCountersAMD");
                _SelectPerfMonitorCountersAMD_fnptr(monitor, enable, group, numCounters, counterList);
            }
            
            private static delegate* unmanaged<uint, void> _BeginPerfMonitorAMD_fnptr = &BeginPerfMonitorAMD_Lazy;
            public static void BeginPerfMonitorAMD(uint monitor) => _BeginPerfMonitorAMD_fnptr(monitor);
            [UnmanagedCallersOnly]
            private static void BeginPerfMonitorAMD_Lazy(uint monitor)
            {
                _BeginPerfMonitorAMD_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glBeginPerfMonitorAMD");
                _BeginPerfMonitorAMD_fnptr(monitor);
            }
            
            private static delegate* unmanaged<uint, void> _EndPerfMonitorAMD_fnptr = &EndPerfMonitorAMD_Lazy;
            public static void EndPerfMonitorAMD(uint monitor) => _EndPerfMonitorAMD_fnptr(monitor);
            [UnmanagedCallersOnly]
            private static void EndPerfMonitorAMD_Lazy(uint monitor)
            {
                _EndPerfMonitorAMD_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glEndPerfMonitorAMD");
                _EndPerfMonitorAMD_fnptr(monitor);
            }
            
            private static delegate* unmanaged<uint, All, int, uint*, int*, void> _GetPerfMonitorCounterDataAMD_fnptr = &GetPerfMonitorCounterDataAMD_Lazy;
            public static void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => _GetPerfMonitorCounterDataAMD_fnptr(monitor, pname, dataSize, data, bytesWritten);
            [UnmanagedCallersOnly]
            private static void GetPerfMonitorCounterDataAMD_Lazy(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten)
            {
                _GetPerfMonitorCounterDataAMD_fnptr = (delegate* unmanaged<uint, All, int, uint*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfMonitorCounterDataAMD");
                _GetPerfMonitorCounterDataAMD_fnptr(monitor, pname, dataSize, data, bytesWritten);
            }
            
        }
        public static unsafe partial class ANGLE
        {
            private static delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void> _BlitFramebufferANGLE_fnptr = &BlitFramebufferANGLE_Lazy;
            public static void BlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => _BlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            [UnmanagedCallersOnly]
            private static void BlitFramebufferANGLE_Lazy(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
            {
                _BlitFramebufferANGLE_fnptr = (delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void>)GLLoader.BindingsContext.GetProcAddress("glBlitFramebufferANGLE");
                _BlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleANGLE_fnptr = &RenderbufferStorageMultisampleANGLE_Lazy;
            public static void RenderbufferStorageMultisampleANGLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleANGLE_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleANGLE_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleANGLE_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleANGLE");
                _RenderbufferStorageMultisampleANGLE_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, int, int, void> _DrawArraysInstancedANGLE_fnptr = &DrawArraysInstancedANGLE_Lazy;
            public static void DrawArraysInstancedANGLE(PrimitiveType mode, int first, int count, int primcount) => _DrawArraysInstancedANGLE_fnptr(mode, first, count, primcount);
            [UnmanagedCallersOnly]
            private static void DrawArraysInstancedANGLE_Lazy(PrimitiveType mode, int first, int count, int primcount)
            {
                _DrawArraysInstancedANGLE_fnptr = (delegate* unmanaged<PrimitiveType, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysInstancedANGLE");
                _DrawArraysInstancedANGLE_fnptr(mode, first, count, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, void> _DrawElementsInstancedANGLE_fnptr = &DrawElementsInstancedANGLE_Lazy;
            public static void DrawElementsInstancedANGLE(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount) => _DrawElementsInstancedANGLE_fnptr(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedANGLE_Lazy(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount)
            {
                _DrawElementsInstancedANGLE_fnptr = (delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedANGLE");
                _DrawElementsInstancedANGLE_fnptr(mode, count, type, indices, primcount);
            }
            
            private static delegate* unmanaged<uint, uint, void> _VertexAttribDivisorANGLE_fnptr = &VertexAttribDivisorANGLE_Lazy;
            public static void VertexAttribDivisorANGLE(uint index, uint divisor) => _VertexAttribDivisorANGLE_fnptr(index, divisor);
            [UnmanagedCallersOnly]
            private static void VertexAttribDivisorANGLE_Lazy(uint index, uint divisor)
            {
                _VertexAttribDivisorANGLE_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribDivisorANGLE");
                _VertexAttribDivisorANGLE_fnptr(index, divisor);
            }
            
            private static delegate* unmanaged<ShaderHandle, int, int*, byte*, void> _GetTranslatedShaderSourceANGLE_fnptr = &GetTranslatedShaderSourceANGLE_Lazy;
            public static void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int* length, byte* source) => _GetTranslatedShaderSourceANGLE_fnptr(shader, bufSize, length, source);
            [UnmanagedCallersOnly]
            private static void GetTranslatedShaderSourceANGLE_Lazy(ShaderHandle shader, int bufSize, int* length, byte* source)
            {
                _GetTranslatedShaderSourceANGLE_fnptr = (delegate* unmanaged<ShaderHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTranslatedShaderSourceANGLE");
                _GetTranslatedShaderSourceANGLE_fnptr(shader, bufSize, length, source);
            }
            
        }
        public static unsafe partial class APPLE
        {
            private static delegate* unmanaged<uint, uint, int, int, void> _CopyTextureLevelsAPPLE_fnptr = &CopyTextureLevelsAPPLE_Lazy;
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => _CopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            [UnmanagedCallersOnly]
            private static void CopyTextureLevelsAPPLE_Lazy(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount)
            {
                _CopyTextureLevelsAPPLE_fnptr = (delegate* unmanaged<uint, uint, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTextureLevelsAPPLE");
                _CopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleAPPLE_fnptr = &RenderbufferStorageMultisampleAPPLE_Lazy;
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleAPPLE_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleAPPLE_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleAPPLE_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleAPPLE");
                _RenderbufferStorageMultisampleAPPLE_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<void> _ResolveMultisampleFramebufferAPPLE_fnptr = &ResolveMultisampleFramebufferAPPLE_Lazy;
            public static void ResolveMultisampleFramebufferAPPLE() => _ResolveMultisampleFramebufferAPPLE_fnptr();
            [UnmanagedCallersOnly]
            private static void ResolveMultisampleFramebufferAPPLE_Lazy()
            {
                _ResolveMultisampleFramebufferAPPLE_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glResolveMultisampleFramebufferAPPLE");
                _ResolveMultisampleFramebufferAPPLE_fnptr();
            }
            
            private static delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr> _FenceSyncAPPLE_fnptr = &FenceSyncAPPLE_Lazy;
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) _FenceSyncAPPLE_fnptr(condition, flags);
            [UnmanagedCallersOnly]
            private static IntPtr FenceSyncAPPLE_Lazy(SyncCondition condition, SyncBehaviorFlags flags)
            {
                _FenceSyncAPPLE_fnptr = (delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glFenceSyncAPPLE");
                return _FenceSyncAPPLE_fnptr(condition, flags);
            }
            
            private static delegate* unmanaged<GLSync, byte> _IsSyncAPPLE_fnptr = &IsSyncAPPLE_Lazy;
            public static byte IsSyncAPPLE(GLSync sync) => _IsSyncAPPLE_fnptr(sync);
            [UnmanagedCallersOnly]
            private static byte IsSyncAPPLE_Lazy(GLSync sync)
            {
                _IsSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, byte>)GLLoader.BindingsContext.GetProcAddress("glIsSyncAPPLE");
                return _IsSyncAPPLE_fnptr(sync);
            }
            
            private static delegate* unmanaged<GLSync, void> _DeleteSyncAPPLE_fnptr = &DeleteSyncAPPLE_Lazy;
            public static void DeleteSyncAPPLE(GLSync sync) => _DeleteSyncAPPLE_fnptr(sync);
            [UnmanagedCallersOnly]
            private static void DeleteSyncAPPLE_Lazy(GLSync sync)
            {
                _DeleteSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteSyncAPPLE");
                _DeleteSyncAPPLE_fnptr(sync);
            }
            
            private static delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus> _ClientWaitSyncAPPLE_fnptr = &ClientWaitSyncAPPLE_Lazy;
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => _ClientWaitSyncAPPLE_fnptr(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static SyncStatus ClientWaitSyncAPPLE_Lazy(GLSync sync, SyncObjectMask flags, ulong timeout)
            {
                _ClientWaitSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)GLLoader.BindingsContext.GetProcAddress("glClientWaitSyncAPPLE");
                return _ClientWaitSyncAPPLE_fnptr(sync, flags, timeout);
            }
            
            private static delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void> _WaitSyncAPPLE_fnptr = &WaitSyncAPPLE_Lazy;
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => _WaitSyncAPPLE_fnptr(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static void WaitSyncAPPLE_Lazy(GLSync sync, SyncBehaviorFlags flags, ulong timeout)
            {
                _WaitSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glWaitSyncAPPLE");
                _WaitSyncAPPLE_fnptr(sync, flags, timeout);
            }
            
            private static delegate* unmanaged<GetPName, long*, void> _GetInteger64vAPPLE_fnptr = &GetInteger64vAPPLE_Lazy;
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => _GetInteger64vAPPLE_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetInteger64vAPPLE_Lazy(GetPName pname, long* parameters)
            {
                _GetInteger64vAPPLE_fnptr = (delegate* unmanaged<GetPName, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInteger64vAPPLE");
                _GetInteger64vAPPLE_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void> _GetSyncivAPPLE_fnptr = &GetSyncivAPPLE_Lazy;
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => _GetSyncivAPPLE_fnptr(sync, pname, count, length, values);
            [UnmanagedCallersOnly]
            private static void GetSyncivAPPLE_Lazy(GLSync sync, SyncParameterName pname, int count, int* length, int* values)
            {
                _GetSyncivAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSyncivAPPLE");
                _GetSyncivAPPLE_fnptr(sync, pname, count, length, values);
            }
            
        }
        public static unsafe partial class EXT
        {
            private static delegate* unmanaged<All, void*, int*, void> _EGLImageTargetTexStorageEXT_fnptr = &EGLImageTargetTexStorageEXT_Lazy;
            public static void EGLImageTargetTexStorageEXT(All target, void* image, int* attrib_list) => _EGLImageTargetTexStorageEXT_fnptr(target, image, attrib_list);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetTexStorageEXT_Lazy(All target, void* image, int* attrib_list)
            {
                _EGLImageTargetTexStorageEXT_fnptr = (delegate* unmanaged<All, void*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetTexStorageEXT");
                _EGLImageTargetTexStorageEXT_fnptr(target, image, attrib_list);
            }
            
            private static delegate* unmanaged<TextureHandle, void*, int*, void> _EGLImageTargetTextureStorageEXT_fnptr = &EGLImageTargetTextureStorageEXT_Lazy;
            public static void EGLImageTargetTextureStorageEXT(TextureHandle texture, void* image, int* attrib_list) => _EGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetTextureStorageEXT_Lazy(TextureHandle texture, void* image, int* attrib_list)
            {
                _EGLImageTargetTextureStorageEXT_fnptr = (delegate* unmanaged<TextureHandle, void*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetTextureStorageEXT");
                _EGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, int, int, uint, void> _DrawArraysInstancedBaseInstanceEXT_fnptr = &DrawArraysInstancedBaseInstanceEXT_Lazy;
            public static void DrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => _DrawArraysInstancedBaseInstanceEXT_fnptr(mode, first, count, instancecount, baseinstance);
            [UnmanagedCallersOnly]
            private static void DrawArraysInstancedBaseInstanceEXT_Lazy(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
            {
                _DrawArraysInstancedBaseInstanceEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, int, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysInstancedBaseInstanceEXT");
                _DrawArraysInstancedBaseInstanceEXT_fnptr(mode, first, count, instancecount, baseinstance);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, uint, void> _DrawElementsInstancedBaseInstanceEXT_fnptr = &DrawElementsInstancedBaseInstanceEXT_Lazy;
            public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, PrimitiveType type, void* indices, int instancecount, uint baseinstance) => _DrawElementsInstancedBaseInstanceEXT_fnptr(mode, count, type, indices, instancecount, baseinstance);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedBaseInstanceEXT_Lazy(PrimitiveType mode, int count, PrimitiveType type, void* indices, int instancecount, uint baseinstance)
            {
                _DrawElementsInstancedBaseInstanceEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedBaseInstanceEXT");
                _DrawElementsInstancedBaseInstanceEXT_fnptr(mode, count, type, indices, instancecount, baseinstance);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, uint, void> _DrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr = &DrawElementsInstancedBaseVertexBaseInstanceEXT_Lazy;
            public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => _DrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr(mode, count, type, indices, instancecount, basevertex, baseinstance);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedBaseVertexBaseInstanceEXT_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance)
            {
                _DrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedBaseVertexBaseInstanceEXT");
                _DrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr(mode, count, type, indices, instancecount, basevertex, baseinstance);
            }
            
            private static delegate* unmanaged<ProgramHandle, uint, uint, byte*, void> _BindFragDataLocationIndexedEXT_fnptr = &BindFragDataLocationIndexedEXT_Lazy;
            public static void BindFragDataLocationIndexedEXT(ProgramHandle program, uint colorNumber, uint index, byte* name) => _BindFragDataLocationIndexedEXT_fnptr(program, colorNumber, index, name);
            [UnmanagedCallersOnly]
            private static void BindFragDataLocationIndexedEXT_Lazy(ProgramHandle program, uint colorNumber, uint index, byte* name)
            {
                _BindFragDataLocationIndexedEXT_fnptr = (delegate* unmanaged<ProgramHandle, uint, uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glBindFragDataLocationIndexedEXT");
                _BindFragDataLocationIndexedEXT_fnptr(program, colorNumber, index, name);
            }
            
            private static delegate* unmanaged<ProgramHandle, uint, byte*, void> _BindFragDataLocationEXT_fnptr = &BindFragDataLocationEXT_Lazy;
            public static void BindFragDataLocationEXT(ProgramHandle program, uint color, byte* name) => _BindFragDataLocationEXT_fnptr(program, color, name);
            [UnmanagedCallersOnly]
            private static void BindFragDataLocationEXT_Lazy(ProgramHandle program, uint color, byte* name)
            {
                _BindFragDataLocationEXT_fnptr = (delegate* unmanaged<ProgramHandle, uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glBindFragDataLocationEXT");
                _BindFragDataLocationEXT_fnptr(program, color, name);
            }
            
            private static delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, int> _GetProgramResourceLocationIndexEXT_fnptr = &GetProgramResourceLocationIndexEXT_Lazy;
            public static int GetProgramResourceLocationIndexEXT(ProgramHandle program, ProgramInterface programInterface, byte* name) => _GetProgramResourceLocationIndexEXT_fnptr(program, programInterface, name);
            [UnmanagedCallersOnly]
            private static int GetProgramResourceLocationIndexEXT_Lazy(ProgramHandle program, ProgramInterface programInterface, byte* name)
            {
                _GetProgramResourceLocationIndexEXT_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourceLocationIndexEXT");
                return _GetProgramResourceLocationIndexEXT_fnptr(program, programInterface, name);
            }
            
            private static delegate* unmanaged<ProgramHandle, byte*, int> _GetFragDataIndexEXT_fnptr = &GetFragDataIndexEXT_Lazy;
            public static int GetFragDataIndexEXT(ProgramHandle program, byte* name) => _GetFragDataIndexEXT_fnptr(program, name);
            [UnmanagedCallersOnly]
            private static int GetFragDataIndexEXT_Lazy(ProgramHandle program, byte* name)
            {
                _GetFragDataIndexEXT_fnptr = (delegate* unmanaged<ProgramHandle, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glGetFragDataIndexEXT");
                return _GetFragDataIndexEXT_fnptr(program, name);
            }
            
            private static delegate* unmanaged<BlendEquationModeEXT, void> _BlendEquationEXT_fnptr = &BlendEquationEXT_Lazy;
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => _BlendEquationEXT_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationEXT_Lazy(BlendEquationModeEXT mode)
            {
                _BlendEquationEXT_fnptr = (delegate* unmanaged<BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationEXT");
                _BlendEquationEXT_fnptr(mode);
            }
            
            private static delegate* unmanaged<BufferStorageTarget, nint, void*, BufferStorageMask, void> _BufferStorageEXT_fnptr = &BufferStorageEXT_Lazy;
            public static void BufferStorageEXT(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => _BufferStorageEXT_fnptr(target, size, data, flags);
            [UnmanagedCallersOnly]
            private static void BufferStorageEXT_Lazy(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags)
            {
                _BufferStorageEXT_fnptr = (delegate* unmanaged<BufferStorageTarget, nint, void*, BufferStorageMask, void>)GLLoader.BindingsContext.GetProcAddress("glBufferStorageEXT");
                _BufferStorageEXT_fnptr(target, size, data, flags);
            }
            
            private static delegate* unmanaged<TextureHandle, int, PixelFormat, PixelType, void*, void> _ClearTexImageEXT_fnptr = &ClearTexImageEXT_Lazy;
            public static void ClearTexImageEXT(TextureHandle texture, int level, PixelFormat format, PixelType type, void* data) => _ClearTexImageEXT_fnptr(texture, level, format, type, data);
            [UnmanagedCallersOnly]
            private static void ClearTexImageEXT_Lazy(TextureHandle texture, int level, PixelFormat format, PixelType type, void* data)
            {
                _ClearTexImageEXT_fnptr = (delegate* unmanaged<TextureHandle, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glClearTexImageEXT");
                _ClearTexImageEXT_fnptr(texture, level, format, type, data);
            }
            
            private static delegate* unmanaged<TextureHandle, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _ClearTexSubImageEXT_fnptr = &ClearTexSubImageEXT_Lazy;
            public static void ClearTexSubImageEXT(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => _ClearTexSubImageEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
            [UnmanagedCallersOnly]
            private static void ClearTexSubImageEXT_Lazy(TextureHandle texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data)
            {
                _ClearTexSubImageEXT_fnptr = (delegate* unmanaged<TextureHandle, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glClearTexSubImageEXT");
                _ClearTexSubImageEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
            }
            
            private static delegate* unmanaged<All, All, void> _ClipControlEXT_fnptr = &ClipControlEXT_Lazy;
            public static void ClipControlEXT(All origin, All depth) => _ClipControlEXT_fnptr(origin, depth);
            [UnmanagedCallersOnly]
            private static void ClipControlEXT_Lazy(All origin, All depth)
            {
                _ClipControlEXT_fnptr = (delegate* unmanaged<All, All, void>)GLLoader.BindingsContext.GetProcAddress("glClipControlEXT");
                _ClipControlEXT_fnptr(origin, depth);
            }
            
            private static delegate* unmanaged<uint, CopyBufferSubDataTarget, int, int, int, int, uint, CopyBufferSubDataTarget, int, int, int, int, int, int, int, void> _CopyImageSubDataEXT_fnptr = &CopyImageSubDataEXT_Lazy;
            public static void CopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => _CopyImageSubDataEXT_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            [UnmanagedCallersOnly]
            private static void CopyImageSubDataEXT_Lazy(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
            {
                _CopyImageSubDataEXT_fnptr = (delegate* unmanaged<uint, CopyBufferSubDataTarget, int, int, int, int, uint, CopyBufferSubDataTarget, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyImageSubDataEXT");
                _CopyImageSubDataEXT_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            }
            
            private static delegate* unmanaged<All, uint, int, byte*, void> _LabelObjectEXT_fnptr = &LabelObjectEXT_Lazy;
            public static void LabelObjectEXT(All type, uint obj, int length, byte* label) => _LabelObjectEXT_fnptr(type, obj, length, label);
            [UnmanagedCallersOnly]
            private static void LabelObjectEXT_Lazy(All type, uint obj, int length, byte* label)
            {
                _LabelObjectEXT_fnptr = (delegate* unmanaged<All, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glLabelObjectEXT");
                _LabelObjectEXT_fnptr(type, obj, length, label);
            }
            
            private static delegate* unmanaged<All, uint, int, int*, byte*, void> _GetObjectLabelEXT_fnptr = &GetObjectLabelEXT_Lazy;
            public static void GetObjectLabelEXT(All type, uint obj, int bufSize, int* length, byte* label) => _GetObjectLabelEXT_fnptr(type, obj, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabelEXT_Lazy(All type, uint obj, int bufSize, int* length, byte* label)
            {
                _GetObjectLabelEXT_fnptr = (delegate* unmanaged<All, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabelEXT");
                _GetObjectLabelEXT_fnptr(type, obj, bufSize, length, label);
            }
            
            private static delegate* unmanaged<int, byte*, void> _InsertEventMarkerEXT_fnptr = &InsertEventMarkerEXT_Lazy;
            public static void InsertEventMarkerEXT(int length, byte* marker) => _InsertEventMarkerEXT_fnptr(length, marker);
            [UnmanagedCallersOnly]
            private static void InsertEventMarkerEXT_Lazy(int length, byte* marker)
            {
                _InsertEventMarkerEXT_fnptr = (delegate* unmanaged<int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glInsertEventMarkerEXT");
                _InsertEventMarkerEXT_fnptr(length, marker);
            }
            
            private static delegate* unmanaged<int, byte*, void> _PushGroupMarkerEXT_fnptr = &PushGroupMarkerEXT_Lazy;
            public static void PushGroupMarkerEXT(int length, byte* marker) => _PushGroupMarkerEXT_fnptr(length, marker);
            [UnmanagedCallersOnly]
            private static void PushGroupMarkerEXT_Lazy(int length, byte* marker)
            {
                _PushGroupMarkerEXT_fnptr = (delegate* unmanaged<int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushGroupMarkerEXT");
                _PushGroupMarkerEXT_fnptr(length, marker);
            }
            
            private static delegate* unmanaged<void> _PopGroupMarkerEXT_fnptr = &PopGroupMarkerEXT_Lazy;
            public static void PopGroupMarkerEXT() => _PopGroupMarkerEXT_fnptr();
            [UnmanagedCallersOnly]
            private static void PopGroupMarkerEXT_Lazy()
            {
                _PopGroupMarkerEXT_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopGroupMarkerEXT");
                _PopGroupMarkerEXT_fnptr();
            }
            
            private static delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void> _DiscardFramebufferEXT_fnptr = &DiscardFramebufferEXT_Lazy;
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => _DiscardFramebufferEXT_fnptr(target, numAttachments, attachments);
            [UnmanagedCallersOnly]
            private static void DiscardFramebufferEXT_Lazy(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
            {
                _DiscardFramebufferEXT_fnptr = (delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)GLLoader.BindingsContext.GetProcAddress("glDiscardFramebufferEXT");
                _DiscardFramebufferEXT_fnptr(target, numAttachments, attachments);
            }
            
            private static delegate* unmanaged<int, QueryHandle*, void> _GenQueriesEXT_fnptr = &GenQueriesEXT_Lazy;
            public static void GenQueriesEXT(int n, QueryHandle* ids) => _GenQueriesEXT_fnptr(n, ids);
            [UnmanagedCallersOnly]
            private static void GenQueriesEXT_Lazy(int n, QueryHandle* ids)
            {
                _GenQueriesEXT_fnptr = (delegate* unmanaged<int, QueryHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenQueriesEXT");
                _GenQueriesEXT_fnptr(n, ids);
            }
            
            private static delegate* unmanaged<int, QueryHandle*, void> _DeleteQueriesEXT_fnptr = &DeleteQueriesEXT_Lazy;
            public static void DeleteQueriesEXT(int n, QueryHandle* ids) => _DeleteQueriesEXT_fnptr(n, ids);
            [UnmanagedCallersOnly]
            private static void DeleteQueriesEXT_Lazy(int n, QueryHandle* ids)
            {
                _DeleteQueriesEXT_fnptr = (delegate* unmanaged<int, QueryHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteQueriesEXT");
                _DeleteQueriesEXT_fnptr(n, ids);
            }
            
            private static delegate* unmanaged<QueryHandle, byte> _IsQueryEXT_fnptr = &IsQueryEXT_Lazy;
            public static byte IsQueryEXT(QueryHandle id) => _IsQueryEXT_fnptr(id);
            [UnmanagedCallersOnly]
            private static byte IsQueryEXT_Lazy(QueryHandle id)
            {
                _IsQueryEXT_fnptr = (delegate* unmanaged<QueryHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsQueryEXT");
                return _IsQueryEXT_fnptr(id);
            }
            
            private static delegate* unmanaged<QueryTarget, QueryHandle, void> _BeginQueryEXT_fnptr = &BeginQueryEXT_Lazy;
            public static void BeginQueryEXT(QueryTarget target, QueryHandle id) => _BeginQueryEXT_fnptr(target, id);
            [UnmanagedCallersOnly]
            private static void BeginQueryEXT_Lazy(QueryTarget target, QueryHandle id)
            {
                _BeginQueryEXT_fnptr = (delegate* unmanaged<QueryTarget, QueryHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBeginQueryEXT");
                _BeginQueryEXT_fnptr(target, id);
            }
            
            private static delegate* unmanaged<QueryTarget, void> _EndQueryEXT_fnptr = &EndQueryEXT_Lazy;
            public static void EndQueryEXT(QueryTarget target) => _EndQueryEXT_fnptr(target);
            [UnmanagedCallersOnly]
            private static void EndQueryEXT_Lazy(QueryTarget target)
            {
                _EndQueryEXT_fnptr = (delegate* unmanaged<QueryTarget, void>)GLLoader.BindingsContext.GetProcAddress("glEndQueryEXT");
                _EndQueryEXT_fnptr(target);
            }
            
            private static delegate* unmanaged<QueryHandle, QueryCounterTarget, void> _QueryCounterEXT_fnptr = &QueryCounterEXT_Lazy;
            public static void QueryCounterEXT(QueryHandle id, QueryCounterTarget target) => _QueryCounterEXT_fnptr(id, target);
            [UnmanagedCallersOnly]
            private static void QueryCounterEXT_Lazy(QueryHandle id, QueryCounterTarget target)
            {
                _QueryCounterEXT_fnptr = (delegate* unmanaged<QueryHandle, QueryCounterTarget, void>)GLLoader.BindingsContext.GetProcAddress("glQueryCounterEXT");
                _QueryCounterEXT_fnptr(id, target);
            }
            
            private static delegate* unmanaged<QueryTarget, QueryParameterName, int*, void> _GetQueryivEXT_fnptr = &GetQueryivEXT_Lazy;
            public static void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int* parameters) => _GetQueryivEXT_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetQueryivEXT_Lazy(QueryTarget target, QueryParameterName pname, int* parameters)
            {
                _GetQueryivEXT_fnptr = (delegate* unmanaged<QueryTarget, QueryParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryivEXT");
                _GetQueryivEXT_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<QueryHandle, QueryObjectParameterName, int*, void> _GetQueryObjectivEXT_fnptr = &GetQueryObjectivEXT_Lazy;
            public static void GetQueryObjectivEXT(QueryHandle id, QueryObjectParameterName pname, int* parameters) => _GetQueryObjectivEXT_fnptr(id, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetQueryObjectivEXT_Lazy(QueryHandle id, QueryObjectParameterName pname, int* parameters)
            {
                _GetQueryObjectivEXT_fnptr = (delegate* unmanaged<QueryHandle, QueryObjectParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryObjectivEXT");
                _GetQueryObjectivEXT_fnptr(id, pname, parameters);
            }
            
            private static delegate* unmanaged<QueryHandle, QueryObjectParameterName, uint*, void> _GetQueryObjectuivEXT_fnptr = &GetQueryObjectuivEXT_Lazy;
            public static void GetQueryObjectuivEXT(QueryHandle id, QueryObjectParameterName pname, uint* parameters) => _GetQueryObjectuivEXT_fnptr(id, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetQueryObjectuivEXT_Lazy(QueryHandle id, QueryObjectParameterName pname, uint* parameters)
            {
                _GetQueryObjectuivEXT_fnptr = (delegate* unmanaged<QueryHandle, QueryObjectParameterName, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryObjectuivEXT");
                _GetQueryObjectuivEXT_fnptr(id, pname, parameters);
            }
            
            private static delegate* unmanaged<QueryHandle, QueryObjectParameterName, long*, void> _GetQueryObjecti64vEXT_fnptr = &GetQueryObjecti64vEXT_Lazy;
            public static void GetQueryObjecti64vEXT(QueryHandle id, QueryObjectParameterName pname, long* parameters) => _GetQueryObjecti64vEXT_fnptr(id, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetQueryObjecti64vEXT_Lazy(QueryHandle id, QueryObjectParameterName pname, long* parameters)
            {
                _GetQueryObjecti64vEXT_fnptr = (delegate* unmanaged<QueryHandle, QueryObjectParameterName, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryObjecti64vEXT");
                _GetQueryObjecti64vEXT_fnptr(id, pname, parameters);
            }
            
            private static delegate* unmanaged<QueryHandle, QueryObjectParameterName, ulong*, void> _GetQueryObjectui64vEXT_fnptr = &GetQueryObjectui64vEXT_Lazy;
            public static void GetQueryObjectui64vEXT(QueryHandle id, QueryObjectParameterName pname, ulong* parameters) => _GetQueryObjectui64vEXT_fnptr(id, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetQueryObjectui64vEXT_Lazy(QueryHandle id, QueryObjectParameterName pname, ulong* parameters)
            {
                _GetQueryObjectui64vEXT_fnptr = (delegate* unmanaged<QueryHandle, QueryObjectParameterName, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glGetQueryObjectui64vEXT");
                _GetQueryObjectui64vEXT_fnptr(id, pname, parameters);
            }
            
            private static delegate* unmanaged<GetPName, long*, void> _GetInteger64vEXT_fnptr = &GetInteger64vEXT_Lazy;
            public static void GetInteger64vEXT(GetPName pname, long* data) => _GetInteger64vEXT_fnptr(pname, data);
            [UnmanagedCallersOnly]
            private static void GetInteger64vEXT_Lazy(GetPName pname, long* data)
            {
                _GetInteger64vEXT_fnptr = (delegate* unmanaged<GetPName, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInteger64vEXT");
                _GetInteger64vEXT_fnptr(pname, data);
            }
            
            private static delegate* unmanaged<int, All*, void> _DrawBuffersEXT_fnptr = &DrawBuffersEXT_Lazy;
            public static void DrawBuffersEXT(int n, All* bufs) => _DrawBuffersEXT_fnptr(n, bufs);
            [UnmanagedCallersOnly]
            private static void DrawBuffersEXT_Lazy(int n, All* bufs)
            {
                _DrawBuffersEXT_fnptr = (delegate* unmanaged<int, All*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawBuffersEXT");
                _DrawBuffersEXT_fnptr(n, bufs);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _EnableiEXT_fnptr = &EnableiEXT_Lazy;
            public static void EnableiEXT(EnableCap target, uint index) => _EnableiEXT_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void EnableiEXT_Lazy(EnableCap target, uint index)
            {
                _EnableiEXT_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableiEXT");
                _EnableiEXT_fnptr(target, index);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _DisableiEXT_fnptr = &DisableiEXT_Lazy;
            public static void DisableiEXT(EnableCap target, uint index) => _DisableiEXT_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void DisableiEXT_Lazy(EnableCap target, uint index)
            {
                _DisableiEXT_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableiEXT");
                _DisableiEXT_fnptr(target, index);
            }
            
            private static delegate* unmanaged<uint, BlendEquationModeEXT, void> _BlendEquationiEXT_fnptr = &BlendEquationiEXT_Lazy;
            public static void BlendEquationiEXT(uint buf, BlendEquationModeEXT mode) => _BlendEquationiEXT_fnptr(buf, mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationiEXT_Lazy(uint buf, BlendEquationModeEXT mode)
            {
                _BlendEquationiEXT_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationiEXT");
                _BlendEquationiEXT_fnptr(buf, mode);
            }
            
            private static delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void> _BlendEquationSeparateiEXT_fnptr = &BlendEquationSeparateiEXT_Lazy;
            public static void BlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => _BlendEquationSeparateiEXT_fnptr(buf, modeRGB, modeAlpha);
            [UnmanagedCallersOnly]
            private static void BlendEquationSeparateiEXT_Lazy(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
            {
                _BlendEquationSeparateiEXT_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparateiEXT");
                _BlendEquationSeparateiEXT_fnptr(buf, modeRGB, modeAlpha);
            }
            
            private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void> _BlendFunciEXT_fnptr = &BlendFunciEXT_Lazy;
            public static void BlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst) => _BlendFunciEXT_fnptr(buf, src, dst);
            [UnmanagedCallersOnly]
            private static void BlendFunciEXT_Lazy(uint buf, BlendingFactor src, BlendingFactor dst)
            {
                _BlendFunciEXT_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFunciEXT");
                _BlendFunciEXT_fnptr(buf, src, dst);
            }
            
            private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> _BlendFuncSeparateiEXT_fnptr = &BlendFuncSeparateiEXT_Lazy;
            public static void BlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => _BlendFuncSeparateiEXT_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            [UnmanagedCallersOnly]
            private static void BlendFuncSeparateiEXT_Lazy(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
            {
                _BlendFuncSeparateiEXT_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparateiEXT");
                _BlendFuncSeparateiEXT_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
            
            private static delegate* unmanaged<uint, byte, byte, byte, byte, void> _ColorMaskiEXT_fnptr = &ColorMaskiEXT_Lazy;
            public static void ColorMaskiEXT(uint index, byte r, byte g, byte b, byte a) => _ColorMaskiEXT_fnptr(index, r, g, b, a);
            [UnmanagedCallersOnly]
            private static void ColorMaskiEXT_Lazy(uint index, byte r, byte g, byte b, byte a)
            {
                _ColorMaskiEXT_fnptr = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColorMaskiEXT");
                _ColorMaskiEXT_fnptr(index, r, g, b, a);
            }
            
            private static delegate* unmanaged<EnableCap, uint, byte> _IsEnablediEXT_fnptr = &IsEnablediEXT_Lazy;
            public static byte IsEnablediEXT(EnableCap target, uint index) => _IsEnablediEXT_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static byte IsEnablediEXT_Lazy(EnableCap target, uint index)
            {
                _IsEnablediEXT_fnptr = (delegate* unmanaged<EnableCap, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnablediEXT");
                return _IsEnablediEXT_fnptr(target, index);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void> _DrawElementsBaseVertexEXT_fnptr = &DrawElementsBaseVertexEXT_Lazy;
            public static void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => _DrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawElementsBaseVertexEXT_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex)
            {
                _DrawElementsBaseVertexEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsBaseVertexEXT");
                _DrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void> _DrawRangeElementsBaseVertexEXT_fnptr = &DrawRangeElementsBaseVertexEXT_Lazy;
            public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => _DrawRangeElementsBaseVertexEXT_fnptr(mode, start, end, count, type, indices, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawRangeElementsBaseVertexEXT_Lazy(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex)
            {
                _DrawRangeElementsBaseVertexEXT_fnptr = (delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawRangeElementsBaseVertexEXT");
                _DrawRangeElementsBaseVertexEXT_fnptr(mode, start, end, count, type, indices, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void> _DrawElementsInstancedBaseVertexEXT_fnptr = &DrawElementsInstancedBaseVertexEXT_Lazy;
            public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => _DrawElementsInstancedBaseVertexEXT_fnptr(mode, count, type, indices, instancecount, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedBaseVertexEXT_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex)
            {
                _DrawElementsInstancedBaseVertexEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedBaseVertexEXT");
                _DrawElementsInstancedBaseVertexEXT_fnptr(mode, count, type, indices, instancecount, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, int*, void> _MultiDrawElementsBaseVertexEXT_fnptr = &MultiDrawElementsBaseVertexEXT_Lazy;
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => _MultiDrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, drawcount, basevertex);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsBaseVertexEXT_Lazy(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex)
            {
                _MultiDrawElementsBaseVertexEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsBaseVertexEXT");
                _MultiDrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, drawcount, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, int, int, void> _DrawArraysInstancedEXT_fnptr = &DrawArraysInstancedEXT_Lazy;
            public static void DrawArraysInstancedEXT(PrimitiveType mode, int start, int count, int primcount) => _DrawArraysInstancedEXT_fnptr(mode, start, count, primcount);
            [UnmanagedCallersOnly]
            private static void DrawArraysInstancedEXT_Lazy(PrimitiveType mode, int start, int count, int primcount)
            {
                _DrawArraysInstancedEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysInstancedEXT");
                _DrawArraysInstancedEXT_fnptr(mode, start, count, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void> _DrawElementsInstancedEXT_fnptr = &DrawElementsInstancedEXT_Lazy;
            public static void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => _DrawElementsInstancedEXT_fnptr(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedEXT_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount)
            {
                _DrawElementsInstancedEXT_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedEXT");
                _DrawElementsInstancedEXT_fnptr(mode, count, type, indices, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, TransformFeedbackHandle, void> _DrawTransformFeedbackEXT_fnptr = &DrawTransformFeedbackEXT_Lazy;
            public static void DrawTransformFeedbackEXT(PrimitiveType mode, TransformFeedbackHandle id) => _DrawTransformFeedbackEXT_fnptr(mode, id);
            [UnmanagedCallersOnly]
            private static void DrawTransformFeedbackEXT_Lazy(PrimitiveType mode, TransformFeedbackHandle id)
            {
                _DrawTransformFeedbackEXT_fnptr = (delegate* unmanaged<PrimitiveType, TransformFeedbackHandle, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTransformFeedbackEXT");
                _DrawTransformFeedbackEXT_fnptr(mode, id);
            }
            
            private static delegate* unmanaged<PrimitiveType, TransformFeedbackHandle, int, void> _DrawTransformFeedbackInstancedEXT_fnptr = &DrawTransformFeedbackInstancedEXT_Lazy;
            public static void DrawTransformFeedbackInstancedEXT(PrimitiveType mode, TransformFeedbackHandle id, int instancecount) => _DrawTransformFeedbackInstancedEXT_fnptr(mode, id, instancecount);
            [UnmanagedCallersOnly]
            private static void DrawTransformFeedbackInstancedEXT_Lazy(PrimitiveType mode, TransformFeedbackHandle id, int instancecount)
            {
                _DrawTransformFeedbackInstancedEXT_fnptr = (delegate* unmanaged<PrimitiveType, TransformFeedbackHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTransformFeedbackInstancedEXT");
                _DrawTransformFeedbackInstancedEXT_fnptr(mode, id, instancecount);
            }
            
            private static delegate* unmanaged<All, IntPtr, nint, void*, BufferStorageMask, void> _BufferStorageExternalEXT_fnptr = &BufferStorageExternalEXT_Lazy;
            public static void BufferStorageExternalEXT(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => _BufferStorageExternalEXT_fnptr(target, offset, size, clientBuffer, flags);
            [UnmanagedCallersOnly]
            private static void BufferStorageExternalEXT_Lazy(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags)
            {
                _BufferStorageExternalEXT_fnptr = (delegate* unmanaged<All, IntPtr, nint, void*, BufferStorageMask, void>)GLLoader.BindingsContext.GetProcAddress("glBufferStorageExternalEXT");
                _BufferStorageExternalEXT_fnptr(target, offset, size, clientBuffer, flags);
            }
            
            private static delegate* unmanaged<BufferHandle, IntPtr, nint, void*, BufferStorageMask, void> _NamedBufferStorageExternalEXT_fnptr = &NamedBufferStorageExternalEXT_Lazy;
            public static void NamedBufferStorageExternalEXT(BufferHandle buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => _NamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, flags);
            [UnmanagedCallersOnly]
            private static void NamedBufferStorageExternalEXT_Lazy(BufferHandle buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags)
            {
                _NamedBufferStorageExternalEXT_fnptr = (delegate* unmanaged<BufferHandle, IntPtr, nint, void*, BufferStorageMask, void>)GLLoader.BindingsContext.GetProcAddress("glNamedBufferStorageExternalEXT");
                _NamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, flags);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void> _FramebufferTextureEXT_fnptr = &FramebufferTextureEXT_Lazy;
            public static void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => _FramebufferTextureEXT_fnptr(target, attachment, texture, level);
            [UnmanagedCallersOnly]
            private static void FramebufferTextureEXT_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level)
            {
                _FramebufferTextureEXT_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureEXT");
                _FramebufferTextureEXT_fnptr(target, attachment, texture, level);
            }
            
            private static delegate* unmanaged<uint, uint, void> _VertexAttribDivisorEXT_fnptr = &VertexAttribDivisorEXT_Lazy;
            public static void VertexAttribDivisorEXT(uint index, uint divisor) => _VertexAttribDivisorEXT_fnptr(index, divisor);
            [UnmanagedCallersOnly]
            private static void VertexAttribDivisorEXT_Lazy(uint index, uint divisor)
            {
                _VertexAttribDivisorEXT_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribDivisorEXT");
                _VertexAttribDivisorEXT_fnptr(index, divisor);
            }
            
            private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*> _MapBufferRangeEXT_fnptr = &MapBufferRangeEXT_Lazy;
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => _MapBufferRangeEXT_fnptr(target, offset, length, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access)
            {
                _MapBufferRangeEXT_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)GLLoader.BindingsContext.GetProcAddress("glMapBufferRangeEXT");
                return _MapBufferRangeEXT_fnptr(target, offset, length, access);
            }
            
            private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, void> _FlushMappedBufferRangeEXT_fnptr = &FlushMappedBufferRangeEXT_Lazy;
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => _FlushMappedBufferRangeEXT_fnptr(target, offset, length);
            [UnmanagedCallersOnly]
            private static void FlushMappedBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length)
            {
                _FlushMappedBufferRangeEXT_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glFlushMappedBufferRangeEXT");
                _FlushMappedBufferRangeEXT_fnptr(target, offset, length);
            }
            
            private static delegate* unmanaged<GetPName, byte*, void> _GetUnsignedBytevEXT_fnptr = &GetUnsignedBytevEXT_Lazy;
            public static void GetUnsignedBytevEXT(GetPName pname, byte* data) => _GetUnsignedBytevEXT_fnptr(pname, data);
            [UnmanagedCallersOnly]
            private static void GetUnsignedBytevEXT_Lazy(GetPName pname, byte* data)
            {
                _GetUnsignedBytevEXT_fnptr = (delegate* unmanaged<GetPName, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUnsignedBytevEXT");
                _GetUnsignedBytevEXT_fnptr(pname, data);
            }
            
            private static delegate* unmanaged<All, uint, byte*, void> _GetUnsignedBytei_vEXT_fnptr = &GetUnsignedBytei_vEXT_Lazy;
            public static void GetUnsignedBytei_vEXT(All target, uint index, byte* data) => _GetUnsignedBytei_vEXT_fnptr(target, index, data);
            [UnmanagedCallersOnly]
            private static void GetUnsignedBytei_vEXT_Lazy(All target, uint index, byte* data)
            {
                _GetUnsignedBytei_vEXT_fnptr = (delegate* unmanaged<All, uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUnsignedBytei_vEXT");
                _GetUnsignedBytei_vEXT_fnptr(target, index, data);
            }
            
            private static delegate* unmanaged<int, uint*, void> _DeleteMemoryObjectsEXT_fnptr = &DeleteMemoryObjectsEXT_Lazy;
            public static void DeleteMemoryObjectsEXT(int n, uint* memoryObjects) => _DeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            [UnmanagedCallersOnly]
            private static void DeleteMemoryObjectsEXT_Lazy(int n, uint* memoryObjects)
            {
                _DeleteMemoryObjectsEXT_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteMemoryObjectsEXT");
                _DeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            }
            
            private static delegate* unmanaged<uint, byte> _IsMemoryObjectEXT_fnptr = &IsMemoryObjectEXT_Lazy;
            public static byte IsMemoryObjectEXT(uint memoryObject) => _IsMemoryObjectEXT_fnptr(memoryObject);
            [UnmanagedCallersOnly]
            private static byte IsMemoryObjectEXT_Lazy(uint memoryObject)
            {
                _IsMemoryObjectEXT_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsMemoryObjectEXT");
                return _IsMemoryObjectEXT_fnptr(memoryObject);
            }
            
            private static delegate* unmanaged<int, uint*, void> _CreateMemoryObjectsEXT_fnptr = &CreateMemoryObjectsEXT_Lazy;
            public static void CreateMemoryObjectsEXT(int n, uint* memoryObjects) => _CreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            [UnmanagedCallersOnly]
            private static void CreateMemoryObjectsEXT_Lazy(int n, uint* memoryObjects)
            {
                _CreateMemoryObjectsEXT_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glCreateMemoryObjectsEXT");
                _CreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            }
            
            private static delegate* unmanaged<uint, MemoryObjectParameterName, int*, void> _MemoryObjectParameterivEXT_fnptr = &MemoryObjectParameterivEXT_Lazy;
            public static void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => _MemoryObjectParameterivEXT_fnptr(memoryObject, pname, parameters);
            [UnmanagedCallersOnly]
            private static void MemoryObjectParameterivEXT_Lazy(uint memoryObject, MemoryObjectParameterName pname, int* parameters)
            {
                _MemoryObjectParameterivEXT_fnptr = (delegate* unmanaged<uint, MemoryObjectParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMemoryObjectParameterivEXT");
                _MemoryObjectParameterivEXT_fnptr(memoryObject, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, MemoryObjectParameterName, int*, void> _GetMemoryObjectParameterivEXT_fnptr = &GetMemoryObjectParameterivEXT_Lazy;
            public static void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => _GetMemoryObjectParameterivEXT_fnptr(memoryObject, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetMemoryObjectParameterivEXT_Lazy(uint memoryObject, MemoryObjectParameterName pname, int* parameters)
            {
                _GetMemoryObjectParameterivEXT_fnptr = (delegate* unmanaged<uint, MemoryObjectParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMemoryObjectParameterivEXT");
                _GetMemoryObjectParameterivEXT_fnptr(memoryObject, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, uint, ulong, void> _TexStorageMem2DEXT_fnptr = &TexStorageMem2DEXT_Lazy;
            public static void TexStorageMem2DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => _TexStorageMem2DEXT_fnptr(target, levels, internalFormat, width, height, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexStorageMem2DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset)
            {
                _TexStorageMem2DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorageMem2DEXT");
                _TexStorageMem2DEXT_fnptr(target, levels, internalFormat, width, height, memory, offset);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, byte, uint, ulong, void> _TexStorageMem2DMultisampleEXT_fnptr = &TexStorageMem2DMultisampleEXT_Lazy;
            public static void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset) => _TexStorageMem2DMultisampleEXT_fnptr(target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexStorageMem2DMultisampleEXT_Lazy(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset)
            {
                _TexStorageMem2DMultisampleEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, byte, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorageMem2DMultisampleEXT");
                _TexStorageMem2DMultisampleEXT_fnptr(target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, uint, ulong, void> _TexStorageMem3DEXT_fnptr = &TexStorageMem3DEXT_Lazy;
            public static void TexStorageMem3DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => _TexStorageMem3DEXT_fnptr(target, levels, internalFormat, width, height, depth, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexStorageMem3DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset)
            {
                _TexStorageMem3DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorageMem3DEXT");
                _TexStorageMem3DEXT_fnptr(target, levels, internalFormat, width, height, depth, memory, offset);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, uint, ulong, void> _TexStorageMem3DMultisampleEXT_fnptr = &TexStorageMem3DMultisampleEXT_Lazy;
            public static void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset) => _TexStorageMem3DMultisampleEXT_fnptr(target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexStorageMem3DMultisampleEXT_Lazy(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset)
            {
                _TexStorageMem3DMultisampleEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorageMem3DMultisampleEXT");
                _TexStorageMem3DMultisampleEXT_fnptr(target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            }
            
            private static delegate* unmanaged<BufferTargetARB, nint, uint, ulong, void> _BufferStorageMemEXT_fnptr = &BufferStorageMemEXT_Lazy;
            public static void BufferStorageMemEXT(BufferTargetARB target, nint size, uint memory, ulong offset) => _BufferStorageMemEXT_fnptr(target, size, memory, offset);
            [UnmanagedCallersOnly]
            private static void BufferStorageMemEXT_Lazy(BufferTargetARB target, nint size, uint memory, ulong offset)
            {
                _BufferStorageMemEXT_fnptr = (delegate* unmanaged<BufferTargetARB, nint, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glBufferStorageMemEXT");
                _BufferStorageMemEXT_fnptr(target, size, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, uint, ulong, void> _TextureStorageMem2DEXT_fnptr = &TextureStorageMem2DEXT_Lazy;
            public static void TextureStorageMem2DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => _TextureStorageMem2DEXT_fnptr(texture, levels, internalFormat, width, height, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureStorageMem2DEXT_Lazy(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset)
            {
                _TextureStorageMem2DEXT_fnptr = (delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorageMem2DEXT");
                _TextureStorageMem2DEXT_fnptr(texture, levels, internalFormat, width, height, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, byte, uint, ulong, void> _TextureStorageMem2DMultisampleEXT_fnptr = &TextureStorageMem2DMultisampleEXT_Lazy;
            public static void TextureStorageMem2DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset) => _TextureStorageMem2DMultisampleEXT_fnptr(texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureStorageMem2DMultisampleEXT_Lazy(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, byte fixedSampleLocations, uint memory, ulong offset)
            {
                _TextureStorageMem2DMultisampleEXT_fnptr = (delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, byte, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorageMem2DMultisampleEXT");
                _TextureStorageMem2DMultisampleEXT_fnptr(texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, int, uint, ulong, void> _TextureStorageMem3DEXT_fnptr = &TextureStorageMem3DEXT_Lazy;
            public static void TextureStorageMem3DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => _TextureStorageMem3DEXT_fnptr(texture, levels, internalFormat, width, height, depth, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureStorageMem3DEXT_Lazy(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset)
            {
                _TextureStorageMem3DEXT_fnptr = (delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorageMem3DEXT");
                _TextureStorageMem3DEXT_fnptr(texture, levels, internalFormat, width, height, depth, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, int, byte, uint, ulong, void> _TextureStorageMem3DMultisampleEXT_fnptr = &TextureStorageMem3DMultisampleEXT_Lazy;
            public static void TextureStorageMem3DMultisampleEXT(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset) => _TextureStorageMem3DMultisampleEXT_fnptr(texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureStorageMem3DMultisampleEXT_Lazy(TextureHandle texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, ulong offset)
            {
                _TextureStorageMem3DMultisampleEXT_fnptr = (delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, int, int, byte, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorageMem3DMultisampleEXT");
                _TextureStorageMem3DMultisampleEXT_fnptr(texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
            }
            
            private static delegate* unmanaged<BufferHandle, nint, uint, ulong, void> _NamedBufferStorageMemEXT_fnptr = &NamedBufferStorageMemEXT_Lazy;
            public static void NamedBufferStorageMemEXT(BufferHandle buffer, nint size, uint memory, ulong offset) => _NamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            [UnmanagedCallersOnly]
            private static void NamedBufferStorageMemEXT_Lazy(BufferHandle buffer, nint size, uint memory, ulong offset)
            {
                _NamedBufferStorageMemEXT_fnptr = (delegate* unmanaged<BufferHandle, nint, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glNamedBufferStorageMemEXT");
                _NamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, uint, ulong, void> _TexStorageMem1DEXT_fnptr = &TexStorageMem1DEXT_Lazy;
            public static void TexStorageMem1DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => _TexStorageMem1DEXT_fnptr(target, levels, internalFormat, width, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexStorageMem1DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset)
            {
                _TexStorageMem1DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorageMem1DEXT");
                _TexStorageMem1DEXT_fnptr(target, levels, internalFormat, width, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, uint, ulong, void> _TextureStorageMem1DEXT_fnptr = &TextureStorageMem1DEXT_Lazy;
            public static void TextureStorageMem1DEXT(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => _TextureStorageMem1DEXT_fnptr(texture, levels, internalFormat, width, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureStorageMem1DEXT_Lazy(TextureHandle texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset)
            {
                _TextureStorageMem1DEXT_fnptr = (delegate* unmanaged<TextureHandle, int, SizedInternalFormat, int, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorageMem1DEXT");
                _TextureStorageMem1DEXT_fnptr(texture, levels, internalFormat, width, memory, offset);
            }
            
            private static delegate* unmanaged<uint, ulong, ExternalHandleType, int, void> _ImportMemoryFdEXT_fnptr = &ImportMemoryFdEXT_Lazy;
            public static void ImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => _ImportMemoryFdEXT_fnptr(memory, size, handleType, fd);
            [UnmanagedCallersOnly]
            private static void ImportMemoryFdEXT_Lazy(uint memory, ulong size, ExternalHandleType handleType, int fd)
            {
                _ImportMemoryFdEXT_fnptr = (delegate* unmanaged<uint, ulong, ExternalHandleType, int, void>)GLLoader.BindingsContext.GetProcAddress("glImportMemoryFdEXT");
                _ImportMemoryFdEXT_fnptr(memory, size, handleType, fd);
            }
            
            private static delegate* unmanaged<uint, ulong, ExternalHandleType, void*, void> _ImportMemoryWin32HandleEXT_fnptr = &ImportMemoryWin32HandleEXT_Lazy;
            public static void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void* handle) => _ImportMemoryWin32HandleEXT_fnptr(memory, size, handleType, handle);
            [UnmanagedCallersOnly]
            private static void ImportMemoryWin32HandleEXT_Lazy(uint memory, ulong size, ExternalHandleType handleType, void* handle)
            {
                _ImportMemoryWin32HandleEXT_fnptr = (delegate* unmanaged<uint, ulong, ExternalHandleType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glImportMemoryWin32HandleEXT");
                _ImportMemoryWin32HandleEXT_fnptr(memory, size, handleType, handle);
            }
            
            private static delegate* unmanaged<uint, ulong, ExternalHandleType, void*, void> _ImportMemoryWin32NameEXT_fnptr = &ImportMemoryWin32NameEXT_Lazy;
            public static void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void* name) => _ImportMemoryWin32NameEXT_fnptr(memory, size, handleType, name);
            [UnmanagedCallersOnly]
            private static void ImportMemoryWin32NameEXT_Lazy(uint memory, ulong size, ExternalHandleType handleType, void* name)
            {
                _ImportMemoryWin32NameEXT_fnptr = (delegate* unmanaged<uint, ulong, ExternalHandleType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glImportMemoryWin32NameEXT");
                _ImportMemoryWin32NameEXT_fnptr(memory, size, handleType, name);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, int*, int, void> _MultiDrawArraysEXT_fnptr = &MultiDrawArraysEXT_Lazy;
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => _MultiDrawArraysEXT_fnptr(mode, first, count, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawArraysEXT_Lazy(PrimitiveType mode, int* first, int* count, int primcount)
            {
                _MultiDrawArraysEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, int*, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawArraysEXT");
                _MultiDrawArraysEXT_fnptr(mode, first, count, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void> _MultiDrawElementsEXT_fnptr = &MultiDrawElementsEXT_Lazy;
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => _MultiDrawElementsEXT_fnptr(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsEXT_Lazy(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount)
            {
                _MultiDrawElementsEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsEXT");
                _MultiDrawElementsEXT_fnptr(mode, count, type, indices, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, void*, int, int, void> _MultiDrawArraysIndirectEXT_fnptr = &MultiDrawArraysIndirectEXT_Lazy;
            public static void MultiDrawArraysIndirectEXT(PrimitiveType mode, void* indirect, int drawcount, int stride) => _MultiDrawArraysIndirectEXT_fnptr(mode, indirect, drawcount, stride);
            [UnmanagedCallersOnly]
            private static void MultiDrawArraysIndirectEXT_Lazy(PrimitiveType mode, void* indirect, int drawcount, int stride)
            {
                _MultiDrawArraysIndirectEXT_fnptr = (delegate* unmanaged<PrimitiveType, void*, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawArraysIndirectEXT");
                _MultiDrawArraysIndirectEXT_fnptr(mode, indirect, drawcount, stride);
            }
            
            private static delegate* unmanaged<PrimitiveType, DrawElementsType, void*, int, int, void> _MultiDrawElementsIndirectEXT_fnptr = &MultiDrawElementsIndirectEXT_Lazy;
            public static void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => _MultiDrawElementsIndirectEXT_fnptr(mode, type, indirect, drawcount, stride);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsIndirectEXT_Lazy(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride)
            {
                _MultiDrawElementsIndirectEXT_fnptr = (delegate* unmanaged<PrimitiveType, DrawElementsType, void*, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsIndirectEXT");
                _MultiDrawElementsIndirectEXT_fnptr(mode, type, indirect, drawcount, stride);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleEXT_fnptr = &RenderbufferStorageMultisampleEXT_Lazy;
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleEXT_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleEXT_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleEXT_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleEXT");
                _RenderbufferStorageMultisampleEXT_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void> _FramebufferTexture2DMultisampleEXT_fnptr = &FramebufferTexture2DMultisampleEXT_Lazy;
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => _FramebufferTexture2DMultisampleEXT_fnptr(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleEXT_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                _FramebufferTexture2DMultisampleEXT_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleEXT");
                _FramebufferTexture2DMultisampleEXT_fnptr(target, attachment, textarget, texture, level, samples);
            }
            
            private static delegate* unmanaged<ReadBufferMode, int, void> _ReadBufferIndexedEXT_fnptr = &ReadBufferIndexedEXT_Lazy;
            public static void ReadBufferIndexedEXT(ReadBufferMode src, int index) => _ReadBufferIndexedEXT_fnptr(src, index);
            [UnmanagedCallersOnly]
            private static void ReadBufferIndexedEXT_Lazy(ReadBufferMode src, int index)
            {
                _ReadBufferIndexedEXT_fnptr = (delegate* unmanaged<ReadBufferMode, int, void>)GLLoader.BindingsContext.GetProcAddress("glReadBufferIndexedEXT");
                _ReadBufferIndexedEXT_fnptr(src, index);
            }
            
            private static delegate* unmanaged<int, All*, int*, void> _DrawBuffersIndexedEXT_fnptr = &DrawBuffersIndexedEXT_Lazy;
            public static void DrawBuffersIndexedEXT(int n, All* location, int* indices) => _DrawBuffersIndexedEXT_fnptr(n, location, indices);
            [UnmanagedCallersOnly]
            private static void DrawBuffersIndexedEXT_Lazy(int n, All* location, int* indices)
            {
                _DrawBuffersIndexedEXT_fnptr = (delegate* unmanaged<int, All*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawBuffersIndexedEXT");
                _DrawBuffersIndexedEXT_fnptr(n, location, indices);
            }
            
            private static delegate* unmanaged<GetPName, uint, int*, void> _GetIntegeri_vEXT_fnptr = &GetIntegeri_vEXT_Lazy;
            public static void GetIntegeri_vEXT(GetPName target, uint index, int* data) => _GetIntegeri_vEXT_fnptr(target, index, data);
            [UnmanagedCallersOnly]
            private static void GetIntegeri_vEXT_Lazy(GetPName target, uint index, int* data)
            {
                _GetIntegeri_vEXT_fnptr = (delegate* unmanaged<GetPName, uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetIntegeri_vEXT");
                _GetIntegeri_vEXT_fnptr(target, index, data);
            }
            
            private static delegate* unmanaged<float, float, float, void> _PolygonOffsetClampEXT_fnptr = &PolygonOffsetClampEXT_Lazy;
            public static void PolygonOffsetClampEXT(float factor, float units, float clamp) => _PolygonOffsetClampEXT_fnptr(factor, units, clamp);
            [UnmanagedCallersOnly]
            private static void PolygonOffsetClampEXT_Lazy(float factor, float units, float clamp)
            {
                _PolygonOffsetClampEXT_fnptr = (delegate* unmanaged<float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonOffsetClampEXT");
                _PolygonOffsetClampEXT_fnptr(factor, units, clamp);
            }
            
            private static delegate* unmanaged<float, float, float, float, float, float, float, float, void> _PrimitiveBoundingBoxEXT_fnptr = &PrimitiveBoundingBoxEXT_Lazy;
            public static void PrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => _PrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            [UnmanagedCallersOnly]
            private static void PrimitiveBoundingBoxEXT_Lazy(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
            {
                _PrimitiveBoundingBoxEXT_fnptr = (delegate* unmanaged<float, float, float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPrimitiveBoundingBoxEXT");
                _PrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            }
            
            private static delegate* unmanaged<uint, byte, void> _RasterSamplesEXT_fnptr = &RasterSamplesEXT_Lazy;
            public static void RasterSamplesEXT(uint samples, byte fixedsamplelocations) => _RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            [UnmanagedCallersOnly]
            private static void RasterSamplesEXT_Lazy(uint samples, byte fixedsamplelocations)
            {
                _RasterSamplesEXT_fnptr = (delegate* unmanaged<uint, byte, void>)GLLoader.BindingsContext.GetProcAddress("glRasterSamplesEXT");
                _RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            }
            
            private static delegate* unmanaged<GraphicsResetStatus> _GetGraphicsResetStatusEXT_fnptr = &GetGraphicsResetStatusEXT_Lazy;
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => _GetGraphicsResetStatusEXT_fnptr();
            [UnmanagedCallersOnly]
            private static GraphicsResetStatus GetGraphicsResetStatusEXT_Lazy()
            {
                _GetGraphicsResetStatusEXT_fnptr = (delegate* unmanaged<GraphicsResetStatus>)GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatusEXT");
                return _GetGraphicsResetStatusEXT_fnptr();
            }
            
            private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void> _ReadnPixelsEXT_fnptr = &ReadnPixelsEXT_Lazy;
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => _ReadnPixelsEXT_fnptr(x, y, width, height, format, type, bufSize, data);
            [UnmanagedCallersOnly]
            private static void ReadnPixelsEXT_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
            {
                _ReadnPixelsEXT_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadnPixelsEXT");
                _ReadnPixelsEXT_fnptr(x, y, width, height, format, type, bufSize, data);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _GetnUniformfvEXT_fnptr = &GetnUniformfvEXT_Lazy;
            public static void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, float* parameters) => _GetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformfvEXT_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
            {
                _GetnUniformfvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformfvEXT");
                _GetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _GetnUniformivEXT_fnptr = &GetnUniformivEXT_Lazy;
            public static void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, int* parameters) => _GetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformivEXT_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
            {
                _GetnUniformivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformivEXT");
                _GetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<int, uint*, void> _GenSemaphoresEXT_fnptr = &GenSemaphoresEXT_Lazy;
            public static void GenSemaphoresEXT(int n, uint* semaphores) => _GenSemaphoresEXT_fnptr(n, semaphores);
            [UnmanagedCallersOnly]
            private static void GenSemaphoresEXT_Lazy(int n, uint* semaphores)
            {
                _GenSemaphoresEXT_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGenSemaphoresEXT");
                _GenSemaphoresEXT_fnptr(n, semaphores);
            }
            
            private static delegate* unmanaged<int, uint*, void> _DeleteSemaphoresEXT_fnptr = &DeleteSemaphoresEXT_Lazy;
            public static void DeleteSemaphoresEXT(int n, uint* semaphores) => _DeleteSemaphoresEXT_fnptr(n, semaphores);
            [UnmanagedCallersOnly]
            private static void DeleteSemaphoresEXT_Lazy(int n, uint* semaphores)
            {
                _DeleteSemaphoresEXT_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteSemaphoresEXT");
                _DeleteSemaphoresEXT_fnptr(n, semaphores);
            }
            
            private static delegate* unmanaged<uint, byte> _IsSemaphoreEXT_fnptr = &IsSemaphoreEXT_Lazy;
            public static byte IsSemaphoreEXT(uint semaphore) => _IsSemaphoreEXT_fnptr(semaphore);
            [UnmanagedCallersOnly]
            private static byte IsSemaphoreEXT_Lazy(uint semaphore)
            {
                _IsSemaphoreEXT_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsSemaphoreEXT");
                return _IsSemaphoreEXT_fnptr(semaphore);
            }
            
            private static delegate* unmanaged<uint, SemaphoreParameterName, ulong*, void> _SemaphoreParameterui64vEXT_fnptr = &SemaphoreParameterui64vEXT_Lazy;
            public static void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => _SemaphoreParameterui64vEXT_fnptr(semaphore, pname, parameters);
            [UnmanagedCallersOnly]
            private static void SemaphoreParameterui64vEXT_Lazy(uint semaphore, SemaphoreParameterName pname, ulong* parameters)
            {
                _SemaphoreParameterui64vEXT_fnptr = (delegate* unmanaged<uint, SemaphoreParameterName, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glSemaphoreParameterui64vEXT");
                _SemaphoreParameterui64vEXT_fnptr(semaphore, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, SemaphoreParameterName, ulong*, void> _GetSemaphoreParameterui64vEXT_fnptr = &GetSemaphoreParameterui64vEXT_Lazy;
            public static void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => _GetSemaphoreParameterui64vEXT_fnptr(semaphore, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSemaphoreParameterui64vEXT_Lazy(uint semaphore, SemaphoreParameterName pname, ulong* parameters)
            {
                _GetSemaphoreParameterui64vEXT_fnptr = (delegate* unmanaged<uint, SemaphoreParameterName, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSemaphoreParameterui64vEXT");
                _GetSemaphoreParameterui64vEXT_fnptr(semaphore, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, uint, BufferHandle*, uint, TextureHandle*, TextureLayout*, void> _WaitSemaphoreEXT_fnptr = &WaitSemaphoreEXT_Lazy;
            public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* srcLayouts) => _WaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);
            [UnmanagedCallersOnly]
            private static void WaitSemaphoreEXT_Lazy(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* srcLayouts)
            {
                _WaitSemaphoreEXT_fnptr = (delegate* unmanaged<uint, uint, BufferHandle*, uint, TextureHandle*, TextureLayout*, void>)GLLoader.BindingsContext.GetProcAddress("glWaitSemaphoreEXT");
                _WaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);
            }
            
            private static delegate* unmanaged<uint, uint, BufferHandle*, uint, TextureHandle*, TextureLayout*, void> _SignalSemaphoreEXT_fnptr = &SignalSemaphoreEXT_Lazy;
            public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* dstLayouts) => _SignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
            [UnmanagedCallersOnly]
            private static void SignalSemaphoreEXT_Lazy(uint semaphore, uint numBufferBarriers, BufferHandle* buffers, uint numTextureBarriers, TextureHandle* textures, TextureLayout* dstLayouts)
            {
                _SignalSemaphoreEXT_fnptr = (delegate* unmanaged<uint, uint, BufferHandle*, uint, TextureHandle*, TextureLayout*, void>)GLLoader.BindingsContext.GetProcAddress("glSignalSemaphoreEXT");
                _SignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
            }
            
            private static delegate* unmanaged<uint, ExternalHandleType, int, void> _ImportSemaphoreFdEXT_fnptr = &ImportSemaphoreFdEXT_Lazy;
            public static void ImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => _ImportSemaphoreFdEXT_fnptr(semaphore, handleType, fd);
            [UnmanagedCallersOnly]
            private static void ImportSemaphoreFdEXT_Lazy(uint semaphore, ExternalHandleType handleType, int fd)
            {
                _ImportSemaphoreFdEXT_fnptr = (delegate* unmanaged<uint, ExternalHandleType, int, void>)GLLoader.BindingsContext.GetProcAddress("glImportSemaphoreFdEXT");
                _ImportSemaphoreFdEXT_fnptr(semaphore, handleType, fd);
            }
            
            private static delegate* unmanaged<uint, ExternalHandleType, void*, void> _ImportSemaphoreWin32HandleEXT_fnptr = &ImportSemaphoreWin32HandleEXT_Lazy;
            public static void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void* handle) => _ImportSemaphoreWin32HandleEXT_fnptr(semaphore, handleType, handle);
            [UnmanagedCallersOnly]
            private static void ImportSemaphoreWin32HandleEXT_Lazy(uint semaphore, ExternalHandleType handleType, void* handle)
            {
                _ImportSemaphoreWin32HandleEXT_fnptr = (delegate* unmanaged<uint, ExternalHandleType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glImportSemaphoreWin32HandleEXT");
                _ImportSemaphoreWin32HandleEXT_fnptr(semaphore, handleType, handle);
            }
            
            private static delegate* unmanaged<uint, ExternalHandleType, void*, void> _ImportSemaphoreWin32NameEXT_fnptr = &ImportSemaphoreWin32NameEXT_Lazy;
            public static void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void* name) => _ImportSemaphoreWin32NameEXT_fnptr(semaphore, handleType, name);
            [UnmanagedCallersOnly]
            private static void ImportSemaphoreWin32NameEXT_Lazy(uint semaphore, ExternalHandleType handleType, void* name)
            {
                _ImportSemaphoreWin32NameEXT_fnptr = (delegate* unmanaged<uint, ExternalHandleType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glImportSemaphoreWin32NameEXT");
                _ImportSemaphoreWin32NameEXT_fnptr(semaphore, handleType, name);
            }
            
            private static delegate* unmanaged<All, ProgramHandle, void> _UseShaderProgramEXT_fnptr = &UseShaderProgramEXT_Lazy;
            public static void UseShaderProgramEXT(All type, ProgramHandle program) => _UseShaderProgramEXT_fnptr(type, program);
            [UnmanagedCallersOnly]
            private static void UseShaderProgramEXT_Lazy(All type, ProgramHandle program)
            {
                _UseShaderProgramEXT_fnptr = (delegate* unmanaged<All, ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glUseShaderProgramEXT");
                _UseShaderProgramEXT_fnptr(type, program);
            }
            
            private static delegate* unmanaged<ProgramHandle, void> _ActiveProgramEXT_fnptr = &ActiveProgramEXT_Lazy;
            public static void ActiveProgramEXT(ProgramHandle program) => _ActiveProgramEXT_fnptr(program);
            [UnmanagedCallersOnly]
            private static void ActiveProgramEXT_Lazy(ProgramHandle program)
            {
                _ActiveProgramEXT_fnptr = (delegate* unmanaged<ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glActiveProgramEXT");
                _ActiveProgramEXT_fnptr(program);
            }
            
            private static delegate* unmanaged<ShaderType, byte*, int> _CreateShaderProgramEXT_fnptr = &CreateShaderProgramEXT_Lazy;
            public static ProgramHandle CreateShaderProgramEXT(ShaderType type, byte* str) => (ProgramHandle) _CreateShaderProgramEXT_fnptr(type, str);
            [UnmanagedCallersOnly]
            private static int CreateShaderProgramEXT_Lazy(ShaderType type, byte* str)
            {
                _CreateShaderProgramEXT_fnptr = (delegate* unmanaged<ShaderType, byte*, int>)GLLoader.BindingsContext.GetProcAddress("glCreateShaderProgramEXT");
                return _CreateShaderProgramEXT_fnptr(type, str);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, ProgramHandle, void> _ActiveShaderProgramEXT_fnptr = &ActiveShaderProgramEXT_Lazy;
            public static void ActiveShaderProgramEXT(ProgramPipelineHandle pipeline, ProgramHandle program) => _ActiveShaderProgramEXT_fnptr(pipeline, program);
            [UnmanagedCallersOnly]
            private static void ActiveShaderProgramEXT_Lazy(ProgramPipelineHandle pipeline, ProgramHandle program)
            {
                _ActiveShaderProgramEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glActiveShaderProgramEXT");
                _ActiveShaderProgramEXT_fnptr(pipeline, program);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, void> _BindProgramPipelineEXT_fnptr = &BindProgramPipelineEXT_Lazy;
            public static void BindProgramPipelineEXT(ProgramPipelineHandle pipeline) => _BindProgramPipelineEXT_fnptr(pipeline);
            [UnmanagedCallersOnly]
            private static void BindProgramPipelineEXT_Lazy(ProgramPipelineHandle pipeline)
            {
                _BindProgramPipelineEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindProgramPipelineEXT");
                _BindProgramPipelineEXT_fnptr(pipeline);
            }
            
            private static delegate* unmanaged<ShaderType, int, byte**, int> _CreateShaderProgramvEXT_fnptr = &CreateShaderProgramvEXT_Lazy;
            public static ProgramHandle CreateShaderProgramvEXT(ShaderType type, int count, byte** strings) => (ProgramHandle) _CreateShaderProgramvEXT_fnptr(type, count, strings);
            [UnmanagedCallersOnly]
            private static int CreateShaderProgramvEXT_Lazy(ShaderType type, int count, byte** strings)
            {
                _CreateShaderProgramvEXT_fnptr = (delegate* unmanaged<ShaderType, int, byte**, int>)GLLoader.BindingsContext.GetProcAddress("glCreateShaderProgramvEXT");
                return _CreateShaderProgramvEXT_fnptr(type, count, strings);
            }
            
            private static delegate* unmanaged<int, ProgramPipelineHandle*, void> _DeleteProgramPipelinesEXT_fnptr = &DeleteProgramPipelinesEXT_Lazy;
            public static void DeleteProgramPipelinesEXT(int n, ProgramPipelineHandle* pipelines) => _DeleteProgramPipelinesEXT_fnptr(n, pipelines);
            [UnmanagedCallersOnly]
            private static void DeleteProgramPipelinesEXT_Lazy(int n, ProgramPipelineHandle* pipelines)
            {
                _DeleteProgramPipelinesEXT_fnptr = (delegate* unmanaged<int, ProgramPipelineHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteProgramPipelinesEXT");
                _DeleteProgramPipelinesEXT_fnptr(n, pipelines);
            }
            
            private static delegate* unmanaged<int, ProgramPipelineHandle*, void> _GenProgramPipelinesEXT_fnptr = &GenProgramPipelinesEXT_Lazy;
            public static void GenProgramPipelinesEXT(int n, ProgramPipelineHandle* pipelines) => _GenProgramPipelinesEXT_fnptr(n, pipelines);
            [UnmanagedCallersOnly]
            private static void GenProgramPipelinesEXT_Lazy(int n, ProgramPipelineHandle* pipelines)
            {
                _GenProgramPipelinesEXT_fnptr = (delegate* unmanaged<int, ProgramPipelineHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenProgramPipelinesEXT");
                _GenProgramPipelinesEXT_fnptr(n, pipelines);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, int, int*, byte*, void> _GetProgramPipelineInfoLogEXT_fnptr = &GetProgramPipelineInfoLogEXT_Lazy;
            public static void GetProgramPipelineInfoLogEXT(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog) => _GetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            [UnmanagedCallersOnly]
            private static void GetProgramPipelineInfoLogEXT_Lazy(ProgramPipelineHandle pipeline, int bufSize, int* length, byte* infoLog)
            {
                _GetProgramPipelineInfoLogEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramPipelineInfoLogEXT");
                _GetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, PipelineParameterName, int*, void> _GetProgramPipelineivEXT_fnptr = &GetProgramPipelineivEXT_Lazy;
            public static void GetProgramPipelineivEXT(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters) => _GetProgramPipelineivEXT_fnptr(pipeline, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetProgramPipelineivEXT_Lazy(ProgramPipelineHandle pipeline, PipelineParameterName pname, int* parameters)
            {
                _GetProgramPipelineivEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, PipelineParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramPipelineivEXT");
                _GetProgramPipelineivEXT_fnptr(pipeline, pname, parameters);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, byte> _IsProgramPipelineEXT_fnptr = &IsProgramPipelineEXT_Lazy;
            public static byte IsProgramPipelineEXT(ProgramPipelineHandle pipeline) => _IsProgramPipelineEXT_fnptr(pipeline);
            [UnmanagedCallersOnly]
            private static byte IsProgramPipelineEXT_Lazy(ProgramPipelineHandle pipeline)
            {
                _IsProgramPipelineEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsProgramPipelineEXT");
                return _IsProgramPipelineEXT_fnptr(pipeline);
            }
            
            private static delegate* unmanaged<ProgramHandle, ProgramParameterPName, int, void> _ProgramParameteriEXT_fnptr = &ProgramParameteriEXT_Lazy;
            public static void ProgramParameteriEXT(ProgramHandle program, ProgramParameterPName pname, int value) => _ProgramParameteriEXT_fnptr(program, pname, value);
            [UnmanagedCallersOnly]
            private static void ProgramParameteriEXT_Lazy(ProgramHandle program, ProgramParameterPName pname, int value)
            {
                _ProgramParameteriEXT_fnptr = (delegate* unmanaged<ProgramHandle, ProgramParameterPName, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramParameteriEXT");
                _ProgramParameteriEXT_fnptr(program, pname, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, float, void> _ProgramUniform1fEXT_fnptr = &ProgramUniform1fEXT_Lazy;
            public static void ProgramUniform1fEXT(ProgramHandle program, int location, float v0) => _ProgramUniform1fEXT_fnptr(program, location, v0);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1fEXT_Lazy(ProgramHandle program, int location, float v0)
            {
                _ProgramUniform1fEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1fEXT");
                _ProgramUniform1fEXT_fnptr(program, location, v0);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform1fvEXT_fnptr = &ProgramUniform1fvEXT_Lazy;
            public static void ProgramUniform1fvEXT(ProgramHandle program, int location, int count, float* value) => _ProgramUniform1fvEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1fvEXT_Lazy(ProgramHandle program, int location, int count, float* value)
            {
                _ProgramUniform1fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1fvEXT");
                _ProgramUniform1fvEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, void> _ProgramUniform1iEXT_fnptr = &ProgramUniform1iEXT_Lazy;
            public static void ProgramUniform1iEXT(ProgramHandle program, int location, int v0) => _ProgramUniform1iEXT_fnptr(program, location, v0);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1iEXT_Lazy(ProgramHandle program, int location, int v0)
            {
                _ProgramUniform1iEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1iEXT");
                _ProgramUniform1iEXT_fnptr(program, location, v0);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform1ivEXT_fnptr = &ProgramUniform1ivEXT_Lazy;
            public static void ProgramUniform1ivEXT(ProgramHandle program, int location, int count, int* value) => _ProgramUniform1ivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1ivEXT_Lazy(ProgramHandle program, int location, int count, int* value)
            {
                _ProgramUniform1ivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1ivEXT");
                _ProgramUniform1ivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, float, float, void> _ProgramUniform2fEXT_fnptr = &ProgramUniform2fEXT_Lazy;
            public static void ProgramUniform2fEXT(ProgramHandle program, int location, float v0, float v1) => _ProgramUniform2fEXT_fnptr(program, location, v0, v1);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2fEXT_Lazy(ProgramHandle program, int location, float v0, float v1)
            {
                _ProgramUniform2fEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2fEXT");
                _ProgramUniform2fEXT_fnptr(program, location, v0, v1);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform2fvEXT_fnptr = &ProgramUniform2fvEXT_Lazy;
            public static void ProgramUniform2fvEXT(ProgramHandle program, int location, int count, float* value) => _ProgramUniform2fvEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2fvEXT_Lazy(ProgramHandle program, int location, int count, float* value)
            {
                _ProgramUniform2fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2fvEXT");
                _ProgramUniform2fvEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int, void> _ProgramUniform2iEXT_fnptr = &ProgramUniform2iEXT_Lazy;
            public static void ProgramUniform2iEXT(ProgramHandle program, int location, int v0, int v1) => _ProgramUniform2iEXT_fnptr(program, location, v0, v1);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2iEXT_Lazy(ProgramHandle program, int location, int v0, int v1)
            {
                _ProgramUniform2iEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2iEXT");
                _ProgramUniform2iEXT_fnptr(program, location, v0, v1);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform2ivEXT_fnptr = &ProgramUniform2ivEXT_Lazy;
            public static void ProgramUniform2ivEXT(ProgramHandle program, int location, int count, int* value) => _ProgramUniform2ivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2ivEXT_Lazy(ProgramHandle program, int location, int count, int* value)
            {
                _ProgramUniform2ivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2ivEXT");
                _ProgramUniform2ivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, float, float, float, void> _ProgramUniform3fEXT_fnptr = &ProgramUniform3fEXT_Lazy;
            public static void ProgramUniform3fEXT(ProgramHandle program, int location, float v0, float v1, float v2) => _ProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3fEXT_Lazy(ProgramHandle program, int location, float v0, float v1, float v2)
            {
                _ProgramUniform3fEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3fEXT");
                _ProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform3fvEXT_fnptr = &ProgramUniform3fvEXT_Lazy;
            public static void ProgramUniform3fvEXT(ProgramHandle program, int location, int count, float* value) => _ProgramUniform3fvEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3fvEXT_Lazy(ProgramHandle program, int location, int count, float* value)
            {
                _ProgramUniform3fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3fvEXT");
                _ProgramUniform3fvEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int, int, void> _ProgramUniform3iEXT_fnptr = &ProgramUniform3iEXT_Lazy;
            public static void ProgramUniform3iEXT(ProgramHandle program, int location, int v0, int v1, int v2) => _ProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3iEXT_Lazy(ProgramHandle program, int location, int v0, int v1, int v2)
            {
                _ProgramUniform3iEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3iEXT");
                _ProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform3ivEXT_fnptr = &ProgramUniform3ivEXT_Lazy;
            public static void ProgramUniform3ivEXT(ProgramHandle program, int location, int count, int* value) => _ProgramUniform3ivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3ivEXT_Lazy(ProgramHandle program, int location, int count, int* value)
            {
                _ProgramUniform3ivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3ivEXT");
                _ProgramUniform3ivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, float, float, float, float, void> _ProgramUniform4fEXT_fnptr = &ProgramUniform4fEXT_Lazy;
            public static void ProgramUniform4fEXT(ProgramHandle program, int location, float v0, float v1, float v2, float v3) => _ProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4fEXT_Lazy(ProgramHandle program, int location, float v0, float v1, float v2, float v3)
            {
                _ProgramUniform4fEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4fEXT");
                _ProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _ProgramUniform4fvEXT_fnptr = &ProgramUniform4fvEXT_Lazy;
            public static void ProgramUniform4fvEXT(ProgramHandle program, int location, int count, float* value) => _ProgramUniform4fvEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4fvEXT_Lazy(ProgramHandle program, int location, int count, float* value)
            {
                _ProgramUniform4fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4fvEXT");
                _ProgramUniform4fvEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int, int, int, void> _ProgramUniform4iEXT_fnptr = &ProgramUniform4iEXT_Lazy;
            public static void ProgramUniform4iEXT(ProgramHandle program, int location, int v0, int v1, int v2, int v3) => _ProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4iEXT_Lazy(ProgramHandle program, int location, int v0, int v1, int v2, int v3)
            {
                _ProgramUniform4iEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4iEXT");
                _ProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _ProgramUniform4ivEXT_fnptr = &ProgramUniform4ivEXT_Lazy;
            public static void ProgramUniform4ivEXT(ProgramHandle program, int location, int count, int* value) => _ProgramUniform4ivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4ivEXT_Lazy(ProgramHandle program, int location, int count, int* value)
            {
                _ProgramUniform4ivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4ivEXT");
                _ProgramUniform4ivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2fvEXT_fnptr = &ProgramUniformMatrix2fvEXT_Lazy;
            public static void ProgramUniformMatrix2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix2fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix2fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2fvEXT");
                _ProgramUniformMatrix2fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3fvEXT_fnptr = &ProgramUniformMatrix3fvEXT_Lazy;
            public static void ProgramUniformMatrix3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix3fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix3fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3fvEXT");
                _ProgramUniformMatrix3fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4fvEXT_fnptr = &ProgramUniformMatrix4fvEXT_Lazy;
            public static void ProgramUniformMatrix4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix4fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix4fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4fvEXT");
                _ProgramUniformMatrix4fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, UseProgramStageMask, ProgramHandle, void> _UseProgramStagesEXT_fnptr = &UseProgramStagesEXT_Lazy;
            public static void UseProgramStagesEXT(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program) => _UseProgramStagesEXT_fnptr(pipeline, stages, program);
            [UnmanagedCallersOnly]
            private static void UseProgramStagesEXT_Lazy(ProgramPipelineHandle pipeline, UseProgramStageMask stages, ProgramHandle program)
            {
                _UseProgramStagesEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, UseProgramStageMask, ProgramHandle, void>)GLLoader.BindingsContext.GetProcAddress("glUseProgramStagesEXT");
                _UseProgramStagesEXT_fnptr(pipeline, stages, program);
            }
            
            private static delegate* unmanaged<ProgramPipelineHandle, void> _ValidateProgramPipelineEXT_fnptr = &ValidateProgramPipelineEXT_Lazy;
            public static void ValidateProgramPipelineEXT(ProgramPipelineHandle pipeline) => _ValidateProgramPipelineEXT_fnptr(pipeline);
            [UnmanagedCallersOnly]
            private static void ValidateProgramPipelineEXT_Lazy(ProgramPipelineHandle pipeline)
            {
                _ValidateProgramPipelineEXT_fnptr = (delegate* unmanaged<ProgramPipelineHandle, void>)GLLoader.BindingsContext.GetProcAddress("glValidateProgramPipelineEXT");
                _ValidateProgramPipelineEXT_fnptr(pipeline);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, uint, void> _ProgramUniform1uiEXT_fnptr = &ProgramUniform1uiEXT_Lazy;
            public static void ProgramUniform1uiEXT(ProgramHandle program, int location, uint v0) => _ProgramUniform1uiEXT_fnptr(program, location, v0);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1uiEXT_Lazy(ProgramHandle program, int location, uint v0)
            {
                _ProgramUniform1uiEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1uiEXT");
                _ProgramUniform1uiEXT_fnptr(program, location, v0);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, uint, uint, void> _ProgramUniform2uiEXT_fnptr = &ProgramUniform2uiEXT_Lazy;
            public static void ProgramUniform2uiEXT(ProgramHandle program, int location, uint v0, uint v1) => _ProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2uiEXT_Lazy(ProgramHandle program, int location, uint v0, uint v1)
            {
                _ProgramUniform2uiEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2uiEXT");
                _ProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, uint, uint, uint, void> _ProgramUniform3uiEXT_fnptr = &ProgramUniform3uiEXT_Lazy;
            public static void ProgramUniform3uiEXT(ProgramHandle program, int location, uint v0, uint v1, uint v2) => _ProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3uiEXT_Lazy(ProgramHandle program, int location, uint v0, uint v1, uint v2)
            {
                _ProgramUniform3uiEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3uiEXT");
                _ProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, uint, uint, uint, uint, void> _ProgramUniform4uiEXT_fnptr = &ProgramUniform4uiEXT_Lazy;
            public static void ProgramUniform4uiEXT(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3) => _ProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4uiEXT_Lazy(ProgramHandle program, int location, uint v0, uint v1, uint v2, uint v3)
            {
                _ProgramUniform4uiEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4uiEXT");
                _ProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform1uivEXT_fnptr = &ProgramUniform1uivEXT_Lazy;
            public static void ProgramUniform1uivEXT(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform1uivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1uivEXT_Lazy(ProgramHandle program, int location, int count, uint* value)
            {
                _ProgramUniform1uivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1uivEXT");
                _ProgramUniform1uivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform2uivEXT_fnptr = &ProgramUniform2uivEXT_Lazy;
            public static void ProgramUniform2uivEXT(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform2uivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2uivEXT_Lazy(ProgramHandle program, int location, int count, uint* value)
            {
                _ProgramUniform2uivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2uivEXT");
                _ProgramUniform2uivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform3uivEXT_fnptr = &ProgramUniform3uivEXT_Lazy;
            public static void ProgramUniform3uivEXT(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform3uivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3uivEXT_Lazy(ProgramHandle program, int location, int count, uint* value)
            {
                _ProgramUniform3uivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3uivEXT");
                _ProgramUniform3uivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _ProgramUniform4uivEXT_fnptr = &ProgramUniform4uivEXT_Lazy;
            public static void ProgramUniform4uivEXT(ProgramHandle program, int location, int count, uint* value) => _ProgramUniform4uivEXT_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4uivEXT_Lazy(ProgramHandle program, int location, int count, uint* value)
            {
                _ProgramUniform4uivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4uivEXT");
                _ProgramUniform4uivEXT_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2x3fvEXT_fnptr = &ProgramUniformMatrix2x3fvEXT_Lazy;
            public static void ProgramUniformMatrix2x3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix2x3fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix2x3fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2x3fvEXT");
                _ProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3x2fvEXT_fnptr = &ProgramUniformMatrix3x2fvEXT_Lazy;
            public static void ProgramUniformMatrix3x2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix3x2fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix3x2fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3x2fvEXT");
                _ProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix2x4fvEXT_fnptr = &ProgramUniformMatrix2x4fvEXT_Lazy;
            public static void ProgramUniformMatrix2x4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix2x4fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix2x4fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix2x4fvEXT");
                _ProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4x2fvEXT_fnptr = &ProgramUniformMatrix4x2fvEXT_Lazy;
            public static void ProgramUniformMatrix4x2fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix4x2fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix4x2fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4x2fvEXT");
                _ProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix3x4fvEXT_fnptr = &ProgramUniformMatrix3x4fvEXT_Lazy;
            public static void ProgramUniformMatrix3x4fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix3x4fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix3x4fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix3x4fvEXT");
                _ProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, byte, float*, void> _ProgramUniformMatrix4x3fvEXT_fnptr = &ProgramUniformMatrix4x3fvEXT_Lazy;
            public static void ProgramUniformMatrix4x3fvEXT(ProgramHandle program, int location, int count, byte transpose, float* value) => _ProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformMatrix4x3fvEXT_Lazy(ProgramHandle program, int location, int count, byte transpose, float* value)
            {
                _ProgramUniformMatrix4x3fvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformMatrix4x3fvEXT");
                _ProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, transpose, value);
            }
            
            private static delegate* unmanaged<void> _FramebufferFetchBarrierEXT_fnptr = &FramebufferFetchBarrierEXT_Lazy;
            public static void FramebufferFetchBarrierEXT() => _FramebufferFetchBarrierEXT_fnptr();
            [UnmanagedCallersOnly]
            private static void FramebufferFetchBarrierEXT_Lazy()
            {
                _FramebufferFetchBarrierEXT_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferFetchBarrierEXT");
                _FramebufferFetchBarrierEXT_fnptr();
            }
            
            private static delegate* unmanaged<uint, int, void> _FramebufferPixelLocalStorageSizeEXT_fnptr = &FramebufferPixelLocalStorageSizeEXT_Lazy;
            public static void FramebufferPixelLocalStorageSizeEXT(uint target, int size) => _FramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            [UnmanagedCallersOnly]
            private static void FramebufferPixelLocalStorageSizeEXT_Lazy(uint target, int size)
            {
                _FramebufferPixelLocalStorageSizeEXT_fnptr = (delegate* unmanaged<uint, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferPixelLocalStorageSizeEXT");
                _FramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            }
            
            private static delegate* unmanaged<uint, int> _GetFramebufferPixelLocalStorageSizeEXT_fnptr = &GetFramebufferPixelLocalStorageSizeEXT_Lazy;
            public static int GetFramebufferPixelLocalStorageSizeEXT(uint target) => _GetFramebufferPixelLocalStorageSizeEXT_fnptr(target);
            [UnmanagedCallersOnly]
            private static int GetFramebufferPixelLocalStorageSizeEXT_Lazy(uint target)
            {
                _GetFramebufferPixelLocalStorageSizeEXT_fnptr = (delegate* unmanaged<uint, int>)GLLoader.BindingsContext.GetProcAddress("glGetFramebufferPixelLocalStorageSizeEXT");
                return _GetFramebufferPixelLocalStorageSizeEXT_fnptr(target);
            }
            
            private static delegate* unmanaged<int, int, uint*, void> _ClearPixelLocalStorageuiEXT_fnptr = &ClearPixelLocalStorageuiEXT_Lazy;
            public static void ClearPixelLocalStorageuiEXT(int offset, int n, uint* values) => _ClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            [UnmanagedCallersOnly]
            private static void ClearPixelLocalStorageuiEXT_Lazy(int offset, int n, uint* values)
            {
                _ClearPixelLocalStorageuiEXT_fnptr = (delegate* unmanaged<int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glClearPixelLocalStorageuiEXT");
                _ClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            }
            
            private static delegate* unmanaged<All, int, int, int, int, int, int, int, byte, void> _TexPageCommitmentEXT_fnptr = &TexPageCommitmentEXT_Lazy;
            public static void TexPageCommitmentEXT(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit) => _TexPageCommitmentEXT_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
            [UnmanagedCallersOnly]
            private static void TexPageCommitmentEXT_Lazy(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit)
            {
                _TexPageCommitmentEXT_fnptr = (delegate* unmanaged<All, int, int, int, int, int, int, int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexPageCommitmentEXT");
                _TexPageCommitmentEXT_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
            }
            
            private static delegate* unmanaged<PatchParameterName, int, void> _PatchParameteriEXT_fnptr = &PatchParameteriEXT_Lazy;
            public static void PatchParameteriEXT(PatchParameterName pname, int value) => _PatchParameteriEXT_fnptr(pname, value);
            [UnmanagedCallersOnly]
            private static void PatchParameteriEXT_Lazy(PatchParameterName pname, int value)
            {
                _PatchParameteriEXT_fnptr = (delegate* unmanaged<PatchParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glPatchParameteriEXT");
                _PatchParameteriEXT_fnptr(pname, value);
            }
            
            private static delegate* unmanaged<TextureTarget, TextureParameterName, int*, void> _TexParameterIivEXT_fnptr = &TexParameterIivEXT_Lazy;
            public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* parameters) => _TexParameterIivEXT_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterIivEXT_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
            {
                _TexParameterIivEXT_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIivEXT");
                _TexParameterIivEXT_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void> _TexParameterIuivEXT_fnptr = &TexParameterIuivEXT_Lazy;
            public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* parameters) => _TexParameterIuivEXT_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterIuivEXT_Lazy(TextureTarget target, TextureParameterName pname, uint* parameters)
            {
                _TexParameterIuivEXT_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIuivEXT");
                _TexParameterIuivEXT_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameterIivEXT_fnptr = &GetTexParameterIivEXT_Lazy;
            public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameterIivEXT_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterIivEXT_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                _GetTexParameterIivEXT_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIivEXT");
                _GetTexParameterIivEXT_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void> _GetTexParameterIuivEXT_fnptr = &GetTexParameterIuivEXT_Lazy;
            public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* parameters) => _GetTexParameterIuivEXT_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterIuivEXT_Lazy(TextureTarget target, GetTextureParameter pname, uint* parameters)
            {
                _GetTexParameterIuivEXT_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIuivEXT");
                _GetTexParameterIuivEXT_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _SamplerParameterIivEXT_fnptr = &SamplerParameterIivEXT_Lazy;
            public static void SamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int* param) => _SamplerParameterIivEXT_fnptr(sampler, pname, param);
            [UnmanagedCallersOnly]
            private static void SamplerParameterIivEXT_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* param)
            {
                _SamplerParameterIivEXT_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIivEXT");
                _SamplerParameterIivEXT_fnptr(sampler, pname, param);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _SamplerParameterIuivEXT_fnptr = &SamplerParameterIuivEXT_Lazy;
            public static void SamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint* param) => _SamplerParameterIuivEXT_fnptr(sampler, pname, param);
            [UnmanagedCallersOnly]
            private static void SamplerParameterIuivEXT_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* param)
            {
                _SamplerParameterIuivEXT_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIuivEXT");
                _SamplerParameterIuivEXT_fnptr(sampler, pname, param);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _GetSamplerParameterIivEXT_fnptr = &GetSamplerParameterIivEXT_Lazy;
            public static void GetSamplerParameterIivEXT(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => _GetSamplerParameterIivEXT_fnptr(sampler, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSamplerParameterIivEXT_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* parameters)
            {
                _GetSamplerParameterIivEXT_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIivEXT");
                _GetSamplerParameterIivEXT_fnptr(sampler, pname, parameters);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _GetSamplerParameterIuivEXT_fnptr = &GetSamplerParameterIuivEXT_Lazy;
            public static void GetSamplerParameterIuivEXT(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => _GetSamplerParameterIuivEXT_fnptr(sampler, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSamplerParameterIuivEXT_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* parameters)
            {
                _GetSamplerParameterIuivEXT_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIuivEXT");
                _GetSamplerParameterIuivEXT_fnptr(sampler, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void> _TexBufferEXT_fnptr = &TexBufferEXT_Lazy;
            public static void TexBufferEXT(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => _TexBufferEXT_fnptr(target, internalformat, buffer);
            [UnmanagedCallersOnly]
            private static void TexBufferEXT_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer)
            {
                _TexBufferEXT_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glTexBufferEXT");
                _TexBufferEXT_fnptr(target, internalformat, buffer);
            }
            
            private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void> _TexBufferRangeEXT_fnptr = &TexBufferRangeEXT_Lazy;
            public static void TexBufferRangeEXT(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => _TexBufferRangeEXT_fnptr(target, internalformat, buffer, offset, size);
            [UnmanagedCallersOnly]
            private static void TexBufferRangeEXT_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size)
            {
                _TexBufferRangeEXT_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glTexBufferRangeEXT");
                _TexBufferRangeEXT_fnptr(target, internalformat, buffer, offset, size);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void> _TexStorage1DEXT_fnptr = &TexStorage1DEXT_Lazy;
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => _TexStorage1DEXT_fnptr(target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TexStorage1DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width)
            {
                _TexStorage1DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage1DEXT");
                _TexStorage1DEXT_fnptr(target, levels, internalformat, width);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void> _TexStorage2DEXT_fnptr = &TexStorage2DEXT_Lazy;
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => _TexStorage2DEXT_fnptr(target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TexStorage2DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                _TexStorage2DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage2DEXT");
                _TexStorage2DEXT_fnptr(target, levels, internalformat, width, height);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void> _TexStorage3DEXT_fnptr = &TexStorage3DEXT_Lazy;
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => _TexStorage3DEXT_fnptr(target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TexStorage3DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                _TexStorage3DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage3DEXT");
                _TexStorage3DEXT_fnptr(target, levels, internalformat, width, height, depth);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void> _TextureStorage1DEXT_fnptr = &TextureStorage1DEXT_Lazy;
            public static void TextureStorage1DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width) => _TextureStorage1DEXT_fnptr(texture, target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TextureStorage1DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width)
            {
                _TextureStorage1DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage1DEXT");
                _TextureStorage1DEXT_fnptr(texture, target, levels, internalformat, width);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void> _TextureStorage2DEXT_fnptr = &TextureStorage2DEXT_Lazy;
            public static void TextureStorage2DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => _TextureStorage2DEXT_fnptr(texture, target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TextureStorage2DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                _TextureStorage2DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage2DEXT");
                _TextureStorage2DEXT_fnptr(texture, target, levels, internalformat, width, height);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void> _TextureStorage3DEXT_fnptr = &TextureStorage3DEXT_Lazy;
            public static void TextureStorage3DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => _TextureStorage3DEXT_fnptr(texture, target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TextureStorage3DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                _TextureStorage3DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage3DEXT");
                _TextureStorage3DEXT_fnptr(texture, target, levels, internalformat, width, height, depth);
            }
            
            private static delegate* unmanaged<TextureHandle, TextureTarget, TextureHandle, SizedInternalFormat, uint, uint, uint, uint, void> _TextureViewEXT_fnptr = &TextureViewEXT_Lazy;
            public static void TextureViewEXT(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => _TextureViewEXT_fnptr(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            [UnmanagedCallersOnly]
            private static void TextureViewEXT_Lazy(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
            {
                _TextureViewEXT_fnptr = (delegate* unmanaged<TextureHandle, TextureTarget, TextureHandle, SizedInternalFormat, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glTextureViewEXT");
                _TextureViewEXT_fnptr(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            }
            
            private static delegate* unmanaged<uint, ulong, uint, byte> _AcquireKeyedMutexWin32EXT_fnptr = &AcquireKeyedMutexWin32EXT_Lazy;
            public static byte AcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => _AcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout);
            [UnmanagedCallersOnly]
            private static byte AcquireKeyedMutexWin32EXT_Lazy(uint memory, ulong key, uint timeout)
            {
                _AcquireKeyedMutexWin32EXT_fnptr = (delegate* unmanaged<uint, ulong, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glAcquireKeyedMutexWin32EXT");
                return _AcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout);
            }
            
            private static delegate* unmanaged<uint, ulong, byte> _ReleaseKeyedMutexWin32EXT_fnptr = &ReleaseKeyedMutexWin32EXT_Lazy;
            public static byte ReleaseKeyedMutexWin32EXT(uint memory, ulong key) => _ReleaseKeyedMutexWin32EXT_fnptr(memory, key);
            [UnmanagedCallersOnly]
            private static byte ReleaseKeyedMutexWin32EXT_Lazy(uint memory, ulong key)
            {
                _ReleaseKeyedMutexWin32EXT_fnptr = (delegate* unmanaged<uint, ulong, byte>)GLLoader.BindingsContext.GetProcAddress("glReleaseKeyedMutexWin32EXT");
                return _ReleaseKeyedMutexWin32EXT_fnptr(memory, key);
            }
            
            private static delegate* unmanaged<All, int, int*, void> _WindowRectanglesEXT_fnptr = &WindowRectanglesEXT_Lazy;
            public static void WindowRectanglesEXT(All mode, int count, int* box) => _WindowRectanglesEXT_fnptr(mode, count, box);
            [UnmanagedCallersOnly]
            private static void WindowRectanglesEXT_Lazy(All mode, int count, int* box)
            {
                _WindowRectanglesEXT_fnptr = (delegate* unmanaged<All, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glWindowRectanglesEXT");
                _WindowRectanglesEXT_fnptr(mode, count, box);
            }
            
        }
        public static unsafe partial class NV
        {
            private static delegate* unmanaged<int, uint*, void> _CreateSemaphoresNV_fnptr = &CreateSemaphoresNV_Lazy;
            public static void CreateSemaphoresNV(int n, uint* semaphores) => _CreateSemaphoresNV_fnptr(n, semaphores);
            [UnmanagedCallersOnly]
            private static void CreateSemaphoresNV_Lazy(int n, uint* semaphores)
            {
                _CreateSemaphoresNV_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glCreateSemaphoresNV");
                _CreateSemaphoresNV_fnptr(n, semaphores);
            }
            
            private static delegate* unmanaged<uint, SemaphoreParameterName, int*, void> _SemaphoreParameterivNV_fnptr = &SemaphoreParameterivNV_Lazy;
            public static void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => _SemaphoreParameterivNV_fnptr(semaphore, pname, parameters);
            [UnmanagedCallersOnly]
            private static void SemaphoreParameterivNV_Lazy(uint semaphore, SemaphoreParameterName pname, int* parameters)
            {
                _SemaphoreParameterivNV_fnptr = (delegate* unmanaged<uint, SemaphoreParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glSemaphoreParameterivNV");
                _SemaphoreParameterivNV_fnptr(semaphore, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, SemaphoreParameterName, int*, void> _GetSemaphoreParameterivNV_fnptr = &GetSemaphoreParameterivNV_Lazy;
            public static void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => _GetSemaphoreParameterivNV_fnptr(semaphore, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSemaphoreParameterivNV_Lazy(uint semaphore, SemaphoreParameterName pname, int* parameters)
            {
                _GetSemaphoreParameterivNV_fnptr = (delegate* unmanaged<uint, SemaphoreParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSemaphoreParameterivNV");
                _GetSemaphoreParameterivNV_fnptr(semaphore, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureHandle, ulong> _GetTextureHandleNV_fnptr = &GetTextureHandleNV_Lazy;
            public static ulong GetTextureHandleNV(TextureHandle texture) => _GetTextureHandleNV_fnptr(texture);
            [UnmanagedCallersOnly]
            private static ulong GetTextureHandleNV_Lazy(TextureHandle texture)
            {
                _GetTextureHandleNV_fnptr = (delegate* unmanaged<TextureHandle, ulong>)GLLoader.BindingsContext.GetProcAddress("glGetTextureHandleNV");
                return _GetTextureHandleNV_fnptr(texture);
            }
            
            private static delegate* unmanaged<TextureHandle, SamplerHandle, ulong> _GetTextureSamplerHandleNV_fnptr = &GetTextureSamplerHandleNV_Lazy;
            public static ulong GetTextureSamplerHandleNV(TextureHandle texture, SamplerHandle sampler) => _GetTextureSamplerHandleNV_fnptr(texture, sampler);
            [UnmanagedCallersOnly]
            private static ulong GetTextureSamplerHandleNV_Lazy(TextureHandle texture, SamplerHandle sampler)
            {
                _GetTextureSamplerHandleNV_fnptr = (delegate* unmanaged<TextureHandle, SamplerHandle, ulong>)GLLoader.BindingsContext.GetProcAddress("glGetTextureSamplerHandleNV");
                return _GetTextureSamplerHandleNV_fnptr(texture, sampler);
            }
            
            private static delegate* unmanaged<ulong, void> _MakeTextureHandleResidentNV_fnptr = &MakeTextureHandleResidentNV_Lazy;
            public static void MakeTextureHandleResidentNV(ulong handle) => _MakeTextureHandleResidentNV_fnptr(handle);
            [UnmanagedCallersOnly]
            private static void MakeTextureHandleResidentNV_Lazy(ulong handle)
            {
                _MakeTextureHandleResidentNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glMakeTextureHandleResidentNV");
                _MakeTextureHandleResidentNV_fnptr(handle);
            }
            
            private static delegate* unmanaged<ulong, void> _MakeTextureHandleNonResidentNV_fnptr = &MakeTextureHandleNonResidentNV_Lazy;
            public static void MakeTextureHandleNonResidentNV(ulong handle) => _MakeTextureHandleNonResidentNV_fnptr(handle);
            [UnmanagedCallersOnly]
            private static void MakeTextureHandleNonResidentNV_Lazy(ulong handle)
            {
                _MakeTextureHandleNonResidentNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glMakeTextureHandleNonResidentNV");
                _MakeTextureHandleNonResidentNV_fnptr(handle);
            }
            
            private static delegate* unmanaged<TextureHandle, int, byte, int, PixelFormat, ulong> _GetImageHandleNV_fnptr = &GetImageHandleNV_Lazy;
            public static ulong GetImageHandleNV(TextureHandle texture, int level, byte layered, int layer, PixelFormat format) => _GetImageHandleNV_fnptr(texture, level, layered, layer, format);
            [UnmanagedCallersOnly]
            private static ulong GetImageHandleNV_Lazy(TextureHandle texture, int level, byte layered, int layer, PixelFormat format)
            {
                _GetImageHandleNV_fnptr = (delegate* unmanaged<TextureHandle, int, byte, int, PixelFormat, ulong>)GLLoader.BindingsContext.GetProcAddress("glGetImageHandleNV");
                return _GetImageHandleNV_fnptr(texture, level, layered, layer, format);
            }
            
            private static delegate* unmanaged<ulong, All, void> _MakeImageHandleResidentNV_fnptr = &MakeImageHandleResidentNV_Lazy;
            public static void MakeImageHandleResidentNV(ulong handle, All access) => _MakeImageHandleResidentNV_fnptr(handle, access);
            [UnmanagedCallersOnly]
            private static void MakeImageHandleResidentNV_Lazy(ulong handle, All access)
            {
                _MakeImageHandleResidentNV_fnptr = (delegate* unmanaged<ulong, All, void>)GLLoader.BindingsContext.GetProcAddress("glMakeImageHandleResidentNV");
                _MakeImageHandleResidentNV_fnptr(handle, access);
            }
            
            private static delegate* unmanaged<ulong, void> _MakeImageHandleNonResidentNV_fnptr = &MakeImageHandleNonResidentNV_Lazy;
            public static void MakeImageHandleNonResidentNV(ulong handle) => _MakeImageHandleNonResidentNV_fnptr(handle);
            [UnmanagedCallersOnly]
            private static void MakeImageHandleNonResidentNV_Lazy(ulong handle)
            {
                _MakeImageHandleNonResidentNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glMakeImageHandleNonResidentNV");
                _MakeImageHandleNonResidentNV_fnptr(handle);
            }
            
            private static delegate* unmanaged<int, ulong, void> _UniformHandleui64NV_fnptr = &UniformHandleui64NV_Lazy;
            public static void UniformHandleui64NV(int location, ulong value) => _UniformHandleui64NV_fnptr(location, value);
            [UnmanagedCallersOnly]
            private static void UniformHandleui64NV_Lazy(int location, ulong value)
            {
                _UniformHandleui64NV_fnptr = (delegate* unmanaged<int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniformHandleui64NV");
                _UniformHandleui64NV_fnptr(location, value);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _UniformHandleui64vNV_fnptr = &UniformHandleui64vNV_Lazy;
            public static void UniformHandleui64vNV(int location, int count, ulong* value) => _UniformHandleui64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void UniformHandleui64vNV_Lazy(int location, int count, ulong* value)
            {
                _UniformHandleui64vNV_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformHandleui64vNV");
                _UniformHandleui64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, void> _ProgramUniformHandleui64NV_fnptr = &ProgramUniformHandleui64NV_Lazy;
            public static void ProgramUniformHandleui64NV(ProgramHandle program, int location, ulong value) => _ProgramUniformHandleui64NV_fnptr(program, location, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformHandleui64NV_Lazy(ProgramHandle program, int location, ulong value)
            {
                _ProgramUniformHandleui64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformHandleui64NV");
                _ProgramUniformHandleui64NV_fnptr(program, location, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniformHandleui64vNV_fnptr = &ProgramUniformHandleui64vNV_Lazy;
            public static void ProgramUniformHandleui64vNV(ProgramHandle program, int location, int count, ulong* values) => _ProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            [UnmanagedCallersOnly]
            private static void ProgramUniformHandleui64vNV_Lazy(ProgramHandle program, int location, int count, ulong* values)
            {
                _ProgramUniformHandleui64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformHandleui64vNV");
                _ProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            }
            
            private static delegate* unmanaged<ulong, byte> _IsTextureHandleResidentNV_fnptr = &IsTextureHandleResidentNV_Lazy;
            public static byte IsTextureHandleResidentNV(ulong handle) => _IsTextureHandleResidentNV_fnptr(handle);
            [UnmanagedCallersOnly]
            private static byte IsTextureHandleResidentNV_Lazy(ulong handle)
            {
                _IsTextureHandleResidentNV_fnptr = (delegate* unmanaged<ulong, byte>)GLLoader.BindingsContext.GetProcAddress("glIsTextureHandleResidentNV");
                return _IsTextureHandleResidentNV_fnptr(handle);
            }
            
            private static delegate* unmanaged<ulong, byte> _IsImageHandleResidentNV_fnptr = &IsImageHandleResidentNV_Lazy;
            public static byte IsImageHandleResidentNV(ulong handle) => _IsImageHandleResidentNV_fnptr(handle);
            [UnmanagedCallersOnly]
            private static byte IsImageHandleResidentNV_Lazy(ulong handle)
            {
                _IsImageHandleResidentNV_fnptr = (delegate* unmanaged<ulong, byte>)GLLoader.BindingsContext.GetProcAddress("glIsImageHandleResidentNV");
                return _IsImageHandleResidentNV_fnptr(handle);
            }
            
            private static delegate* unmanaged<All, int, void> _BlendParameteriNV_fnptr = &BlendParameteriNV_Lazy;
            public static void BlendParameteriNV(All pname, int value) => _BlendParameteriNV_fnptr(pname, value);
            [UnmanagedCallersOnly]
            private static void BlendParameteriNV_Lazy(All pname, int value)
            {
                _BlendParameteriNV_fnptr = (delegate* unmanaged<All, int, void>)GLLoader.BindingsContext.GetProcAddress("glBlendParameteriNV");
                _BlendParameteriNV_fnptr(pname, value);
            }
            
            private static delegate* unmanaged<void> _BlendBarrierNV_fnptr = &BlendBarrierNV_Lazy;
            public static void BlendBarrierNV() => _BlendBarrierNV_fnptr();
            [UnmanagedCallersOnly]
            private static void BlendBarrierNV_Lazy()
            {
                _BlendBarrierNV_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glBlendBarrierNV");
                _BlendBarrierNV_fnptr();
            }
            
            private static delegate* unmanaged<uint, float, float, void> _ViewportPositionWScaleNV_fnptr = &ViewportPositionWScaleNV_Lazy;
            public static void ViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => _ViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            [UnmanagedCallersOnly]
            private static void ViewportPositionWScaleNV_Lazy(uint index, float xcoeff, float ycoeff)
            {
                _ViewportPositionWScaleNV_fnptr = (delegate* unmanaged<uint, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glViewportPositionWScaleNV");
                _ViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            }
            
            private static delegate* unmanaged<uint, ConditionalRenderMode, void> _BeginConditionalRenderNV_fnptr = &BeginConditionalRenderNV_Lazy;
            public static void BeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => _BeginConditionalRenderNV_fnptr(id, mode);
            [UnmanagedCallersOnly]
            private static void BeginConditionalRenderNV_Lazy(uint id, ConditionalRenderMode mode)
            {
                _BeginConditionalRenderNV_fnptr = (delegate* unmanaged<uint, ConditionalRenderMode, void>)GLLoader.BindingsContext.GetProcAddress("glBeginConditionalRenderNV");
                _BeginConditionalRenderNV_fnptr(id, mode);
            }
            
            private static delegate* unmanaged<void> _EndConditionalRenderNV_fnptr = &EndConditionalRenderNV_Lazy;
            public static void EndConditionalRenderNV() => _EndConditionalRenderNV_fnptr();
            [UnmanagedCallersOnly]
            private static void EndConditionalRenderNV_Lazy()
            {
                _EndConditionalRenderNV_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glEndConditionalRenderNV");
                _EndConditionalRenderNV_fnptr();
            }
            
            private static delegate* unmanaged<uint, uint, void> _SubpixelPrecisionBiasNV_fnptr = &SubpixelPrecisionBiasNV_Lazy;
            public static void SubpixelPrecisionBiasNV(uint xbits, uint ybits) => _SubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            [UnmanagedCallersOnly]
            private static void SubpixelPrecisionBiasNV_Lazy(uint xbits, uint ybits)
            {
                _SubpixelPrecisionBiasNV_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glSubpixelPrecisionBiasNV");
                _SubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            }
            
            private static delegate* unmanaged<All, int, void> _ConservativeRasterParameteriNV_fnptr = &ConservativeRasterParameteriNV_Lazy;
            public static void ConservativeRasterParameteriNV(All pname, int param) => _ConservativeRasterParameteriNV_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void ConservativeRasterParameteriNV_Lazy(All pname, int param)
            {
                _ConservativeRasterParameteriNV_fnptr = (delegate* unmanaged<All, int, void>)GLLoader.BindingsContext.GetProcAddress("glConservativeRasterParameteriNV");
                _ConservativeRasterParameteriNV_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<CopyBufferSubDataTarget, CopyBufferSubDataTarget, IntPtr, IntPtr, nint, void> _CopyBufferSubDataNV_fnptr = &CopyBufferSubDataNV_Lazy;
            public static void CopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => _CopyBufferSubDataNV_fnptr(readTarget, writeTarget, readOffset, writeOffset, size);
            [UnmanagedCallersOnly]
            private static void CopyBufferSubDataNV_Lazy(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                _CopyBufferSubDataNV_fnptr = (delegate* unmanaged<CopyBufferSubDataTarget, CopyBufferSubDataTarget, IntPtr, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glCopyBufferSubDataNV");
                _CopyBufferSubDataNV_fnptr(readTarget, writeTarget, readOffset, writeOffset, size);
            }
            
            private static delegate* unmanaged<byte, void> _CoverageMaskNV_fnptr = &CoverageMaskNV_Lazy;
            public static void CoverageMaskNV(byte mask) => _CoverageMaskNV_fnptr(mask);
            [UnmanagedCallersOnly]
            private static void CoverageMaskNV_Lazy(byte mask)
            {
                _CoverageMaskNV_fnptr = (delegate* unmanaged<byte, void>)GLLoader.BindingsContext.GetProcAddress("glCoverageMaskNV");
                _CoverageMaskNV_fnptr(mask);
            }
            
            private static delegate* unmanaged<All, void> _CoverageOperationNV_fnptr = &CoverageOperationNV_Lazy;
            public static void CoverageOperationNV(All operation) => _CoverageOperationNV_fnptr(operation);
            [UnmanagedCallersOnly]
            private static void CoverageOperationNV_Lazy(All operation)
            {
                _CoverageOperationNV_fnptr = (delegate* unmanaged<All, void>)GLLoader.BindingsContext.GetProcAddress("glCoverageOperationNV");
                _CoverageOperationNV_fnptr(operation);
            }
            
            private static delegate* unmanaged<int, All*, void> _DrawBuffersNV_fnptr = &DrawBuffersNV_Lazy;
            public static void DrawBuffersNV(int n, All* bufs) => _DrawBuffersNV_fnptr(n, bufs);
            [UnmanagedCallersOnly]
            private static void DrawBuffersNV_Lazy(int n, All* bufs)
            {
                _DrawBuffersNV_fnptr = (delegate* unmanaged<int, All*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawBuffersNV");
                _DrawBuffersNV_fnptr(n, bufs);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, int, int, void> _DrawArraysInstancedNV_fnptr = &DrawArraysInstancedNV_Lazy;
            public static void DrawArraysInstancedNV(PrimitiveType mode, int first, int count, int primcount) => _DrawArraysInstancedNV_fnptr(mode, first, count, primcount);
            [UnmanagedCallersOnly]
            private static void DrawArraysInstancedNV_Lazy(PrimitiveType mode, int first, int count, int primcount)
            {
                _DrawArraysInstancedNV_fnptr = (delegate* unmanaged<PrimitiveType, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArraysInstancedNV");
                _DrawArraysInstancedNV_fnptr(mode, first, count, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, void> _DrawElementsInstancedNV_fnptr = &DrawElementsInstancedNV_Lazy;
            public static void DrawElementsInstancedNV(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount) => _DrawElementsInstancedNV_fnptr(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedNV_Lazy(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount)
            {
                _DrawElementsInstancedNV_fnptr = (delegate* unmanaged<PrimitiveType, int, PrimitiveType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedNV");
                _DrawElementsInstancedNV_fnptr(mode, count, type, indices, primcount);
            }
            
            private static delegate* unmanaged<ulong, SamplerHandle, float, float, float, float, float, float, float, float, float, void> _DrawVkImageNV_fnptr = &DrawVkImageNV_Lazy;
            public static void DrawVkImageNV(ulong vkImage, SamplerHandle sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => _DrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            [UnmanagedCallersOnly]
            private static void DrawVkImageNV_Lazy(ulong vkImage, SamplerHandle sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
            {
                _DrawVkImageNV_fnptr = (delegate* unmanaged<ulong, SamplerHandle, float, float, float, float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDrawVkImageNV");
                _DrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            }
            
            private static delegate* unmanaged<byte*, IntPtr> _GetVkProcAddrNV_fnptr = &GetVkProcAddrNV_Lazy;
            public static IntPtr GetVkProcAddrNV(byte* name) => _GetVkProcAddrNV_fnptr(name);
            [UnmanagedCallersOnly]
            private static IntPtr GetVkProcAddrNV_Lazy(byte* name)
            {
                _GetVkProcAddrNV_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glGetVkProcAddrNV");
                return _GetVkProcAddrNV_fnptr(name);
            }
            
            private static delegate* unmanaged<ulong, void> _WaitVkSemaphoreNV_fnptr = &WaitVkSemaphoreNV_Lazy;
            public static void WaitVkSemaphoreNV(ulong vkSemaphore) => _WaitVkSemaphoreNV_fnptr(vkSemaphore);
            [UnmanagedCallersOnly]
            private static void WaitVkSemaphoreNV_Lazy(ulong vkSemaphore)
            {
                _WaitVkSemaphoreNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glWaitVkSemaphoreNV");
                _WaitVkSemaphoreNV_fnptr(vkSemaphore);
            }
            
            private static delegate* unmanaged<ulong, void> _SignalVkSemaphoreNV_fnptr = &SignalVkSemaphoreNV_Lazy;
            public static void SignalVkSemaphoreNV(ulong vkSemaphore) => _SignalVkSemaphoreNV_fnptr(vkSemaphore);
            [UnmanagedCallersOnly]
            private static void SignalVkSemaphoreNV_Lazy(ulong vkSemaphore)
            {
                _SignalVkSemaphoreNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glSignalVkSemaphoreNV");
                _SignalVkSemaphoreNV_fnptr(vkSemaphore);
            }
            
            private static delegate* unmanaged<ulong, void> _SignalVkFenceNV_fnptr = &SignalVkFenceNV_Lazy;
            public static void SignalVkFenceNV(ulong vkFence) => _SignalVkFenceNV_fnptr(vkFence);
            [UnmanagedCallersOnly]
            private static void SignalVkFenceNV_Lazy(ulong vkFence)
            {
                _SignalVkFenceNV_fnptr = (delegate* unmanaged<ulong, void>)GLLoader.BindingsContext.GetProcAddress("glSignalVkFenceNV");
                _SignalVkFenceNV_fnptr(vkFence);
            }
            
            private static delegate* unmanaged<int, uint*, void> _DeleteFencesNV_fnptr = &DeleteFencesNV_Lazy;
            public static void DeleteFencesNV(int n, uint* fences) => _DeleteFencesNV_fnptr(n, fences);
            [UnmanagedCallersOnly]
            private static void DeleteFencesNV_Lazy(int n, uint* fences)
            {
                _DeleteFencesNV_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteFencesNV");
                _DeleteFencesNV_fnptr(n, fences);
            }
            
            private static delegate* unmanaged<int, uint*, void> _GenFencesNV_fnptr = &GenFencesNV_Lazy;
            public static void GenFencesNV(int n, uint* fences) => _GenFencesNV_fnptr(n, fences);
            [UnmanagedCallersOnly]
            private static void GenFencesNV_Lazy(int n, uint* fences)
            {
                _GenFencesNV_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGenFencesNV");
                _GenFencesNV_fnptr(n, fences);
            }
            
            private static delegate* unmanaged<uint, byte> _IsFenceNV_fnptr = &IsFenceNV_Lazy;
            public static byte IsFenceNV(uint fence) => _IsFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static byte IsFenceNV_Lazy(uint fence)
            {
                _IsFenceNV_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsFenceNV");
                return _IsFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, byte> _TestFenceNV_fnptr = &TestFenceNV_Lazy;
            public static byte TestFenceNV(uint fence) => _TestFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static byte TestFenceNV_Lazy(uint fence)
            {
                _TestFenceNV_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glTestFenceNV");
                return _TestFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, FenceParameterNameNV, int*, void> _GetFenceivNV_fnptr = &GetFenceivNV_Lazy;
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => _GetFenceivNV_fnptr(fence, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFenceivNV_Lazy(uint fence, FenceParameterNameNV pname, int* parameters)
            {
                _GetFenceivNV_fnptr = (delegate* unmanaged<uint, FenceParameterNameNV, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFenceivNV");
                _GetFenceivNV_fnptr(fence, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, void> _FinishFenceNV_fnptr = &FinishFenceNV_Lazy;
            public static void FinishFenceNV(uint fence) => _FinishFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static void FinishFenceNV_Lazy(uint fence)
            {
                _FinishFenceNV_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glFinishFenceNV");
                _FinishFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, FenceConditionNV, void> _SetFenceNV_fnptr = &SetFenceNV_Lazy;
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => _SetFenceNV_fnptr(fence, condition);
            [UnmanagedCallersOnly]
            private static void SetFenceNV_Lazy(uint fence, FenceConditionNV condition)
            {
                _SetFenceNV_fnptr = (delegate* unmanaged<uint, FenceConditionNV, void>)GLLoader.BindingsContext.GetProcAddress("glSetFenceNV");
                _SetFenceNV_fnptr(fence, condition);
            }
            
            private static delegate* unmanaged<uint, void> _FragmentCoverageColorNV_fnptr = &FragmentCoverageColorNV_Lazy;
            public static void FragmentCoverageColorNV(uint color) => _FragmentCoverageColorNV_fnptr(color);
            [UnmanagedCallersOnly]
            private static void FragmentCoverageColorNV_Lazy(uint color)
            {
                _FragmentCoverageColorNV_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glFragmentCoverageColorNV");
                _FragmentCoverageColorNV_fnptr(color);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void> _BlitFramebufferNV_fnptr = &BlitFramebufferNV_Lazy;
            public static void BlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => _BlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            [UnmanagedCallersOnly]
            private static void BlitFramebufferNV_Lazy(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
            {
                _BlitFramebufferNV_fnptr = (delegate* unmanaged<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void>)GLLoader.BindingsContext.GetProcAddress("glBlitFramebufferNV");
                _BlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
            
            private static delegate* unmanaged<uint, byte, void> _RasterSamplesEXT_fnptr = &RasterSamplesEXT_Lazy;
            public static void RasterSamplesEXT(uint samples, byte fixedsamplelocations) => _RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            [UnmanagedCallersOnly]
            private static void RasterSamplesEXT_Lazy(uint samples, byte fixedsamplelocations)
            {
                _RasterSamplesEXT_fnptr = (delegate* unmanaged<uint, byte, void>)GLLoader.BindingsContext.GetProcAddress("glRasterSamplesEXT");
                _RasterSamplesEXT_fnptr(samples, fixedsamplelocations);
            }
            
            private static delegate* unmanaged<int, float*, void> _CoverageModulationTableNV_fnptr = &CoverageModulationTableNV_Lazy;
            public static void CoverageModulationTableNV(int n, float* v) => _CoverageModulationTableNV_fnptr(n, v);
            [UnmanagedCallersOnly]
            private static void CoverageModulationTableNV_Lazy(int n, float* v)
            {
                _CoverageModulationTableNV_fnptr = (delegate* unmanaged<int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glCoverageModulationTableNV");
                _CoverageModulationTableNV_fnptr(n, v);
            }
            
            private static delegate* unmanaged<int, float*, void> _GetCoverageModulationTableNV_fnptr = &GetCoverageModulationTableNV_Lazy;
            public static void GetCoverageModulationTableNV(int bufSize, float* v) => _GetCoverageModulationTableNV_fnptr(bufSize, v);
            [UnmanagedCallersOnly]
            private static void GetCoverageModulationTableNV_Lazy(int bufSize, float* v)
            {
                _GetCoverageModulationTableNV_fnptr = (delegate* unmanaged<int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetCoverageModulationTableNV");
                _GetCoverageModulationTableNV_fnptr(bufSize, v);
            }
            
            private static delegate* unmanaged<All, void> _CoverageModulationNV_fnptr = &CoverageModulationNV_Lazy;
            public static void CoverageModulationNV(All components) => _CoverageModulationNV_fnptr(components);
            [UnmanagedCallersOnly]
            private static void CoverageModulationNV_Lazy(All components)
            {
                _CoverageModulationNV_fnptr = (delegate* unmanaged<All, void>)GLLoader.BindingsContext.GetProcAddress("glCoverageModulationNV");
                _CoverageModulationNV_fnptr(components);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleNV_fnptr = &RenderbufferStorageMultisampleNV_Lazy;
            public static void RenderbufferStorageMultisampleNV(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleNV_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleNV_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleNV_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleNV");
                _RenderbufferStorageMultisampleNV_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<int, long, void> _Uniform1i64NV_fnptr = &Uniform1i64NV_Lazy;
            public static void Uniform1i64NV(int location, long x) => _Uniform1i64NV_fnptr(location, x);
            [UnmanagedCallersOnly]
            private static void Uniform1i64NV_Lazy(int location, long x)
            {
                _Uniform1i64NV_fnptr = (delegate* unmanaged<int, long, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1i64NV");
                _Uniform1i64NV_fnptr(location, x);
            }
            
            private static delegate* unmanaged<int, long, long, void> _Uniform2i64NV_fnptr = &Uniform2i64NV_Lazy;
            public static void Uniform2i64NV(int location, long x, long y) => _Uniform2i64NV_fnptr(location, x, y);
            [UnmanagedCallersOnly]
            private static void Uniform2i64NV_Lazy(int location, long x, long y)
            {
                _Uniform2i64NV_fnptr = (delegate* unmanaged<int, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2i64NV");
                _Uniform2i64NV_fnptr(location, x, y);
            }
            
            private static delegate* unmanaged<int, long, long, long, void> _Uniform3i64NV_fnptr = &Uniform3i64NV_Lazy;
            public static void Uniform3i64NV(int location, long x, long y, long z) => _Uniform3i64NV_fnptr(location, x, y, z);
            [UnmanagedCallersOnly]
            private static void Uniform3i64NV_Lazy(int location, long x, long y, long z)
            {
                _Uniform3i64NV_fnptr = (delegate* unmanaged<int, long, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3i64NV");
                _Uniform3i64NV_fnptr(location, x, y, z);
            }
            
            private static delegate* unmanaged<int, long, long, long, long, void> _Uniform4i64NV_fnptr = &Uniform4i64NV_Lazy;
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => _Uniform4i64NV_fnptr(location, x, y, z, w);
            [UnmanagedCallersOnly]
            private static void Uniform4i64NV_Lazy(int location, long x, long y, long z, long w)
            {
                _Uniform4i64NV_fnptr = (delegate* unmanaged<int, long, long, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4i64NV");
                _Uniform4i64NV_fnptr(location, x, y, z, w);
            }
            
            private static delegate* unmanaged<int, int, long*, void> _Uniform1i64vNV_fnptr = &Uniform1i64vNV_Lazy;
            public static void Uniform1i64vNV(int location, int count, long* value) => _Uniform1i64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform1i64vNV_Lazy(int location, int count, long* value)
            {
                _Uniform1i64vNV_fnptr = (delegate* unmanaged<int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1i64vNV");
                _Uniform1i64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, long*, void> _Uniform2i64vNV_fnptr = &Uniform2i64vNV_Lazy;
            public static void Uniform2i64vNV(int location, int count, long* value) => _Uniform2i64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform2i64vNV_Lazy(int location, int count, long* value)
            {
                _Uniform2i64vNV_fnptr = (delegate* unmanaged<int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2i64vNV");
                _Uniform2i64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, long*, void> _Uniform3i64vNV_fnptr = &Uniform3i64vNV_Lazy;
            public static void Uniform3i64vNV(int location, int count, long* value) => _Uniform3i64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform3i64vNV_Lazy(int location, int count, long* value)
            {
                _Uniform3i64vNV_fnptr = (delegate* unmanaged<int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3i64vNV");
                _Uniform3i64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, long*, void> _Uniform4i64vNV_fnptr = &Uniform4i64vNV_Lazy;
            public static void Uniform4i64vNV(int location, int count, long* value) => _Uniform4i64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform4i64vNV_Lazy(int location, int count, long* value)
            {
                _Uniform4i64vNV_fnptr = (delegate* unmanaged<int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4i64vNV");
                _Uniform4i64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, ulong, void> _Uniform1ui64NV_fnptr = &Uniform1ui64NV_Lazy;
            public static void Uniform1ui64NV(int location, ulong x) => _Uniform1ui64NV_fnptr(location, x);
            [UnmanagedCallersOnly]
            private static void Uniform1ui64NV_Lazy(int location, ulong x)
            {
                _Uniform1ui64NV_fnptr = (delegate* unmanaged<int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1ui64NV");
                _Uniform1ui64NV_fnptr(location, x);
            }
            
            private static delegate* unmanaged<int, ulong, ulong, void> _Uniform2ui64NV_fnptr = &Uniform2ui64NV_Lazy;
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => _Uniform2ui64NV_fnptr(location, x, y);
            [UnmanagedCallersOnly]
            private static void Uniform2ui64NV_Lazy(int location, ulong x, ulong y)
            {
                _Uniform2ui64NV_fnptr = (delegate* unmanaged<int, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2ui64NV");
                _Uniform2ui64NV_fnptr(location, x, y);
            }
            
            private static delegate* unmanaged<int, ulong, ulong, ulong, void> _Uniform3ui64NV_fnptr = &Uniform3ui64NV_Lazy;
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => _Uniform3ui64NV_fnptr(location, x, y, z);
            [UnmanagedCallersOnly]
            private static void Uniform3ui64NV_Lazy(int location, ulong x, ulong y, ulong z)
            {
                _Uniform3ui64NV_fnptr = (delegate* unmanaged<int, ulong, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3ui64NV");
                _Uniform3ui64NV_fnptr(location, x, y, z);
            }
            
            private static delegate* unmanaged<int, ulong, ulong, ulong, ulong, void> _Uniform4ui64NV_fnptr = &Uniform4ui64NV_Lazy;
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => _Uniform4ui64NV_fnptr(location, x, y, z, w);
            [UnmanagedCallersOnly]
            private static void Uniform4ui64NV_Lazy(int location, ulong x, ulong y, ulong z, ulong w)
            {
                _Uniform4ui64NV_fnptr = (delegate* unmanaged<int, ulong, ulong, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4ui64NV");
                _Uniform4ui64NV_fnptr(location, x, y, z, w);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _Uniform1ui64vNV_fnptr = &Uniform1ui64vNV_Lazy;
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => _Uniform1ui64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform1ui64vNV_Lazy(int location, int count, ulong* value)
            {
                _Uniform1ui64vNV_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform1ui64vNV");
                _Uniform1ui64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _Uniform2ui64vNV_fnptr = &Uniform2ui64vNV_Lazy;
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => _Uniform2ui64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform2ui64vNV_Lazy(int location, int count, ulong* value)
            {
                _Uniform2ui64vNV_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform2ui64vNV");
                _Uniform2ui64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _Uniform3ui64vNV_fnptr = &Uniform3ui64vNV_Lazy;
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => _Uniform3ui64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform3ui64vNV_Lazy(int location, int count, ulong* value)
            {
                _Uniform3ui64vNV_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform3ui64vNV");
                _Uniform3ui64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _Uniform4ui64vNV_fnptr = &Uniform4ui64vNV_Lazy;
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => _Uniform4ui64vNV_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void Uniform4ui64vNV_Lazy(int location, int count, ulong* value)
            {
                _Uniform4ui64vNV_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniform4ui64vNV");
                _Uniform4ui64vNV_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, long*, void> _GetUniformi64vNV_fnptr = &GetUniformi64vNV_Lazy;
            public static void GetUniformi64vNV(ProgramHandle program, int location, long* parameters) => _GetUniformi64vNV_fnptr(program, location, parameters);
            [UnmanagedCallersOnly]
            private static void GetUniformi64vNV_Lazy(ProgramHandle program, int location, long* parameters)
            {
                _GetUniformi64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetUniformi64vNV");
                _GetUniformi64vNV_fnptr(program, location, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, long, void> _ProgramUniform1i64NV_fnptr = &ProgramUniform1i64NV_Lazy;
            public static void ProgramUniform1i64NV(ProgramHandle program, int location, long x) => _ProgramUniform1i64NV_fnptr(program, location, x);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1i64NV_Lazy(ProgramHandle program, int location, long x)
            {
                _ProgramUniform1i64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, long, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1i64NV");
                _ProgramUniform1i64NV_fnptr(program, location, x);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, long, long, void> _ProgramUniform2i64NV_fnptr = &ProgramUniform2i64NV_Lazy;
            public static void ProgramUniform2i64NV(ProgramHandle program, int location, long x, long y) => _ProgramUniform2i64NV_fnptr(program, location, x, y);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2i64NV_Lazy(ProgramHandle program, int location, long x, long y)
            {
                _ProgramUniform2i64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2i64NV");
                _ProgramUniform2i64NV_fnptr(program, location, x, y);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, long, long, long, void> _ProgramUniform3i64NV_fnptr = &ProgramUniform3i64NV_Lazy;
            public static void ProgramUniform3i64NV(ProgramHandle program, int location, long x, long y, long z) => _ProgramUniform3i64NV_fnptr(program, location, x, y, z);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3i64NV_Lazy(ProgramHandle program, int location, long x, long y, long z)
            {
                _ProgramUniform3i64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, long, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3i64NV");
                _ProgramUniform3i64NV_fnptr(program, location, x, y, z);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, long, long, long, long, void> _ProgramUniform4i64NV_fnptr = &ProgramUniform4i64NV_Lazy;
            public static void ProgramUniform4i64NV(ProgramHandle program, int location, long x, long y, long z, long w) => _ProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4i64NV_Lazy(ProgramHandle program, int location, long x, long y, long z, long w)
            {
                _ProgramUniform4i64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, long, long, long, long, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4i64NV");
                _ProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, long*, void> _ProgramUniform1i64vNV_fnptr = &ProgramUniform1i64vNV_Lazy;
            public static void ProgramUniform1i64vNV(ProgramHandle program, int location, int count, long* value) => _ProgramUniform1i64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1i64vNV_Lazy(ProgramHandle program, int location, int count, long* value)
            {
                _ProgramUniform1i64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1i64vNV");
                _ProgramUniform1i64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, long*, void> _ProgramUniform2i64vNV_fnptr = &ProgramUniform2i64vNV_Lazy;
            public static void ProgramUniform2i64vNV(ProgramHandle program, int location, int count, long* value) => _ProgramUniform2i64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2i64vNV_Lazy(ProgramHandle program, int location, int count, long* value)
            {
                _ProgramUniform2i64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2i64vNV");
                _ProgramUniform2i64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, long*, void> _ProgramUniform3i64vNV_fnptr = &ProgramUniform3i64vNV_Lazy;
            public static void ProgramUniform3i64vNV(ProgramHandle program, int location, int count, long* value) => _ProgramUniform3i64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3i64vNV_Lazy(ProgramHandle program, int location, int count, long* value)
            {
                _ProgramUniform3i64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3i64vNV");
                _ProgramUniform3i64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, long*, void> _ProgramUniform4i64vNV_fnptr = &ProgramUniform4i64vNV_Lazy;
            public static void ProgramUniform4i64vNV(ProgramHandle program, int location, int count, long* value) => _ProgramUniform4i64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4i64vNV_Lazy(ProgramHandle program, int location, int count, long* value)
            {
                _ProgramUniform4i64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, long*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4i64vNV");
                _ProgramUniform4i64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, void> _ProgramUniform1ui64NV_fnptr = &ProgramUniform1ui64NV_Lazy;
            public static void ProgramUniform1ui64NV(ProgramHandle program, int location, ulong x) => _ProgramUniform1ui64NV_fnptr(program, location, x);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1ui64NV_Lazy(ProgramHandle program, int location, ulong x)
            {
                _ProgramUniform1ui64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1ui64NV");
                _ProgramUniform1ui64NV_fnptr(program, location, x);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, ulong, void> _ProgramUniform2ui64NV_fnptr = &ProgramUniform2ui64NV_Lazy;
            public static void ProgramUniform2ui64NV(ProgramHandle program, int location, ulong x, ulong y) => _ProgramUniform2ui64NV_fnptr(program, location, x, y);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2ui64NV_Lazy(ProgramHandle program, int location, ulong x, ulong y)
            {
                _ProgramUniform2ui64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2ui64NV");
                _ProgramUniform2ui64NV_fnptr(program, location, x, y);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, ulong, ulong, void> _ProgramUniform3ui64NV_fnptr = &ProgramUniform3ui64NV_Lazy;
            public static void ProgramUniform3ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z) => _ProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3ui64NV_Lazy(ProgramHandle program, int location, ulong x, ulong y, ulong z)
            {
                _ProgramUniform3ui64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3ui64NV");
                _ProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, ulong, ulong, ulong, void> _ProgramUniform4ui64NV_fnptr = &ProgramUniform4ui64NV_Lazy;
            public static void ProgramUniform4ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z, ulong w) => _ProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4ui64NV_Lazy(ProgramHandle program, int location, ulong x, ulong y, ulong z, ulong w)
            {
                _ProgramUniform4ui64NV_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, ulong, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4ui64NV");
                _ProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniform1ui64vNV_fnptr = &ProgramUniform1ui64vNV_Lazy;
            public static void ProgramUniform1ui64vNV(ProgramHandle program, int location, int count, ulong* value) => _ProgramUniform1ui64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform1ui64vNV_Lazy(ProgramHandle program, int location, int count, ulong* value)
            {
                _ProgramUniform1ui64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform1ui64vNV");
                _ProgramUniform1ui64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniform2ui64vNV_fnptr = &ProgramUniform2ui64vNV_Lazy;
            public static void ProgramUniform2ui64vNV(ProgramHandle program, int location, int count, ulong* value) => _ProgramUniform2ui64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform2ui64vNV_Lazy(ProgramHandle program, int location, int count, ulong* value)
            {
                _ProgramUniform2ui64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform2ui64vNV");
                _ProgramUniform2ui64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniform3ui64vNV_fnptr = &ProgramUniform3ui64vNV_Lazy;
            public static void ProgramUniform3ui64vNV(ProgramHandle program, int location, int count, ulong* value) => _ProgramUniform3ui64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform3ui64vNV_Lazy(ProgramHandle program, int location, int count, ulong* value)
            {
                _ProgramUniform3ui64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform3ui64vNV");
                _ProgramUniform3ui64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniform4ui64vNV_fnptr = &ProgramUniform4ui64vNV_Lazy;
            public static void ProgramUniform4ui64vNV(ProgramHandle program, int location, int count, ulong* value) => _ProgramUniform4ui64vNV_fnptr(program, location, count, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniform4ui64vNV_Lazy(ProgramHandle program, int location, int count, ulong* value)
            {
                _ProgramUniform4ui64vNV_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniform4ui64vNV");
                _ProgramUniform4ui64vNV_fnptr(program, location, count, value);
            }
            
            private static delegate* unmanaged<uint, uint, void> _VertexAttribDivisorNV_fnptr = &VertexAttribDivisorNV_Lazy;
            public static void VertexAttribDivisorNV(uint index, uint divisor) => _VertexAttribDivisorNV_fnptr(index, divisor);
            [UnmanagedCallersOnly]
            private static void VertexAttribDivisorNV_Lazy(uint index, uint divisor)
            {
                _VertexAttribDivisorNV_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glVertexAttribDivisorNV");
                _VertexAttribDivisorNV_fnptr(index, divisor);
            }
            
            private static delegate* unmanaged<TextureTarget, InternalFormat, int, InternalFormatPName, int, int*, void> _GetInternalformatSampleivNV_fnptr = &GetInternalformatSampleivNV_Lazy;
            public static void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => _GetInternalformatSampleivNV_fnptr(target, internalformat, samples, pname, count, parameters);
            [UnmanagedCallersOnly]
            private static void GetInternalformatSampleivNV_Lazy(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters)
            {
                _GetInternalformatSampleivNV_fnptr = (delegate* unmanaged<TextureTarget, InternalFormat, int, InternalFormatPName, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInternalformatSampleivNV");
                _GetInternalformatSampleivNV_fnptr(target, internalformat, samples, pname, count, parameters);
            }
            
            private static delegate* unmanaged<uint, All, int, int, uint*, void> _GetMemoryObjectDetachedResourcesuivNV_fnptr = &GetMemoryObjectDetachedResourcesuivNV_Lazy;
            public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, uint* parameters) => _GetMemoryObjectDetachedResourcesuivNV_fnptr(memory, pname, first, count, parameters);
            [UnmanagedCallersOnly]
            private static void GetMemoryObjectDetachedResourcesuivNV_Lazy(uint memory, All pname, int first, int count, uint* parameters)
            {
                _GetMemoryObjectDetachedResourcesuivNV_fnptr = (delegate* unmanaged<uint, All, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMemoryObjectDetachedResourcesuivNV");
                _GetMemoryObjectDetachedResourcesuivNV_fnptr(memory, pname, first, count, parameters);
            }
            
            private static delegate* unmanaged<uint, All, void> _ResetMemoryObjectParameterNV_fnptr = &ResetMemoryObjectParameterNV_Lazy;
            public static void ResetMemoryObjectParameterNV(uint memory, All pname) => _ResetMemoryObjectParameterNV_fnptr(memory, pname);
            [UnmanagedCallersOnly]
            private static void ResetMemoryObjectParameterNV_Lazy(uint memory, All pname)
            {
                _ResetMemoryObjectParameterNV_fnptr = (delegate* unmanaged<uint, All, void>)GLLoader.BindingsContext.GetProcAddress("glResetMemoryObjectParameterNV");
                _ResetMemoryObjectParameterNV_fnptr(memory, pname);
            }
            
            private static delegate* unmanaged<TextureTarget, uint, ulong, void> _TexAttachMemoryNV_fnptr = &TexAttachMemoryNV_Lazy;
            public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => _TexAttachMemoryNV_fnptr(target, memory, offset);
            [UnmanagedCallersOnly]
            private static void TexAttachMemoryNV_Lazy(TextureTarget target, uint memory, ulong offset)
            {
                _TexAttachMemoryNV_fnptr = (delegate* unmanaged<TextureTarget, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTexAttachMemoryNV");
                _TexAttachMemoryNV_fnptr(target, memory, offset);
            }
            
            private static delegate* unmanaged<BufferTargetARB, uint, ulong, void> _BufferAttachMemoryNV_fnptr = &BufferAttachMemoryNV_Lazy;
            public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => _BufferAttachMemoryNV_fnptr(target, memory, offset);
            [UnmanagedCallersOnly]
            private static void BufferAttachMemoryNV_Lazy(BufferTargetARB target, uint memory, ulong offset)
            {
                _BufferAttachMemoryNV_fnptr = (delegate* unmanaged<BufferTargetARB, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glBufferAttachMemoryNV");
                _BufferAttachMemoryNV_fnptr(target, memory, offset);
            }
            
            private static delegate* unmanaged<TextureHandle, uint, ulong, void> _TextureAttachMemoryNV_fnptr = &TextureAttachMemoryNV_Lazy;
            public static void TextureAttachMemoryNV(TextureHandle texture, uint memory, ulong offset) => _TextureAttachMemoryNV_fnptr(texture, memory, offset);
            [UnmanagedCallersOnly]
            private static void TextureAttachMemoryNV_Lazy(TextureHandle texture, uint memory, ulong offset)
            {
                _TextureAttachMemoryNV_fnptr = (delegate* unmanaged<TextureHandle, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glTextureAttachMemoryNV");
                _TextureAttachMemoryNV_fnptr(texture, memory, offset);
            }
            
            private static delegate* unmanaged<BufferHandle, uint, ulong, void> _NamedBufferAttachMemoryNV_fnptr = &NamedBufferAttachMemoryNV_Lazy;
            public static void NamedBufferAttachMemoryNV(BufferHandle buffer, uint memory, ulong offset) => _NamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            [UnmanagedCallersOnly]
            private static void NamedBufferAttachMemoryNV_Lazy(BufferHandle buffer, uint memory, ulong offset)
            {
                _NamedBufferAttachMemoryNV_fnptr = (delegate* unmanaged<BufferHandle, uint, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glNamedBufferAttachMemoryNV");
                _NamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            }
            
            private static delegate* unmanaged<BufferStorageTarget, IntPtr, nint, uint, ulong, byte, void> _BufferPageCommitmentMemNV_fnptr = &BufferPageCommitmentMemNV_Lazy;
            public static void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit) => _BufferPageCommitmentMemNV_fnptr(target, offset, size, memory, memOffset, commit);
            [UnmanagedCallersOnly]
            private static void BufferPageCommitmentMemNV_Lazy(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit)
            {
                _BufferPageCommitmentMemNV_fnptr = (delegate* unmanaged<BufferStorageTarget, IntPtr, nint, uint, ulong, byte, void>)GLLoader.BindingsContext.GetProcAddress("glBufferPageCommitmentMemNV");
                _BufferPageCommitmentMemNV_fnptr(target, offset, size, memory, memOffset, commit);
            }
            
            private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, int, uint, ulong, byte, void> _TexPageCommitmentMemNV_fnptr = &TexPageCommitmentMemNV_Lazy;
            public static void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit) => _TexPageCommitmentMemNV_fnptr(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            [UnmanagedCallersOnly]
            private static void TexPageCommitmentMemNV_Lazy(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit)
            {
                _TexPageCommitmentMemNV_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexPageCommitmentMemNV");
                _TexPageCommitmentMemNV_fnptr(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            }
            
            private static delegate* unmanaged<BufferHandle, IntPtr, nint, uint, ulong, byte, void> _NamedBufferPageCommitmentMemNV_fnptr = &NamedBufferPageCommitmentMemNV_Lazy;
            public static void NamedBufferPageCommitmentMemNV(BufferHandle buffer, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit) => _NamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, commit);
            [UnmanagedCallersOnly]
            private static void NamedBufferPageCommitmentMemNV_Lazy(BufferHandle buffer, IntPtr offset, nint size, uint memory, ulong memOffset, byte commit)
            {
                _NamedBufferPageCommitmentMemNV_fnptr = (delegate* unmanaged<BufferHandle, IntPtr, nint, uint, ulong, byte, void>)GLLoader.BindingsContext.GetProcAddress("glNamedBufferPageCommitmentMemNV");
                _NamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, commit);
            }
            
            private static delegate* unmanaged<TextureHandle, int, int, int, int, int, int, int, int, uint, ulong, byte, void> _TexturePageCommitmentMemNV_fnptr = &TexturePageCommitmentMemNV_Lazy;
            public static void TexturePageCommitmentMemNV(TextureHandle texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit) => _TexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            [UnmanagedCallersOnly]
            private static void TexturePageCommitmentMemNV_Lazy(TextureHandle texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, byte commit)
            {
                _TexturePageCommitmentMemNV_fnptr = (delegate* unmanaged<TextureHandle, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexturePageCommitmentMemNV");
                _TexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
            }
            
            private static delegate* unmanaged<uint, uint, void> _DrawMeshTasksNV_fnptr = &DrawMeshTasksNV_Lazy;
            public static void DrawMeshTasksNV(uint first, uint count) => _DrawMeshTasksNV_fnptr(first, count);
            [UnmanagedCallersOnly]
            private static void DrawMeshTasksNV_Lazy(uint first, uint count)
            {
                _DrawMeshTasksNV_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDrawMeshTasksNV");
                _DrawMeshTasksNV_fnptr(first, count);
            }
            
            private static delegate* unmanaged<IntPtr, void> _DrawMeshTasksIndirectNV_fnptr = &DrawMeshTasksIndirectNV_Lazy;
            public static void DrawMeshTasksIndirectNV(IntPtr indirect) => _DrawMeshTasksIndirectNV_fnptr(indirect);
            [UnmanagedCallersOnly]
            private static void DrawMeshTasksIndirectNV_Lazy(IntPtr indirect)
            {
                _DrawMeshTasksIndirectNV_fnptr = (delegate* unmanaged<IntPtr, void>)GLLoader.BindingsContext.GetProcAddress("glDrawMeshTasksIndirectNV");
                _DrawMeshTasksIndirectNV_fnptr(indirect);
            }
            
            private static delegate* unmanaged<IntPtr, int, int, void> _MultiDrawMeshTasksIndirectNV_fnptr = &MultiDrawMeshTasksIndirectNV_Lazy;
            public static void MultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride) => _MultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            [UnmanagedCallersOnly]
            private static void MultiDrawMeshTasksIndirectNV_Lazy(IntPtr indirect, int drawcount, int stride)
            {
                _MultiDrawMeshTasksIndirectNV_fnptr = (delegate* unmanaged<IntPtr, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawMeshTasksIndirectNV");
                _MultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            }
            
            private static delegate* unmanaged<IntPtr, IntPtr, int, int, void> _MultiDrawMeshTasksIndirectCountNV_fnptr = &MultiDrawMeshTasksIndirectCountNV_Lazy;
            public static void MultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => _MultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            [UnmanagedCallersOnly]
            private static void MultiDrawMeshTasksIndirectCountNV_Lazy(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
            {
                _MultiDrawMeshTasksIndirectCountNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawMeshTasksIndirectCountNV");
                _MultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix2x3fvNV_fnptr = &UniformMatrix2x3fvNV_Lazy;
            public static void UniformMatrix2x3fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix2x3fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix2x3fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix2x3fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix2x3fvNV");
                _UniformMatrix2x3fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix3x2fvNV_fnptr = &UniformMatrix3x2fvNV_Lazy;
            public static void UniformMatrix3x2fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix3x2fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix3x2fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix3x2fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix3x2fvNV");
                _UniformMatrix3x2fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix2x4fvNV_fnptr = &UniformMatrix2x4fvNV_Lazy;
            public static void UniformMatrix2x4fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix2x4fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix2x4fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix2x4fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix2x4fvNV");
                _UniformMatrix2x4fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix4x2fvNV_fnptr = &UniformMatrix4x2fvNV_Lazy;
            public static void UniformMatrix4x2fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix4x2fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix4x2fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix4x2fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix4x2fvNV");
                _UniformMatrix4x2fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix3x4fvNV_fnptr = &UniformMatrix3x4fvNV_Lazy;
            public static void UniformMatrix3x4fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix3x4fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix3x4fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix3x4fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix3x4fvNV");
                _UniformMatrix3x4fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, int, byte, float*, void> _UniformMatrix4x3fvNV_fnptr = &UniformMatrix4x3fvNV_Lazy;
            public static void UniformMatrix4x3fvNV(int location, int count, byte transpose, float* value) => _UniformMatrix4x3fvNV_fnptr(location, count, transpose, value);
            [UnmanagedCallersOnly]
            private static void UniformMatrix4x3fvNV_Lazy(int location, int count, byte transpose, float* value)
            {
                _UniformMatrix4x3fvNV_fnptr = (delegate* unmanaged<int, int, byte, float*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformMatrix4x3fvNV");
                _UniformMatrix4x3fvNV_fnptr(location, count, transpose, value);
            }
            
            private static delegate* unmanaged<int, uint> _GenPathsNV_fnptr = &GenPathsNV_Lazy;
            public static uint GenPathsNV(int range) => _GenPathsNV_fnptr(range);
            [UnmanagedCallersOnly]
            private static uint GenPathsNV_Lazy(int range)
            {
                _GenPathsNV_fnptr = (delegate* unmanaged<int, uint>)GLLoader.BindingsContext.GetProcAddress("glGenPathsNV");
                return _GenPathsNV_fnptr(range);
            }
            
            private static delegate* unmanaged<uint, int, void> _DeletePathsNV_fnptr = &DeletePathsNV_Lazy;
            public static void DeletePathsNV(uint path, int range) => _DeletePathsNV_fnptr(path, range);
            [UnmanagedCallersOnly]
            private static void DeletePathsNV_Lazy(uint path, int range)
            {
                _DeletePathsNV_fnptr = (delegate* unmanaged<uint, int, void>)GLLoader.BindingsContext.GetProcAddress("glDeletePathsNV");
                _DeletePathsNV_fnptr(path, range);
            }
            
            private static delegate* unmanaged<uint, byte> _IsPathNV_fnptr = &IsPathNV_Lazy;
            public static byte IsPathNV(uint path) => _IsPathNV_fnptr(path);
            [UnmanagedCallersOnly]
            private static byte IsPathNV_Lazy(uint path)
            {
                _IsPathNV_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsPathNV");
                return _IsPathNV_fnptr(path);
            }
            
            private static delegate* unmanaged<uint, int, byte*, int, PathCoordType, void*, void> _PathCommandsNV_fnptr = &PathCommandsNV_Lazy;
            public static void PathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => _PathCommandsNV_fnptr(path, numCommands, commands, numCoords, coordType, coords);
            [UnmanagedCallersOnly]
            private static void PathCommandsNV_Lazy(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords)
            {
                _PathCommandsNV_fnptr = (delegate* unmanaged<uint, int, byte*, int, PathCoordType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPathCommandsNV");
                _PathCommandsNV_fnptr(path, numCommands, commands, numCoords, coordType, coords);
            }
            
            private static delegate* unmanaged<uint, int, PathCoordType, void*, void> _PathCoordsNV_fnptr = &PathCoordsNV_Lazy;
            public static void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, void* coords) => _PathCoordsNV_fnptr(path, numCoords, coordType, coords);
            [UnmanagedCallersOnly]
            private static void PathCoordsNV_Lazy(uint path, int numCoords, PathCoordType coordType, void* coords)
            {
                _PathCoordsNV_fnptr = (delegate* unmanaged<uint, int, PathCoordType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPathCoordsNV");
                _PathCoordsNV_fnptr(path, numCoords, coordType, coords);
            }
            
            private static delegate* unmanaged<uint, int, int, int, byte*, int, PathCoordType, void*, void> _PathSubCommandsNV_fnptr = &PathSubCommandsNV_Lazy;
            public static void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => _PathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);
            [UnmanagedCallersOnly]
            private static void PathSubCommandsNV_Lazy(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords)
            {
                _PathSubCommandsNV_fnptr = (delegate* unmanaged<uint, int, int, int, byte*, int, PathCoordType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPathSubCommandsNV");
                _PathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);
            }
            
            private static delegate* unmanaged<uint, int, int, PathCoordType, void*, void> _PathSubCoordsNV_fnptr = &PathSubCoordsNV_Lazy;
            public static void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => _PathSubCoordsNV_fnptr(path, coordStart, numCoords, coordType, coords);
            [UnmanagedCallersOnly]
            private static void PathSubCoordsNV_Lazy(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords)
            {
                _PathSubCoordsNV_fnptr = (delegate* unmanaged<uint, int, int, PathCoordType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPathSubCoordsNV");
                _PathSubCoordsNV_fnptr(path, coordStart, numCoords, coordType, coords);
            }
            
            private static delegate* unmanaged<uint, PathStringFormat, int, void*, void> _PathStringNV_fnptr = &PathStringNV_Lazy;
            public static void PathStringNV(uint path, PathStringFormat format, int length, void* pathString) => _PathStringNV_fnptr(path, format, length, pathString);
            [UnmanagedCallersOnly]
            private static void PathStringNV_Lazy(uint path, PathStringFormat format, int length, void* pathString)
            {
                _PathStringNV_fnptr = (delegate* unmanaged<uint, PathStringFormat, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPathStringNV");
                _PathStringNV_fnptr(path, format, length, pathString);
            }
            
            private static delegate* unmanaged<uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float, void> _PathGlyphsNV_fnptr = &PathGlyphsNV_Lazy;
            public static void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => _PathGlyphsNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
            [UnmanagedCallersOnly]
            private static void PathGlyphsNV_Lazy(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                _PathGlyphsNV_fnptr = (delegate* unmanaged<uint, PathFontTarget, void*, PathFontStyle, int, PathElementType, void*, PathHandleMissingGlyphs, uint, float, void>)GLLoader.BindingsContext.GetProcAddress("glPathGlyphsNV");
                _PathGlyphsNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            
            private static delegate* unmanaged<uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float, void> _PathGlyphRangeNV_fnptr = &PathGlyphRangeNV_Lazy;
            public static void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => _PathGlyphRangeNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            [UnmanagedCallersOnly]
            private static void PathGlyphRangeNV_Lazy(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale)
            {
                _PathGlyphRangeNV_fnptr = (delegate* unmanaged<uint, PathFontTarget, void*, PathFontStyle, uint, int, PathHandleMissingGlyphs, uint, float, void>)GLLoader.BindingsContext.GetProcAddress("glPathGlyphRangeNV");
                _PathGlyphRangeNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
            
            private static delegate* unmanaged<uint, int, uint*, float*, void> _WeightPathsNV_fnptr = &WeightPathsNV_Lazy;
            public static void WeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights) => _WeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            [UnmanagedCallersOnly]
            private static void WeightPathsNV_Lazy(uint resultPath, int numPaths, uint* paths, float* weights)
            {
                _WeightPathsNV_fnptr = (delegate* unmanaged<uint, int, uint*, float*, void>)GLLoader.BindingsContext.GetProcAddress("glWeightPathsNV");
                _WeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            }
            
            private static delegate* unmanaged<uint, uint, void> _CopyPathNV_fnptr = &CopyPathNV_Lazy;
            public static void CopyPathNV(uint resultPath, uint srcPath) => _CopyPathNV_fnptr(resultPath, srcPath);
            [UnmanagedCallersOnly]
            private static void CopyPathNV_Lazy(uint resultPath, uint srcPath)
            {
                _CopyPathNV_fnptr = (delegate* unmanaged<uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glCopyPathNV");
                _CopyPathNV_fnptr(resultPath, srcPath);
            }
            
            private static delegate* unmanaged<uint, uint, uint, float, void> _InterpolatePathsNV_fnptr = &InterpolatePathsNV_Lazy;
            public static void InterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => _InterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            [UnmanagedCallersOnly]
            private static void InterpolatePathsNV_Lazy(uint resultPath, uint pathA, uint pathB, float weight)
            {
                _InterpolatePathsNV_fnptr = (delegate* unmanaged<uint, uint, uint, float, void>)GLLoader.BindingsContext.GetProcAddress("glInterpolatePathsNV");
                _InterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            }
            
            private static delegate* unmanaged<uint, uint, PathTransformType, float*, void> _TransformPathNV_fnptr = &TransformPathNV_Lazy;
            public static void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => _TransformPathNV_fnptr(resultPath, srcPath, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void TransformPathNV_Lazy(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues)
            {
                _TransformPathNV_fnptr = (delegate* unmanaged<uint, uint, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glTransformPathNV");
                _TransformPathNV_fnptr(resultPath, srcPath, transformType, transformValues);
            }
            
            private static delegate* unmanaged<uint, PathParameter, int*, void> _PathParameterivNV_fnptr = &PathParameterivNV_Lazy;
            public static void PathParameterivNV(uint path, PathParameter pname, int* value) => _PathParameterivNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void PathParameterivNV_Lazy(uint path, PathParameter pname, int* value)
            {
                _PathParameterivNV_fnptr = (delegate* unmanaged<uint, PathParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glPathParameterivNV");
                _PathParameterivNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, PathParameter, int, void> _PathParameteriNV_fnptr = &PathParameteriNV_Lazy;
            public static void PathParameteriNV(uint path, PathParameter pname, int value) => _PathParameteriNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void PathParameteriNV_Lazy(uint path, PathParameter pname, int value)
            {
                _PathParameteriNV_fnptr = (delegate* unmanaged<uint, PathParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glPathParameteriNV");
                _PathParameteriNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, PathParameter, float*, void> _PathParameterfvNV_fnptr = &PathParameterfvNV_Lazy;
            public static void PathParameterfvNV(uint path, PathParameter pname, float* value) => _PathParameterfvNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void PathParameterfvNV_Lazy(uint path, PathParameter pname, float* value)
            {
                _PathParameterfvNV_fnptr = (delegate* unmanaged<uint, PathParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glPathParameterfvNV");
                _PathParameterfvNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, PathParameter, float, void> _PathParameterfNV_fnptr = &PathParameterfNV_Lazy;
            public static void PathParameterfNV(uint path, PathParameter pname, float value) => _PathParameterfNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void PathParameterfNV_Lazy(uint path, PathParameter pname, float value)
            {
                _PathParameterfNV_fnptr = (delegate* unmanaged<uint, PathParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glPathParameterfNV");
                _PathParameterfNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, int, float*, void> _PathDashArrayNV_fnptr = &PathDashArrayNV_Lazy;
            public static void PathDashArrayNV(uint path, int dashCount, float* dashArray) => _PathDashArrayNV_fnptr(path, dashCount, dashArray);
            [UnmanagedCallersOnly]
            private static void PathDashArrayNV_Lazy(uint path, int dashCount, float* dashArray)
            {
                _PathDashArrayNV_fnptr = (delegate* unmanaged<uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glPathDashArrayNV");
                _PathDashArrayNV_fnptr(path, dashCount, dashArray);
            }
            
            private static delegate* unmanaged<StencilFunction, int, uint, void> _PathStencilFuncNV_fnptr = &PathStencilFuncNV_Lazy;
            public static void PathStencilFuncNV(StencilFunction func, int reference, uint mask) => _PathStencilFuncNV_fnptr(func, reference, mask);
            [UnmanagedCallersOnly]
            private static void PathStencilFuncNV_Lazy(StencilFunction func, int reference, uint mask)
            {
                _PathStencilFuncNV_fnptr = (delegate* unmanaged<StencilFunction, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glPathStencilFuncNV");
                _PathStencilFuncNV_fnptr(func, reference, mask);
            }
            
            private static delegate* unmanaged<float, float, void> _PathStencilDepthOffsetNV_fnptr = &PathStencilDepthOffsetNV_Lazy;
            public static void PathStencilDepthOffsetNV(float factor, float units) => _PathStencilDepthOffsetNV_fnptr(factor, units);
            [UnmanagedCallersOnly]
            private static void PathStencilDepthOffsetNV_Lazy(float factor, float units)
            {
                _PathStencilDepthOffsetNV_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPathStencilDepthOffsetNV");
                _PathStencilDepthOffsetNV_fnptr(factor, units);
            }
            
            private static delegate* unmanaged<uint, PathFillMode, uint, void> _StencilFillPathNV_fnptr = &StencilFillPathNV_Lazy;
            public static void StencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => _StencilFillPathNV_fnptr(path, fillMode, mask);
            [UnmanagedCallersOnly]
            private static void StencilFillPathNV_Lazy(uint path, PathFillMode fillMode, uint mask)
            {
                _StencilFillPathNV_fnptr = (delegate* unmanaged<uint, PathFillMode, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilFillPathNV");
                _StencilFillPathNV_fnptr(path, fillMode, mask);
            }
            
            private static delegate* unmanaged<uint, int, uint, void> _StencilStrokePathNV_fnptr = &StencilStrokePathNV_Lazy;
            public static void StencilStrokePathNV(uint path, int reference, uint mask) => _StencilStrokePathNV_fnptr(path, reference, mask);
            [UnmanagedCallersOnly]
            private static void StencilStrokePathNV_Lazy(uint path, int reference, uint mask)
            {
                _StencilStrokePathNV_fnptr = (delegate* unmanaged<uint, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilStrokePathNV");
                _StencilStrokePathNV_fnptr(path, reference, mask);
            }
            
            private static delegate* unmanaged<int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*, void> _StencilFillPathInstancedNV_fnptr = &StencilFillPathInstancedNV_Lazy;
            public static void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => _StencilFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void StencilFillPathInstancedNV_Lazy(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues)
            {
                _StencilFillPathInstancedNV_fnptr = (delegate* unmanaged<int, PathElementType, void*, uint, PathFillMode, uint, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glStencilFillPathInstancedNV");
                _StencilFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);
            }
            
            private static delegate* unmanaged<int, PathElementType, void*, uint, int, uint, PathTransformType, float*, void> _StencilStrokePathInstancedNV_fnptr = &StencilStrokePathInstancedNV_Lazy;
            public static void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => _StencilStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void StencilStrokePathInstancedNV_Lazy(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues)
            {
                _StencilStrokePathInstancedNV_fnptr = (delegate* unmanaged<int, PathElementType, void*, uint, int, uint, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glStencilStrokePathInstancedNV");
                _StencilStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);
            }
            
            private static delegate* unmanaged<DepthFunction, void> _PathCoverDepthFuncNV_fnptr = &PathCoverDepthFuncNV_Lazy;
            public static void PathCoverDepthFuncNV(DepthFunction func) => _PathCoverDepthFuncNV_fnptr(func);
            [UnmanagedCallersOnly]
            private static void PathCoverDepthFuncNV_Lazy(DepthFunction func)
            {
                _PathCoverDepthFuncNV_fnptr = (delegate* unmanaged<DepthFunction, void>)GLLoader.BindingsContext.GetProcAddress("glPathCoverDepthFuncNV");
                _PathCoverDepthFuncNV_fnptr(func);
            }
            
            private static delegate* unmanaged<uint, PathCoverMode, void> _CoverFillPathNV_fnptr = &CoverFillPathNV_Lazy;
            public static void CoverFillPathNV(uint path, PathCoverMode coverMode) => _CoverFillPathNV_fnptr(path, coverMode);
            [UnmanagedCallersOnly]
            private static void CoverFillPathNV_Lazy(uint path, PathCoverMode coverMode)
            {
                _CoverFillPathNV_fnptr = (delegate* unmanaged<uint, PathCoverMode, void>)GLLoader.BindingsContext.GetProcAddress("glCoverFillPathNV");
                _CoverFillPathNV_fnptr(path, coverMode);
            }
            
            private static delegate* unmanaged<uint, PathCoverMode, void> _CoverStrokePathNV_fnptr = &CoverStrokePathNV_Lazy;
            public static void CoverStrokePathNV(uint path, PathCoverMode coverMode) => _CoverStrokePathNV_fnptr(path, coverMode);
            [UnmanagedCallersOnly]
            private static void CoverStrokePathNV_Lazy(uint path, PathCoverMode coverMode)
            {
                _CoverStrokePathNV_fnptr = (delegate* unmanaged<uint, PathCoverMode, void>)GLLoader.BindingsContext.GetProcAddress("glCoverStrokePathNV");
                _CoverStrokePathNV_fnptr(path, coverMode);
            }
            
            private static delegate* unmanaged<int, PathElementType, void*, uint, PathCoverMode, PathTransformType, float*, void> _CoverFillPathInstancedNV_fnptr = &CoverFillPathInstancedNV_Lazy;
            public static void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues) => _CoverFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void CoverFillPathInstancedNV_Lazy(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues)
            {
                _CoverFillPathInstancedNV_fnptr = (delegate* unmanaged<int, PathElementType, void*, uint, PathCoverMode, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glCoverFillPathInstancedNV");
                _CoverFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
            }
            
            private static delegate* unmanaged<int, PathElementType, void*, uint, PathCoverMode, PathTransformType, float*, void> _CoverStrokePathInstancedNV_fnptr = &CoverStrokePathInstancedNV_Lazy;
            public static void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues) => _CoverStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void CoverStrokePathInstancedNV_Lazy(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float* transformValues)
            {
                _CoverStrokePathInstancedNV_fnptr = (delegate* unmanaged<int, PathElementType, void*, uint, PathCoverMode, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glCoverStrokePathInstancedNV");
                _CoverStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
            }
            
            private static delegate* unmanaged<uint, PathParameter, int*, void> _GetPathParameterivNV_fnptr = &GetPathParameterivNV_Lazy;
            public static void GetPathParameterivNV(uint path, PathParameter pname, int* value) => _GetPathParameterivNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void GetPathParameterivNV_Lazy(uint path, PathParameter pname, int* value)
            {
                _GetPathParameterivNV_fnptr = (delegate* unmanaged<uint, PathParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathParameterivNV");
                _GetPathParameterivNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, PathParameter, float*, void> _GetPathParameterfvNV_fnptr = &GetPathParameterfvNV_Lazy;
            public static void GetPathParameterfvNV(uint path, PathParameter pname, float* value) => _GetPathParameterfvNV_fnptr(path, pname, value);
            [UnmanagedCallersOnly]
            private static void GetPathParameterfvNV_Lazy(uint path, PathParameter pname, float* value)
            {
                _GetPathParameterfvNV_fnptr = (delegate* unmanaged<uint, PathParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathParameterfvNV");
                _GetPathParameterfvNV_fnptr(path, pname, value);
            }
            
            private static delegate* unmanaged<uint, byte*, void> _GetPathCommandsNV_fnptr = &GetPathCommandsNV_Lazy;
            public static void GetPathCommandsNV(uint path, byte* commands) => _GetPathCommandsNV_fnptr(path, commands);
            [UnmanagedCallersOnly]
            private static void GetPathCommandsNV_Lazy(uint path, byte* commands)
            {
                _GetPathCommandsNV_fnptr = (delegate* unmanaged<uint, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathCommandsNV");
                _GetPathCommandsNV_fnptr(path, commands);
            }
            
            private static delegate* unmanaged<uint, float*, void> _GetPathCoordsNV_fnptr = &GetPathCoordsNV_Lazy;
            public static void GetPathCoordsNV(uint path, float* coords) => _GetPathCoordsNV_fnptr(path, coords);
            [UnmanagedCallersOnly]
            private static void GetPathCoordsNV_Lazy(uint path, float* coords)
            {
                _GetPathCoordsNV_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathCoordsNV");
                _GetPathCoordsNV_fnptr(path, coords);
            }
            
            private static delegate* unmanaged<uint, float*, void> _GetPathDashArrayNV_fnptr = &GetPathDashArrayNV_Lazy;
            public static void GetPathDashArrayNV(uint path, float* dashArray) => _GetPathDashArrayNV_fnptr(path, dashArray);
            [UnmanagedCallersOnly]
            private static void GetPathDashArrayNV_Lazy(uint path, float* dashArray)
            {
                _GetPathDashArrayNV_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathDashArrayNV");
                _GetPathDashArrayNV_fnptr(path, dashArray);
            }
            
            private static delegate* unmanaged<PathMetricMask, int, PathElementType, void*, uint, int, float*, void> _GetPathMetricsNV_fnptr = &GetPathMetricsNV_Lazy;
            public static void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => _GetPathMetricsNV_fnptr(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);
            [UnmanagedCallersOnly]
            private static void GetPathMetricsNV_Lazy(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics)
            {
                _GetPathMetricsNV_fnptr = (delegate* unmanaged<PathMetricMask, int, PathElementType, void*, uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathMetricsNV");
                _GetPathMetricsNV_fnptr(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);
            }
            
            private static delegate* unmanaged<PathMetricMask, uint, int, int, float*, void> _GetPathMetricRangeNV_fnptr = &GetPathMetricRangeNV_Lazy;
            public static void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => _GetPathMetricRangeNV_fnptr(metricQueryMask, firstPathName, numPaths, stride, metrics);
            [UnmanagedCallersOnly]
            private static void GetPathMetricRangeNV_Lazy(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics)
            {
                _GetPathMetricRangeNV_fnptr = (delegate* unmanaged<PathMetricMask, uint, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathMetricRangeNV");
                _GetPathMetricRangeNV_fnptr(metricQueryMask, firstPathName, numPaths, stride, metrics);
            }
            
            private static delegate* unmanaged<PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*, void> _GetPathSpacingNV_fnptr = &GetPathSpacingNV_Lazy;
            public static void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => _GetPathSpacingNV_fnptr(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
            [UnmanagedCallersOnly]
            private static void GetPathSpacingNV_Lazy(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing)
            {
                _GetPathSpacingNV_fnptr = (delegate* unmanaged<PathListMode, int, PathElementType, void*, uint, float, float, PathTransformType, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPathSpacingNV");
                _GetPathSpacingNV_fnptr(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
            }
            
            private static delegate* unmanaged<uint, uint, float, float, byte> _IsPointInFillPathNV_fnptr = &IsPointInFillPathNV_Lazy;
            public static byte IsPointInFillPathNV(uint path, uint mask, float x, float y) => _IsPointInFillPathNV_fnptr(path, mask, x, y);
            [UnmanagedCallersOnly]
            private static byte IsPointInFillPathNV_Lazy(uint path, uint mask, float x, float y)
            {
                _IsPointInFillPathNV_fnptr = (delegate* unmanaged<uint, uint, float, float, byte>)GLLoader.BindingsContext.GetProcAddress("glIsPointInFillPathNV");
                return _IsPointInFillPathNV_fnptr(path, mask, x, y);
            }
            
            private static delegate* unmanaged<uint, float, float, byte> _IsPointInStrokePathNV_fnptr = &IsPointInStrokePathNV_Lazy;
            public static byte IsPointInStrokePathNV(uint path, float x, float y) => _IsPointInStrokePathNV_fnptr(path, x, y);
            [UnmanagedCallersOnly]
            private static byte IsPointInStrokePathNV_Lazy(uint path, float x, float y)
            {
                _IsPointInStrokePathNV_fnptr = (delegate* unmanaged<uint, float, float, byte>)GLLoader.BindingsContext.GetProcAddress("glIsPointInStrokePathNV");
                return _IsPointInStrokePathNV_fnptr(path, x, y);
            }
            
            private static delegate* unmanaged<uint, int, int, float> _GetPathLengthNV_fnptr = &GetPathLengthNV_Lazy;
            public static float GetPathLengthNV(uint path, int startSegment, int numSegments) => _GetPathLengthNV_fnptr(path, startSegment, numSegments);
            [UnmanagedCallersOnly]
            private static float GetPathLengthNV_Lazy(uint path, int startSegment, int numSegments)
            {
                _GetPathLengthNV_fnptr = (delegate* unmanaged<uint, int, int, float>)GLLoader.BindingsContext.GetProcAddress("glGetPathLengthNV");
                return _GetPathLengthNV_fnptr(path, startSegment, numSegments);
            }
            
            private static delegate* unmanaged<uint, int, int, float, float*, float*, float*, float*, byte> _PointAlongPathNV_fnptr = &PointAlongPathNV_Lazy;
            public static byte PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => _PointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);
            [UnmanagedCallersOnly]
            private static byte PointAlongPathNV_Lazy(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY)
            {
                _PointAlongPathNV_fnptr = (delegate* unmanaged<uint, int, int, float, float*, float*, float*, float*, byte>)GLLoader.BindingsContext.GetProcAddress("glPointAlongPathNV");
                return _PointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixLoad3x2fNV_fnptr = &MatrixLoad3x2fNV_Lazy;
            public static void MatrixLoad3x2fNV(All matrixMode, float* m) => _MatrixLoad3x2fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoad3x2fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixLoad3x2fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoad3x2fNV");
                _MatrixLoad3x2fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixLoad3x3fNV_fnptr = &MatrixLoad3x3fNV_Lazy;
            public static void MatrixLoad3x3fNV(All matrixMode, float* m) => _MatrixLoad3x3fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoad3x3fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixLoad3x3fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoad3x3fNV");
                _MatrixLoad3x3fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixLoadTranspose3x3fNV_fnptr = &MatrixLoadTranspose3x3fNV_Lazy;
            public static void MatrixLoadTranspose3x3fNV(All matrixMode, float* m) => _MatrixLoadTranspose3x3fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoadTranspose3x3fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixLoadTranspose3x3fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoadTranspose3x3fNV");
                _MatrixLoadTranspose3x3fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixMult3x2fNV_fnptr = &MatrixMult3x2fNV_Lazy;
            public static void MatrixMult3x2fNV(All matrixMode, float* m) => _MatrixMult3x2fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMult3x2fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixMult3x2fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMult3x2fNV");
                _MatrixMult3x2fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixMult3x3fNV_fnptr = &MatrixMult3x3fNV_Lazy;
            public static void MatrixMult3x3fNV(All matrixMode, float* m) => _MatrixMult3x3fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMult3x3fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixMult3x3fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMult3x3fNV");
                _MatrixMult3x3fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<All, float*, void> _MatrixMultTranspose3x3fNV_fnptr = &MatrixMultTranspose3x3fNV_Lazy;
            public static void MatrixMultTranspose3x3fNV(All matrixMode, float* m) => _MatrixMultTranspose3x3fNV_fnptr(matrixMode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMultTranspose3x3fNV_Lazy(All matrixMode, float* m)
            {
                _MatrixMultTranspose3x3fNV_fnptr = (delegate* unmanaged<All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMultTranspose3x3fNV");
                _MatrixMultTranspose3x3fNV_fnptr(matrixMode, m);
            }
            
            private static delegate* unmanaged<uint, All, uint, All, void> _StencilThenCoverFillPathNV_fnptr = &StencilThenCoverFillPathNV_Lazy;
            public static void StencilThenCoverFillPathNV(uint path, All fillMode, uint mask, All coverMode) => _StencilThenCoverFillPathNV_fnptr(path, fillMode, mask, coverMode);
            [UnmanagedCallersOnly]
            private static void StencilThenCoverFillPathNV_Lazy(uint path, All fillMode, uint mask, All coverMode)
            {
                _StencilThenCoverFillPathNV_fnptr = (delegate* unmanaged<uint, All, uint, All, void>)GLLoader.BindingsContext.GetProcAddress("glStencilThenCoverFillPathNV");
                _StencilThenCoverFillPathNV_fnptr(path, fillMode, mask, coverMode);
            }
            
            private static delegate* unmanaged<uint, int, uint, All, void> _StencilThenCoverStrokePathNV_fnptr = &StencilThenCoverStrokePathNV_Lazy;
            public static void StencilThenCoverStrokePathNV(uint path, int reference, uint mask, All coverMode) => _StencilThenCoverStrokePathNV_fnptr(path, reference, mask, coverMode);
            [UnmanagedCallersOnly]
            private static void StencilThenCoverStrokePathNV_Lazy(uint path, int reference, uint mask, All coverMode)
            {
                _StencilThenCoverStrokePathNV_fnptr = (delegate* unmanaged<uint, int, uint, All, void>)GLLoader.BindingsContext.GetProcAddress("glStencilThenCoverStrokePathNV");
                _StencilThenCoverStrokePathNV_fnptr(path, reference, mask, coverMode);
            }
            
            private static delegate* unmanaged<int, All, void*, uint, All, uint, All, All, float*, void> _StencilThenCoverFillPathInstancedNV_fnptr = &StencilThenCoverFillPathInstancedNV_Lazy;
            public static void StencilThenCoverFillPathInstancedNV(int numPaths, All pathNameType, void* paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, float* transformValues) => _StencilThenCoverFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void StencilThenCoverFillPathInstancedNV_Lazy(int numPaths, All pathNameType, void* paths, uint pathBase, All fillMode, uint mask, All coverMode, All transformType, float* transformValues)
            {
                _StencilThenCoverFillPathInstancedNV_fnptr = (delegate* unmanaged<int, All, void*, uint, All, uint, All, All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glStencilThenCoverFillPathInstancedNV");
                _StencilThenCoverFillPathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);
            }
            
            private static delegate* unmanaged<int, All, void*, uint, int, uint, All, All, float*, void> _StencilThenCoverStrokePathInstancedNV_fnptr = &StencilThenCoverStrokePathInstancedNV_Lazy;
            public static void StencilThenCoverStrokePathInstancedNV(int numPaths, All pathNameType, void* paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, float* transformValues) => _StencilThenCoverStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);
            [UnmanagedCallersOnly]
            private static void StencilThenCoverStrokePathInstancedNV_Lazy(int numPaths, All pathNameType, void* paths, uint pathBase, int reference, uint mask, All coverMode, All transformType, float* transformValues)
            {
                _StencilThenCoverStrokePathInstancedNV_fnptr = (delegate* unmanaged<int, All, void*, uint, int, uint, All, All, float*, void>)GLLoader.BindingsContext.GetProcAddress("glStencilThenCoverStrokePathInstancedNV");
                _StencilThenCoverStrokePathInstancedNV_fnptr(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);
            }
            
            private static delegate* unmanaged<All, void*, PathFontStyle, uint, float, uint*, All> _PathGlyphIndexRangeNV_fnptr = &PathGlyphIndexRangeNV_Lazy;
            public static All PathGlyphIndexRangeNV(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => _PathGlyphIndexRangeNV_fnptr(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount);
            [UnmanagedCallersOnly]
            private static All PathGlyphIndexRangeNV_Lazy(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount)
            {
                _PathGlyphIndexRangeNV_fnptr = (delegate* unmanaged<All, void*, PathFontStyle, uint, float, uint*, All>)GLLoader.BindingsContext.GetProcAddress("glPathGlyphIndexRangeNV");
                return _PathGlyphIndexRangeNV_fnptr(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount);
            }
            
            private static delegate* unmanaged<uint, All, void*, PathFontStyle, uint, int, uint, float, All> _PathGlyphIndexArrayNV_fnptr = &PathGlyphIndexArrayNV_Lazy;
            public static All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => _PathGlyphIndexArrayNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            [UnmanagedCallersOnly]
            private static All PathGlyphIndexArrayNV_Lazy(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                _PathGlyphIndexArrayNV_fnptr = (delegate* unmanaged<uint, All, void*, PathFontStyle, uint, int, uint, float, All>)GLLoader.BindingsContext.GetProcAddress("glPathGlyphIndexArrayNV");
                return _PathGlyphIndexArrayNV_fnptr(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            }
            
            private static delegate* unmanaged<uint, All, nint, void*, int, uint, int, uint, float, All> _PathMemoryGlyphIndexArrayNV_fnptr = &PathMemoryGlyphIndexArrayNV_Lazy;
            public static All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => _PathMemoryGlyphIndexArrayNV_fnptr(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            [UnmanagedCallersOnly]
            private static All PathMemoryGlyphIndexArrayNV_Lazy(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale)
            {
                _PathMemoryGlyphIndexArrayNV_fnptr = (delegate* unmanaged<uint, All, nint, void*, int, uint, int, uint, float, All>)GLLoader.BindingsContext.GetProcAddress("glPathMemoryGlyphIndexArrayNV");
                return _PathMemoryGlyphIndexArrayNV_fnptr(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, All, int, float*, void> _ProgramPathFragmentInputGenNV_fnptr = &ProgramPathFragmentInputGenNV_Lazy;
            public static void ProgramPathFragmentInputGenNV(ProgramHandle program, int location, All genMode, int components, float* coeffs) => _ProgramPathFragmentInputGenNV_fnptr(program, location, genMode, components, coeffs);
            [UnmanagedCallersOnly]
            private static void ProgramPathFragmentInputGenNV_Lazy(ProgramHandle program, int location, All genMode, int components, float* coeffs)
            {
                _ProgramPathFragmentInputGenNV_fnptr = (delegate* unmanaged<ProgramHandle, int, All, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramPathFragmentInputGenNV");
                _ProgramPathFragmentInputGenNV_fnptr(program, location, genMode, components, coeffs);
            }
            
            private static delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, All*, int, int*, float*, void> _GetProgramResourcefvNV_fnptr = &GetProgramResourcefvNV_Lazy;
            public static void GetProgramResourcefvNV(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => _GetProgramResourcefvNV_fnptr(program, programInterface, index, propCount, props, count, length, parameters);
            [UnmanagedCallersOnly]
            private static void GetProgramResourcefvNV_Lazy(ProgramHandle program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters)
            {
                _GetProgramResourcefvNV_fnptr = (delegate* unmanaged<ProgramHandle, ProgramInterface, uint, int, All*, int, int*, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramResourcefvNV");
                _GetProgramResourcefvNV_fnptr(program, programInterface, index, propCount, props, count, length, parameters);
            }
            
            private static delegate* unmanaged<MatrixMode, double, double, double, double, double, double, void> _MatrixFrustumEXT_fnptr = &MatrixFrustumEXT_Lazy;
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => _MatrixFrustumEXT_fnptr(mode, left, right, bottom, top, zNear, zFar);
            [UnmanagedCallersOnly]
            private static void MatrixFrustumEXT_Lazy(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
            {
                _MatrixFrustumEXT_fnptr = (delegate* unmanaged<MatrixMode, double, double, double, double, double, double, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixFrustumEXT");
                _MatrixFrustumEXT_fnptr(mode, left, right, bottom, top, zNear, zFar);
            }
            
            private static delegate* unmanaged<MatrixMode, void> _MatrixLoadIdentityEXT_fnptr = &MatrixLoadIdentityEXT_Lazy;
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => _MatrixLoadIdentityEXT_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void MatrixLoadIdentityEXT_Lazy(MatrixMode mode)
            {
                _MatrixLoadIdentityEXT_fnptr = (delegate* unmanaged<MatrixMode, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoadIdentityEXT");
                _MatrixLoadIdentityEXT_fnptr(mode);
            }
            
            private static delegate* unmanaged<MatrixMode, float*, void> _MatrixLoadTransposefEXT_fnptr = &MatrixLoadTransposefEXT_Lazy;
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => _MatrixLoadTransposefEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoadTransposefEXT_Lazy(MatrixMode mode, float* m)
            {
                _MatrixLoadTransposefEXT_fnptr = (delegate* unmanaged<MatrixMode, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoadTransposefEXT");
                _MatrixLoadTransposefEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, double*, void> _MatrixLoadTransposedEXT_fnptr = &MatrixLoadTransposedEXT_Lazy;
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => _MatrixLoadTransposedEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoadTransposedEXT_Lazy(MatrixMode mode, double* m)
            {
                _MatrixLoadTransposedEXT_fnptr = (delegate* unmanaged<MatrixMode, double*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoadTransposedEXT");
                _MatrixLoadTransposedEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, float*, void> _MatrixLoadfEXT_fnptr = &MatrixLoadfEXT_Lazy;
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => _MatrixLoadfEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoadfEXT_Lazy(MatrixMode mode, float* m)
            {
                _MatrixLoadfEXT_fnptr = (delegate* unmanaged<MatrixMode, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoadfEXT");
                _MatrixLoadfEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, double*, void> _MatrixLoaddEXT_fnptr = &MatrixLoaddEXT_Lazy;
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => _MatrixLoaddEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixLoaddEXT_Lazy(MatrixMode mode, double* m)
            {
                _MatrixLoaddEXT_fnptr = (delegate* unmanaged<MatrixMode, double*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixLoaddEXT");
                _MatrixLoaddEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, float*, void> _MatrixMultTransposefEXT_fnptr = &MatrixMultTransposefEXT_Lazy;
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => _MatrixMultTransposefEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMultTransposefEXT_Lazy(MatrixMode mode, float* m)
            {
                _MatrixMultTransposefEXT_fnptr = (delegate* unmanaged<MatrixMode, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMultTransposefEXT");
                _MatrixMultTransposefEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, double*, void> _MatrixMultTransposedEXT_fnptr = &MatrixMultTransposedEXT_Lazy;
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => _MatrixMultTransposedEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMultTransposedEXT_Lazy(MatrixMode mode, double* m)
            {
                _MatrixMultTransposedEXT_fnptr = (delegate* unmanaged<MatrixMode, double*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMultTransposedEXT");
                _MatrixMultTransposedEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, float*, void> _MatrixMultfEXT_fnptr = &MatrixMultfEXT_Lazy;
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => _MatrixMultfEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMultfEXT_Lazy(MatrixMode mode, float* m)
            {
                _MatrixMultfEXT_fnptr = (delegate* unmanaged<MatrixMode, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMultfEXT");
                _MatrixMultfEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, double*, void> _MatrixMultdEXT_fnptr = &MatrixMultdEXT_Lazy;
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => _MatrixMultdEXT_fnptr(mode, m);
            [UnmanagedCallersOnly]
            private static void MatrixMultdEXT_Lazy(MatrixMode mode, double* m)
            {
                _MatrixMultdEXT_fnptr = (delegate* unmanaged<MatrixMode, double*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMultdEXT");
                _MatrixMultdEXT_fnptr(mode, m);
            }
            
            private static delegate* unmanaged<MatrixMode, double, double, double, double, double, double, void> _MatrixOrthoEXT_fnptr = &MatrixOrthoEXT_Lazy;
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => _MatrixOrthoEXT_fnptr(mode, left, right, bottom, top, zNear, zFar);
            [UnmanagedCallersOnly]
            private static void MatrixOrthoEXT_Lazy(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
            {
                _MatrixOrthoEXT_fnptr = (delegate* unmanaged<MatrixMode, double, double, double, double, double, double, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixOrthoEXT");
                _MatrixOrthoEXT_fnptr(mode, left, right, bottom, top, zNear, zFar);
            }
            
            private static delegate* unmanaged<MatrixMode, void> _MatrixPopEXT_fnptr = &MatrixPopEXT_Lazy;
            public static void MatrixPopEXT(MatrixMode mode) => _MatrixPopEXT_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void MatrixPopEXT_Lazy(MatrixMode mode)
            {
                _MatrixPopEXT_fnptr = (delegate* unmanaged<MatrixMode, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixPopEXT");
                _MatrixPopEXT_fnptr(mode);
            }
            
            private static delegate* unmanaged<MatrixMode, void> _MatrixPushEXT_fnptr = &MatrixPushEXT_Lazy;
            public static void MatrixPushEXT(MatrixMode mode) => _MatrixPushEXT_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void MatrixPushEXT_Lazy(MatrixMode mode)
            {
                _MatrixPushEXT_fnptr = (delegate* unmanaged<MatrixMode, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixPushEXT");
                _MatrixPushEXT_fnptr(mode);
            }
            
            private static delegate* unmanaged<MatrixMode, float, float, float, float, void> _MatrixRotatefEXT_fnptr = &MatrixRotatefEXT_Lazy;
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => _MatrixRotatefEXT_fnptr(mode, angle, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixRotatefEXT_Lazy(MatrixMode mode, float angle, float x, float y, float z)
            {
                _MatrixRotatefEXT_fnptr = (delegate* unmanaged<MatrixMode, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixRotatefEXT");
                _MatrixRotatefEXT_fnptr(mode, angle, x, y, z);
            }
            
            private static delegate* unmanaged<MatrixMode, double, double, double, double, void> _MatrixRotatedEXT_fnptr = &MatrixRotatedEXT_Lazy;
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => _MatrixRotatedEXT_fnptr(mode, angle, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixRotatedEXT_Lazy(MatrixMode mode, double angle, double x, double y, double z)
            {
                _MatrixRotatedEXT_fnptr = (delegate* unmanaged<MatrixMode, double, double, double, double, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixRotatedEXT");
                _MatrixRotatedEXT_fnptr(mode, angle, x, y, z);
            }
            
            private static delegate* unmanaged<MatrixMode, float, float, float, void> _MatrixScalefEXT_fnptr = &MatrixScalefEXT_Lazy;
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => _MatrixScalefEXT_fnptr(mode, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixScalefEXT_Lazy(MatrixMode mode, float x, float y, float z)
            {
                _MatrixScalefEXT_fnptr = (delegate* unmanaged<MatrixMode, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixScalefEXT");
                _MatrixScalefEXT_fnptr(mode, x, y, z);
            }
            
            private static delegate* unmanaged<MatrixMode, double, double, double, void> _MatrixScaledEXT_fnptr = &MatrixScaledEXT_Lazy;
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => _MatrixScaledEXT_fnptr(mode, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixScaledEXT_Lazy(MatrixMode mode, double x, double y, double z)
            {
                _MatrixScaledEXT_fnptr = (delegate* unmanaged<MatrixMode, double, double, double, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixScaledEXT");
                _MatrixScaledEXT_fnptr(mode, x, y, z);
            }
            
            private static delegate* unmanaged<MatrixMode, float, float, float, void> _MatrixTranslatefEXT_fnptr = &MatrixTranslatefEXT_Lazy;
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => _MatrixTranslatefEXT_fnptr(mode, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixTranslatefEXT_Lazy(MatrixMode mode, float x, float y, float z)
            {
                _MatrixTranslatefEXT_fnptr = (delegate* unmanaged<MatrixMode, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixTranslatefEXT");
                _MatrixTranslatefEXT_fnptr(mode, x, y, z);
            }
            
            private static delegate* unmanaged<MatrixMode, double, double, double, void> _MatrixTranslatedEXT_fnptr = &MatrixTranslatedEXT_Lazy;
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => _MatrixTranslatedEXT_fnptr(mode, x, y, z);
            [UnmanagedCallersOnly]
            private static void MatrixTranslatedEXT_Lazy(MatrixMode mode, double x, double y, double z)
            {
                _MatrixTranslatedEXT_fnptr = (delegate* unmanaged<MatrixMode, double, double, double, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixTranslatedEXT");
                _MatrixTranslatedEXT_fnptr(mode, x, y, z);
            }
            
            private static delegate* unmanaged<MaterialFace, PolygonMode, void> _PolygonModeNV_fnptr = &PolygonModeNV_Lazy;
            public static void PolygonModeNV(MaterialFace face, PolygonMode mode) => _PolygonModeNV_fnptr(face, mode);
            [UnmanagedCallersOnly]
            private static void PolygonModeNV_Lazy(MaterialFace face, PolygonMode mode)
            {
                _PolygonModeNV_fnptr = (delegate* unmanaged<MaterialFace, PolygonMode, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonModeNV");
                _PolygonModeNV_fnptr(face, mode);
            }
            
            private static delegate* unmanaged<All, void> _ReadBufferNV_fnptr = &ReadBufferNV_Lazy;
            public static void ReadBufferNV(All mode) => _ReadBufferNV_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void ReadBufferNV_Lazy(All mode)
            {
                _ReadBufferNV_fnptr = (delegate* unmanaged<All, void>)GLLoader.BindingsContext.GetProcAddress("glReadBufferNV");
                _ReadBufferNV_fnptr(mode);
            }
            
            private static delegate* unmanaged<FramebufferTarget, uint, int, float*, void> _FramebufferSampleLocationsfvNV_fnptr = &FramebufferSampleLocationsfvNV_Lazy;
            public static void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, float* v) => _FramebufferSampleLocationsfvNV_fnptr(target, start, count, v);
            [UnmanagedCallersOnly]
            private static void FramebufferSampleLocationsfvNV_Lazy(FramebufferTarget target, uint start, int count, float* v)
            {
                _FramebufferSampleLocationsfvNV_fnptr = (delegate* unmanaged<FramebufferTarget, uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferSampleLocationsfvNV");
                _FramebufferSampleLocationsfvNV_fnptr(target, start, count, v);
            }
            
            private static delegate* unmanaged<FramebufferHandle, uint, int, float*, void> _NamedFramebufferSampleLocationsfvNV_fnptr = &NamedFramebufferSampleLocationsfvNV_Lazy;
            public static void NamedFramebufferSampleLocationsfvNV(FramebufferHandle framebuffer, uint start, int count, float* v) => _NamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            [UnmanagedCallersOnly]
            private static void NamedFramebufferSampleLocationsfvNV_Lazy(FramebufferHandle framebuffer, uint start, int count, float* v)
            {
                _NamedFramebufferSampleLocationsfvNV_fnptr = (delegate* unmanaged<FramebufferHandle, uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glNamedFramebufferSampleLocationsfvNV");
                _NamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            }
            
            private static delegate* unmanaged<void> _ResolveDepthValuesNV_fnptr = &ResolveDepthValuesNV_Lazy;
            public static void ResolveDepthValuesNV() => _ResolveDepthValuesNV_fnptr();
            [UnmanagedCallersOnly]
            private static void ResolveDepthValuesNV_Lazy()
            {
                _ResolveDepthValuesNV_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glResolveDepthValuesNV");
                _ResolveDepthValuesNV_fnptr();
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _ScissorExclusiveNV_fnptr = &ScissorExclusiveNV_Lazy;
            public static void ScissorExclusiveNV(int x, int y, int width, int height) => _ScissorExclusiveNV_fnptr(x, y, width, height);
            [UnmanagedCallersOnly]
            private static void ScissorExclusiveNV_Lazy(int x, int y, int width, int height)
            {
                _ScissorExclusiveNV_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScissorExclusiveNV");
                _ScissorExclusiveNV_fnptr(x, y, width, height);
            }
            
            private static delegate* unmanaged<uint, int, int*, void> _ScissorExclusiveArrayvNV_fnptr = &ScissorExclusiveArrayvNV_Lazy;
            public static void ScissorExclusiveArrayvNV(uint first, int count, int* v) => _ScissorExclusiveArrayvNV_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void ScissorExclusiveArrayvNV_Lazy(uint first, int count, int* v)
            {
                _ScissorExclusiveArrayvNV_fnptr = (delegate* unmanaged<uint, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glScissorExclusiveArrayvNV");
                _ScissorExclusiveArrayvNV_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<TextureHandle, void> _BindShadingRateImageNV_fnptr = &BindShadingRateImageNV_Lazy;
            public static void BindShadingRateImageNV(TextureHandle texture) => _BindShadingRateImageNV_fnptr(texture);
            [UnmanagedCallersOnly]
            private static void BindShadingRateImageNV_Lazy(TextureHandle texture)
            {
                _BindShadingRateImageNV_fnptr = (delegate* unmanaged<TextureHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindShadingRateImageNV");
                _BindShadingRateImageNV_fnptr(texture);
            }
            
            private static delegate* unmanaged<uint, uint, All*, void> _GetShadingRateImagePaletteNV_fnptr = &GetShadingRateImagePaletteNV_Lazy;
            public static void GetShadingRateImagePaletteNV(uint viewport, uint entry, All* rate) => _GetShadingRateImagePaletteNV_fnptr(viewport, entry, rate);
            [UnmanagedCallersOnly]
            private static void GetShadingRateImagePaletteNV_Lazy(uint viewport, uint entry, All* rate)
            {
                _GetShadingRateImagePaletteNV_fnptr = (delegate* unmanaged<uint, uint, All*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShadingRateImagePaletteNV");
                _GetShadingRateImagePaletteNV_fnptr(viewport, entry, rate);
            }
            
            private static delegate* unmanaged<All, uint, uint, int*, void> _GetShadingRateSampleLocationivNV_fnptr = &GetShadingRateSampleLocationivNV_Lazy;
            public static void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int* location) => _GetShadingRateSampleLocationivNV_fnptr(rate, samples, index, location);
            [UnmanagedCallersOnly]
            private static void GetShadingRateSampleLocationivNV_Lazy(All rate, uint samples, uint index, int* location)
            {
                _GetShadingRateSampleLocationivNV_fnptr = (delegate* unmanaged<All, uint, uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetShadingRateSampleLocationivNV");
                _GetShadingRateSampleLocationivNV_fnptr(rate, samples, index, location);
            }
            
            private static delegate* unmanaged<byte, void> _ShadingRateImageBarrierNV_fnptr = &ShadingRateImageBarrierNV_Lazy;
            public static void ShadingRateImageBarrierNV(byte synchronize) => _ShadingRateImageBarrierNV_fnptr(synchronize);
            [UnmanagedCallersOnly]
            private static void ShadingRateImageBarrierNV_Lazy(byte synchronize)
            {
                _ShadingRateImageBarrierNV_fnptr = (delegate* unmanaged<byte, void>)GLLoader.BindingsContext.GetProcAddress("glShadingRateImageBarrierNV");
                _ShadingRateImageBarrierNV_fnptr(synchronize);
            }
            
            private static delegate* unmanaged<uint, uint, int, All*, void> _ShadingRateImagePaletteNV_fnptr = &ShadingRateImagePaletteNV_Lazy;
            public static void ShadingRateImagePaletteNV(uint viewport, uint first, int count, All* rates) => _ShadingRateImagePaletteNV_fnptr(viewport, first, count, rates);
            [UnmanagedCallersOnly]
            private static void ShadingRateImagePaletteNV_Lazy(uint viewport, uint first, int count, All* rates)
            {
                _ShadingRateImagePaletteNV_fnptr = (delegate* unmanaged<uint, uint, int, All*, void>)GLLoader.BindingsContext.GetProcAddress("glShadingRateImagePaletteNV");
                _ShadingRateImagePaletteNV_fnptr(viewport, first, count, rates);
            }
            
            private static delegate* unmanaged<All, void> _ShadingRateSampleOrderNV_fnptr = &ShadingRateSampleOrderNV_Lazy;
            public static void ShadingRateSampleOrderNV(All order) => _ShadingRateSampleOrderNV_fnptr(order);
            [UnmanagedCallersOnly]
            private static void ShadingRateSampleOrderNV_Lazy(All order)
            {
                _ShadingRateSampleOrderNV_fnptr = (delegate* unmanaged<All, void>)GLLoader.BindingsContext.GetProcAddress("glShadingRateSampleOrderNV");
                _ShadingRateSampleOrderNV_fnptr(order);
            }
            
            private static delegate* unmanaged<All, uint, int*, void> _ShadingRateSampleOrderCustomNV_fnptr = &ShadingRateSampleOrderCustomNV_Lazy;
            public static void ShadingRateSampleOrderCustomNV(All rate, uint samples, int* locations) => _ShadingRateSampleOrderCustomNV_fnptr(rate, samples, locations);
            [UnmanagedCallersOnly]
            private static void ShadingRateSampleOrderCustomNV_Lazy(All rate, uint samples, int* locations)
            {
                _ShadingRateSampleOrderCustomNV_fnptr = (delegate* unmanaged<All, uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glShadingRateSampleOrderCustomNV");
                _ShadingRateSampleOrderCustomNV_fnptr(rate, samples, locations);
            }
            
            private static delegate* unmanaged<uint, int, float*, void> _ViewportArrayvNV_fnptr = &ViewportArrayvNV_Lazy;
            public static void ViewportArrayvNV(uint first, int count, float* v) => _ViewportArrayvNV_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void ViewportArrayvNV_Lazy(uint first, int count, float* v)
            {
                _ViewportArrayvNV_fnptr = (delegate* unmanaged<uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glViewportArrayvNV");
                _ViewportArrayvNV_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, float, float, float, float, void> _ViewportIndexedfNV_fnptr = &ViewportIndexedfNV_Lazy;
            public static void ViewportIndexedfNV(uint index, float x, float y, float w, float h) => _ViewportIndexedfNV_fnptr(index, x, y, w, h);
            [UnmanagedCallersOnly]
            private static void ViewportIndexedfNV_Lazy(uint index, float x, float y, float w, float h)
            {
                _ViewportIndexedfNV_fnptr = (delegate* unmanaged<uint, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glViewportIndexedfNV");
                _ViewportIndexedfNV_fnptr(index, x, y, w, h);
            }
            
            private static delegate* unmanaged<uint, float*, void> _ViewportIndexedfvNV_fnptr = &ViewportIndexedfvNV_Lazy;
            public static void ViewportIndexedfvNV(uint index, float* v) => _ViewportIndexedfvNV_fnptr(index, v);
            [UnmanagedCallersOnly]
            private static void ViewportIndexedfvNV_Lazy(uint index, float* v)
            {
                _ViewportIndexedfvNV_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glViewportIndexedfvNV");
                _ViewportIndexedfvNV_fnptr(index, v);
            }
            
            private static delegate* unmanaged<uint, int, int*, void> _ScissorArrayvNV_fnptr = &ScissorArrayvNV_Lazy;
            public static void ScissorArrayvNV(uint first, int count, int* v) => _ScissorArrayvNV_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void ScissorArrayvNV_Lazy(uint first, int count, int* v)
            {
                _ScissorArrayvNV_fnptr = (delegate* unmanaged<uint, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glScissorArrayvNV");
                _ScissorArrayvNV_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, int, int, int, int, void> _ScissorIndexedNV_fnptr = &ScissorIndexedNV_Lazy;
            public static void ScissorIndexedNV(uint index, int left, int bottom, int width, int height) => _ScissorIndexedNV_fnptr(index, left, bottom, width, height);
            [UnmanagedCallersOnly]
            private static void ScissorIndexedNV_Lazy(uint index, int left, int bottom, int width, int height)
            {
                _ScissorIndexedNV_fnptr = (delegate* unmanaged<uint, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScissorIndexedNV");
                _ScissorIndexedNV_fnptr(index, left, bottom, width, height);
            }
            
            private static delegate* unmanaged<uint, int*, void> _ScissorIndexedvNV_fnptr = &ScissorIndexedvNV_Lazy;
            public static void ScissorIndexedvNV(uint index, int* v) => _ScissorIndexedvNV_fnptr(index, v);
            [UnmanagedCallersOnly]
            private static void ScissorIndexedvNV_Lazy(uint index, int* v)
            {
                _ScissorIndexedvNV_fnptr = (delegate* unmanaged<uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glScissorIndexedvNV");
                _ScissorIndexedvNV_fnptr(index, v);
            }
            
            private static delegate* unmanaged<uint, int, float*, void> _DepthRangeArrayfvNV_fnptr = &DepthRangeArrayfvNV_Lazy;
            public static void DepthRangeArrayfvNV(uint first, int count, float* v) => _DepthRangeArrayfvNV_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void DepthRangeArrayfvNV_Lazy(uint first, int count, float* v)
            {
                _DepthRangeArrayfvNV_fnptr = (delegate* unmanaged<uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangeArrayfvNV");
                _DepthRangeArrayfvNV_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, float, float, void> _DepthRangeIndexedfNV_fnptr = &DepthRangeIndexedfNV_Lazy;
            public static void DepthRangeIndexedfNV(uint index, float n, float f) => _DepthRangeIndexedfNV_fnptr(index, n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangeIndexedfNV_Lazy(uint index, float n, float f)
            {
                _DepthRangeIndexedfNV_fnptr = (delegate* unmanaged<uint, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangeIndexedfNV");
                _DepthRangeIndexedfNV_fnptr(index, n, f);
            }
            
            private static delegate* unmanaged<GetPName, uint, float*, void> _GetFloati_vNV_fnptr = &GetFloati_vNV_Lazy;
            public static void GetFloati_vNV(GetPName target, uint index, float* data) => _GetFloati_vNV_fnptr(target, index, data);
            [UnmanagedCallersOnly]
            private static void GetFloati_vNV_Lazy(GetPName target, uint index, float* data)
            {
                _GetFloati_vNV_fnptr = (delegate* unmanaged<GetPName, uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFloati_vNV");
                _GetFloati_vNV_fnptr(target, index, data);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _EnableiNV_fnptr = &EnableiNV_Lazy;
            public static void EnableiNV(EnableCap target, uint index) => _EnableiNV_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void EnableiNV_Lazy(EnableCap target, uint index)
            {
                _EnableiNV_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableiNV");
                _EnableiNV_fnptr(target, index);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _DisableiNV_fnptr = &DisableiNV_Lazy;
            public static void DisableiNV(EnableCap target, uint index) => _DisableiNV_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void DisableiNV_Lazy(EnableCap target, uint index)
            {
                _DisableiNV_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableiNV");
                _DisableiNV_fnptr(target, index);
            }
            
            private static delegate* unmanaged<EnableCap, uint, byte> _IsEnablediNV_fnptr = &IsEnablediNV_Lazy;
            public static byte IsEnablediNV(EnableCap target, uint index) => _IsEnablediNV_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static byte IsEnablediNV_Lazy(EnableCap target, uint index)
            {
                _IsEnablediNV_fnptr = (delegate* unmanaged<EnableCap, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnablediNV");
                return _IsEnablediNV_fnptr(target, index);
            }
            
            private static delegate* unmanaged<uint, All, All, All, All, void> _ViewportSwizzleNV_fnptr = &ViewportSwizzleNV_Lazy;
            public static void ViewportSwizzleNV(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => _ViewportSwizzleNV_fnptr(index, swizzlex, swizzley, swizzlez, swizzlew);
            [UnmanagedCallersOnly]
            private static void ViewportSwizzleNV_Lazy(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew)
            {
                _ViewportSwizzleNV_fnptr = (delegate* unmanaged<uint, All, All, All, All, void>)GLLoader.BindingsContext.GetProcAddress("glViewportSwizzleNV");
                _ViewportSwizzleNV_fnptr(index, swizzlex, swizzley, swizzlez, swizzlew);
            }
            
        }
        public static unsafe partial class IMG
        {
            private static delegate* unmanaged<TextureHandle, ulong> _GetTextureHandleIMG_fnptr = &GetTextureHandleIMG_Lazy;
            public static ulong GetTextureHandleIMG(TextureHandle texture) => _GetTextureHandleIMG_fnptr(texture);
            [UnmanagedCallersOnly]
            private static ulong GetTextureHandleIMG_Lazy(TextureHandle texture)
            {
                _GetTextureHandleIMG_fnptr = (delegate* unmanaged<TextureHandle, ulong>)GLLoader.BindingsContext.GetProcAddress("glGetTextureHandleIMG");
                return _GetTextureHandleIMG_fnptr(texture);
            }
            
            private static delegate* unmanaged<TextureHandle, SamplerHandle, ulong> _GetTextureSamplerHandleIMG_fnptr = &GetTextureSamplerHandleIMG_Lazy;
            public static ulong GetTextureSamplerHandleIMG(TextureHandle texture, SamplerHandle sampler) => _GetTextureSamplerHandleIMG_fnptr(texture, sampler);
            [UnmanagedCallersOnly]
            private static ulong GetTextureSamplerHandleIMG_Lazy(TextureHandle texture, SamplerHandle sampler)
            {
                _GetTextureSamplerHandleIMG_fnptr = (delegate* unmanaged<TextureHandle, SamplerHandle, ulong>)GLLoader.BindingsContext.GetProcAddress("glGetTextureSamplerHandleIMG");
                return _GetTextureSamplerHandleIMG_fnptr(texture, sampler);
            }
            
            private static delegate* unmanaged<int, ulong, void> _UniformHandleui64IMG_fnptr = &UniformHandleui64IMG_Lazy;
            public static void UniformHandleui64IMG(int location, ulong value) => _UniformHandleui64IMG_fnptr(location, value);
            [UnmanagedCallersOnly]
            private static void UniformHandleui64IMG_Lazy(int location, ulong value)
            {
                _UniformHandleui64IMG_fnptr = (delegate* unmanaged<int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glUniformHandleui64IMG");
                _UniformHandleui64IMG_fnptr(location, value);
            }
            
            private static delegate* unmanaged<int, int, ulong*, void> _UniformHandleui64vIMG_fnptr = &UniformHandleui64vIMG_Lazy;
            public static void UniformHandleui64vIMG(int location, int count, ulong* value) => _UniformHandleui64vIMG_fnptr(location, count, value);
            [UnmanagedCallersOnly]
            private static void UniformHandleui64vIMG_Lazy(int location, int count, ulong* value)
            {
                _UniformHandleui64vIMG_fnptr = (delegate* unmanaged<int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glUniformHandleui64vIMG");
                _UniformHandleui64vIMG_fnptr(location, count, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, ulong, void> _ProgramUniformHandleui64IMG_fnptr = &ProgramUniformHandleui64IMG_Lazy;
            public static void ProgramUniformHandleui64IMG(ProgramHandle program, int location, ulong value) => _ProgramUniformHandleui64IMG_fnptr(program, location, value);
            [UnmanagedCallersOnly]
            private static void ProgramUniformHandleui64IMG_Lazy(ProgramHandle program, int location, ulong value)
            {
                _ProgramUniformHandleui64IMG_fnptr = (delegate* unmanaged<ProgramHandle, int, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformHandleui64IMG");
                _ProgramUniformHandleui64IMG_fnptr(program, location, value);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, ulong*, void> _ProgramUniformHandleui64vIMG_fnptr = &ProgramUniformHandleui64vIMG_Lazy;
            public static void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, int count, ulong* values) => _ProgramUniformHandleui64vIMG_fnptr(program, location, count, values);
            [UnmanagedCallersOnly]
            private static void ProgramUniformHandleui64vIMG_Lazy(ProgramHandle program, int location, int count, ulong* values)
            {
                _ProgramUniformHandleui64vIMG_fnptr = (delegate* unmanaged<ProgramHandle, int, int, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glProgramUniformHandleui64vIMG");
                _ProgramUniformHandleui64vIMG_fnptr(program, location, count, values);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, int, void> _FramebufferTexture2DDownsampleIMG_fnptr = &FramebufferTexture2DDownsampleIMG_Lazy;
            public static void FramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int xscale, int yscale) => _FramebufferTexture2DDownsampleIMG_fnptr(target, attachment, textarget, texture, level, xscale, yscale);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DDownsampleIMG_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int xscale, int yscale)
            {
                _FramebufferTexture2DDownsampleIMG_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DDownsampleIMG");
                _FramebufferTexture2DDownsampleIMG_fnptr(target, attachment, textarget, texture, level, xscale, yscale);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void> _FramebufferTextureLayerDownsampleIMG_fnptr = &FramebufferTextureLayerDownsampleIMG_Lazy;
            public static void FramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer, int xscale, int yscale) => _FramebufferTextureLayerDownsampleIMG_fnptr(target, attachment, texture, level, layer, xscale, yscale);
            [UnmanagedCallersOnly]
            private static void FramebufferTextureLayerDownsampleIMG_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer, int xscale, int yscale)
            {
                _FramebufferTextureLayerDownsampleIMG_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureLayerDownsampleIMG");
                _FramebufferTextureLayerDownsampleIMG_fnptr(target, attachment, texture, level, layer, xscale, yscale);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleIMG_fnptr = &RenderbufferStorageMultisampleIMG_Lazy;
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleIMG_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleIMG_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleIMG_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleIMG");
                _RenderbufferStorageMultisampleIMG_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void> _FramebufferTexture2DMultisampleIMG_fnptr = &FramebufferTexture2DMultisampleIMG_Lazy;
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => _FramebufferTexture2DMultisampleIMG_fnptr(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleIMG_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                _FramebufferTexture2DMultisampleIMG_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleIMG");
                _FramebufferTexture2DMultisampleIMG_fnptr(target, attachment, textarget, texture, level, samples);
            }
            
        }
        public static unsafe partial class INTEL
        {
            private static delegate* unmanaged<void> _ApplyFramebufferAttachmentCMAAINTEL_fnptr = &ApplyFramebufferAttachmentCMAAINTEL_Lazy;
            public static void ApplyFramebufferAttachmentCMAAINTEL() => _ApplyFramebufferAttachmentCMAAINTEL_fnptr();
            [UnmanagedCallersOnly]
            private static void ApplyFramebufferAttachmentCMAAINTEL_Lazy()
            {
                _ApplyFramebufferAttachmentCMAAINTEL_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glApplyFramebufferAttachmentCMAAINTEL");
                _ApplyFramebufferAttachmentCMAAINTEL_fnptr();
            }
            
            private static delegate* unmanaged<uint, void> _BeginPerfQueryINTEL_fnptr = &BeginPerfQueryINTEL_Lazy;
            public static void BeginPerfQueryINTEL(uint queryHandle) => _BeginPerfQueryINTEL_fnptr(queryHandle);
            [UnmanagedCallersOnly]
            private static void BeginPerfQueryINTEL_Lazy(uint queryHandle)
            {
                _BeginPerfQueryINTEL_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glBeginPerfQueryINTEL");
                _BeginPerfQueryINTEL_fnptr(queryHandle);
            }
            
            private static delegate* unmanaged<uint, uint*, void> _CreatePerfQueryINTEL_fnptr = &CreatePerfQueryINTEL_Lazy;
            public static void CreatePerfQueryINTEL(uint queryId, uint* queryHandle) => _CreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            [UnmanagedCallersOnly]
            private static void CreatePerfQueryINTEL_Lazy(uint queryId, uint* queryHandle)
            {
                _CreatePerfQueryINTEL_fnptr = (delegate* unmanaged<uint, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glCreatePerfQueryINTEL");
                _CreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            }
            
            private static delegate* unmanaged<uint, void> _DeletePerfQueryINTEL_fnptr = &DeletePerfQueryINTEL_Lazy;
            public static void DeletePerfQueryINTEL(uint queryHandle) => _DeletePerfQueryINTEL_fnptr(queryHandle);
            [UnmanagedCallersOnly]
            private static void DeletePerfQueryINTEL_Lazy(uint queryHandle)
            {
                _DeletePerfQueryINTEL_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glDeletePerfQueryINTEL");
                _DeletePerfQueryINTEL_fnptr(queryHandle);
            }
            
            private static delegate* unmanaged<uint, void> _EndPerfQueryINTEL_fnptr = &EndPerfQueryINTEL_Lazy;
            public static void EndPerfQueryINTEL(uint queryHandle) => _EndPerfQueryINTEL_fnptr(queryHandle);
            [UnmanagedCallersOnly]
            private static void EndPerfQueryINTEL_Lazy(uint queryHandle)
            {
                _EndPerfQueryINTEL_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glEndPerfQueryINTEL");
                _EndPerfQueryINTEL_fnptr(queryHandle);
            }
            
            private static delegate* unmanaged<uint*, void> _GetFirstPerfQueryIdINTEL_fnptr = &GetFirstPerfQueryIdINTEL_Lazy;
            public static void GetFirstPerfQueryIdINTEL(uint* queryId) => _GetFirstPerfQueryIdINTEL_fnptr(queryId);
            [UnmanagedCallersOnly]
            private static void GetFirstPerfQueryIdINTEL_Lazy(uint* queryId)
            {
                _GetFirstPerfQueryIdINTEL_fnptr = (delegate* unmanaged<uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFirstPerfQueryIdINTEL");
                _GetFirstPerfQueryIdINTEL_fnptr(queryId);
            }
            
            private static delegate* unmanaged<uint, uint*, void> _GetNextPerfQueryIdINTEL_fnptr = &GetNextPerfQueryIdINTEL_Lazy;
            public static void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => _GetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            [UnmanagedCallersOnly]
            private static void GetNextPerfQueryIdINTEL_Lazy(uint queryId, uint* nextQueryId)
            {
                _GetNextPerfQueryIdINTEL_fnptr = (delegate* unmanaged<uint, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetNextPerfQueryIdINTEL");
                _GetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            }
            
            private static delegate* unmanaged<uint, uint, uint, byte*, uint, byte*, uint*, uint*, uint*, uint*, ulong*, void> _GetPerfCounterInfoINTEL_fnptr = &GetPerfCounterInfoINTEL_Lazy;
            public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => _GetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            [UnmanagedCallersOnly]
            private static void GetPerfCounterInfoINTEL_Lazy(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue)
            {
                _GetPerfCounterInfoINTEL_fnptr = (delegate* unmanaged<uint, uint, uint, byte*, uint, byte*, uint*, uint*, uint*, uint*, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfCounterInfoINTEL");
                _GetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            }
            
            private static delegate* unmanaged<uint, uint, int, void*, uint*, void> _GetPerfQueryDataINTEL_fnptr = &GetPerfQueryDataINTEL_Lazy;
            public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => _GetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            [UnmanagedCallersOnly]
            private static void GetPerfQueryDataINTEL_Lazy(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten)
            {
                _GetPerfQueryDataINTEL_fnptr = (delegate* unmanaged<uint, uint, int, void*, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfQueryDataINTEL");
                _GetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            }
            
            private static delegate* unmanaged<byte*, uint*, void> _GetPerfQueryIdByNameINTEL_fnptr = &GetPerfQueryIdByNameINTEL_Lazy;
            public static void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => _GetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            [UnmanagedCallersOnly]
            private static void GetPerfQueryIdByNameINTEL_Lazy(byte* queryName, uint* queryId)
            {
                _GetPerfQueryIdByNameINTEL_fnptr = (delegate* unmanaged<byte*, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfQueryIdByNameINTEL");
                _GetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            }
            
            private static delegate* unmanaged<uint, uint, byte*, uint*, uint*, uint*, uint*, void> _GetPerfQueryInfoINTEL_fnptr = &GetPerfQueryInfoINTEL_Lazy;
            public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask) => _GetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
            [UnmanagedCallersOnly]
            private static void GetPerfQueryInfoINTEL_Lazy(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask)
            {
                _GetPerfQueryInfoINTEL_fnptr = (delegate* unmanaged<uint, uint, byte*, uint*, uint*, uint*, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPerfQueryInfoINTEL");
                _GetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
            }
            
        }
        public static unsafe partial class KHR
        {
            private static delegate* unmanaged<void> _BlendBarrierKHR_fnptr = &BlendBarrierKHR_Lazy;
            public static void BlendBarrierKHR() => _BlendBarrierKHR_fnptr();
            [UnmanagedCallersOnly]
            private static void BlendBarrierKHR_Lazy()
            {
                _BlendBarrierKHR_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glBlendBarrierKHR");
                _BlendBarrierKHR_fnptr();
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void> _DebugMessageControl_fnptr = &DebugMessageControl_Lazy;
            /// <summary> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="count"> The length of the array ids. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControl_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                _DebugMessageControl_fnptr = (delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageControl");
                _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> _DebugMessageInsert_fnptr = &DebugMessageInsert_Lazy;
            /// <summary> Inject an application-supplied message into the debug message queue. </summary>
            /// <param name="source"> The source of the debug message to insert. </param>
            /// <param name="type"> The type of the debug message insert. </param>
            /// <param name="id"> The user-supplied identifier of the message to insert. </param>
            /// <param name="severity"> The severity of the debug messages to insert. </param>
            /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
            /// <param name="message"> The address of a character array containing the message to insert. </param>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsert_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                _DebugMessageInsert_fnptr = (delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsert");
                _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
            }
            
            private static delegate* unmanaged<IntPtr, void*, void> _DebugMessageCallback_fnptr = &DebugMessageCallback_Lazy;
            /// <summary> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => _DebugMessageCallback_fnptr(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallback_Lazy(IntPtr callback, void* userParam)
            {
                _DebugMessageCallback_fnptr = (delegate* unmanaged<IntPtr, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallback");
                _DebugMessageCallback_fnptr(callback, userParam);
            }
            
            private static delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint> _GetDebugMessageLog_fnptr = &GetDebugMessageLog_Lazy;
            /// <summary> Retrieve messages from the debug message log. </summary>
            /// <param name="count"> The number of debug messages to retrieve from the log. </param>
            /// <param name="bufSize"> The size of the buffer whose address is given by messageLog. </param>
            /// <param name="sources"> The address of an array of variables to receive the sources of the retrieved messages. </param>
            /// <param name="types"> The address of an array of variables to receive the types of the retrieved messages. </param>
            /// <param name="ids"> The address of an array of unsigned integers to receive the ids of the retrieved messages. </param>
            /// <param name="severities"> The address of an array of variables to receive the severites of the retrieved messages. </param>
            /// <param name="lengths"> The address of an array of variables to receive the lengths of the received messages. </param>
            /// <param name="messageLog"> The address of an array of characters that will receive the messages. </param>
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLog_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                _GetDebugMessageLog_fnptr = (delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLog");
                return _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _PushDebugGroup_fnptr = &PushDebugGroup_Lazy;
            /// <summary> Push a named debug group into the command stream. </summary>
            /// <param name="source"> The source of the debug message. </param>
            /// <param name="id"> The identifier of the message. </param>
            /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
            /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => _PushDebugGroup_fnptr(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroup_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                _PushDebugGroup_fnptr = (delegate* unmanaged<DebugSource, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushDebugGroup");
                _PushDebugGroup_fnptr(source, id, length, message);
            }
            
            private static delegate* unmanaged<void> _PopDebugGroup_fnptr = &PopDebugGroup_Lazy;
            /// <summary> Pop the active debug group. </summary>
            public static void PopDebugGroup() => _PopDebugGroup_fnptr();
            [UnmanagedCallersOnly]
            private static void PopDebugGroup_Lazy()
            {
                _PopDebugGroup_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopDebugGroup");
                _PopDebugGroup_fnptr();
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void> _ObjectLabel_fnptr = &ObjectLabel_Lazy;
            /// <summary> Label a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object to label. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => _ObjectLabel_fnptr(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                _ObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectLabel");
                _ObjectLabel_fnptr(identifier, name, length, label);
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void> _GetObjectLabel_fnptr = &GetObjectLabel_Lazy;
            /// <summary> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label)
            {
                _GetObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabel");
                _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
            }
            
            private static delegate* unmanaged<void*, int, byte*, void> _ObjectPtrLabel_fnptr = &ObjectPtrLabel_Lazy;
            /// <summary> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => _ObjectPtrLabel_fnptr(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabel_Lazy(void* ptr, int length, byte* label)
            {
                _ObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabel");
                _ObjectPtrLabel_fnptr(ptr, length, label);
            }
            
            private static delegate* unmanaged<void*, int, int*, byte*, void> _GetObjectPtrLabel_fnptr = &GetObjectPtrLabel_Lazy;
            /// <summary> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabel_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                _GetObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabel");
                _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            }
            
            private static delegate* unmanaged<GetPointervPName, void**, void> _GetPointerv_fnptr = &GetPointerv_Lazy;
            /// <summary> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => _GetPointerv_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
            {
                _GetPointerv_fnptr = (delegate* unmanaged<GetPointervPName, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
                _GetPointerv_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void> _DebugMessageControlKHR_fnptr = &DebugMessageControlKHR_Lazy;
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => _DebugMessageControlKHR_fnptr(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControlKHR_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                _DebugMessageControlKHR_fnptr = (delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageControlKHR");
                _DebugMessageControlKHR_fnptr(source, type, severity, count, ids, enabled);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> _DebugMessageInsertKHR_fnptr = &DebugMessageInsertKHR_Lazy;
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => _DebugMessageInsertKHR_fnptr(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsertKHR_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                _DebugMessageInsertKHR_fnptr = (delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsertKHR");
                _DebugMessageInsertKHR_fnptr(source, type, id, severity, length, buf);
            }
            
            private static delegate* unmanaged<IntPtr, void*, void> _DebugMessageCallbackKHR_fnptr = &DebugMessageCallbackKHR_Lazy;
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => _DebugMessageCallbackKHR_fnptr(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallbackKHR_Lazy(IntPtr callback, void* userParam)
            {
                _DebugMessageCallbackKHR_fnptr = (delegate* unmanaged<IntPtr, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallbackKHR");
                _DebugMessageCallbackKHR_fnptr(callback, userParam);
            }
            
            private static delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint> _GetDebugMessageLogKHR_fnptr = &GetDebugMessageLogKHR_Lazy;
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => _GetDebugMessageLogKHR_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLogKHR_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                _GetDebugMessageLogKHR_fnptr = (delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLogKHR");
                return _GetDebugMessageLogKHR_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _PushDebugGroupKHR_fnptr = &PushDebugGroupKHR_Lazy;
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => _PushDebugGroupKHR_fnptr(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroupKHR_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                _PushDebugGroupKHR_fnptr = (delegate* unmanaged<DebugSource, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushDebugGroupKHR");
                _PushDebugGroupKHR_fnptr(source, id, length, message);
            }
            
            private static delegate* unmanaged<void> _PopDebugGroupKHR_fnptr = &PopDebugGroupKHR_Lazy;
            public static void PopDebugGroupKHR() => _PopDebugGroupKHR_fnptr();
            [UnmanagedCallersOnly]
            private static void PopDebugGroupKHR_Lazy()
            {
                _PopDebugGroupKHR_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopDebugGroupKHR");
                _PopDebugGroupKHR_fnptr();
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void> _ObjectLabelKHR_fnptr = &ObjectLabelKHR_Lazy;
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => _ObjectLabelKHR_fnptr(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabelKHR_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                _ObjectLabelKHR_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectLabelKHR");
                _ObjectLabelKHR_fnptr(identifier, name, length, label);
            }
            
            private static delegate* unmanaged<All, uint, int, int*, byte*, void> _GetObjectLabelKHR_fnptr = &GetObjectLabelKHR_Lazy;
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => _GetObjectLabelKHR_fnptr(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabelKHR_Lazy(All identifier, uint name, int bufSize, int* length, byte* label)
            {
                _GetObjectLabelKHR_fnptr = (delegate* unmanaged<All, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabelKHR");
                _GetObjectLabelKHR_fnptr(identifier, name, bufSize, length, label);
            }
            
            private static delegate* unmanaged<void*, int, byte*, void> _ObjectPtrLabelKHR_fnptr = &ObjectPtrLabelKHR_Lazy;
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => _ObjectPtrLabelKHR_fnptr(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabelKHR_Lazy(void* ptr, int length, byte* label)
            {
                _ObjectPtrLabelKHR_fnptr = (delegate* unmanaged<void*, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabelKHR");
                _ObjectPtrLabelKHR_fnptr(ptr, length, label);
            }
            
            private static delegate* unmanaged<void*, int, int*, byte*, void> _GetObjectPtrLabelKHR_fnptr = &GetObjectPtrLabelKHR_Lazy;
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => _GetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabelKHR_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                _GetObjectPtrLabelKHR_fnptr = (delegate* unmanaged<void*, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabelKHR");
                _GetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            }
            
            private static delegate* unmanaged<All, void**, void> _GetPointervKHR_fnptr = &GetPointervKHR_Lazy;
            public static void GetPointervKHR(All pname, void** parameters) => _GetPointervKHR_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointervKHR_Lazy(All pname, void** parameters)
            {
                _GetPointervKHR_fnptr = (delegate* unmanaged<All, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointervKHR");
                _GetPointervKHR_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<GraphicsResetStatus> _GetGraphicsResetStatus_fnptr = &GetGraphicsResetStatus_Lazy;
            /// <summary> Check if the rendering context has not been lost due to software or hardware issues. </summary>
            public static GraphicsResetStatus GetGraphicsResetStatus() => _GetGraphicsResetStatus_fnptr();
            [UnmanagedCallersOnly]
            private static GraphicsResetStatus GetGraphicsResetStatus_Lazy()
            {
                _GetGraphicsResetStatus_fnptr = (delegate* unmanaged<GraphicsResetStatus>)GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatus");
                return _GetGraphicsResetStatus_fnptr();
            }
            
            private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void> _ReadnPixels_fnptr = &ReadnPixels_Lazy;
            /// <summary> Read a block of pixels from the frame buffer. </summary>
            /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
            /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
            /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
            /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
            /// <param name="bufSize"> Specifies the size of the buffer data for glReadnPixels function. </param>
            /// <param name="data"> Returns the pixel data. </param>
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => _ReadnPixels_fnptr(x, y, width, height, format, type, bufSize, data);
            [UnmanagedCallersOnly]
            private static void ReadnPixels_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
            {
                _ReadnPixels_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadnPixels");
                _ReadnPixels_fnptr(x, y, width, height, format, type, bufSize, data);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _GetnUniformfv_fnptr = &GetnUniformfv_Lazy;
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            public static void GetnUniformfv(ProgramHandle program, int location, int bufSize, float* parameters) => _GetnUniformfv_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformfv_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
            {
                _GetnUniformfv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformfv");
                _GetnUniformfv_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _GetnUniformiv_fnptr = &GetnUniformiv_Lazy;
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            public static void GetnUniformiv(ProgramHandle program, int location, int bufSize, int* parameters) => _GetnUniformiv_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformiv_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
            {
                _GetnUniformiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformiv");
                _GetnUniformiv_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _GetnUniformuiv_fnptr = &GetnUniformuiv_Lazy;
            /// <summary> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            public static void GetnUniformuiv(ProgramHandle program, int location, int bufSize, uint* parameters) => _GetnUniformuiv_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformuiv_Lazy(ProgramHandle program, int location, int bufSize, uint* parameters)
            {
                _GetnUniformuiv_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformuiv");
                _GetnUniformuiv_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<GraphicsResetStatus> _GetGraphicsResetStatusKHR_fnptr = &GetGraphicsResetStatusKHR_Lazy;
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => _GetGraphicsResetStatusKHR_fnptr();
            [UnmanagedCallersOnly]
            private static GraphicsResetStatus GetGraphicsResetStatusKHR_Lazy()
            {
                _GetGraphicsResetStatusKHR_fnptr = (delegate* unmanaged<GraphicsResetStatus>)GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatusKHR");
                return _GetGraphicsResetStatusKHR_fnptr();
            }
            
            private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void> _ReadnPixelsKHR_fnptr = &ReadnPixelsKHR_Lazy;
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => _ReadnPixelsKHR_fnptr(x, y, width, height, format, type, bufSize, data);
            [UnmanagedCallersOnly]
            private static void ReadnPixelsKHR_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
            {
                _ReadnPixelsKHR_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadnPixelsKHR");
                _ReadnPixelsKHR_fnptr(x, y, width, height, format, type, bufSize, data);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _GetnUniformfvKHR_fnptr = &GetnUniformfvKHR_Lazy;
            public static void GetnUniformfvKHR(ProgramHandle program, int location, int bufSize, float* parameters) => _GetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformfvKHR_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
            {
                _GetnUniformfvKHR_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformfvKHR");
                _GetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _GetnUniformivKHR_fnptr = &GetnUniformivKHR_Lazy;
            public static void GetnUniformivKHR(ProgramHandle program, int location, int bufSize, int* parameters) => _GetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformivKHR_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
            {
                _GetnUniformivKHR_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformivKHR");
                _GetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, uint*, void> _GetnUniformuivKHR_fnptr = &GetnUniformuivKHR_Lazy;
            public static void GetnUniformuivKHR(ProgramHandle program, int location, int bufSize, uint* parameters) => _GetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformuivKHR_Lazy(ProgramHandle program, int location, int bufSize, uint* parameters)
            {
                _GetnUniformuivKHR_fnptr = (delegate* unmanaged<ProgramHandle, int, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformuivKHR");
                _GetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<uint, void> _MaxShaderCompilerThreadsKHR_fnptr = &MaxShaderCompilerThreadsKHR_Lazy;
            public static void MaxShaderCompilerThreadsKHR(uint count) => _MaxShaderCompilerThreadsKHR_fnptr(count);
            [UnmanagedCallersOnly]
            private static void MaxShaderCompilerThreadsKHR_Lazy(uint count)
            {
                _MaxShaderCompilerThreadsKHR_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glMaxShaderCompilerThreadsKHR");
                _MaxShaderCompilerThreadsKHR_fnptr(count);
            }
            
        }
        public static unsafe partial class MESA
        {
            private static delegate* unmanaged<FramebufferTarget, FramebufferParameterName, int, void> _FramebufferParameteriMESA_fnptr = &FramebufferParameteriMESA_Lazy;
            public static void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => _FramebufferParameteriMESA_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void FramebufferParameteriMESA_Lazy(FramebufferTarget target, FramebufferParameterName pname, int param)
            {
                _FramebufferParameteriMESA_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferParameteriMESA");
                _FramebufferParameteriMESA_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachmentParameterName, int*, void> _GetFramebufferParameterivMESA_fnptr = &GetFramebufferParameterivMESA_Lazy;
            public static void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => _GetFramebufferParameterivMESA_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFramebufferParameterivMESA_Lazy(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters)
            {
                _GetFramebufferParameterivMESA_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachmentParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFramebufferParameterivMESA");
                _GetFramebufferParameterivMESA_fnptr(target, pname, parameters);
            }
            
        }
        public static unsafe partial class OES
        {
            private static delegate* unmanaged<All, void*, void> _EGLImageTargetTexture2DOES_fnptr = &EGLImageTargetTexture2DOES_Lazy;
            public static void EGLImageTargetTexture2DOES(All target, void* image) => _EGLImageTargetTexture2DOES_fnptr(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetTexture2DOES_Lazy(All target, void* image)
            {
                _EGLImageTargetTexture2DOES_fnptr = (delegate* unmanaged<All, void*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetTexture2DOES");
                _EGLImageTargetTexture2DOES_fnptr(target, image);
            }
            
            private static delegate* unmanaged<All, void*, void> _EGLImageTargetRenderbufferStorageOES_fnptr = &EGLImageTargetRenderbufferStorageOES_Lazy;
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => _EGLImageTargetRenderbufferStorageOES_fnptr(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetRenderbufferStorageOES_Lazy(All target, void* image)
            {
                _EGLImageTargetRenderbufferStorageOES_fnptr = (delegate* unmanaged<All, void*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetRenderbufferStorageOES");
                _EGLImageTargetRenderbufferStorageOES_fnptr(target, image);
            }
            
            private static delegate* unmanaged<uint, CopyBufferSubDataTarget, int, int, int, int, uint, CopyBufferSubDataTarget, int, int, int, int, int, int, int, void> _CopyImageSubDataOES_fnptr = &CopyImageSubDataOES_Lazy;
            public static void CopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => _CopyImageSubDataOES_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            [UnmanagedCallersOnly]
            private static void CopyImageSubDataOES_Lazy(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
            {
                _CopyImageSubDataOES_fnptr = (delegate* unmanaged<uint, CopyBufferSubDataTarget, int, int, int, int, uint, CopyBufferSubDataTarget, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyImageSubDataOES");
                _CopyImageSubDataOES_fnptr(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _EnableiOES_fnptr = &EnableiOES_Lazy;
            public static void EnableiOES(EnableCap target, uint index) => _EnableiOES_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void EnableiOES_Lazy(EnableCap target, uint index)
            {
                _EnableiOES_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableiOES");
                _EnableiOES_fnptr(target, index);
            }
            
            private static delegate* unmanaged<EnableCap, uint, void> _DisableiOES_fnptr = &DisableiOES_Lazy;
            public static void DisableiOES(EnableCap target, uint index) => _DisableiOES_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static void DisableiOES_Lazy(EnableCap target, uint index)
            {
                _DisableiOES_fnptr = (delegate* unmanaged<EnableCap, uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableiOES");
                _DisableiOES_fnptr(target, index);
            }
            
            private static delegate* unmanaged<uint, BlendEquationModeEXT, void> _BlendEquationiOES_fnptr = &BlendEquationiOES_Lazy;
            public static void BlendEquationiOES(uint buf, BlendEquationModeEXT mode) => _BlendEquationiOES_fnptr(buf, mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationiOES_Lazy(uint buf, BlendEquationModeEXT mode)
            {
                _BlendEquationiOES_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationiOES");
                _BlendEquationiOES_fnptr(buf, mode);
            }
            
            private static delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void> _BlendEquationSeparateiOES_fnptr = &BlendEquationSeparateiOES_Lazy;
            public static void BlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => _BlendEquationSeparateiOES_fnptr(buf, modeRGB, modeAlpha);
            [UnmanagedCallersOnly]
            private static void BlendEquationSeparateiOES_Lazy(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
            {
                _BlendEquationSeparateiOES_fnptr = (delegate* unmanaged<uint, BlendEquationModeEXT, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparateiOES");
                _BlendEquationSeparateiOES_fnptr(buf, modeRGB, modeAlpha);
            }
            
            private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void> _BlendFunciOES_fnptr = &BlendFunciOES_Lazy;
            public static void BlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => _BlendFunciOES_fnptr(buf, src, dst);
            [UnmanagedCallersOnly]
            private static void BlendFunciOES_Lazy(uint buf, BlendingFactor src, BlendingFactor dst)
            {
                _BlendFunciOES_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFunciOES");
                _BlendFunciOES_fnptr(buf, src, dst);
            }
            
            private static delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> _BlendFuncSeparateiOES_fnptr = &BlendFuncSeparateiOES_Lazy;
            public static void BlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => _BlendFuncSeparateiOES_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            [UnmanagedCallersOnly]
            private static void BlendFuncSeparateiOES_Lazy(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
            {
                _BlendFuncSeparateiOES_fnptr = (delegate* unmanaged<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparateiOES");
                _BlendFuncSeparateiOES_fnptr(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
            
            private static delegate* unmanaged<uint, byte, byte, byte, byte, void> _ColorMaskiOES_fnptr = &ColorMaskiOES_Lazy;
            public static void ColorMaskiOES(uint index, byte r, byte g, byte b, byte a) => _ColorMaskiOES_fnptr(index, r, g, b, a);
            [UnmanagedCallersOnly]
            private static void ColorMaskiOES_Lazy(uint index, byte r, byte g, byte b, byte a)
            {
                _ColorMaskiOES_fnptr = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColorMaskiOES");
                _ColorMaskiOES_fnptr(index, r, g, b, a);
            }
            
            private static delegate* unmanaged<EnableCap, uint, byte> _IsEnablediOES_fnptr = &IsEnablediOES_Lazy;
            public static byte IsEnablediOES(EnableCap target, uint index) => _IsEnablediOES_fnptr(target, index);
            [UnmanagedCallersOnly]
            private static byte IsEnablediOES_Lazy(EnableCap target, uint index)
            {
                _IsEnablediOES_fnptr = (delegate* unmanaged<EnableCap, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnablediOES");
                return _IsEnablediOES_fnptr(target, index);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void> _DrawElementsBaseVertexOES_fnptr = &DrawElementsBaseVertexOES_Lazy;
            public static void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => _DrawElementsBaseVertexOES_fnptr(mode, count, type, indices, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawElementsBaseVertexOES_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex)
            {
                _DrawElementsBaseVertexOES_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsBaseVertexOES");
                _DrawElementsBaseVertexOES_fnptr(mode, count, type, indices, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void> _DrawRangeElementsBaseVertexOES_fnptr = &DrawRangeElementsBaseVertexOES_Lazy;
            public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => _DrawRangeElementsBaseVertexOES_fnptr(mode, start, end, count, type, indices, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawRangeElementsBaseVertexOES_Lazy(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex)
            {
                _DrawRangeElementsBaseVertexOES_fnptr = (delegate* unmanaged<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawRangeElementsBaseVertexOES");
                _DrawRangeElementsBaseVertexOES_fnptr(mode, start, end, count, type, indices, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void> _DrawElementsInstancedBaseVertexOES_fnptr = &DrawElementsInstancedBaseVertexOES_Lazy;
            public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => _DrawElementsInstancedBaseVertexOES_fnptr(mode, count, type, indices, instancecount, basevertex);
            [UnmanagedCallersOnly]
            private static void DrawElementsInstancedBaseVertexOES_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex)
            {
                _DrawElementsInstancedBaseVertexOES_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElementsInstancedBaseVertexOES");
                _DrawElementsInstancedBaseVertexOES_fnptr(mode, count, type, indices, instancecount, basevertex);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, int*, void> _MultiDrawElementsBaseVertexEXT_fnptr = &MultiDrawElementsBaseVertexEXT_Lazy;
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => _MultiDrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, drawcount, basevertex);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsBaseVertexEXT_Lazy(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex)
            {
                _MultiDrawElementsBaseVertexEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsBaseVertexEXT");
                _MultiDrawElementsBaseVertexEXT_fnptr(mode, count, type, indices, drawcount, basevertex);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void> _FramebufferTextureOES_fnptr = &FramebufferTextureOES_Lazy;
            public static void FramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => _FramebufferTextureOES_fnptr(target, attachment, texture, level);
            [UnmanagedCallersOnly]
            private static void FramebufferTextureOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level)
            {
                _FramebufferTextureOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureOES");
                _FramebufferTextureOES_fnptr(target, attachment, texture, level);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int*, All*, void*, void> _GetProgramBinaryOES_fnptr = &GetProgramBinaryOES_Lazy;
            public static void GetProgramBinaryOES(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary) => _GetProgramBinaryOES_fnptr(program, bufSize, length, binaryFormat, binary);
            [UnmanagedCallersOnly]
            private static void GetProgramBinaryOES_Lazy(ProgramHandle program, int bufSize, int* length, All* binaryFormat, void* binary)
            {
                _GetProgramBinaryOES_fnptr = (delegate* unmanaged<ProgramHandle, int, int*, All*, void*, void>)GLLoader.BindingsContext.GetProcAddress("glGetProgramBinaryOES");
                _GetProgramBinaryOES_fnptr(program, bufSize, length, binaryFormat, binary);
            }
            
            private static delegate* unmanaged<ProgramHandle, All, void*, int, void> _ProgramBinaryOES_fnptr = &ProgramBinaryOES_Lazy;
            public static void ProgramBinaryOES(ProgramHandle program, All binaryFormat, void* binary, int length) => _ProgramBinaryOES_fnptr(program, binaryFormat, binary, length);
            [UnmanagedCallersOnly]
            private static void ProgramBinaryOES_Lazy(ProgramHandle program, All binaryFormat, void* binary, int length)
            {
                _ProgramBinaryOES_fnptr = (delegate* unmanaged<ProgramHandle, All, void*, int, void>)GLLoader.BindingsContext.GetProcAddress("glProgramBinaryOES");
                _ProgramBinaryOES_fnptr(program, binaryFormat, binary, length);
            }
            
            private static delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*> _MapBufferOES_fnptr = &MapBufferOES_Lazy;
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => _MapBufferOES_fnptr(target, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferOES_Lazy(BufferTargetARB target, BufferAccessARB access)
            {
                _MapBufferOES_fnptr = (delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*>)GLLoader.BindingsContext.GetProcAddress("glMapBufferOES");
                return _MapBufferOES_fnptr(target, access);
            }
            
            private static delegate* unmanaged<All, byte> _UnmapBufferOES_fnptr = &UnmapBufferOES_Lazy;
            public static byte UnmapBufferOES(All target) => _UnmapBufferOES_fnptr(target);
            [UnmanagedCallersOnly]
            private static byte UnmapBufferOES_Lazy(All target)
            {
                _UnmapBufferOES_fnptr = (delegate* unmanaged<All, byte>)GLLoader.BindingsContext.GetProcAddress("glUnmapBufferOES");
                return _UnmapBufferOES_fnptr(target);
            }
            
            private static delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void> _GetBufferPointervOES_fnptr = &GetBufferPointervOES_Lazy;
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => _GetBufferPointervOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetBufferPointervOES_Lazy(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
            {
                _GetBufferPointervOES_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferPointervOES");
                _GetBufferPointervOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<float, float, float, float, float, float, float, float, void> _PrimitiveBoundingBoxOES_fnptr = &PrimitiveBoundingBoxOES_Lazy;
            public static void PrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => _PrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            [UnmanagedCallersOnly]
            private static void PrimitiveBoundingBoxOES_Lazy(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
            {
                _PrimitiveBoundingBoxOES_fnptr = (delegate* unmanaged<float, float, float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPrimitiveBoundingBoxOES");
                _PrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            }
            
            private static delegate* unmanaged<float, void> _MinSampleShadingOES_fnptr = &MinSampleShadingOES_Lazy;
            public static void MinSampleShadingOES(float value) => _MinSampleShadingOES_fnptr(value);
            [UnmanagedCallersOnly]
            private static void MinSampleShadingOES_Lazy(float value)
            {
                _MinSampleShadingOES_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glMinSampleShadingOES");
                _MinSampleShadingOES_fnptr(value);
            }
            
            private static delegate* unmanaged<PatchParameterName, int, void> _PatchParameteriOES_fnptr = &PatchParameteriOES_Lazy;
            public static void PatchParameteriOES(PatchParameterName pname, int value) => _PatchParameteriOES_fnptr(pname, value);
            [UnmanagedCallersOnly]
            private static void PatchParameteriOES_Lazy(PatchParameterName pname, int value)
            {
                _PatchParameteriOES_fnptr = (delegate* unmanaged<PatchParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glPatchParameteriOES");
                _PatchParameteriOES_fnptr(pname, value);
            }
            
            private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*, void> _TexImage3DOES_fnptr = &TexImage3DOES_Lazy;
            public static void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => _TexImage3DOES_fnptr(target, level, internalformat, width, height, depth, border, format, type, pixels);
            [UnmanagedCallersOnly]
            private static void TexImage3DOES_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels)
            {
                _TexImage3DOES_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexImage3DOES");
                _TexImage3DOES_fnptr(target, level, internalformat, width, height, depth, border, format, type, pixels);
            }
            
            private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexSubImage3DOES_fnptr = &TexSubImage3DOES_Lazy;
            public static void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => _TexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
            [UnmanagedCallersOnly]
            private static void TexSubImage3DOES_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels)
            {
                _TexSubImage3DOES_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexSubImage3DOES");
                _TexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
            }
            
            private static delegate* unmanaged<All, int, int, int, int, int, int, int, int, void> _CopyTexSubImage3DOES_fnptr = &CopyTexSubImage3DOES_Lazy;
            public static void CopyTexSubImage3DOES(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => _CopyTexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, x, y, width, height);
            [UnmanagedCallersOnly]
            private static void CopyTexSubImage3DOES_Lazy(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
            {
                _CopyTexSubImage3DOES_fnptr = (delegate* unmanaged<All, int, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexSubImage3DOES");
                _CopyTexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
            
            private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void> _CompressedTexImage3DOES_fnptr = &CompressedTexImage3DOES_Lazy;
            public static void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => _CompressedTexImage3DOES_fnptr(target, level, internalformat, width, height, depth, border, imageSize, data);
            [UnmanagedCallersOnly]
            private static void CompressedTexImage3DOES_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data)
            {
                _CompressedTexImage3DOES_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexImage3DOES");
                _CompressedTexImage3DOES_fnptr(target, level, internalformat, width, height, depth, border, imageSize, data);
            }
            
            private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, int, void*, void> _CompressedTexSubImage3DOES_fnptr = &CompressedTexSubImage3DOES_Lazy;
            public static void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data) => _CompressedTexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
            [UnmanagedCallersOnly]
            private static void CompressedTexSubImage3DOES_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data)
            {
                _CompressedTexSubImage3DOES_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, PixelFormat, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexSubImage3DOES");
                _CompressedTexSubImage3DOES_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void> _FramebufferTexture3DOES_fnptr = &FramebufferTexture3DOES_Lazy;
            public static void FramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int zoffset) => _FramebufferTexture3DOES_fnptr(target, attachment, textarget, texture, level, zoffset);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture3DOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int zoffset)
            {
                _FramebufferTexture3DOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture3DOES");
                _FramebufferTexture3DOES_fnptr(target, attachment, textarget, texture, level, zoffset);
            }
            
            private static delegate* unmanaged<TextureTarget, TextureParameterName, int*, void> _TexParameterIivOES_fnptr = &TexParameterIivOES_Lazy;
            public static void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int* parameters) => _TexParameterIivOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterIivOES_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
            {
                _TexParameterIivOES_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIivOES");
                _TexParameterIivOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void> _TexParameterIuivOES_fnptr = &TexParameterIuivOES_Lazy;
            public static void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint* parameters) => _TexParameterIuivOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterIuivOES_Lazy(TextureTarget target, TextureParameterName pname, uint* parameters)
            {
                _TexParameterIuivOES_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterIuivOES");
                _TexParameterIuivOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameterIivOES_fnptr = &GetTexParameterIivOES_Lazy;
            public static void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameterIivOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterIivOES_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                _GetTexParameterIivOES_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIivOES");
                _GetTexParameterIivOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void> _GetTexParameterIuivOES_fnptr = &GetTexParameterIuivOES_Lazy;
            public static void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint* parameters) => _GetTexParameterIuivOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterIuivOES_Lazy(TextureTarget target, GetTextureParameter pname, uint* parameters)
            {
                _GetTexParameterIuivOES_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterIuivOES");
                _GetTexParameterIuivOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _SamplerParameterIivOES_fnptr = &SamplerParameterIivOES_Lazy;
            public static void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* param) => _SamplerParameterIivOES_fnptr(sampler, pname, param);
            [UnmanagedCallersOnly]
            private static void SamplerParameterIivOES_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* param)
            {
                _SamplerParameterIivOES_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIivOES");
                _SamplerParameterIivOES_fnptr(sampler, pname, param);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _SamplerParameterIuivOES_fnptr = &SamplerParameterIuivOES_Lazy;
            public static void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* param) => _SamplerParameterIuivOES_fnptr(sampler, pname, param);
            [UnmanagedCallersOnly]
            private static void SamplerParameterIuivOES_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* param)
            {
                _SamplerParameterIuivOES_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glSamplerParameterIuivOES");
                _SamplerParameterIuivOES_fnptr(sampler, pname, param);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void> _GetSamplerParameterIivOES_fnptr = &GetSamplerParameterIivOES_Lazy;
            public static void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => _GetSamplerParameterIivOES_fnptr(sampler, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSamplerParameterIivOES_Lazy(SamplerHandle sampler, SamplerParameterI pname, int* parameters)
            {
                _GetSamplerParameterIivOES_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIivOES");
                _GetSamplerParameterIivOES_fnptr(sampler, pname, parameters);
            }
            
            private static delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void> _GetSamplerParameterIuivOES_fnptr = &GetSamplerParameterIuivOES_Lazy;
            public static void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => _GetSamplerParameterIuivOES_fnptr(sampler, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetSamplerParameterIuivOES_Lazy(SamplerHandle sampler, SamplerParameterI pname, uint* parameters)
            {
                _GetSamplerParameterIuivOES_fnptr = (delegate* unmanaged<SamplerHandle, SamplerParameterI, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSamplerParameterIuivOES");
                _GetSamplerParameterIuivOES_fnptr(sampler, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void> _TexBufferOES_fnptr = &TexBufferOES_Lazy;
            public static void TexBufferOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => _TexBufferOES_fnptr(target, internalformat, buffer);
            [UnmanagedCallersOnly]
            private static void TexBufferOES_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer)
            {
                _TexBufferOES_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glTexBufferOES");
                _TexBufferOES_fnptr(target, internalformat, buffer);
            }
            
            private static delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void> _TexBufferRangeOES_fnptr = &TexBufferRangeOES_Lazy;
            public static void TexBufferRangeOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => _TexBufferRangeOES_fnptr(target, internalformat, buffer, offset, size);
            [UnmanagedCallersOnly]
            private static void TexBufferRangeOES_Lazy(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size)
            {
                _TexBufferRangeOES_fnptr = (delegate* unmanaged<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glTexBufferRangeOES");
                _TexBufferRangeOES_fnptr(target, internalformat, buffer, offset, size);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, void> _TexStorage3DMultisampleOES_fnptr = &TexStorage3DMultisampleOES_Lazy;
            public static void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations) => _TexStorage3DMultisampleOES_fnptr(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            [UnmanagedCallersOnly]
            private static void TexStorage3DMultisampleOES_Lazy(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations)
            {
                _TexStorage3DMultisampleOES_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage3DMultisampleOES");
                _TexStorage3DMultisampleOES_fnptr(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            }
            
            private static delegate* unmanaged<TextureHandle, TextureTarget, TextureHandle, SizedInternalFormat, uint, uint, uint, uint, void> _TextureViewOES_fnptr = &TextureViewOES_Lazy;
            public static void TextureViewOES(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => _TextureViewOES_fnptr(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            [UnmanagedCallersOnly]
            private static void TextureViewOES_Lazy(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
            {
                _TextureViewOES_fnptr = (delegate* unmanaged<TextureHandle, TextureTarget, TextureHandle, SizedInternalFormat, uint, uint, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glTextureViewOES");
                _TextureViewOES_fnptr(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            }
            
            private static delegate* unmanaged<VertexArrayHandle, void> _BindVertexArrayOES_fnptr = &BindVertexArrayOES_Lazy;
            public static void BindVertexArrayOES(VertexArrayHandle array) => _BindVertexArrayOES_fnptr(array);
            [UnmanagedCallersOnly]
            private static void BindVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                _BindVertexArrayOES_fnptr = (delegate* unmanaged<VertexArrayHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindVertexArrayOES");
                _BindVertexArrayOES_fnptr(array);
            }
            
            private static delegate* unmanaged<int, VertexArrayHandle*, void> _DeleteVertexArraysOES_fnptr = &DeleteVertexArraysOES_Lazy;
            public static void DeleteVertexArraysOES(int n, VertexArrayHandle* arrays) => _DeleteVertexArraysOES_fnptr(n, arrays);
            [UnmanagedCallersOnly]
            private static void DeleteVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                _DeleteVertexArraysOES_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteVertexArraysOES");
                _DeleteVertexArraysOES_fnptr(n, arrays);
            }
            
            private static delegate* unmanaged<int, VertexArrayHandle*, void> _GenVertexArraysOES_fnptr = &GenVertexArraysOES_Lazy;
            public static void GenVertexArraysOES(int n, VertexArrayHandle* arrays) => _GenVertexArraysOES_fnptr(n, arrays);
            [UnmanagedCallersOnly]
            private static void GenVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                _GenVertexArraysOES_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenVertexArraysOES");
                _GenVertexArraysOES_fnptr(n, arrays);
            }
            
            private static delegate* unmanaged<VertexArrayHandle, byte> _IsVertexArrayOES_fnptr = &IsVertexArrayOES_Lazy;
            public static byte IsVertexArrayOES(VertexArrayHandle array) => _IsVertexArrayOES_fnptr(array);
            [UnmanagedCallersOnly]
            private static byte IsVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                _IsVertexArrayOES_fnptr = (delegate* unmanaged<VertexArrayHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsVertexArrayOES");
                return _IsVertexArrayOES_fnptr(array);
            }
            
            private static delegate* unmanaged<uint, int, float*, void> _ViewportArrayvOES_fnptr = &ViewportArrayvOES_Lazy;
            public static void ViewportArrayvOES(uint first, int count, float* v) => _ViewportArrayvOES_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void ViewportArrayvOES_Lazy(uint first, int count, float* v)
            {
                _ViewportArrayvOES_fnptr = (delegate* unmanaged<uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glViewportArrayvOES");
                _ViewportArrayvOES_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, float, float, float, float, void> _ViewportIndexedfOES_fnptr = &ViewportIndexedfOES_Lazy;
            public static void ViewportIndexedfOES(uint index, float x, float y, float w, float h) => _ViewportIndexedfOES_fnptr(index, x, y, w, h);
            [UnmanagedCallersOnly]
            private static void ViewportIndexedfOES_Lazy(uint index, float x, float y, float w, float h)
            {
                _ViewportIndexedfOES_fnptr = (delegate* unmanaged<uint, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glViewportIndexedfOES");
                _ViewportIndexedfOES_fnptr(index, x, y, w, h);
            }
            
            private static delegate* unmanaged<uint, float*, void> _ViewportIndexedfvOES_fnptr = &ViewportIndexedfvOES_Lazy;
            public static void ViewportIndexedfvOES(uint index, float* v) => _ViewportIndexedfvOES_fnptr(index, v);
            [UnmanagedCallersOnly]
            private static void ViewportIndexedfvOES_Lazy(uint index, float* v)
            {
                _ViewportIndexedfvOES_fnptr = (delegate* unmanaged<uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glViewportIndexedfvOES");
                _ViewportIndexedfvOES_fnptr(index, v);
            }
            
            private static delegate* unmanaged<uint, int, int*, void> _ScissorArrayvOES_fnptr = &ScissorArrayvOES_Lazy;
            public static void ScissorArrayvOES(uint first, int count, int* v) => _ScissorArrayvOES_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void ScissorArrayvOES_Lazy(uint first, int count, int* v)
            {
                _ScissorArrayvOES_fnptr = (delegate* unmanaged<uint, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glScissorArrayvOES");
                _ScissorArrayvOES_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, int, int, int, int, void> _ScissorIndexedOES_fnptr = &ScissorIndexedOES_Lazy;
            public static void ScissorIndexedOES(uint index, int left, int bottom, int width, int height) => _ScissorIndexedOES_fnptr(index, left, bottom, width, height);
            [UnmanagedCallersOnly]
            private static void ScissorIndexedOES_Lazy(uint index, int left, int bottom, int width, int height)
            {
                _ScissorIndexedOES_fnptr = (delegate* unmanaged<uint, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScissorIndexedOES");
                _ScissorIndexedOES_fnptr(index, left, bottom, width, height);
            }
            
            private static delegate* unmanaged<uint, int*, void> _ScissorIndexedvOES_fnptr = &ScissorIndexedvOES_Lazy;
            public static void ScissorIndexedvOES(uint index, int* v) => _ScissorIndexedvOES_fnptr(index, v);
            [UnmanagedCallersOnly]
            private static void ScissorIndexedvOES_Lazy(uint index, int* v)
            {
                _ScissorIndexedvOES_fnptr = (delegate* unmanaged<uint, int*, void>)GLLoader.BindingsContext.GetProcAddress("glScissorIndexedvOES");
                _ScissorIndexedvOES_fnptr(index, v);
            }
            
            private static delegate* unmanaged<uint, int, float*, void> _DepthRangeArrayfvOES_fnptr = &DepthRangeArrayfvOES_Lazy;
            public static void DepthRangeArrayfvOES(uint first, int count, float* v) => _DepthRangeArrayfvOES_fnptr(first, count, v);
            [UnmanagedCallersOnly]
            private static void DepthRangeArrayfvOES_Lazy(uint first, int count, float* v)
            {
                _DepthRangeArrayfvOES_fnptr = (delegate* unmanaged<uint, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangeArrayfvOES");
                _DepthRangeArrayfvOES_fnptr(first, count, v);
            }
            
            private static delegate* unmanaged<uint, float, float, void> _DepthRangeIndexedfOES_fnptr = &DepthRangeIndexedfOES_Lazy;
            public static void DepthRangeIndexedfOES(uint index, float n, float f) => _DepthRangeIndexedfOES_fnptr(index, n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangeIndexedfOES_Lazy(uint index, float n, float f)
            {
                _DepthRangeIndexedfOES_fnptr = (delegate* unmanaged<uint, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangeIndexedfOES");
                _DepthRangeIndexedfOES_fnptr(index, n, f);
            }
            
            private static delegate* unmanaged<GetPName, uint, float*, void> _GetFloati_vOES_fnptr = &GetFloati_vOES_Lazy;
            public static void GetFloati_vOES(GetPName target, uint index, float* data) => _GetFloati_vOES_fnptr(target, index, data);
            [UnmanagedCallersOnly]
            private static void GetFloati_vOES_Lazy(GetPName target, uint index, float* data)
            {
                _GetFloati_vOES_fnptr = (delegate* unmanaged<GetPName, uint, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFloati_vOES");
                _GetFloati_vOES_fnptr(target, index, data);
            }
            
        }
        public static unsafe partial class OVR
        {
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, void> _FramebufferTextureMultiviewOVR_fnptr = &FramebufferTextureMultiviewOVR_Lazy;
            public static void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int baseViewIndex, int numViews) => _FramebufferTextureMultiviewOVR_fnptr(target, attachment, texture, level, baseViewIndex, numViews);
            [UnmanagedCallersOnly]
            private static void FramebufferTextureMultiviewOVR_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int baseViewIndex, int numViews)
            {
                _FramebufferTextureMultiviewOVR_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureMultiviewOVR");
                _FramebufferTextureMultiviewOVR_fnptr(target, attachment, texture, level, baseViewIndex, numViews);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void> _FramebufferTextureMultisampleMultiviewOVR_fnptr = &FramebufferTextureMultisampleMultiviewOVR_Lazy;
            public static void FramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int samples, int baseViewIndex, int numViews) => _FramebufferTextureMultisampleMultiviewOVR_fnptr(target, attachment, texture, level, samples, baseViewIndex, numViews);
            [UnmanagedCallersOnly]
            private static void FramebufferTextureMultisampleMultiviewOVR_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int samples, int baseViewIndex, int numViews)
            {
                _FramebufferTextureMultisampleMultiviewOVR_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTextureMultisampleMultiviewOVR");
                _FramebufferTextureMultisampleMultiviewOVR_fnptr(target, attachment, texture, level, samples, baseViewIndex, numViews);
            }
            
        }
        public static unsafe partial class QCOM
        {
            private static delegate* unmanaged<All, float, void> _AlphaFuncQCOM_fnptr = &AlphaFuncQCOM_Lazy;
            public static void AlphaFuncQCOM(All func, float reference) => _AlphaFuncQCOM_fnptr(func, reference);
            [UnmanagedCallersOnly]
            private static void AlphaFuncQCOM_Lazy(All func, float reference)
            {
                _AlphaFuncQCOM_fnptr = (delegate* unmanaged<All, float, void>)GLLoader.BindingsContext.GetProcAddress("glAlphaFuncQCOM");
                _AlphaFuncQCOM_fnptr(func, reference);
            }
            
            private static delegate* unmanaged<int*, int, uint*, void> _GetDriverControlsQCOM_fnptr = &GetDriverControlsQCOM_Lazy;
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => _GetDriverControlsQCOM_fnptr(num, size, driverControls);
            [UnmanagedCallersOnly]
            private static void GetDriverControlsQCOM_Lazy(int* num, int size, uint* driverControls)
            {
                _GetDriverControlsQCOM_fnptr = (delegate* unmanaged<int*, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetDriverControlsQCOM");
                _GetDriverControlsQCOM_fnptr(num, size, driverControls);
            }
            
            private static delegate* unmanaged<uint, int, int*, byte*, void> _GetDriverControlStringQCOM_fnptr = &GetDriverControlStringQCOM_Lazy;
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => _GetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            [UnmanagedCallersOnly]
            private static void GetDriverControlStringQCOM_Lazy(uint driverControl, int bufSize, int* length, byte* driverControlString)
            {
                _GetDriverControlStringQCOM_fnptr = (delegate* unmanaged<uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetDriverControlStringQCOM");
                _GetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            }
            
            private static delegate* unmanaged<uint, void> _EnableDriverControlQCOM_fnptr = &EnableDriverControlQCOM_Lazy;
            public static void EnableDriverControlQCOM(uint driverControl) => _EnableDriverControlQCOM_fnptr(driverControl);
            [UnmanagedCallersOnly]
            private static void EnableDriverControlQCOM_Lazy(uint driverControl)
            {
                _EnableDriverControlQCOM_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableDriverControlQCOM");
                _EnableDriverControlQCOM_fnptr(driverControl);
            }
            
            private static delegate* unmanaged<uint, void> _DisableDriverControlQCOM_fnptr = &DisableDriverControlQCOM_Lazy;
            public static void DisableDriverControlQCOM(uint driverControl) => _DisableDriverControlQCOM_fnptr(driverControl);
            [UnmanagedCallersOnly]
            private static void DisableDriverControlQCOM_Lazy(uint driverControl)
            {
                _DisableDriverControlQCOM_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableDriverControlQCOM");
                _DisableDriverControlQCOM_fnptr(driverControl);
            }
            
            private static delegate* unmanaged<TextureHandle*, int, int*, void> _ExtGetTexturesQCOM_fnptr = &ExtGetTexturesQCOM_Lazy;
            public static void ExtGetTexturesQCOM(TextureHandle* textures, int maxTextures, int* numTextures) => _ExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            [UnmanagedCallersOnly]
            private static void ExtGetTexturesQCOM_Lazy(TextureHandle* textures, int maxTextures, int* numTextures)
            {
                _ExtGetTexturesQCOM_fnptr = (delegate* unmanaged<TextureHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexturesQCOM");
                _ExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            }
            
            private static delegate* unmanaged<BufferHandle*, int, int*, void> _ExtGetBuffersQCOM_fnptr = &ExtGetBuffersQCOM_Lazy;
            public static void ExtGetBuffersQCOM(BufferHandle* buffers, int maxBuffers, int* numBuffers) => _ExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetBuffersQCOM_Lazy(BufferHandle* buffers, int maxBuffers, int* numBuffers)
            {
                _ExtGetBuffersQCOM_fnptr = (delegate* unmanaged<BufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetBuffersQCOM");
                _ExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            }
            
            private static delegate* unmanaged<RenderbufferHandle*, int, int*, void> _ExtGetRenderbuffersQCOM_fnptr = &ExtGetRenderbuffersQCOM_Lazy;
            public static void ExtGetRenderbuffersQCOM(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => _ExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetRenderbuffersQCOM_Lazy(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers)
            {
                _ExtGetRenderbuffersQCOM_fnptr = (delegate* unmanaged<RenderbufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetRenderbuffersQCOM");
                _ExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            }
            
            private static delegate* unmanaged<FramebufferHandle*, int, int*, void> _ExtGetFramebuffersQCOM_fnptr = &ExtGetFramebuffersQCOM_Lazy;
            public static void ExtGetFramebuffersQCOM(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers) => _ExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetFramebuffersQCOM_Lazy(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers)
            {
                _ExtGetFramebuffersQCOM_fnptr = (delegate* unmanaged<FramebufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetFramebuffersQCOM");
                _ExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, All, int*, void> _ExtGetTexLevelParameterivQCOM_fnptr = &ExtGetTexLevelParameterivQCOM_Lazy;
            public static void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, int* parameters) => _ExtGetTexLevelParameterivQCOM_fnptr(texture, face, level, pname, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetTexLevelParameterivQCOM_Lazy(TextureHandle texture, All face, int level, All pname, int* parameters)
            {
                _ExtGetTexLevelParameterivQCOM_fnptr = (delegate* unmanaged<TextureHandle, All, int, All, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexLevelParameterivQCOM");
                _ExtGetTexLevelParameterivQCOM_fnptr(texture, face, level, pname, parameters);
            }
            
            private static delegate* unmanaged<All, All, int, void> _ExtTexObjectStateOverrideiQCOM_fnptr = &ExtTexObjectStateOverrideiQCOM_Lazy;
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => _ExtTexObjectStateOverrideiQCOM_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void ExtTexObjectStateOverrideiQCOM_Lazy(All target, All pname, int param)
            {
                _ExtTexObjectStateOverrideiQCOM_fnptr = (delegate* unmanaged<All, All, int, void>)GLLoader.BindingsContext.GetProcAddress("glExtTexObjectStateOverrideiQCOM");
                _ExtTexObjectStateOverrideiQCOM_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _ExtGetTexSubImageQCOM_fnptr = &ExtGetTexSubImageQCOM_Lazy;
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => _ExtGetTexSubImageQCOM_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            [UnmanagedCallersOnly]
            private static void ExtGetTexSubImageQCOM_Lazy(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels)
            {
                _ExtGetTexSubImageQCOM_fnptr = (delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexSubImageQCOM");
                _ExtGetTexSubImageQCOM_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            }
            
            private static delegate* unmanaged<All, void**, void> _ExtGetBufferPointervQCOM_fnptr = &ExtGetBufferPointervQCOM_Lazy;
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => _ExtGetBufferPointervQCOM_fnptr(target, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetBufferPointervQCOM_Lazy(All target, void** parameters)
            {
                _ExtGetBufferPointervQCOM_fnptr = (delegate* unmanaged<All, void**, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetBufferPointervQCOM");
                _ExtGetBufferPointervQCOM_fnptr(target, parameters);
            }
            
            private static delegate* unmanaged<ShaderHandle*, int, int*, void> _ExtGetShadersQCOM_fnptr = &ExtGetShadersQCOM_Lazy;
            public static void ExtGetShadersQCOM(ShaderHandle* shaders, int maxShaders, int* numShaders) => _ExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            [UnmanagedCallersOnly]
            private static void ExtGetShadersQCOM_Lazy(ShaderHandle* shaders, int maxShaders, int* numShaders)
            {
                _ExtGetShadersQCOM_fnptr = (delegate* unmanaged<ShaderHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetShadersQCOM");
                _ExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            }
            
            private static delegate* unmanaged<ProgramHandle*, int, int*, void> _ExtGetProgramsQCOM_fnptr = &ExtGetProgramsQCOM_Lazy;
            public static void ExtGetProgramsQCOM(ProgramHandle* programs, int maxPrograms, int* numPrograms) => _ExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramsQCOM_Lazy(ProgramHandle* programs, int maxPrograms, int* numPrograms)
            {
                _ExtGetProgramsQCOM_fnptr = (delegate* unmanaged<ProgramHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetProgramsQCOM");
                _ExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            }
            
            private static delegate* unmanaged<ProgramHandle, byte> _ExtIsProgramBinaryQCOM_fnptr = &ExtIsProgramBinaryQCOM_Lazy;
            public static byte ExtIsProgramBinaryQCOM(ProgramHandle program) => _ExtIsProgramBinaryQCOM_fnptr(program);
            [UnmanagedCallersOnly]
            private static byte ExtIsProgramBinaryQCOM_Lazy(ProgramHandle program)
            {
                _ExtIsProgramBinaryQCOM_fnptr = (delegate* unmanaged<ProgramHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glExtIsProgramBinaryQCOM");
                return _ExtIsProgramBinaryQCOM_fnptr(program);
            }
            
            private static delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void> _ExtGetProgramBinarySourceQCOM_fnptr = &ExtGetProgramBinarySourceQCOM_Lazy;
            public static void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, int* length) => _ExtGetProgramBinarySourceQCOM_fnptr(program, shadertype, source, length);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramBinarySourceQCOM_Lazy(ProgramHandle program, ShaderType shadertype, byte* source, int* length)
            {
                _ExtGetProgramBinarySourceQCOM_fnptr = (delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetProgramBinarySourceQCOM");
                _ExtGetProgramBinarySourceQCOM_fnptr(program, shadertype, source, length);
            }
            
            private static delegate* unmanaged<FramebufferHandle, uint, uint, uint, uint*, void> _FramebufferFoveationConfigQCOM_fnptr = &FramebufferFoveationConfigQCOM_Lazy;
            public static void FramebufferFoveationConfigQCOM(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures) => _FramebufferFoveationConfigQCOM_fnptr(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            [UnmanagedCallersOnly]
            private static void FramebufferFoveationConfigQCOM_Lazy(FramebufferHandle framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures)
            {
                _FramebufferFoveationConfigQCOM_fnptr = (delegate* unmanaged<FramebufferHandle, uint, uint, uint, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferFoveationConfigQCOM");
                _FramebufferFoveationConfigQCOM_fnptr(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            }
            
            private static delegate* unmanaged<FramebufferHandle, uint, uint, float, float, float, float, float, void> _FramebufferFoveationParametersQCOM_fnptr = &FramebufferFoveationParametersQCOM_Lazy;
            public static void FramebufferFoveationParametersQCOM(FramebufferHandle framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => _FramebufferFoveationParametersQCOM_fnptr(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            [UnmanagedCallersOnly]
            private static void FramebufferFoveationParametersQCOM_Lazy(FramebufferHandle framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea)
            {
                _FramebufferFoveationParametersQCOM_fnptr = (delegate* unmanaged<FramebufferHandle, uint, uint, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferFoveationParametersQCOM");
                _FramebufferFoveationParametersQCOM_fnptr(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            }
            
            private static delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, void> _TexEstimateMotionQCOM_fnptr = &TexEstimateMotionQCOM_Lazy;
            public static void TexEstimateMotionQCOM(TextureHandle reference, TextureHandle target, TextureHandle output) => _TexEstimateMotionQCOM_fnptr(reference, target, output);
            [UnmanagedCallersOnly]
            private static void TexEstimateMotionQCOM_Lazy(TextureHandle reference, TextureHandle target, TextureHandle output)
            {
                _TexEstimateMotionQCOM_fnptr = (delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, void>)GLLoader.BindingsContext.GetProcAddress("glTexEstimateMotionQCOM");
                _TexEstimateMotionQCOM_fnptr(reference, target, output);
            }
            
            private static delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, TextureHandle, void> _TexEstimateMotionRegionsQCOM_fnptr = &TexEstimateMotionRegionsQCOM_Lazy;
            public static void TexEstimateMotionRegionsQCOM(TextureHandle reference, TextureHandle target, TextureHandle output, TextureHandle mask) => _TexEstimateMotionRegionsQCOM_fnptr(reference, target, output, mask);
            [UnmanagedCallersOnly]
            private static void TexEstimateMotionRegionsQCOM_Lazy(TextureHandle reference, TextureHandle target, TextureHandle output, TextureHandle mask)
            {
                _TexEstimateMotionRegionsQCOM_fnptr = (delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, TextureHandle, void>)GLLoader.BindingsContext.GetProcAddress("glTexEstimateMotionRegionsQCOM");
                _TexEstimateMotionRegionsQCOM_fnptr(reference, target, output, mask);
            }
            
            private static delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, float, void> _ExtrapolateTex2DQCOM_fnptr = &ExtrapolateTex2DQCOM_Lazy;
            public static void ExtrapolateTex2DQCOM(TextureHandle src1, TextureHandle src2, TextureHandle output, float scaleFactor) => _ExtrapolateTex2DQCOM_fnptr(src1, src2, output, scaleFactor);
            [UnmanagedCallersOnly]
            private static void ExtrapolateTex2DQCOM_Lazy(TextureHandle src1, TextureHandle src2, TextureHandle output, float scaleFactor)
            {
                _ExtrapolateTex2DQCOM_fnptr = (delegate* unmanaged<TextureHandle, TextureHandle, TextureHandle, float, void>)GLLoader.BindingsContext.GetProcAddress("glExtrapolateTex2DQCOM");
                _ExtrapolateTex2DQCOM_fnptr(src1, src2, output, scaleFactor);
            }
            
            private static delegate* unmanaged<TextureHandle, uint, uint, float, float, float, float, float, void> _TextureFoveationParametersQCOM_fnptr = &TextureFoveationParametersQCOM_Lazy;
            public static void TextureFoveationParametersQCOM(TextureHandle texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => _TextureFoveationParametersQCOM_fnptr(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            [UnmanagedCallersOnly]
            private static void TextureFoveationParametersQCOM_Lazy(TextureHandle texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea)
            {
                _TextureFoveationParametersQCOM_fnptr = (delegate* unmanaged<TextureHandle, uint, uint, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glTextureFoveationParametersQCOM");
                _TextureFoveationParametersQCOM_fnptr(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            }
            
            private static delegate* unmanaged<void> _FramebufferFetchBarrierQCOM_fnptr = &FramebufferFetchBarrierQCOM_Lazy;
            public static void FramebufferFetchBarrierQCOM() => _FramebufferFetchBarrierQCOM_fnptr();
            [UnmanagedCallersOnly]
            private static void FramebufferFetchBarrierQCOM_Lazy()
            {
                _FramebufferFetchBarrierQCOM_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferFetchBarrierQCOM");
                _FramebufferFetchBarrierQCOM_fnptr();
            }
            
            private static delegate* unmanaged<ShadingRateQCOM, void> _ShadingRateQCOM_fnptr = &ShadingRateQCOM_Lazy;
            public static void ShadingRateQCOM(ShadingRateQCOM rate) => _ShadingRateQCOM_fnptr(rate);
            [UnmanagedCallersOnly]
            private static void ShadingRateQCOM_Lazy(ShadingRateQCOM rate)
            {
                _ShadingRateQCOM_fnptr = (delegate* unmanaged<ShadingRateQCOM, void>)GLLoader.BindingsContext.GetProcAddress("glShadingRateQCOM");
                _ShadingRateQCOM_fnptr(rate);
            }
            
            private static delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void> _StartTilingQCOM_fnptr = &StartTilingQCOM_Lazy;
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => _StartTilingQCOM_fnptr(x, y, width, height, preserveMask);
            [UnmanagedCallersOnly]
            private static void StartTilingQCOM_Lazy(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask)
            {
                _StartTilingQCOM_fnptr = (delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void>)GLLoader.BindingsContext.GetProcAddress("glStartTilingQCOM");
                _StartTilingQCOM_fnptr(x, y, width, height, preserveMask);
            }
            
            private static delegate* unmanaged<BufferBitQCOM, void> _EndTilingQCOM_fnptr = &EndTilingQCOM_Lazy;
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => _EndTilingQCOM_fnptr(preserveMask);
            [UnmanagedCallersOnly]
            private static void EndTilingQCOM_Lazy(BufferBitQCOM preserveMask)
            {
                _EndTilingQCOM_fnptr = (delegate* unmanaged<BufferBitQCOM, void>)GLLoader.BindingsContext.GetProcAddress("glEndTilingQCOM");
                _EndTilingQCOM_fnptr(preserveMask);
            }
            
        }
    }
}
