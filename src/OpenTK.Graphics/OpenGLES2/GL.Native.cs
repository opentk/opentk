// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES2
{
    public static unsafe partial class GL
    {
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glActiveShaderProgram</c>]</b><br/> Set the active program object for a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to set the active program object for. </param>
        /// <param name="program"> Specifies the program object to set as the active program pipeline object pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveShaderProgram.xhtml" /></remarks>
        public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgram_fnptr(pipeline, program);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glActiveTexture</c>]</b><br/> Select active texture unit. </summary>
        /// <param name="texture"> Specifies which texture unit to make active. The number of texture units is implementation-dependent, but must be at least 32. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglActiveTexture.xhtml" /></remarks>
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glAttachShader</c>]</b><br/> Attaches a shader object to a program object. </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglAttachShader.xhtml" /></remarks>
        public static void AttachShader(int program, int shader) => GLPointers._glAttachShader_fnptr(program, shader);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBeginQuery</c>]</b><br/> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void BeginQuery(QueryTarget target, int id) => GLPointers._glBeginQuery_fnptr((uint)target, id);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBeginTransformFeedback</c>]</b><br/> Start transform feedback operation. </summary>
        /// <param name="primitiveMode"> Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform feedback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedback_fnptr((uint)primitiveMode);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBindAttribLocation</c>]</b><br/> Associates a generic vertex attribute index with a named attribute variable. </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindAttribLocation.xhtml" /></remarks>
        public static void BindAttribLocation(int program, uint index, byte* name) => GLPointers._glBindAttribLocation_fnptr(program, index, name);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBindBuffer</c>]</b><br/> Bind a named buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="buffer"> Specifies the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBuffer.xhtml" /></remarks>
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBindBufferBase</c>]</b><br/> Bind a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferBase.xhtml" /></remarks>
        public static void BindBufferBase(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBase_fnptr((uint)target, index, buffer);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBindBufferRange</c>]</b><br/> Bind a range within a buffer object to an indexed buffer target. </summary>
        /// <param name="target"> Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER. </param>
        /// <param name="index"> Specify the index of the binding point within the array specified by target. </param>
        /// <param name="buffer"> The name of a buffer object to bind to the specified binding point. </param>
        /// <param name="offset"> The starting offset in basic machine units into the buffer object buffer. </param>
        /// <param name="size"> The amount of data in machine units that can be read from the buffet object while used as an indexed target. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindBufferRange.xhtml" /></remarks>
        public static void BindBufferRange(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRange_fnptr((uint)target, index, buffer, offset, size);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBindFramebuffer</c>]</b><br/> Bind a framebuffer to a framebuffer target. </summary>
        /// <param name="target"> Specifies the framebuffer target of the binding operation. </param>
        /// <param name="framebuffer"> Specifies the name of the framebuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindFramebuffer.xhtml" /></remarks>
        public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebuffer_fnptr((uint)target, framebuffer);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glBindImageTexture</c>]</b><br/> Bind a level of a texture to an image unit. </summary>
        /// <param name="unit"> Specifies the index of the image unit to which to bind the texture </param>
        /// <param name="texture"> Specifies the name of the texture to bind to the image unit. </param>
        /// <param name="level"> Specifies the level of the texture that is to be bound. </param>
        /// <param name="layered"> Specifies whether a layered texture binding is to be established. </param>
        /// <param name="layer"> If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise. </param>
        /// <param name="access"> Specifies a token indicating the type of access that will be performed on the image. </param>
        /// <param name="format"> Specifies the format that the elements of the image will be treated as for the purposes of formatted loads and stores. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindImageTexture.xhtml" /></remarks>
        public static void BindImageTexture(uint unit, int texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._glBindImageTexture_fnptr(unit, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, (uint)format);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glBindProgramPipeline</c>]</b><br/> Bind a program pipeline to the current context. </summary>
        /// <param name="pipeline"> Specifies the name of the pipeline object to bind to the context. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindProgramPipeline.xhtml" /></remarks>
        public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipeline_fnptr(pipeline);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBindRenderbuffer</c>]</b><br/> Bind a renderbuffer to a renderbuffer target. </summary>
        /// <param name="target"> Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of the renderbuffer object to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindRenderbuffer.xhtml" /></remarks>
        public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbuffer_fnptr((uint)target, renderbuffer);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBindSampler</c>]</b><br/> Bind a named sampler to a texturing target. </summary>
        /// <param name="unit"> Specifies the index of the texture unit to which the sampler is bound. </param>
        /// <param name="sampler"> Specifies the name of a sampler. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindSampler.xhtml" /></remarks>
        public static void BindSampler(uint unit, int sampler) => GLPointers._glBindSampler_fnptr(unit, sampler);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBindTexture</c>]</b><br/> Bind a named texture to a texturing target. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound. Must be either GL_TEXTURE_2D, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="texture"> Specifies the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTexture.xhtml" /></remarks>
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBindTransformFeedback</c>]</b><br/> Bind a transform feedback object. </summary>
        /// <param name="target"> Specifies the target to which to bind the transform feedback object id. target must be GL_TRANSFORM_FEEDBACK. </param>
        /// <param name="id"> Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindTransformFeedback.xhtml" /></remarks>
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, int id) => GLPointers._glBindTransformFeedback_fnptr((uint)target, id);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBindVertexArray</c>]</b><br/> Bind a vertex array object. </summary>
        /// <param name="array"> Specifies the name of the vertex array to bind. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexArray.xhtml" /></remarks>
        public static void BindVertexArray(int array) => GLPointers._glBindVertexArray_fnptr(array);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glBindVertexBuffer</c>]</b><br/> Bind a buffer to a vertex buffer bind point. </summary>
        /// <param name="bindingindex"> The index of the vertex buffer binding point to which to bind the buffer. </param>
        /// <param name="buffer"> The name of an existing buffer to bind to the vertex buffer binding point. </param>
        /// <param name="offset"> The offset of the first element of the buffer. </param>
        /// <param name="stride"> The distance between elements within the buffer. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBindVertexBuffer.xhtml" /></remarks>
        public static void BindVertexBuffer(uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glBindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glBlendBarrier</c>]</b><br/> Specifies a boundary between advanced blending passes. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendBarrier.xhtml" /></remarks>
        public static void BlendBarrier() => GLPointers._glBlendBarrier_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBlendColor</c>]</b><br/> Set the blend color. </summary>
        /// <param name="red"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="green"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="blue"> specify the components of GL_BLEND_COLOR </param>
        /// <param name="alpha"> specify the components of GL_BLEND_COLOR </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendColor.xhtml" /></remarks>
        public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._glBlendColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBlendEquation</c>]</b><br/> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquation_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glBlendEquationi</c>]</b><br/> Specify the equation used for both the RGB blend equation and the Alpha blend equation. </summary>
        /// <param name="buf"> for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation. </param>
        /// <param name="mode"> specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquation.xhtml" /></remarks>
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationi_fnptr(buf, (uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBlendEquationSeparate</c>]</b><br/> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparate_fnptr((uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glBlendEquationSeparatei</c>]</b><br/> Set the RGB blend equation and the alpha blend equation separately. </summary>
        /// <param name="buf"> for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations. </param>
        /// <param name="modeRGB"> specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <param name="modeAlpha"> specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendEquationSeparate.xhtml" /></remarks>
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparatei_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBlendFunc</c>]</b><br/> Specify pixel arithmetic. </summary>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glBlendFunci</c>]</b><br/> Specify pixel arithmetic. </summary>
        /// <param name="buf"> For glBlendFunci, specifies the index of the draw buffer for which to set the blend function. </param>
        /// <param name="sfactor"> Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dfactor"> Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFunc.xhtml" /></remarks>
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunci_fnptr(buf, (uint)src, (uint)dst);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBlendFuncSeparate</c>]</b><br/> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparate_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glBlendFuncSeparatei</c>]</b><br/> Specify pixel arithmetic for RGB and alpha components separately. </summary>
        /// <param name="buf"> For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions. </param>
        /// <param name="srcRGB"> Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE. </param>
        /// <param name="dstRGB"> Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO. </param>
        /// <param name="srcAlpha"> Specified how the alpha source blending factor is computed. The initial value is GL_ONE. </param>
        /// <param name="dstAlpha"> Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBlendFuncSeparate.xhtml" /></remarks>
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparatei_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glBlitFramebuffer</c>]</b><br/> Copy a block of pixels from the read framebuffer to the draw framebuffer. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBufferData</c>]</b><br/> Creates and initializes a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="size"> Specifies the size in bytes of the buffer object&apos;s new data store. </param>
        /// <param name="data"> Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied. </param>
        /// <param name="usage"> Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferData.xhtml" /></remarks>
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glBufferSubData</c>]</b><br/> Updates a subset of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the offset into the buffer object&apos;s data store where data replacement will begin, measured in bytes. </param>
        /// <param name="size"> Specifies the size in bytes of the data store region being replaced. </param>
        /// <param name="data"> Specifies a pointer to the new data that will be copied into the data store. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBufferSubData.xhtml" /></remarks>
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCheckFramebufferStatus</c>]</b><br/> Check the completeness status of a framebuffer. </summary>
        /// <param name="target"> Specify the target of the framebuffer completeness check. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCheckFramebufferStatus.xhtml" /></remarks>
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatus_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glClear</c>]</b><br/> Clear buffers to preset values. </summary>
        /// <param name="mask"> Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClear.xhtml" /></remarks>
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glClearBufferfi</c>]</b><br/> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="depth"> The value to clear a depth render buffer to. </param>
        /// <param name="stencil"> The value to clear a stencil render buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearBufferfi_fnptr((uint)buffer, drawbuffer, depth, stencil);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glClearBufferfv</c>]</b><br/> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearBufferfv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glClearBufferiv</c>]</b><br/> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearBufferiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glClearBufferuiv</c>]</b><br/> Clear individual buffers of the currently bound draw framebuffer. </summary>
        /// <param name="buffer"> Specify the buffer to clear. </param>
        /// <param name="drawBuffer"> Specify a particular draw buffer to clear. </param>
        /// <param name="value"> For color buffers, a pointer to a four-element vector specifying R, G, B and A values to clear the buffer to. For depth buffers, a pointer to a single depth value to clear the buffer to. For stencil buffers, a pointer to a single stencil value to clear the buffer to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearBuffer.xhtml" /></remarks>
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearBufferuiv_fnptr((uint)buffer, drawbuffer, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glClearColor</c>]</b><br/> Specify clear values for the color buffers. </summary>
        /// <param name="red"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="green"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="blue"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <param name="alpha"> Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearColor.xhtml" /></remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glClearDepthf</c>]</b><br/> Specify the clear value for the depth buffer. </summary>
        /// <param name="depth"> Specifies the depth value used when the depth buffer is cleared. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearDepthf.xhtml" /></remarks>
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glClearStencil</c>]</b><br/> Specify the clear value for the stencil buffer. </summary>
        /// <param name="s"> Specifies the index used when the stencil buffer is cleared. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClearStencil.xhtml" /></remarks>
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glClientWaitSync</c>]</b><br/> Block and wait for a sync object to become signaled. </summary>
        /// <param name="sync"> The sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT. </param>
        /// <param name="timeout"> The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglClientWaitSync.xhtml" /></remarks>
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glColorMask</c>]</b><br/> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glColorMaski</c>]</b><br/> Enable and disable writing of frame buffer color components. </summary>
        /// <param name="buf"> For glColorMaski, specifies the index of the draw buffer whose color mask to set. </param>
        /// <param name="red"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="green"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="blue"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <param name="alpha"> Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglColorMask.xhtml" /></remarks>
        public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaski_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCompileShader</c>]</b><br/> Compiles a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCompileShader.xhtml" /></remarks>
        public static void CompileShader(int shader) => GLPointers._glCompileShader_fnptr(shader);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCompressedTexImage2D</c>]</b><br/> Specify a two-dimensional texture image in a compressed format. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glCompressedTexImage3D</c>]</b><br/> Specify a three-dimensional texture image in a compressed format. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCompressedTexSubImage2D</c>]</b><br/> Specify a two-dimensional texture subimage in a compressed format. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glCompressedTexSubImage3D</c>]</b><br/> Specify a three-dimensional texture subimage in a compressed format. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glCopyBufferSubData</c>]</b><br/> Copy part of the data store of a buffer object to the data store of another buffer object. </summary>
        /// <param name="readtarget"> Specifies the target from whose data store data should be read. </param>
        /// <param name="writetarget"> Specifies the target to whose data store data should be written. </param>
        /// <param name="readoffset"> Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read. </param>
        /// <param name="writeoffset"> Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written. </param>
        /// <param name="size"> Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCopyBufferSubData.xhtml" /></remarks>
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glCopyImageSubData</c>]</b><br/> Perform a raw data copy between two images. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCopyTexImage2D</c>]</b><br/> Copy pixels into a 2D texture image. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCopyTexSubImage2D</c>]</b><br/> Copy a two-dimensional texture subimage. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glCopyTexSubImage3D</c>]</b><br/> Copy a three-dimensional texture subimage. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCreateProgram</c>]</b><br/> Creates a program object. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateProgram.xhtml" /></remarks>
        public static int CreateProgram() => GLPointers._glCreateProgram_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCreateShader</c>]</b><br/> Creates a shader object. </summary>
        /// <param name="shaderType"> Specifies the type of shader to be created. Must be one of GL_COMPUTE_SHADER, GL_VERTEX_SHADER, GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER, or GL_FRAGMENT_SHADER. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShader.xhtml" /></remarks>
        public static int CreateShader(ShaderType type) => GLPointers._glCreateShader_fnptr((uint)type);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glCreateShaderProgramv</c>]</b><br/> Create a stand-alone program from an array of null-terminated source code strings. </summary>
        /// <param name="type"> Specifies the type of shader to create. </param>
        /// <param name="count"> Specifies the number of source code strings in the array strings. </param>
        /// <param name="strings"> Specifies the address of an array of pointers to source code strings from which to create the program object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCreateShaderProgram.xhtml" /></remarks>
        public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramv_fnptr((uint)type, count, strings);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glCullFace</c>]</b><br/> Specify whether front- or back-facing polygons can be culled. </summary>
        /// <param name="mode"> Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglCullFace.xhtml" /></remarks>
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageCallback</c>]</b><br/> Specify a callback to receive debugging messages from the GL. </summary>
        /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
        /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageControl</c>]</b><br/> Control the reporting of debug messages in a debug context. </summary>
        /// <param name="source"> The source of debug messages to enable or disable. </param>
        /// <param name="type"> The type of debug messages to enable or disable. </param>
        /// <param name="severity"> The severity of debug messages to enable or disable. </param>
        /// <param name="count"> The length of the array ids. </param>
        /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
        /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageInsert</c>]</b><br/> Inject an application-supplied message into the debug message queue. </summary>
        /// <param name="source"> The source of the debug message to insert. </param>
        /// <param name="type"> The type of the debug message insert. </param>
        /// <param name="id"> The user-supplied identifier of the message to insert. </param>
        /// <param name="severity"> The severity of the debug messages to insert. </param>
        /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
        /// <param name="message"> The address of a character array containing the message to insert. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteBuffers</c>]</b><br/> Delete named buffer objects. </summary>
        /// <param name="n"> Specifies the number of buffer objects to be deleted. </param>
        /// <param name="buffers"> Specifies an array of buffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteBuffers.xhtml" /></remarks>
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteFramebuffers</c>]</b><br/> Delete framebuffer objects. </summary>
        /// <param name="n"> Specifies the number of framebuffer objects to be deleted. </param>
        /// <param name="framebuffers"> A pointer to an array containing n framebuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteFramebuffers.xhtml" /></remarks>
        public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffers_fnptr(n, framebuffers);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteProgram</c>]</b><br/> Deletes a program object. </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgram.xhtml" /></remarks>
        public static void DeleteProgram(int program) => GLPointers._glDeleteProgram_fnptr(program);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glDeleteProgramPipelines</c>]</b><br/> Delete program pipeline objects. </summary>
        /// <param name="n"> Specifies the number of program pipeline objects to delete. </param>
        /// <param name="pipelines"> Specifies an array of names of program pipeline objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteProgramPipelines.xhtml" /></remarks>
        public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelines_fnptr(n, pipelines);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDeleteQueries</c>]</b><br/> Delete named query objects. </summary>
        /// <param name="n"> Specifies the number of query objects to be deleted. </param>
        /// <param name="ids"> Specifies an array of query objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteQueries.xhtml" /></remarks>
        public static void DeleteQueries(int n, int* ids) => GLPointers._glDeleteQueries_fnptr(n, ids);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteRenderbuffers</c>]</b><br/> Delete renderbuffer objects. </summary>
        /// <param name="n"> Specifies the number of renderbuffer objects to be deleted. </param>
        /// <param name="renderbuffers"> A pointer to an array containing n renderbuffer objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteRenderbuffers.xhtml" /></remarks>
        public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffers_fnptr(n, renderbuffers);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDeleteSamplers</c>]</b><br/> Delete named sampler objects. </summary>
        /// <param name="n"> Specifies the number of sampler objects to be deleted. </param>
        /// <param name="samplers"> Specifies an array of sampler objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSamplers.xhtml" /></remarks>
        public static void DeleteSamplers(int count, int* samplers) => GLPointers._glDeleteSamplers_fnptr(count, samplers);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteShader</c>]</b><br/> Deletes a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteShader.xhtml" /></remarks>
        public static void DeleteShader(int shader) => GLPointers._glDeleteShader_fnptr(shader);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDeleteSync</c>]</b><br/> Delete a sync object. </summary>
        /// <param name="sync"> The sync object to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteSync.xhtml" /></remarks>
        public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSync_fnptr((IntPtr)sync);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDeleteTextures</c>]</b><br/> Delete named textures. </summary>
        /// <param name="n"> Specifies the number of textures to be deleted. </param>
        /// <param name="textures"> Specifies an array of textures to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTextures.xhtml" /></remarks>
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDeleteTransformFeedbacks</c>]</b><br/> Delete transform feedback objects. </summary>
        /// <param name="n"> Specifies the number of transform feedback objects to delete. </param>
        /// <param name="ids"> Specifies an array of names of transform feedback objects to delete. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteTransformFeedbacks.xhtml" /></remarks>
        public static void DeleteTransformFeedbacks(int n, int* ids) => GLPointers._glDeleteTransformFeedbacks_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDeleteVertexArrays</c>]</b><br/> Delete vertex array objects. </summary>
        /// <param name="n"> Specifies the number of vertex array objects to be deleted. </param>
        /// <param name="arrays"> Specifies the address of an array containing the n names of the objects to be deleted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDeleteVertexArrays.xhtml" /></remarks>
        public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArrays_fnptr(n, arrays);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDepthFunc</c>]</b><br/> Specify the value used for depth buffer comparisons. </summary>
        /// <param name="func"> Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthFunc.xhtml" /></remarks>
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDepthMask</c>]</b><br/> Enable or disable writing into the depth buffer. </summary>
        /// <param name="flag"> Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthMask.xhtml" /></remarks>
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDepthRangef</c>]</b><br/> Specify mapping of depth values from normalized device coordinates to window coordinates. </summary>
        /// <param name="n"> Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0. </param>
        /// <param name="f"> Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDepthRangef.xhtml" /></remarks>
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDetachShader</c>]</b><br/> Detaches a shader object from a program object to which it is attached. </summary>
        /// <param name="program">Specifies the program object from which to detach the shader object.</param>
        /// <param name="shader">Specifies the shader object to be detached.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDetachShader.xhtml" /></remarks>
        public static void DetachShader(int program, int shader) => GLPointers._glDetachShader_fnptr(program, shader);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDisable</c>]</b><br/> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glDisablei</c>]</b><br/> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Disablei(EnableCap target, uint index) => GLPointers._glDisablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDisableVertexAttribArray</c>]</b><br/> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void DisableVertexAttribArray(uint index) => GLPointers._glDisableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glDispatchCompute</c>]</b><br/> Launch one or more compute work groups. </summary>
        /// <param name="num_groups_x"> The number of work groups to be launched in the X dimension. </param>
        /// <param name="num_groups_y"> The number of work groups to be launched in the Y dimension. </param>
        /// <param name="num_groups_z"> The number of work groups to be launched in the Z dimension. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchCompute.xhtml" /></remarks>
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._glDispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glDispatchComputeIndirect</c>]</b><br/> Launch one or more compute work groups using parameters stored in a buffer. </summary>
        /// <param name="indirect"> The offset into the buffer object currently bound to the GL_DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch parameters are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDispatchComputeIndirect.xhtml" /></remarks>
        public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._glDispatchComputeIndirect_fnptr(indirect);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDrawArrays</c>]</b><br/> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArrays.xhtml" /></remarks>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glDrawArraysIndirect</c>]</b><br/> Render primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysIndirect.xhtml" /></remarks>
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._glDrawArraysIndirect_fnptr((uint)mode, indirect);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDrawArraysInstanced</c>]</b><br/> Draw multiple instances of a range of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="first"> Specifies the starting index in the enabled arrays. </param>
        /// <param name="count"> Specifies the number of indices to be rendered. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawArraysInstanced.xhtml" /></remarks>
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => GLPointers._glDrawArraysInstanced_fnptr((uint)mode, first, count, instancecount);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDrawBuffers</c>]</b><br/> Specifies a list of color buffers to be drawn into. </summary>
        /// <param name="n">Specifies the number of buffers in bufs.</param>
        /// <param name="bufs">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawBuffers.xhtml" /></remarks>
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffers_fnptr(n, (uint*)bufs);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glDrawElements</c>]</b><br/> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElements.xhtml" /></remarks>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glDrawElementsBaseVertex</c>]</b><br/> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsBaseVertex.xhtml" /></remarks>
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glDrawElementsIndirect</c>]</b><br/> Render indexed primitives from array data, taking parameters from memory. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. </param>
        /// <param name="type"> Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. </param>
        /// <param name="indirect"> Specifies the address of a structure containing the draw parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsIndirect.xhtml" /></remarks>
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._glDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDrawElementsInstanced</c>]</b><br/> Draw multiple instances of a set of elements. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the specified range of indices to be rendered. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstanced.xhtml" /></remarks>
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => GLPointers._glDrawElementsInstanced_fnptr((uint)mode, count, (uint)type, indices, instancecount);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glDrawElementsInstancedBaseVertex</c>]</b><br/> Render multiple instances of a set of primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="primcount"> Specifies the number of instances of the indexed geometry that should be drawn. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawElementsInstancedBaseVertex.xhtml" /></remarks>
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glDrawRangeElements</c>]</b><br/> Render primitives from array data. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a byte offset (cast to a pointer type) into the buffer bound to GL_ELEMENT_ARRAY_BUFFER to start reading indices from. If no buffer is bound, specifies a pointer to the location where the indices are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElements.xhtml" /></remarks>
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._glDrawRangeElements_fnptr((uint)mode, start, end, count, (uint)type, indices);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glDrawRangeElementsBaseVertex</c>]</b><br/> Render primitives from array data with a per-element offset. </summary>
        /// <param name="mode"> Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted. </param>
        /// <param name="start"> Specifies the minimum array index contained in indices. </param>
        /// <param name="end"> Specifies the maximum array index contained in indices. </param>
        /// <param name="count"> Specifies the number of elements to be rendered. </param>
        /// <param name="type"> Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. </param>
        /// <param name="indices"> Specifies a pointer to the location where the indices are stored. </param>
        /// <param name="basevertex"> Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDrawRangeElementsBaseVertex.xhtml" /></remarks>
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glEnable</c>]</b><br/> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glEnablei</c>]</b><br/> Enable or disable server-side GL capabilities. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the switch to disable (for glEnablei and glDisablei only). </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnable.xhtml" /></remarks>
        public static void Enablei(EnableCap target, uint index) => GLPointers._glEnablei_fnptr((uint)target, index);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glEnableVertexAttribArray</c>]</b><br/> Enable or disable a generic vertex attribute array. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled or disabled.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglEnableVertexAttribArray.xhtml" /></remarks>
        public static void EnableVertexAttribArray(uint index) => GLPointers._glEnableVertexAttribArray_fnptr(index);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glEndQuery</c>]</b><br/> Delimit the boundaries of a query object. </summary>
        /// <param name="target"> Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginQuery.xhtml" /></remarks>
        public static void EndQuery(QueryTarget target) => GLPointers._glEndQuery_fnptr((uint)target);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glEndTransformFeedback</c>]</b><br/> Start transform feedback operation. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglBeginTransformFeedback.xhtml" /></remarks>
        public static void EndTransformFeedback() => GLPointers._glEndTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glFenceSync</c>]</b><br/> Create a new sync object and insert it into the GL command stream. </summary>
        /// <param name="condition"> Specifies the condition that must be met to set the sync object&apos;s state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. </param>
        /// <param name="flags"> Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFenceSync.xhtml" /></remarks>
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSync_fnptr((uint)condition, (uint)flags);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glFinish</c>]</b><br/> Block until all GL execution is complete. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFinish.xhtml" /></remarks>
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glFlush</c>]</b><br/> Force execution of GL commands in finite time. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlush.xhtml" /></remarks>
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glFlushMappedBufferRange</c>]</b><br/> Indicate modifications to a range of a mapped buffer. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the start of the buffer subrange, in basic machine units. </param>
        /// <param name="length"> Specifies the length of the buffer subrange, in basic machine units. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFlushMappedBufferRange.xhtml" /></remarks>
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRange_fnptr((uint)target, offset, length);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glFramebufferParameteri</c>]</b><br/> Set a named parameter of a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be modified. </param>
        /// <param name="param"> The new value for the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferParameteri.xhtml" /></remarks>
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glFramebufferRenderbuffer</c>]</b><br/> Attach a renderbuffer as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="renderbuffertarget"> Specifies the renderbuffer target and must be GL_RENDERBUFFER. </param>
        /// <param name="renderbuffer"> Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferRenderbuffer.xhtml" /></remarks>
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glFramebufferTexture</c>]</b><br/> Attach a level of a texture object as a logical buffer of a framebuffer object. </summary>
        /// <param name="target"> Specifies the target to which the framebuffer is bound. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. </param>
        /// <param name="texture"> Specifies the name of an existing texture object to attach. </param>
        /// <param name="level"> Specifies the mipmap level of the texture object to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture.xhtml" /></remarks>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTexture_fnptr((uint)target, (uint)attachment, texture, level);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glFramebufferTexture2D</c>]</b><br/> Attach a level of a texture object as a logical buffer to the currently bound framebuffer object. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="textarget"> Specifies a 2D texture target, 2D multisample texture target, or for cube map textures, which face is to be attached. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTexture2D.xhtml" /></remarks>
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glFramebufferTextureLayer</c>]</b><br/> Attach a single layer of a texture to a framebuffer. </summary>
        /// <param name="target"> Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. </param>
        /// <param name="attachment"> Specifies the attachment point of the framebuffer. attachment must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. </param>
        /// <param name="texture"> Specifies the texture object to attach to the framebuffer attachment point named by attachment. </param>
        /// <param name="level"> Specifies the mipmap level of texture to attach. </param>
        /// <param name="layer"> Specifies the layer of texture to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFramebufferTextureLayer.xhtml" /></remarks>
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayer_fnptr((uint)target, (uint)attachment, texture, level, layer);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glFrontFace</c>]</b><br/> Define front- and back-facing polygons. </summary>
        /// <param name="mode"> Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglFrontFace.xhtml" /></remarks>
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGenBuffers</c>]</b><br/> Generate buffer object names. </summary>
        /// <param name="n"> Specifies the number of buffer object names to be generated. </param>
        /// <param name="buffers"> Specifies an array in which the generated buffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenBuffers.xhtml" /></remarks>
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGenerateMipmap</c>]</b><br/> Generate mipmaps for a specified texture target. </summary>
        /// <param name="target"> Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenerateMipmap.xhtml" /></remarks>
        public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmap_fnptr((uint)target);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGenFramebuffers</c>]</b><br/> Generate framebuffer object names. </summary>
        /// <param name="n"> Specifies the number of framebuffer object names to generate. </param>
        /// <param name="framebuffers"> Specifies an array in which the generated framebuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenFramebuffers.xhtml" /></remarks>
        public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffers_fnptr(n, framebuffers);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGenProgramPipelines</c>]</b><br/> Reserve program pipeline object names. </summary>
        /// <param name="n"> Specifies the number of program pipeline object names to reserve. </param>
        /// <param name="pipelines"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenProgramPipelines.xhtml" /></remarks>
        public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelines_fnptr(n, pipelines);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGenQueries</c>]</b><br/> Generate query object names. </summary>
        /// <param name="n"> Specifies the number of query object names to be generated. </param>
        /// <param name="ids"> Specifies an array in which the generated query object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenQueries.xhtml" /></remarks>
        public static void GenQueries(int n, int* ids) => GLPointers._glGenQueries_fnptr(n, ids);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGenRenderbuffers</c>]</b><br/> Generate renderbuffer object names. </summary>
        /// <param name="n"> Specifies the number of renderbuffer object names to generate. </param>
        /// <param name="renderbuffers"> Specifies an array in which the generated renderbuffer object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenRenderbuffers.xhtml" /></remarks>
        public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffers_fnptr(n, renderbuffers);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGenSamplers</c>]</b><br/> Generate sampler object names. </summary>
        /// <param name="n"> Specifies the number of sampler object names to generate. </param>
        /// <param name="samplers"> Specifies an array in which the generated sampler object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenSamplers.xhtml" /></remarks>
        public static void GenSamplers(int count, int* samplers) => GLPointers._glGenSamplers_fnptr(count, samplers);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGenTextures</c>]</b><br/> Generate texture names. </summary>
        /// <param name="n"> Specifies the number of texture names to be generated. </param>
        /// <param name="textures"> Specifies an array in which the generated texture names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTextures.xhtml" /></remarks>
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGenTransformFeedbacks</c>]</b><br/> Reserve transform feedback object names. </summary>
        /// <param name="n"> Specifies the number of transform feedback object names to reserve. </param>
        /// <param name="ids"> Specifies an array of into which the reserved names will be written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenTransformFeedbacks.xhtml" /></remarks>
        public static void GenTransformFeedbacks(int n, int* ids) => GLPointers._glGenTransformFeedbacks_fnptr(n, ids);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGenVertexArrays</c>]</b><br/> Generate vertex array object names. </summary>
        /// <param name="n"> Specifies the number of vertex array object names to generate. </param>
        /// <param name="arrays"> Specifies an array in which the generated vertex array object names are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGenVertexArrays.xhtml" /></remarks>
        public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArrays_fnptr(n, arrays);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetActiveAttrib</c>]</b><br/> Returns information about an active attribute variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the attribute variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveAttrib.xhtml" /></remarks>
        public static void GetActiveAttrib(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetActiveAttrib_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetActiveUniform</c>]</b><br/> Returns information about an active uniform variable for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null terminator) if a value other than NULL is passed.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a null terminated string containing the name of the uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniform.xhtml" /></remarks>
        public static void GetActiveUniform(int program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => GLPointers._glGetActiveUniform_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetActiveUniformBlockiv</c>]</b><br/> Query information about an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="pname"> Specifies the name of the parameter to query. </param>
        /// <param name="parameters"> Specifies the address of a variable to receive the result of the query. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockiv.xhtml" /></remarks>
        public static void GetActiveUniformBlockiv(int program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._glGetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetActiveUniformBlockName</c>]</b><br/> Retrieve the name of an active uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockIndex"> Specifies the index of the uniform block within program. </param>
        /// <param name="bufSize"> Specifies the size of the buffer addressed by uniformBlockName. </param>
        /// <param name="length"> Specifies the address of a variable to receive the number of characters that were written to uniformBlockName. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformBlockName.xhtml" /></remarks>
        public static void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._glGetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetActiveUniformsiv</c>]</b><br/> Returns information about several active uniform variables for the specified program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.</param>
        /// <param name="parameters">Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetActiveUniformsiv.xhtml" /></remarks>
        public static void GetActiveUniformsiv(int program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._glGetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetAttachedShaders</c>]</b><br/> Returns the handles of the shader objects attached to a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttachedShaders.xhtml" /></remarks>
        public static void GetAttachedShaders(int program, int maxCount, int* count, int* shaders) => GLPointers._glGetAttachedShaders_fnptr(program, maxCount, count, shaders);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetAttribLocation</c>]</b><br/> Returns the location of an attribute variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetAttribLocation.xhtml" /></remarks>
        public static int GetAttribLocation(int program, byte* name) => GLPointers._glGetAttribLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetBooleani_v</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleani_v(BufferTargetARB target, uint index, bool* data) => GLPointers._glGetBooleani_v_fnptr((uint)target, index, (byte*)data);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetBooleanv</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetBufferParameteri64v</c>]</b><br/> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => GLPointers._glGetBufferParameteri64v_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetBufferParameteriv</c>]</b><br/> Return parameters of a buffer object. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must be one of the buffer binding targets in the following table: </param>
        /// <param name="value"> Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS_FLAGS, GL_BUFFER_MAPPED, GL_BUFFER_MAP_LENGTH, GL_BUFFER_MAP_OFFSET, GL_BUFFER_SIZE, or GL_BUFFER_USAGE. </param>
        /// <param name="data"> Returns the requested parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferParameter.xhtml" /></remarks>
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetBufferPointerv</c>]</b><br/> Return the pointer to a mapped buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="pname"> Specifies the pointer to be returned. The symbolic constant must be GL_BUFFER_MAP_POINTER. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetBufferPointerv.xhtml" /></remarks>
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointerv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetDebugMessageLog</c>]</b><br/> Retrieve messages from the debug message log. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetError</c>]</b><br/> Return error information. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetError.xhtml" /></remarks>
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetFloatv</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetFragDataLocation</c>]</b><br/> Query the bindings of color numbers to user-defined varying out variables. </summary>
        /// <param name="program"> The name of the program containing varying out variable whose binding to query </param>
        /// <param name="name"> The name of the user-defined varying out variable whose binding to query </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFragDataLocation.xhtml" /></remarks>
        public static int GetFragDataLocation(int program, byte* name) => GLPointers._glGetFragDataLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetFramebufferAttachmentParameteriv</c>]</b><br/> Retrieve information about attachments of a bound framebuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. </param>
        /// <param name="attachment"> Specifies the attachment within target </param>
        /// <param name="pname"> Specifies the parameter of attachment to query. </param>
        /// <param name="parameters"> Specifies the address of a variable receive the value of pname for attachment. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferAttachmentParameteriv.xhtml" /></remarks>
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetFramebufferParameteriv</c>]</b><br/> Retrieve a named parameter from a framebuffer. </summary>
        /// <param name="target"> The target of the operation, which must be GL_READ_FRAMEBUFFER, GL_DRAW_FRAMEBUFFER or GL_FRAMEBUFFER. </param>
        /// <param name="pname"> A token indicating the parameter to be retrieved. </param>
        /// <param name="parameters"> The address of a variable to receive the value of the parameter named pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetFramebufferParameteriv.xhtml" /></remarks>
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetGraphicsResetStatus</c>]</b><br/> Check if the rendering context has not been lost due to software or hardware issues. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
        public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetInteger64i_v</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => GLPointers._glGetInteger64i_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetInteger64v</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64v_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetIntegeri_v</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="target"> Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are accepted. </param>
        /// <param name="index"> Specifies the index of the particular element being queried. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_v_fnptr((uint)target, index, data);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetIntegerv</c>]</b><br/> Return the value or values of a selected parameter. </summary>
        /// <param name="pname"> Specifies the parameter value to be returned. The symbolic constants in the list below are accepted. </param>
        /// <param name="data"> Returns the value or values of the specified parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGet.xhtml" /></remarks>
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetInternalformativ</c>]</b><br/> Retrieve information about implementation-dependent support for internal formats. </summary>
        /// <param name="target"> Indicates the usage of the internal format. target must be GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="internalformat"> Specifies the internal format about which to retrieve information. </param>
        /// <param name="pname"> Specifies the type of information to query. </param>
        /// <param name="bufSize"> Specifies the maximum number of integers that may be written to params by the function. </param>
        /// <param name="parameters"> Specifies the address of a variable into which to write the retrieved information. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetInternalformativ.xhtml" /></remarks>
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetMultisamplefv</c>]</b><br/> Retrieve the location of a sample. </summary>
        /// <param name="pname"> Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION. </param>
        /// <param name="index"> Specifies the index of the sample whose position to query. </param>
        /// <param name="val"> Specifies the address of an array to receive the position of the sample. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetMultisamplefv.xhtml" /></remarks>
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefv_fnptr((uint)pname, index, val);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformfv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformuiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the size of the buffer params. </param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectLabel</c>]</b><br/> Retrieve the label of a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectPtrLabel</c>]</b><br/> Retrieve the label of a sync object identified by a pointer. </summary>
        /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
        /// <param name="bifSize">!!missing documentation!!</param>
        /// <param name="length"> The address of a variable to receive the length of the object label. </param>
        /// <param name="label"> The address of a string that will receive the object label. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetPointerv</c>]</b><br/> Return the address of the specified pointer. </summary>
        /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
        /// <param name="parameters"> Returns the pointer value specified by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetProgramBinary</c>]</b><br/> Return a binary representation of a program object&apos;s compiled and linked executable source. </summary>
        /// <param name="program"> Specifies the name of a program object whose binary representation to retrieve. </param>
        /// <param name="bufsize">!!missing documentation!!</param>
        /// <param name="length"> Specifies the address of a variable to receive the number of bytes written into binary. </param>
        /// <param name="binaryFormat"> Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL. </param>
        /// <param name="binary"> Specifies the address an array into which the GL will return program&apos;s binary representation. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramBinary.xhtml" /></remarks>
        public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinary_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetProgramInfoLog</c>]</b><br/> Returns the information log for a program object. </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInfoLog.xhtml" /></remarks>
        public static void GetProgramInfoLog(int program, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramInterfaceiv</c>]</b><br/> Query a property of an interface in a program. </summary>
        /// <param name="program"> The name of a program object whose interface to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program to query. </param>
        /// <param name="pname"> The name of the parameter within programInterface to query. </param>
        /// <param name="parameters"> The address of a variable to retrieve the value of pname for the program interface. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramInterface.xhtml" /></remarks>
        public static void GetProgramInterfaceiv(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._glGetProgramInterfaceiv_fnptr(program, (uint)programInterface, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetProgramiv</c>]</b><br/> Returns a parameter from a program object. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_ATTACHED_SHADERS, GL_COMPUTE_WORK_GROUP_SIZE, GL_DELETE_STATUS, GL_GEOMETRY_LINKED_INPUT_TYPE, GL_GEOMETRY_LINKED_OUTPUT_TYPE, GL_GEOMETRY_LINKED_VERTICES_OUT, GL_GEOMETRY_SHADER_INVOCATIONS, GL_INFO_LOG_LENGTH, GL_LINK_STATUS, GL_PROGRAM_BINARY_RETRIEVABLE_HINT, GL_PROGRAM_SEPARABLE, GL_TESS_CONTROL_OUTPUT_VERTICES, GL_TESS_GEN_MODE, GL_TESS_GEN_POINT_MODE, GL_TESS_GEN_SPACING, GL_TESS_GEN_VERTEX_ORDER, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH and GL_VALIDATE_STATUS.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramiv.xhtml" /></remarks>
        public static void GetProgramiv(int program, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetProgramiv_fnptr(program, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramPipelineInfoLog</c>]</b><br/> Retrieve the info log string from a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object from which to retrieve the info log. </param>
        /// <param name="bufSize"> Specifies the maximum number of characters, including the null terminator, that may be written into infoLog. </param>
        /// <param name="length"> Specifies the address of a variable into which will be written the number of characters written into infoLog. </param>
        /// <param name="infoLog"> Specifies the address of an array of characters into which will be written the info log for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipelineInfoLog.xhtml" /></remarks>
        public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramPipelineiv</c>]</b><br/> Retrieve properties of a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object whose parameter retrieve. </param>
        /// <param name="pname"> Specifies the name of the parameter to retrieve. </param>
        /// <param name="parameters"> Specifies the address of a variable into which will be written the value or values of pname for pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramPipeline.xhtml" /></remarks>
        public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineiv_fnptr(pipeline, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramResourceIndex</c>]</b><br/> Query the index of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the index of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceIndex.xhtml" /></remarks>
        public static uint GetProgramResourceIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceIndex_fnptr(program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramResourceiv</c>]</b><br/> Retrieve values for multiple properties of a single active resource within a program object. </summary>
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
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramResourceLocation</c>]</b><br/> Query the location of a named resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the resource named name. </param>
        /// <param name="name"> The name of the resource to query the location of. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceLocation.xhtml" /></remarks>
        public static int GetProgramResourceLocation(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocation_fnptr(program, (uint)programInterface, name);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetProgramResourceName</c>]</b><br/> Query the name of an indexed resource within a program. </summary>
        /// <param name="program"> The name of a program object whose resources to query. </param>
        /// <param name="programInterface"> A token identifying the interface within program containing the indexed resource. </param>
        /// <param name="index"> The index of the resource within programInterface of program. </param>
        /// <param name="bufSize"> The size of the character array whose address is given by name. </param>
        /// <param name="length"> The address of a variable which will receive the length of the resource name. </param>
        /// <param name="name"> The address of a character array into which will be written the name of the resource. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetProgramResourceName.xhtml" /></remarks>
        public static void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetProgramResourceName_fnptr(program, (uint)programInterface, index, bufSize, length, name);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetQueryiv</c>]</b><br/> Return parameters of a query object target. </summary>
        /// <param name="target"> Specifies a query object target. Must be GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_PRIMITIVES_GENERATED, or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object target parameter. Must be GL_CURRENT_QUERY. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryiv.xhtml" /></remarks>
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetQueryObjectuiv</c>]</b><br/> Return parameters of a query object. </summary>
        /// <param name="id"> Specifies the name of a query object. </param>
        /// <param name="pname"> Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetQueryObjectuiv.xhtml" /></remarks>
        public static void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuiv_fnptr(id, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetRenderbufferParameteriv</c>]</b><br/> Retrieve information about a bound renderbuffer object. </summary>
        /// <param name="target"> Specifies the target of the query operation. target must be GL_RENDERBUFFER. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the renderbuffer bound to target. </param>
        /// <param name="parameters"> Specifies the address of an array to receive the value of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetRenderbufferParameteriv.xhtml" /></remarks>
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetSamplerParameterfv</c>]</b><br/> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterfv(int sampler, SamplerParameterF pname, float* parameters) => GLPointers._glGetSamplerParameterfv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glGetSamplerParameterIiv</c>]</b><br/> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIiv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glGetSamplerParameterIuiv</c>]</b><br/> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuiv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetSamplerParameteriv</c>]</b><br/> Return sampler parameter values. </summary>
        /// <param name="sampler"> Specifies name of the sampler object from which to retrieve parameters. </param>
        /// <param name="pname"> Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the sampler parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSamplerParameter.xhtml" /></remarks>
        public static void GetSamplerParameteriv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameteriv_fnptr(sampler, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetShaderInfoLog</c>]</b><br/> Returns the information log for a shader object. </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="maxLength">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog">Specifies an array of characters that is used to return the information log.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderInfoLog.xhtml" /></remarks>
        public static void GetShaderInfoLog(int shader, int bufSize, int* length, byte* infoLog) => GLPointers._glGetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetShaderiv</c>]</b><br/> Returns a parameter from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.</param>
        /// <param name="parameters">Returns the requested object parameter.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderiv.xhtml" /></remarks>
        public static void GetShaderiv(int shader, ShaderParameterName pname, int* parameters) => GLPointers._glGetShaderiv_fnptr(shader, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetShaderPrecisionFormat</c>]</b><br/> Retrieve the range and precision for numeric formats supported by the shader compiler. </summary>
        /// <param name="shaderType"> Specifies the type of shader whose precision to query. shaderType must be GL_VERTEX_SHADER or GL_FRAGMENT_SHADER. </param>
        /// <param name="precisionType"> Specifies the numeric format whose precision and range to query. </param>
        /// <param name="range"> Specifies the address of array of two integers into which encodings of the implementation&apos;s numeric range are returned. </param>
        /// <param name="precision"> Specifies the address of an integer into which the numeric precision of the implementation is written. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderPrecisionFormat.xhtml" /></remarks>
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._glGetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetShaderSource</c>]</b><br/> Returns the source code string from a shader object. </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <param name="length">Returns the length of the string returned in source (excluding the null terminator).</param>
        /// <param name="source">Specifies an array of characters that is used to return the source code string.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetShaderSource.xhtml" /></remarks>
        public static void GetShaderSource(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetShaderSource_fnptr(shader, bufSize, length, source);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetString</c>]</b><br/> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetStringi</c>]</b><br/> Return a string describing the current GL connection. </summary>
        /// <param name="name"> Specifies a symbolic constant, one of GL_EXTENSIONS, GL_RENDERER, GL_SHADING_LANGUAGE_VERSION, GL_VENDOR, or GL_VERSION. glGetStringi accepts only the GL_EXTENSIONS token. </param>
        /// <param name="index"> For glGetStringi, specifies the index of the string to return. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetString.xhtml" /></remarks>
        public static byte* GetStringi_(StringName name, uint index) => GLPointers._glGetStringi_fnptr((uint)name, index);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetSynciv</c>]</b><br/> Query the properties of a sync object. </summary>
        /// <param name="sync"> Specifies the sync object whose properties to query. </param>
        /// <param name="pname"> Specifies the parameter whose value to retrieve from the sync object specified in sync. </param>
        /// <param name="bufSize"> Specifies the size of the buffer whose address is given in values. </param>
        /// <param name="length"> Specifies the address of an variable to receive the number of integers placed in values. </param>
        /// <param name="values"> Specifies the address of an array to receive the values of the queried parameter. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetSynciv.xhtml" /></remarks>
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetTexLevelParameterfv</c>]</b><br/> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexLevelParameterfv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glGetTexLevelParameteriv</c>]</b><br/> Return texture parameter values for a specific level of detail. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture, one of GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_CUBE_MAP_ARRAY, or GL_TEXTURE_BUFFER. </param>
        /// <param name="level"> Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_SAMPLES, GL_TEXTURE_FIXED_SAMPLE_LOCATIONS, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_STENCIL_SIZE, GL_TEXTURE_SHARED_SIZE, GL_TEXTURE_RED_TYPE, GL_TEXTURE_GREEN_TYPE, GL_TEXTURE_BLUE_TYPE, GL_TEXTURE_ALPHA_TYPE, GL_TEXTURE_DEPTH_TYPE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_BUFFER_DATA_STORE_BINDING, GL_TEXTURE_BUFFER_OFFSET, and GL_TEXTURE_BUFFER_SIZE are accepted. </param>
        /// <param name="parameters"> Returns the requested data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexLevelParameter.xhtml" /></remarks>
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameteriv_fnptr((uint)target, level, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetTexParameterfv</c>]</b><br/> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glGetTexParameterIiv</c>]</b><br/> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glGetTexParameterIuiv</c>]</b><br/> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetTexParameteriv</c>]</b><br/> Return texture parameter values. </summary>
        /// <param name="target"> Specifies the symbolic name of the target texture. GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted. </param>
        /// <param name="pname"> Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE,GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, and GL_TEXTURE_BORDER_COLOR are accepted. </param>
        /// <param name="parameters"> Returns the texture parameters. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTexParameter.xhtml" /></remarks>
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetTransformFeedbackVarying</c>]</b><br/> Retrieve information about varying variables selected for transform feedback. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="index"> The index of the varying variable whose information to retrieve. </param>
        /// <param name="bufSize"> The maximum number of characters, including the null terminator, that may be written into name. </param>
        /// <param name="length"> The address of a variable which will receive the number of characters written into name, excluding the null-terminator. If length is NULL no length is returned. </param>
        /// <param name="size"> The address of a variable that will receive the size of the varying. </param>
        /// <param name="type"> The address of a variable that will receive the type of the varying. </param>
        /// <param name="name"> The address of a buffer into which will be written the name of the varying. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetTransformFeedbackVarying.xhtml" /></remarks>
        public static void GetTransformFeedbackVarying(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetUniformBlockIndex</c>]</b><br/> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing the uniform block. </param>
        /// <param name="uniformBlockName"> Specifies the address an array of characters containing the name of the uniform block whose index to retrieve. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformBlockIndex.xhtml" /></remarks>
        public static uint GetUniformBlockIndex(int program, byte* uniformBlockName) => GLPointers._glGetUniformBlockIndex_fnptr(program, uniformBlockName);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetUniformfv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformfv(int program, int location, float* parameters) => GLPointers._glGetUniformfv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetUniformIndices</c>]</b><br/> Retrieve the index of a named uniform block. </summary>
        /// <param name="program"> Specifies the name of a program containing uniforms whose indices to query. </param>
        /// <param name="uniformCount"> Specifies the number of uniforms whose indices to query. </param>
        /// <param name="uniformNames"> Specifies the address of an array of pointers to buffers containing the names of the queried uniforms. </param>
        /// <param name="uniformIndices"> Specifies the address of an array that will receive the indices of the uniforms. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformIndices.xhtml" /></remarks>
        public static void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._glGetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetUniformiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformiv(int program, int location, int* parameters) => GLPointers._glGetUniformiv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetUniformLocation</c>]</b><br/> Returns the location of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniformLocation.xhtml" /></remarks>
        public static int GetUniformLocation(int program, byte* name) => GLPointers._glGetUniformLocation_fnptr(program, name);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetUniformuiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="parameters">Returns the value of the specified uniform variable.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
        public static void GetUniformuiv(int program, int location, uint* parameters) => GLPointers._glGetUniformuiv_fnptr(program, location, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetVertexAttribfv</c>]</b><br/> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._glGetVertexAttribfv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetVertexAttribIiv</c>]</b><br/> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glGetVertexAttribIuiv</c>]</b><br/> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetVertexAttribiv</c>]</b><br/> Return a generic vertex attribute parameter. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are GL_CURRENT_VERTEX_ATTRIB, GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_BINDING.</param>
        /// <param name="parameters">Returns the requested data.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttrib.xhtml" /></remarks>
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._glGetVertexAttribiv_fnptr(index, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glGetVertexAttribPointerv</c>]</b><br/> Return the address of the specified generic vertex attribute pointer. </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</param>
        /// <param name="pointer">Returns the pointer value.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetVertexAttribPointerv.xhtml" /></remarks>
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._glGetVertexAttribPointerv_fnptr(index, (uint)pname, pointer);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glHint</c>]</b><br/> Specify implementation-specific hints. </summary>
        /// <param name="target"> Specifies a symbolic constant indicating the behavior to be controlled. GL_FRAGMENT_SHADER_DERIVATIVE_HINT, and GL_GENERATE_MIPMAP_HINT are accepted. </param>
        /// <param name="mode"> Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglHint.xhtml" /></remarks>
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glInvalidateFramebuffer</c>]</b><br/> Invalidate the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateFramebuffer.xhtml" /></remarks>
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glInvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glInvalidateSubFramebuffer</c>]</b><br/> Invalidate portions of the contents of attachments within a framebuffer. </summary>
        /// <param name="target"> Specifies the target of the invalidate operation. </param>
        /// <param name="numAttachments"> Specifies how many attachments are supplied in the attachments list. </param>
        /// <param name="attachments"> A list of numAttachments attachments to invalidate. </param>
        /// <param name="x"> Specifies the left origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="y"> Specifies the bottom origin of the pixel rectangle to invalidate, with lower left hand corner at (0,0). </param>
        /// <param name="width"> Specifies the width of the pixel rectangle to invalidate. </param>
        /// <param name="height"> Specifies the height of the pixel rectangle to invalidate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglInvalidateSubFramebuffer.xhtml" /></remarks>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsBuffer</c>]</b><br/> Determine if a name corresponds to a buffer object. </summary>
        /// <param name="buffer"> Specifies a value that may be the name of a buffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsBuffer.xhtml" /></remarks>
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsEnabled</c>]</b><br/> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glIsEnabledi</c>]</b><br/> Test whether a capability is enabled. </summary>
        /// <param name="cap"> Specifies a symbolic constant indicating a GL capability. </param>
        /// <param name="index"> Specifies the index of the capability. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsEnabled.xhtml" /></remarks>
        public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnabledi_fnptr((uint)target, index) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsFramebuffer</c>]</b><br/> Determine if a name corresponds to a framebuffer object. </summary>
        /// <param name="framebuffer"> Specifies a value that may be the name of a framebuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsFramebuffer.xhtml" /></remarks>
        public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebuffer_fnptr(framebuffer) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsProgram</c>]</b><br/> Determines if a name corresponds to a program object. </summary>
        /// <param name="program">Specifies a potential program object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgram.xhtml" /></remarks>
        public static bool IsProgram(int program) => GLPointers._glIsProgram_fnptr(program) != 0;
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glIsProgramPipeline</c>]</b><br/> Determine if a name corresponds to a program pipeline object. </summary>
        /// <param name="pipeline"> Specifies a value that may be the name of a program pipeline object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsProgramPipeline.xhtml" /></remarks>
        public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipeline_fnptr(pipeline) != 0;
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glIsQuery</c>]</b><br/> Determine if a name corresponds to a query object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a query object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsQuery.xhtml" /></remarks>
        public static bool IsQuery(int id) => GLPointers._glIsQuery_fnptr(id) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsRenderbuffer</c>]</b><br/> Determine if a name corresponds to a renderbuffer object. </summary>
        /// <param name="renderbuffer"> Specifies a value that may be the name of a renderbuffer object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsRenderbuffer.xhtml" /></remarks>
        public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbuffer_fnptr(renderbuffer) != 0;
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glIsSampler</c>]</b><br/> Determine if a name corresponds to a sampler object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a sampler object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSampler.xhtml" /></remarks>
        public static bool IsSampler(int sampler) => GLPointers._glIsSampler_fnptr(sampler) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsShader</c>]</b><br/> Determines if a name corresponds to a shader object. </summary>
        /// <param name="shader">Specifies a potential shader object.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsShader.xhtml" /></remarks>
        public static bool IsShader(int shader) => GLPointers._glIsShader_fnptr(shader) != 0;
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glIsSync</c>]</b><br/> Determine if a name corresponds to a sync object. </summary>
        /// <param name="sync"> Specifies a value that may be the name of a sync object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsSync.xhtml" /></remarks>
        public static bool IsSync(GLSync sync) => GLPointers._glIsSync_fnptr((IntPtr)sync) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glIsTexture</c>]</b><br/> Determine if a name corresponds to a texture. </summary>
        /// <param name="texture"> Specifies a value that may be the name of a texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTexture.xhtml" /></remarks>
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glIsTransformFeedback</c>]</b><br/> Determine if a name corresponds to a transform feedback object. </summary>
        /// <param name="id"> Specifies a value that may be the name of a transform feedback object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsTransformFeedback.xhtml" /></remarks>
        public static bool IsTransformFeedback(int id) => GLPointers._glIsTransformFeedback_fnptr(id) != 0;
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glIsVertexArray</c>]</b><br/> Determine if a name corresponds to a vertex array object. </summary>
        /// <param name="array"> Specifies a value that may be the name of a vertex array object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglIsVertexArray.xhtml" /></remarks>
        public static bool IsVertexArray(int array) => GLPointers._glIsVertexArray_fnptr(array) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glLineWidth</c>]</b><br/> Specify the width of rasterized lines. </summary>
        /// <param name="width"> Specifies the width of rasterized lines. The initial value is 1. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLineWidth.xhtml" /></remarks>
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glLinkProgram</c>]</b><br/> Links a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglLinkProgram.xhtml" /></remarks>
        public static void LinkProgram(int program) => GLPointers._glLinkProgram_fnptr(program);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glMapBufferRange</c>]</b><br/> Map a section of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <param name="offset"> Specifies the starting offset within the buffer of the range to be mapped. </param>
        /// <param name="length"> Specifies the length of the range to be mapped. </param>
        /// <param name="access"> Specifies a combination of access flags indicating the desired access to the range. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRange_fnptr((uint)target, offset, length, (uint)access);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glMemoryBarrier</c>]</b><br/> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrier_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glMemoryBarrierByRegion</c>]</b><br/> Defines a barrier ordering memory transactions. </summary>
        /// <param name="barriers"> Specifies the barriers to insert. Must be a bitwise combination of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_COMMAND_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT, or GL_SHADER_STORAGE_BARRIER_BIT. If the special value GL_ALL_BARRIER_BITS is specified, all supported barriers will be inserted. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMemoryBarrier.xhtml" /></remarks>
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierByRegion_fnptr((uint)barriers);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glMinSampleShading</c>]</b><br/> Specifies minimum rate at which sample shading takes place. </summary>
        /// <param name="value"> Specifies the rate at which samples are shaded within each covered pixel. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMinSampleShading.xhtml" /></remarks>
        public static void MinSampleShading(float value) => GLPointers._glMinSampleShading_fnptr(value);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glObjectLabel</c>]</b><br/> Label a named object identified within a namespace. </summary>
        /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
        /// <param name="name"> The name of the object to label. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glObjectPtrLabel</c>]</b><br/> Label a sync object identified by a pointer. </summary>
        /// <param name="ptr"> A pointer identifying a sync object. </param>
        /// <param name="length"> The length of the label to be used for the object. </param>
        /// <param name="label"> The address of a string containing the label to assign to the object. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glPatchParameteri</c>]</b><br/> Specifies the parameters for patch primitives. </summary>
        /// <param name="pname"> Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES is accepted. </param>
        /// <param name="value"> Specifies the new value for the parameter given by pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPatchParameteri.xhtml" /></remarks>
        public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteri_fnptr((uint)pname, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glPauseTransformFeedback</c>]</b><br/> Pause transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPauseTransformFeedback.xhtml" /></remarks>
        public static void PauseTransformFeedback() => GLPointers._glPauseTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glPixelStorei</c>]</b><br/> Set pixel storage modes. </summary>
        /// <param name="pname"> Specifies the symbolic name of the parameter to be set. Four values affect the packing of pixel data into memory: GL_PACK_ROW_LENGTH, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT. </param>
        /// <param name="param"> Specifies the value that pname is set to. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPixelStorei.xhtml" /></remarks>
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glPolygonOffset</c>]</b><br/> Set the scale and units used to calculate depth values. </summary>
        /// <param name="factor"> Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0. </param>
        /// <param name="units"> Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPolygonOffset.xhtml" /></remarks>
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glPopDebugGroup</c>]</b><br/> Pop the active debug group. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
        public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glPrimitiveBoundingBox</c>]</b><br/> Set the bounding box for a primitive. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glProgramBinary</c>]</b><br/> Load a program object with a program binary. </summary>
        /// <param name="program"> Specifies the name of a program object into which to load a program binary. </param>
        /// <param name="binaryFormat"> Specifies the format of the binary data in binary. </param>
        /// <param name="binary"> Specifies the address of an array containing the binary to be loaded into program. </param>
        /// <param name="length"> Specifies the number of bytes contained in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramBinary.xhtml" /></remarks>
        public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinary_fnptr(program, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glProgramParameteri</c>]</b><br/> Specify a parameter for a program object. </summary>
        /// <param name="program"> Specifies the name of a program object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the name of the parameter to modify. </param>
        /// <param name="value"> Specifies the new value of the parameter specified by pname for program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramParameteri.xhtml" /></remarks>
        public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteri_fnptr(program, (uint)pname, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1f</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1f_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1i</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1i_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1iv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1ui</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1ui_fnptr(program, location, v0);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform1uiv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2f</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2f_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2i</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2i_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2iv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2ui</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2ui_fnptr(program, location, v0, v1);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform2uiv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3f</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3f_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3i</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3i_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3iv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3ui</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform3uiv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4f</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4i</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4iv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4iv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4ui</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniform4uiv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uiv_fnptr(program, location, count, value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix2fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix2x3fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix2x4fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix3fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix3x2fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix3x4fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix4fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix4x2fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glProgramUniformMatrix4x3fv</c>]</b><br/> Specify the value of a uniform variable for a specified program object. </summary>
        /// <param name="program">Specifies the handle of the program containing the uniform variable to be modified.</param>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglProgramUniform.xhtml" /></remarks>
        public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glPushDebugGroup</c>]</b><br/> Push a named debug group into the command stream. </summary>
        /// <param name="source"> The source of the debug message. </param>
        /// <param name="id"> The identifier of the message. </param>
        /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
        /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glReadBuffer</c>]</b><br/> Select a color buffer source for pixels. </summary>
        /// <param name="src"> Specifies a color buffer. Accepted values are GL_BACK, GL_NONE, and GL_COLOR_ATTACHMENTi. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadBuffer.xhtml" /></remarks>
        public static void ReadBuffer(ReadBufferMode src) => GLPointers._glReadBuffer_fnptr((uint)src);
        
        /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glReadnPixels</c>]</b><br/> Read a block of pixels from the frame buffer. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glReadPixels</c>]</b><br/> Read a block of pixels from the frame buffer. </summary>
        /// <param name="x"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="y"> Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels. </param>
        /// <param name="width"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="height"> Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel. </param>
        /// <param name="format"> Specifies the format of the pixel data. The following symbolic values are accepted: GL_RGBA, and GL_RGBA_INTEGER. An implementation-chosen format will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_FORMAT. </param>
        /// <param name="type"> Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, GL_INT, or GL_FLOAT. An implementation-chosen type will also be accepted. This can be queried with glGet and GL_IMPLEMENTATION_COLOR_READ_TYPE. </param>
        /// <param name="data"> Returns the pixel data. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReadPixels.xhtml" /></remarks>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glReleaseShaderCompiler</c>]</b><br/> Release resources consumed by the implementation&apos;s shader compiler. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglReleaseShaderCompiler.xhtml" /></remarks>
        public static void ReleaseShaderCompiler() => GLPointers._glReleaseShaderCompiler_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glRenderbufferStorage</c>]</b><br/> Establish data storage, format and dimensions of a renderbuffer object&apos;s image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object&apos;s image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorage.xhtml" /></remarks>
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glRenderbufferStorageMultisample</c>]</b><br/> Establish data storage, format, dimensions and sample count of a renderbuffer object&apos;s image. </summary>
        /// <param name="target"> Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER. </param>
        /// <param name="samples"> Specifies the number of samples to be used for the renderbuffer object&apos;s storage. </param>
        /// <param name="internalformat"> Specifies the internal format to use for the renderbuffer object&apos;s image. </param>
        /// <param name="width"> Specifies the width of the renderbuffer, in pixels. </param>
        /// <param name="height"> Specifies the height of the renderbuffer, in pixels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglRenderbufferStorageMultisample.xhtml" /></remarks>
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glResumeTransformFeedback</c>]</b><br/> Resume transform feedback operations. </summary>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglResumeTransformFeedback.xhtml" /></remarks>
        public static void ResumeTransformFeedback() => GLPointers._glResumeTransformFeedback_fnptr();
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glSampleCoverage</c>]</b><br/> Specify multisample coverage parameters. </summary>
        /// <param name="value"> Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0. </param>
        /// <param name="invert"> Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleCoverage.xhtml" /></remarks>
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glSampleMaski</c>]</b><br/> Set the value of a sub-word of the sample mask. </summary>
        /// <param name="maskNumber"> Specifies which 32-bit sub-word of the sample mask to update. </param>
        /// <param name="mask"> Specifies the new value of the mask sub-word. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSampleMaski.xhtml" /></remarks>
        public static void SampleMaski(uint maskNumber, uint mask) => GLPointers._glSampleMaski_fnptr(maskNumber, mask);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glSamplerParameterf</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterf(int sampler, SamplerParameterF pname, float param) => GLPointers._glSamplerParameterf_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glSamplerParameterfv</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterfv(int sampler, SamplerParameterF pname, float* param) => GLPointers._glSamplerParameterfv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glSamplerParameteri</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="param"> For the scalar commands, specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteri(int sampler, SamplerParameterI pname, int param) => GLPointers._glSamplerParameteri_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glSamplerParameterIiv</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIiv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glSamplerParameterIuiv</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuiv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glSamplerParameteriv</c>]</b><br/> Set sampler parameters. </summary>
        /// <param name="sampler"> Specifies the sampler object whose parameter to modify. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued sampler parameter. pname can be one of the following: GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC. </param>
        /// <param name="parameters"> For the vector commands (glSamplerParameter*v), specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglSamplerParameter.xhtml" /></remarks>
        public static void SamplerParameteriv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameteriv_fnptr(sampler, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glScissor</c>]</b><br/> Define the scissor box. </summary>
        /// <param name="x"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="y"> Specify the lower left corner of the scissor box. Initially (0, 0). </param>
        /// <param name="width"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglScissor.xhtml" /></remarks>
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glShaderBinary</c>]</b><br/> Load pre-compiled shader binaries. </summary>
        /// <param name="count"> Specifies the number of shader object handles contained in shaders. </param>
        /// <param name="shaders"> Specifies the address of an array of shader handles into which to load pre-compiled shader binaries. </param>
        /// <param name="binaryFormat"> Specifies the format of the shader binaries contained in binary. </param>
        /// <param name="binary"> Specifies the address of an array of bytes containing pre-compiled binary shader code. </param>
        /// <param name="length"> Specifies the length of the array whose address is given in binary. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderBinary.xhtml" /></remarks>
        public static void ShaderBinary(int count, int* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._glShaderBinary_fnptr(count, shaders, (uint)binaryFormat, binary, length);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glShaderSource</c>]</b><br/> Replaces the source code in a shader object. </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="str">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglShaderSource.xhtml" /></remarks>
        public static void ShaderSource(int shader, int count, byte** str, int* length) => GLPointers._glShaderSource_fnptr(shader, count, str, length);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilFunc</c>]</b><br/> Set front and back function and reference value for stencil testing. </summary>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFunc.xhtml" /></remarks>
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilFuncSeparate</c>]</b><br/> Set front and/or back function and reference value for stencil testing. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="func"> Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. </param>
        /// <param name="reference"> Specifies the reference value for the stencil test. Stencil comparison operations and queries of ref clamp its value to the range 0 2 n - 1 , where n is the number of bitplanes in the stencil buffer. The initial value is 0. </param>
        /// <param name="mask"> Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilFuncSeparate.xhtml" /></remarks>
        public static void StencilFuncSeparate(TriangleFace face, StencilFunction func, int reference, uint mask) => GLPointers._glStencilFuncSeparate_fnptr((uint)face, (uint)func, reference, mask);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilMask</c>]</b><br/> Control the front and back writing of individual bits in the stencil planes. </summary>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMask.xhtml" /></remarks>
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilMaskSeparate</c>]</b><br/> Control the front and/or back writing of individual bits in the stencil planes. </summary>
        /// <param name="face"> Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="mask"> Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1&apos;s. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilMaskSeparate.xhtml" /></remarks>
        public static void StencilMaskSeparate(TriangleFace face, uint mask) => GLPointers._glStencilMaskSeparate_fnptr((uint)face, mask);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilOp</c>]</b><br/> Set front and back stencil test actions. </summary>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOp.xhtml" /></remarks>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glStencilOpSeparate</c>]</b><br/> Set front and/or back stencil test actions. </summary>
        /// <param name="face"> Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK. </param>
        /// <param name="sfail"> Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP. </param>
        /// <param name="dpfail"> Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <param name="dppass"> Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglStencilOpSeparate.xhtml" /></remarks>
        public static void StencilOpSeparate(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._glStencilOpSeparate_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glTexBuffer</c>]</b><br/> Attach a buffer object&apos;s data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBuffer.xhtml" /></remarks>
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBuffer_fnptr((uint)target, (uint)internalformat, buffer);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glTexBufferRange</c>]</b><br/> Attach a range of a buffer object&apos;s data store to a buffer texture object. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexBufferRange. Must be GL_TEXTURE_BUFFER. </param>
        /// <param name="internalFormat"> Specifies the internal format of the data in the store belonging to buffer. </param>
        /// <param name="buffer"> Specifies the name of the buffer object whose storage to attach to the active buffer texture. </param>
        /// <param name="offset"> Specifies the offset of the start of the range of the buffer&apos;s data store to attach. </param>
        /// <param name="size"> Specifies the size of the range of the buffer&apos;s data store to attach. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexBufferRange.xhtml" /></remarks>
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRange_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexImage2D</c>]</b><br/> Specify a two-dimensional texture image. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glTexImage3D</c>]</b><br/> Specify a three-dimensional texture image. </summary>
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
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexParameterf</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexParameterfv</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexParameteri</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="param"> Specifies the value of pname. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glTexParameterIiv</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glTexParameterIuiv</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexParameteriv</c>]</b><br/> Set texture parameters. </summary>
        /// <param name="target"> Specifies the target texture, which must be either GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="pname"> Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R. </param>
        /// <param name="parameters"> For the vector commands, specifies a pointer to an array where the value or values of pname are stored. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexParameter.xhtml" /></remarks>
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glTexStorage2D</c>]</b><br/> Simultaneously specify storage for all levels of a two-dimensional texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_2D, or GL_TEXTURE_CUBE_MAP. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2D.xhtml" /></remarks>
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glTexStorage2DMultisample</c>]</b><br/> Specify storage for a two-dimensional multisample texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage2DMultisample.xhtml" /></remarks>
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glTexStorage3D</c>]</b><br/> Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array, or cube map array texture. </summary>
        /// <param name="target"> Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, or GL_TEXTURE_CUBE_MAP_ARRAY. </param>
        /// <param name="levels"> Specify the number of texture levels. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in texels. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3D.xhtml" /></remarks>
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
        
        /// <summary> <b>[requires: v3.2]</b> <b>[entry point: <c>glTexStorage3DMultisample</c>]</b><br/> Specify storage for a two-dimensional multisample array texture. </summary>
        /// <param name="target"> Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY. </param>
        /// <param name="samples"> Specify the number of samples in the texture. </param>
        /// <param name="internalformat"> Specifies the sized internal format to be used to store texture image data. </param>
        /// <param name="width"> Specifies the width of the texture, in texels. </param>
        /// <param name="height"> Specifies the height of the texture, in texels. </param>
        /// <param name="depth"> Specifies the depth of the texture, in layers. </param>
        /// <param name="fixedsamplelocations"> Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTexStorage3DMultisample.xhtml" /></remarks>
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glTexSubImage2D</c>]</b><br/> Specify a two-dimensional texture subimage. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glTexSubImage3D</c>]</b><br/> Specify a three-dimensional texture subimage. </summary>
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
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glTransformFeedbackVaryings</c>]</b><br/> Specify values to record in transform feedback buffers. </summary>
        /// <param name="program"> The name of the target program object. </param>
        /// <param name="count"> The number of varying variables used for transform feedback. </param>
        /// <param name="varyings"> An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback. </param>
        /// <param name="bufferMode"> Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglTransformFeedbackVaryings.xhtml" /></remarks>
        public static void TransformFeedbackVaryings(int program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryings_fnptr(program, count, varyings, (uint)bufferMode);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform1f</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1f(int location, float v0) => GLPointers._glUniform1f_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform1fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1fv(int location, int count, float* value) => GLPointers._glUniform1fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform1i</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1i(int location, int v0) => GLPointers._glUniform1i_fnptr(location, v0);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform1iv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1iv(int location, int count, int* value) => GLPointers._glUniform1iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform1ui</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1ui(int location, uint v0) => GLPointers._glUniform1ui_fnptr(location, v0);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform1uiv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform1uiv(int location, int count, uint* value) => GLPointers._glUniform1uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform2f</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2f(int location, float v0, float v1) => GLPointers._glUniform2f_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform2fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2fv(int location, int count, float* value) => GLPointers._glUniform2fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform2i</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2i(int location, int v0, int v1) => GLPointers._glUniform2i_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform2iv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2iv(int location, int count, int* value) => GLPointers._glUniform2iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform2ui</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2ui(int location, uint v0, uint v1) => GLPointers._glUniform2ui_fnptr(location, v0, v1);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform2uiv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform2uiv(int location, int count, uint* value) => GLPointers._glUniform2uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform3f</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3f(int location, float v0, float v1, float v2) => GLPointers._glUniform3f_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform3fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3fv(int location, int count, float* value) => GLPointers._glUniform3fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform3i</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3i(int location, int v0, int v1, int v2) => GLPointers._glUniform3i_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform3iv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3iv(int location, int count, int* value) => GLPointers._glUniform3iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform3ui</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => GLPointers._glUniform3ui_fnptr(location, v0, v1, v2);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform3uiv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform3uiv(int location, int count, uint* value) => GLPointers._glUniform3uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform4f</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => GLPointers._glUniform4f_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform4fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4fv(int location, int count, float* value) => GLPointers._glUniform4fv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform4i</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => GLPointers._glUniform4i_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniform4iv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4iv(int location, int count, int* value) => GLPointers._glUniform4iv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform4ui</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glUniform4ui_fnptr(location, v0, v1, v2, v3);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniform4uiv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void Uniform4uiv(int location, int count, uint* value) => GLPointers._glUniform4uiv_fnptr(location, count, value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformBlockBinding</c>]</b><br/> Assign a binding point to an active uniform block. </summary>
        /// <param name="program"> The name of a program object containing the active uniform block whose binding to assign. </param>
        /// <param name="uniformBlockIndex"> The index of the active uniform block within program whose binding to assign. </param>
        /// <param name="uniformBlockBinding"> Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniformBlockBinding.xhtml" /></remarks>
        public static void UniformBlockBinding(int program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._glUniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniformMatrix2fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix2x3fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix2x4fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniformMatrix3fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix3x2fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix3x4fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUniformMatrix4fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix4x2fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUniformMatrix4x3fv</c>]</b><br/> Specify the value of a uniform variable for the current program object. </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count"> For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the targeted uniform variable is not an array, and 1 or more if it is an array. </param>
        /// <param name="transpose"> For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable. </param>
        /// <param name="value"> For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the specified uniform variable. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUniform.xhtml" /></remarks>
        public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glUnmapBuffer</c>]</b><br/> Map a section of a buffer object&apos;s data store. </summary>
        /// <param name="target"> Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding targets in the following table: </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglMapBufferRange.xhtml" /></remarks>
        public static bool UnmapBuffer(BufferTargetARB target) => GLPointers._glUnmapBuffer_fnptr((uint)target) != 0;
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glUseProgram</c>]</b><br/> Installs a program object as part of current rendering state. </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgram.xhtml" /></remarks>
        public static void UseProgram(int program) => GLPointers._glUseProgram_fnptr(program);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glUseProgramStages</c>]</b><br/> Bind stages of a program object to a program pipeline. </summary>
        /// <param name="pipeline"> Specifies the program pipeline object to which to bind stages from program. </param>
        /// <param name="stages"> Specifies a set of program stages to bind to the program pipeline object. </param>
        /// <param name="program"> Specifies the program object containing the shader executables to use in pipeline. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglUseProgramStages.xhtml" /></remarks>
        public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStages_fnptr(pipeline, (uint)stages, program);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glValidateProgram</c>]</b><br/> Validates a program object. </summary>
        /// <param name="program">Specifies the handle of the program object to be validated.</param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgram.xhtml" /></remarks>
        public static void ValidateProgram(int program) => GLPointers._glValidateProgram_fnptr(program);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glValidateProgramPipeline</c>]</b><br/> Validate a program pipeline object against current GL state. </summary>
        /// <param name="pipeline"> Specifies the name of a program pipeline object to validate. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglValidateProgramPipeline.xhtml" /></remarks>
        public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipeline_fnptr(pipeline);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib1f</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1f(uint index, float x) => GLPointers._glVertexAttrib1f_fnptr(index, x);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib1fv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib1fv(uint index, float* v) => GLPointers._glVertexAttrib1fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib2f</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2f(uint index, float x, float y) => GLPointers._glVertexAttrib2f_fnptr(index, x, y);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib2fv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib2fv(uint index, float* v) => GLPointers._glVertexAttrib2fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib3f</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3f(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3f_fnptr(index, x, y, z);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib3fv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib3fv(uint index, float* v) => GLPointers._glVertexAttrib3fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib4f</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4f_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttrib4fv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttrib4fv(uint index, float* v) => GLPointers._glVertexAttrib4fv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glVertexAttribBinding</c>]</b><br/> Associate a vertex attribute and a vertex buffer binding. </summary>
        /// <param name="attribindex"> The index of the attribute to associate with a vertex buffer binding. </param>
        /// <param name="bindingindex"> The index of the vertex buffer binding with which to associate the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribBinding.xhtml" /></remarks>
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._glVertexAttribBinding_fnptr(attribindex, bindingindex);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribDivisor</c>]</b><br/> Modify the rate at which generic vertex attributes advance during instanced rendering. </summary>
        /// <param name="index"> Specify the index of the generic vertex attribute. </param>
        /// <param name="divisor"> Specify the number of instances that will pass between updates of the generic attribute at slot index. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribDivisor.xhtml" /></remarks>
        public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisor_fnptr(index, divisor);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glVertexAttribFormat</c>]</b><br/> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="normalized"> Specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexAttribFormat_fnptr(attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribI4i</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4i_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribI4iv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4iv(uint index, int* v) => GLPointers._glVertexAttribI4iv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribI4ui</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v0"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v1"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v2"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <param name="v3"> For the scalar commands, specifies the new values to be used for the specified vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4ui_fnptr(index, x, y, z, w);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribI4uiv</c>]</b><br/> Specifies the value of a generic vertex attribute. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v"> For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex attribute. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttrib.xhtml" /></remarks>
        public static void VertexAttribI4uiv(uint index, uint* v) => GLPointers._glVertexAttribI4uiv_fnptr(index, v);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glVertexAttribIFormat</c>]</b><br/> Specify the organization of vertex arrays. </summary>
        /// <param name="attribindex"> The generic vertex attribute array being described. </param>
        /// <param name="size"> The number of values per vertex that are stored in the array. </param>
        /// <param name="type"> The type of the data stored in the array. </param>
        /// <param name="relativeoffset"> An offset to the first element relative to the start of the vertex buffer binding. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribFormat.xhtml" /></remarks>
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glVertexAttribIPointer</c>]</b><br/> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glVertexAttribPointer</c>]</b><br/> Define an array of generic vertex attribute data. </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. The initial value is 4.</param>
        /// <param name="type">Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by both functions. Additionally GL_HALF_FLOAT, GL_FLOAT, GL_FIXED, GL_INT_2_10_10_10_REV, and GL_UNSIGNED_INT_2_10_10_10_REV are accepted by glVertexAttribPointer. The initial value is GL_FLOAT.</param>
        /// <param name="normalized">For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted directly as fixed-point values (GL_FALSE) when they are accessed. This parameter is ignored if type is GL_FIXED.</param>
        /// <param name="stride"> Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array. The initial value is 0. </param>
        /// <param name="pointer"> Specifies a pointer to the first generic vertex attribute in the array. If a non-zero buffer is currently bound to the GL_ARRAY_BUFFER target, pointer specifies an offset of into the array in the data store of that buffer. The initial value is 0. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexAttribPointer.xhtml" /></remarks>
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => GLPointers._glVertexAttribPointer_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>glVertexBindingDivisor</c>]</b><br/> Modify the rate at which generic vertex attributes advance. </summary>
        /// <param name="bindingindex"> The index of the binding whose divisor to modify. </param>
        /// <param name="divisor"> The new value for the instance step rate to apply. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglVertexBindingDivisor.xhtml" /></remarks>
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._glVertexBindingDivisor_fnptr(bindingindex, divisor);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>glViewport</c>]</b><br/> Set the viewport. </summary>
        /// <param name="x"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="y"> Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). </param>
        /// <param name="width"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <param name="height"> Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglViewport.xhtml" /></remarks>
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>glWaitSync</c>]</b><br/> Instruct the GL server to block until the specified sync object becomes signaled. </summary>
        /// <param name="sync"> Specifies the sync object whose status to wait on. </param>
        /// <param name="flags"> A bitfield controlling the command flushing behavior. flags must be zero. </param>
        /// <param name="timeout"> Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED. </param>
        /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglWaitSync.xhtml" /></remarks>
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glBeginPerfMonitorAMD</c>]</b><br/>  </summary>
            public static void BeginPerfMonitorAMD(uint monitor) => GLPointers._glBeginPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glDeletePerfMonitorsAMD</c>]</b><br/>  </summary>
            public static void DeletePerfMonitorsAMD(int n, uint* monitors) => GLPointers._glDeletePerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glEndPerfMonitorAMD</c>]</b><br/>  </summary>
            public static void EndPerfMonitorAMD(uint monitor) => GLPointers._glEndPerfMonitorAMD_fnptr(monitor);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGenPerfMonitorsAMD</c>]</b><br/>  </summary>
            public static void GenPerfMonitorsAMD(int n, uint* monitors) => GLPointers._glGenPerfMonitorsAMD_fnptr(n, monitors);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorCounterDataAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => GLPointers._glGetPerfMonitorCounterDataAMD_fnptr(monitor, (uint)pname, dataSize, data, bytesWritten);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorCounterInfoAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, void* data) => GLPointers._glGetPerfMonitorCounterInfoAMD_fnptr(group, counter, (uint)pname, data);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorCountersAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => GLPointers._glGetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorCounterStringAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => GLPointers._glGetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorGroupsAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => GLPointers._glGetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glGetPerfMonitorGroupStringAMD</c>]</b><br/>  </summary>
            public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => GLPointers._glGetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced]</b> <b>[entry point: <c>glNamedRenderbufferStorageMultisampleAdvancedAMD</c>]</b><br/>  </summary>
            public static void NamedRenderbufferStorageMultisampleAdvancedAMD(int renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_framebuffer_multisample_advanced]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleAdvancedAMD</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAdvancedAMD_fnptr((uint)target, samples, storageSamples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_AMD_performance_monitor]</b> <b>[entry point: <c>glSelectPerfMonitorCountersAMD</c>]</b><br/>  </summary>
            public static void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint* counterList) => GLPointers._glSelectPerfMonitorCountersAMD_fnptr(monitor, (byte)(enable ? 1 : 0), group, numCounters, counterList);
            
        }
        /// <summary>ANGLE extensions.</summary>
        public static unsafe partial class ANGLE
        {
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_blit]</b> <b>[entry point: <c>glBlitFramebufferANGLE</c>]</b><br/>  </summary>
            public static void BlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b> <b>[entry point: <c>glDrawArraysInstancedANGLE</c>]</b><br/>  </summary>
            public static void DrawArraysInstancedANGLE(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedANGLE_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b> <b>[entry point: <c>glDrawElementsInstancedANGLE</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedANGLE(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedANGLE_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_ANGLE_translated_shader_source]</b> <b>[entry point: <c>glGetTranslatedShaderSourceANGLE</c>]</b><br/>  </summary>
            public static void GetTranslatedShaderSourceANGLE(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetTranslatedShaderSourceANGLE_fnptr(shader, bufSize, length, source);
            
            /// <summary> <b>[requires: GL_ANGLE_framebuffer_multisample]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleANGLE</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleANGLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleANGLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_ANGLE_instanced_arrays]</b> <b>[entry point: <c>glVertexAttribDivisorANGLE</c>]</b><br/>  </summary>
            public static void VertexAttribDivisorANGLE(uint index, uint divisor) => GLPointers._glVertexAttribDivisorANGLE_fnptr(index, divisor);
            
        }
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glClientWaitSyncAPPLE</c>]</b><br/>  </summary>
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            /// <summary> <b>[requires: GL_APPLE_copy_texture_levels]</b> <b>[entry point: <c>glCopyTextureLevelsAPPLE</c>]</b><br/>  </summary>
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => GLPointers._glCopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glDeleteSyncAPPLE</c>]</b><br/>  </summary>
            public static void DeleteSyncAPPLE(GLSync sync) => GLPointers._glDeleteSyncAPPLE_fnptr((IntPtr)sync);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glFenceSyncAPPLE</c>]</b><br/>  </summary>
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSyncAPPLE_fnptr((uint)condition, (uint)flags);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glGetInteger64vAPPLE</c>]</b><br/>  </summary>
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => GLPointers._glGetInteger64vAPPLE_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glGetSyncivAPPLE</c>]</b><br/>  </summary>
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSyncivAPPLE_fnptr((IntPtr)sync, (uint)pname, count, length, values);
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glIsSyncAPPLE</c>]</b><br/>  </summary>
            public static bool IsSyncAPPLE(GLSync sync) => GLPointers._glIsSyncAPPLE_fnptr((IntPtr)sync) != 0;
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleAPPLE</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAPPLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_APPLE_framebuffer_multisample]</b> <b>[entry point: <c>glResolveMultisampleFramebufferAPPLE</c>]</b><br/>  </summary>
            public static void ResolveMultisampleFramebufferAPPLE() => GLPointers._glResolveMultisampleFramebufferAPPLE_fnptr();
            
            /// <summary> <b>[requires: GL_APPLE_sync]</b> <b>[entry point: <c>glWaitSyncAPPLE</c>]</b><br/>  </summary>
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex]</b> <b>[entry point: <c>glAcquireKeyedMutexWin32EXT</c>]</b><br/>  </summary>
            public static bool AcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => GLPointers._glAcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout) != 0;
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glActiveProgramEXT</c>]</b><br/>  </summary>
            public static void ActiveProgramEXT(int program) => GLPointers._glActiveProgramEXT_fnptr(program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glActiveShaderProgramEXT</c>]</b><br/>  </summary>
            public static void ActiveShaderProgramEXT(int pipeline, int program) => GLPointers._glActiveShaderProgramEXT_fnptr(pipeline, program);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glBeginQueryEXT</c>]</b><br/>  </summary>
            public static void BeginQueryEXT(QueryTarget target, int id) => GLPointers._glBeginQueryEXT_fnptr((uint)target, id);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b> <b>[entry point: <c>glBindFragDataLocationEXT</c>]</b><br/>  </summary>
            public static void BindFragDataLocationEXT(int program, uint color, byte* name) => GLPointers._glBindFragDataLocationEXT_fnptr(program, color, name);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b> <b>[entry point: <c>glBindFragDataLocationIndexedEXT</c>]</b><br/>  </summary>
            public static void BindFragDataLocationIndexedEXT(int program, uint colorNumber, uint index, byte* name) => GLPointers._glBindFragDataLocationIndexedEXT_fnptr(program, colorNumber, index, name);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glBindProgramPipelineEXT</c>]</b><br/>  </summary>
            public static void BindProgramPipelineEXT(int pipeline) => GLPointers._glBindProgramPipelineEXT_fnptr(pipeline);
            
            /// <summary> <b>[requires: GL_EXT_blend_minmax]</b> <b>[entry point: <c>glBlendEquationEXT</c>]</b><br/>  </summary>
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendEquationiEXT</c>]</b><br/>  </summary>
            public static void BlendEquationiEXT(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiEXT_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendEquationSeparateiEXT</c>]</b><br/>  </summary>
            public static void BlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiEXT_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendFunciEXT</c>]</b><br/>  </summary>
            public static void BlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciEXT_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendFuncSeparateiEXT</c>]</b><br/>  </summary>
            public static void BlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiEXT_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_EXT_framebuffer_blit_layers]</b> <b>[entry point: <c>glBlitFramebufferLayerEXT</c>]</b><br/>  </summary>
            public static void BlitFramebufferLayerEXT(int srcX0, int srcY0, int srcX1, int srcY1, int srcLayer, int dstX0, int dstY0, int dstX1, int dstY1, int dstLayer, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayerEXT_fnptr(srcX0, srcY0, srcX1, srcY1, srcLayer, dstX0, dstY0, dstX1, dstY1, dstLayer, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_framebuffer_blit_layers]</b> <b>[entry point: <c>glBlitFramebufferLayersEXT</c>]</b><br/>  </summary>
            public static void BlitFramebufferLayersEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayersEXT_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_EXT_buffer_storage]</b> <b>[entry point: <c>glBufferStorageEXT</c>]</b><br/>  </summary>
            public static void BufferStorageEXT(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._glBufferStorageEXT_fnptr((uint)target, size, data, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer]</b> <b>[entry point: <c>glBufferStorageExternalEXT</c>]</b><br/>  </summary>
            public static void BufferStorageExternalEXT(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glBufferStorageExternalEXT_fnptr((uint)target, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glBufferStorageMemEXT</c>]</b><br/>  </summary>
            public static void BufferStorageMemEXT(BufferTargetARB target, nint size, uint memory, ulong offset) => GLPointers._glBufferStorageMemEXT_fnptr((uint)target, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b> <b>[entry point: <c>glClearPixelLocalStorageuiEXT</c>]</b><br/>  </summary>
            public static void ClearPixelLocalStorageuiEXT(int offset, int n, uint* values) => GLPointers._glClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture]</b> <b>[entry point: <c>glClearTexImageEXT</c>]</b><br/>  </summary>
            public static void ClearTexImageEXT(int texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexImageEXT_fnptr(texture, level, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clear_texture]</b> <b>[entry point: <c>glClearTexSubImageEXT</c>]</b><br/>  </summary>
            public static void ClearTexSubImageEXT(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexSubImageEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
            
            /// <summary> <b>[requires: GL_EXT_clip_control]</b> <b>[entry point: <c>glClipControlEXT</c>]</b><br/>  </summary>
            public static void ClipControlEXT(All origin, All depth) => GLPointers._glClipControlEXT_fnptr((uint)origin, (uint)depth);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glColorMaskiEXT</c>]</b><br/>  </summary>
            public static void ColorMaskiEXT(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiEXT_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_copy_image]</b> <b>[entry point: <c>glCopyImageSubDataEXT</c>]</b><br/>  </summary>
            public static void CopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataEXT_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glCreateMemoryObjectsEXT</c>]</b><br/>  </summary>
            public static void CreateMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glCreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glCreateShaderProgramEXT</c>]</b><br/>  </summary>
            public static int CreateShaderProgramEXT(ShaderType type, byte* str) => GLPointers._glCreateShaderProgramEXT_fnptr((uint)type, str);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glCreateShaderProgramvEXT</c>]</b><br/>  </summary>
            public static int CreateShaderProgramvEXT(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramvEXT_fnptr((uint)type, count, strings);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glDeleteMemoryObjectsEXT</c>]</b><br/>  </summary>
            public static void DeleteMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glDeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glDeleteProgramPipelinesEXT</c>]</b><br/>  </summary>
            public static void DeleteProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glDeleteProgramPipelinesEXT_fnptr(n, pipelines);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glDeleteQueriesEXT</c>]</b><br/>  </summary>
            public static void DeleteQueriesEXT(int n, int* ids) => GLPointers._glDeleteQueriesEXT_fnptr(n, ids);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glDeleteSemaphoresEXT</c>]</b><br/>  </summary>
            public static void DeleteSemaphoresEXT(int n, uint* semaphores) => GLPointers._glDeleteSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glDisableiEXT</c>]</b><br/>  </summary>
            public static void DisableiEXT(EnableCap target, uint index) => GLPointers._glDisableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_discard_framebuffer]</b> <b>[entry point: <c>glDiscardFramebufferEXT</c>]</b><br/>  </summary>
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glDiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b> <b>[entry point: <c>glDrawArraysInstancedBaseInstanceEXT</c>]</b><br/>  </summary>
            public static void DrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._glDrawArraysInstancedBaseInstanceEXT_fnptr((uint)mode, first, count, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays]</b> <b>[entry point: <c>glDrawArraysInstancedEXT</c>]</b><br/>  </summary>
            public static void DrawArraysInstancedEXT(PrimitiveType mode, int start, int count, int primcount) => GLPointers._glDrawArraysInstancedEXT_fnptr((uint)mode, start, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers]</b> <b>[entry point: <c>glDrawBuffersEXT</c>]</b><br/>  </summary>
            public static void DrawBuffersEXT(int n, All* bufs) => GLPointers._glDrawBuffersEXT_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b> <b>[entry point: <c>glDrawBuffersIndexedEXT</c>]</b><br/>  </summary>
            public static void DrawBuffersIndexedEXT(int n, All* location, int* indices) => GLPointers._glDrawBuffersIndexedEXT_fnptr(n, (uint*)location, indices);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawElementsBaseVertexEXT</c>]</b><br/>  </summary>
            public static void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b> <b>[entry point: <c>glDrawElementsInstancedBaseInstanceEXT</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_base_instance]</b> <b>[entry point: <c>glDrawElementsInstancedBaseVertexBaseInstanceEXT</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawElementsInstancedBaseVertexEXT</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_instanced | GL_EXT_instanced_arrays]</b> <b>[entry point: <c>glDrawElementsInstancedEXT</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawRangeElementsBaseVertexEXT</c>]</b><br/>  </summary>
            public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexEXT_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback]</b> <b>[entry point: <c>glDrawTransformFeedbackEXT</c>]</b><br/>  </summary>
            public static void DrawTransformFeedbackEXT(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedbackEXT_fnptr((uint)mode, id);
            
            /// <summary> <b>[requires: GL_EXT_draw_transform_feedback]</b> <b>[entry point: <c>glDrawTransformFeedbackInstancedEXT</c>]</b><br/>  </summary>
            public static void DrawTransformFeedbackInstancedEXT(PrimitiveType mode, int id, int instancecount) => GLPointers._glDrawTransformFeedbackInstancedEXT_fnptr((uint)mode, id, instancecount);
            
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage]</b> <b>[entry point: <c>glEGLImageTargetTexStorageEXT</c>]</b><br/>  </summary>
            public static void EGLImageTargetTexStorageEXT(All target, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTexStorageEXT_fnptr((uint)target, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_EGL_image_storage]</b> <b>[entry point: <c>glEGLImageTargetTextureStorageEXT</c>]</b><br/>  </summary>
            public static void EGLImageTargetTextureStorageEXT(int texture, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glEnableiEXT</c>]</b><br/>  </summary>
            public static void EnableiEXT(EnableCap target, uint index) => GLPointers._glEnableiEXT_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glEndQueryEXT</c>]</b><br/>  </summary>
            public static void EndQueryEXT(QueryTarget target) => GLPointers._glEndQueryEXT_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b> <b>[entry point: <c>glFlushMappedBufferRangeEXT</c>]</b><br/>  </summary>
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            /// <summary> <b>[requires: GL_EXT_shader_framebuffer_fetch_non_coherent]</b> <b>[entry point: <c>glFramebufferFetchBarrierEXT</c>]</b><br/>  </summary>
            public static void FramebufferFetchBarrierEXT() => GLPointers._glFramebufferFetchBarrierEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b> <b>[entry point: <c>glFramebufferPixelLocalStorageSizeEXT</c>]</b><br/>  </summary>
            public static void FramebufferPixelLocalStorageSizeEXT(uint target, int size) => GLPointers._glFramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate]</b> <b>[entry point: <c>glFramebufferShadingRateEXT</c>]</b><br/>  </summary>
            public static void FramebufferShadingRateEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int baseLayer, int numLayers, int texelWidth, int texelHeight) => GLPointers._glFramebufferShadingRateEXT_fnptr((uint)target, (uint)attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b> <b>[entry point: <c>glFramebufferTexture2DMultisampleEXT</c>]</b><br/>  </summary>
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_EXT_geometry_shader]</b> <b>[entry point: <c>glFramebufferTextureEXT</c>]</b><br/>  </summary>
            public static void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureEXT_fnptr((uint)target, (uint)attachment, texture, level);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glGenProgramPipelinesEXT</c>]</b><br/>  </summary>
            public static void GenProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glGenProgramPipelinesEXT_fnptr(n, pipelines);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glGenQueriesEXT</c>]</b><br/>  </summary>
            public static void GenQueriesEXT(int n, int* ids) => GLPointers._glGenQueriesEXT_fnptr(n, ids);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glGenSemaphoresEXT</c>]</b><br/>  </summary>
            public static void GenSemaphoresEXT(int n, uint* semaphores) => GLPointers._glGenSemaphoresEXT_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b> <b>[entry point: <c>glGetFragDataIndexEXT</c>]</b><br/>  </summary>
            public static int GetFragDataIndexEXT(int program, byte* name) => GLPointers._glGetFragDataIndexEXT_fnptr(program, name);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate]</b> <b>[entry point: <c>glGetFragmentShadingRatesEXT</c>]</b><br/>  </summary>
            public static void GetFragmentShadingRatesEXT(int samples, int maxCount, int* count, ShadingRate* shadingRates) => GLPointers._glGetFragmentShadingRatesEXT_fnptr(samples, maxCount, count, (uint*)shadingRates);
            
            /// <summary> <b>[requires: GL_EXT_shader_pixel_local_storage2]</b> <b>[entry point: <c>glGetFramebufferPixelLocalStorageSizeEXT</c>]</b><br/>  </summary>
            public static int GetFramebufferPixelLocalStorageSizeEXT(FramebufferTarget target) => GLPointers._glGetFramebufferPixelLocalStorageSizeEXT_fnptr((uint)target);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b> <b>[entry point: <c>glGetGraphicsResetStatusEXT</c>]</b><br/>  </summary>
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b> <b>[entry point: <c>glGetInteger64vEXT</c>]</b><br/>  </summary>
            public static void GetInteger64vEXT(GetPName pname, long* data) => GLPointers._glGetInteger64vEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b> <b>[entry point: <c>glGetIntegeri_vEXT</c>]</b><br/>  </summary>
            public static void GetIntegeri_vEXT(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glGetMemoryObjectParameterivEXT</c>]</b><br/>  </summary>
            public static void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glGetMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b> <b>[entry point: <c>glGetnUniformfvEXT</c>]</b><br/>  </summary>
            public static void GetnUniformfvEXT(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b> <b>[entry point: <c>glGetnUniformivEXT</c>]</b><br/>  </summary>
            public static void GetnUniformivEXT(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_EXT_debug_label]</b> <b>[entry point: <c>glGetObjectLabelEXT</c>]</b><br/>  </summary>
            public static void GetObjectLabelEXT(All type, uint obj, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelEXT_fnptr((uint)type, obj, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glGetProgramPipelineInfoLogEXT</c>]</b><br/>  </summary>
            public static void GetProgramPipelineInfoLogEXT(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glGetProgramPipelineivEXT</c>]</b><br/>  </summary>
            public static void GetProgramPipelineivEXT(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineivEXT_fnptr(pipeline, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_blend_func_extended]</b> <b>[entry point: <c>glGetProgramResourceLocationIndexEXT</c>]</b><br/>  </summary>
            public static int GetProgramResourceLocationIndexEXT(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocationIndexEXT_fnptr(program, (uint)programInterface, name);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glGetQueryivEXT</c>]</b><br/>  </summary>
            public static void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b> <b>[entry point: <c>glGetQueryObjecti64vEXT</c>]</b><br/>  </summary>
            public static void GetQueryObjecti64vEXT(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64vEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b> <b>[entry point: <c>glGetQueryObjectivEXT</c>]</b><br/>  </summary>
            public static void GetQueryObjectivEXT(int id, QueryObjectParameterName pname, int* parameters) => GLPointers._glGetQueryObjectivEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b> <b>[entry point: <c>glGetQueryObjectui64vEXT</c>]</b><br/>  </summary>
            public static void GetQueryObjectui64vEXT(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64vEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glGetQueryObjectuivEXT</c>]</b><br/>  </summary>
            public static void GetQueryObjectuivEXT(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuivEXT_fnptr(id, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glGetSamplerParameterIivEXT</c>]</b><br/>  </summary>
            public static void GetSamplerParameterIivEXT(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivEXT_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glGetSamplerParameterIuivEXT</c>]</b><br/>  </summary>
            public static void GetSamplerParameterIuivEXT(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glGetSemaphoreParameterui64vEXT</c>]</b><br/>  </summary>
            public static void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glGetSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glGetTexParameterIivEXT</c>]</b><br/>  </summary>
            public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glGetTexParameterIuivEXT</c>]</b><br/>  </summary>
            public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore]</b> <b>[entry point: <c>glGetUnsignedBytei_vEXT</c>]</b><br/>  </summary>
            public static void GetUnsignedBytei_vEXT(All target, uint index, byte* data) => GLPointers._glGetUnsignedBytei_vEXT_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object | GL_EXT_semaphore]</b> <b>[entry point: <c>glGetUnsignedBytevEXT</c>]</b><br/>  </summary>
            public static void GetUnsignedBytevEXT(GetPName pname, byte* data) => GLPointers._glGetUnsignedBytevEXT_fnptr((uint)pname, data);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_fd]</b> <b>[entry point: <c>glImportMemoryFdEXT</c>]</b><br/>  </summary>
            public static void ImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => GLPointers._glImportMemoryFdEXT_fnptr(memory, size, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32]</b> <b>[entry point: <c>glImportMemoryWin32HandleEXT</c>]</b><br/>  </summary>
            public static void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void* handle) => GLPointers._glImportMemoryWin32HandleEXT_fnptr(memory, size, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_memory_object_win32]</b> <b>[entry point: <c>glImportMemoryWin32NameEXT</c>]</b><br/>  </summary>
            public static void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void* name) => GLPointers._glImportMemoryWin32NameEXT_fnptr(memory, size, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_fd]</b> <b>[entry point: <c>glImportSemaphoreFdEXT</c>]</b><br/>  </summary>
            public static void ImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => GLPointers._glImportSemaphoreFdEXT_fnptr(semaphore, (uint)handleType, fd);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32]</b> <b>[entry point: <c>glImportSemaphoreWin32HandleEXT</c>]</b><br/>  </summary>
            public static void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void* handle) => GLPointers._glImportSemaphoreWin32HandleEXT_fnptr(semaphore, (uint)handleType, handle);
            
            /// <summary> <b>[requires: GL_EXT_semaphore_win32]</b> <b>[entry point: <c>glImportSemaphoreWin32NameEXT</c>]</b><br/>  </summary>
            public static void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void* name) => GLPointers._glImportSemaphoreWin32NameEXT_fnptr(semaphore, (uint)handleType, name);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b> <b>[entry point: <c>glInsertEventMarkerEXT</c>]</b><br/>  </summary>
            public static void InsertEventMarkerEXT(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_draw_buffers_indexed]</b> <b>[entry point: <c>glIsEnablediEXT</c>]</b><br/>  </summary>
            public static bool IsEnablediEXT(EnableCap target, uint index) => GLPointers._glIsEnablediEXT_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glIsMemoryObjectEXT</c>]</b><br/>  </summary>
            public static bool IsMemoryObjectEXT(uint memoryObject) => GLPointers._glIsMemoryObjectEXT_fnptr(memoryObject) != 0;
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glIsProgramPipelineEXT</c>]</b><br/>  </summary>
            public static bool IsProgramPipelineEXT(int pipeline) => GLPointers._glIsProgramPipelineEXT_fnptr(pipeline) != 0;
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query | GL_EXT_occlusion_query_boolean]</b> <b>[entry point: <c>glIsQueryEXT</c>]</b><br/>  </summary>
            public static bool IsQueryEXT(int id) => GLPointers._glIsQueryEXT_fnptr(id) != 0;
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glIsSemaphoreEXT</c>]</b><br/>  </summary>
            public static bool IsSemaphoreEXT(uint semaphore) => GLPointers._glIsSemaphoreEXT_fnptr(semaphore) != 0;
            
            /// <summary> <b>[requires: GL_EXT_debug_label]</b> <b>[entry point: <c>glLabelObjectEXT</c>]</b><br/>  </summary>
            public static void LabelObjectEXT(All type, uint obj, int length, byte* label) => GLPointers._glLabelObjectEXT_fnptr((uint)type, obj, length, label);
            
            /// <summary> <b>[requires: GL_EXT_map_buffer_range]</b> <b>[entry point: <c>glMapBufferRangeEXT</c>]</b><br/>  </summary>
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glMemoryObjectParameterivEXT</c>]</b><br/>  </summary>
            public static void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b> <b>[entry point: <c>glMultiDrawArraysEXT</c>]</b><br/>  </summary>
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect]</b> <b>[entry point: <c>glMultiDrawArraysIndirectEXT</c>]</b><br/>  </summary>
            public static void MultiDrawArraysIndirectEXT(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawArraysIndirectEXT_fnptr((uint)mode, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex]</b> <b>[entry point: <c>glMultiDrawElementsBaseVertexEXT</c>]</b><br/>  </summary>
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_arrays]</b> <b>[entry point: <c>glMultiDrawElementsEXT</c>]</b><br/>  </summary>
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_EXT_multi_draw_indirect]</b> <b>[entry point: <c>glMultiDrawElementsIndirectEXT</c>]</b><br/>  </summary>
            public static void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawElementsIndirectEXT_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_EXT_external_buffer]</b> <b>[entry point: <c>glNamedBufferStorageExternalEXT</c>]</b><br/>  </summary>
            public static void NamedBufferStorageExternalEXT(int buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glNamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, (uint)flags);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glNamedBufferStorageMemEXT</c>]</b><br/>  </summary>
            public static void NamedBufferStorageMemEXT(int buffer, nint size, uint memory, ulong offset) => GLPointers._glNamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_tessellation_shader]</b> <b>[entry point: <c>glPatchParameteriEXT</c>]</b><br/>  </summary>
            public static void PatchParameteriEXT(PatchParameterName pname, int value) => GLPointers._glPatchParameteriEXT_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_polygon_offset_clamp]</b> <b>[entry point: <c>glPolygonOffsetClampEXT</c>]</b><br/>  </summary>
            public static void PolygonOffsetClampEXT(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClampEXT_fnptr(factor, units, clamp);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b> <b>[entry point: <c>glPopGroupMarkerEXT</c>]</b><br/>  </summary>
            public static void PopGroupMarkerEXT() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            /// <summary> <b>[requires: GL_EXT_primitive_bounding_box]</b> <b>[entry point: <c>glPrimitiveBoundingBoxEXT</c>]</b><br/>  </summary>
            public static void PrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramParameteriEXT</c>]</b><br/>  </summary>
            public static void ProgramParameteriEXT(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteriEXT_fnptr(program, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1fEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1fEXT(int program, int location, float v0) => GLPointers._glProgramUniform1fEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1iEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1iEXT(int program, int location, int v0) => GLPointers._glProgramUniform1iEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1ivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform1ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1uiEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1uiEXT(int program, int location, uint v0) => GLPointers._glProgramUniform1uiEXT_fnptr(program, location, v0);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform1uivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform1uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2fEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2fEXT(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2fEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2iEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2iEXT(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2iEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2ivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform2ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2uiEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2uiEXT(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform2uivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform2uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3fEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3fEXT(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3iEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3iEXT(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3ivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform3ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3uiEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3uiEXT(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform3uivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform3uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4fEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4fEXT(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fvEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4iEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4iEXT(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4ivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform4ivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4uiEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4uiEXT(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniform4uivEXT</c>]</b><br/>  </summary>
            public static void ProgramUniform4uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uivEXT_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix2fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix2x3fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix2x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix2x4fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix2x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix3fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix3x2fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix3x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix3x4fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix3x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix4fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix4x2fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix4x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glProgramUniformMatrix4x3fvEXT</c>]</b><br/>  </summary>
            public static void ProgramUniformMatrix4x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_EXT_debug_marker]</b> <b>[entry point: <c>glPushGroupMarkerEXT</c>]</b><br/>  </summary>
            public static void PushGroupMarkerEXT(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            /// <summary> <b>[requires: GL_EXT_disjoint_timer_query]</b> <b>[entry point: <c>glQueryCounterEXT</c>]</b><br/>  </summary>
            public static void QueryCounterEXT(int id, QueryCounterTarget target) => GLPointers._glQueryCounterEXT_fnptr(id, (uint)target);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples]</b> <b>[entry point: <c>glRasterSamplesEXT</c>]</b><br/>  </summary>
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_multiview_draw_buffers]</b> <b>[entry point: <c>glReadBufferIndexedEXT</c>]</b><br/>  </summary>
            public static void ReadBufferIndexedEXT(ReadBufferMode src, int index) => GLPointers._glReadBufferIndexedEXT_fnptr((uint)src, index);
            
            /// <summary> <b>[requires: GL_EXT_robustness]</b> <b>[entry point: <c>glReadnPixelsEXT</c>]</b><br/>  </summary>
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            /// <summary> <b>[requires: GL_EXT_win32_keyed_mutex]</b> <b>[entry point: <c>glReleaseKeyedMutexWin32EXT</c>]</b><br/>  </summary>
            public static bool ReleaseKeyedMutexWin32EXT(uint memory, ulong key) => GLPointers._glReleaseKeyedMutexWin32EXT_fnptr(memory, key) != 0;
            
            /// <summary> <b>[requires: GL_EXT_multisampled_render_to_texture]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleEXT</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glSamplerParameterIivEXT</c>]</b><br/>  </summary>
            public static void SamplerParameterIivEXT(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivEXT_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glSamplerParameterIuivEXT</c>]</b><br/>  </summary>
            public static void SamplerParameterIuivEXT(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glSemaphoreParameterui64vEXT</c>]</b><br/>  </summary>
            public static void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate]</b> <b>[entry point: <c>glShadingRateCombinerOpsEXT</c>]</b><br/>  </summary>
            public static void ShadingRateCombinerOpsEXT(ShadingRateCombinerOp combinerOp0, ShadingRateCombinerOp combinerOp1) => GLPointers._glShadingRateCombinerOpsEXT_fnptr((uint)combinerOp0, (uint)combinerOp1);
            
            /// <summary> <b>[requires: GL_EXT_fragment_shading_rate]</b> <b>[entry point: <c>glShadingRateEXT</c>]</b><br/>  </summary>
            public static void ShadingRateEXT(ShadingRate rate) => GLPointers._glShadingRateEXT_fnptr((uint)rate);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glSignalSemaphoreEXT</c>]</b><br/>  </summary>
            public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* dstLayouts) => GLPointers._glSignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)dstLayouts);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer]</b> <b>[entry point: <c>glTexBufferEXT</c>]</b><br/>  </summary>
            public static void TexBufferEXT(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferEXT_fnptr((uint)target, (uint)internalformat, buffer);
            
            /// <summary> <b>[requires: GL_EXT_texture_buffer]</b> <b>[entry point: <c>glTexBufferRangeEXT</c>]</b><br/>  </summary>
            public static void TexBufferRangeEXT(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeEXT_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            /// <summary> <b>[requires: GL_EXT_sparse_texture]</b> <b>[entry point: <c>glTexPageCommitmentEXT</c>]</b><br/>  </summary>
            public static void TexPageCommitmentEXT(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => GLPointers._glTexPageCommitmentEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glTexParameterIivEXT</c>]</b><br/>  </summary>
            public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_border_clamp]</b> <b>[entry point: <c>glTexParameterIuivEXT</c>]</b><br/>  </summary>
            public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTexStorage1DEXT</c>]</b><br/>  </summary>
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTexStorage2DEXT</c>]</b><br/>  </summary>
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTexStorage3DEXT</c>]</b><br/>  </summary>
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression]</b> <b>[entry point: <c>glTexStorageAttribs2DEXT</c>]</b><br/>  </summary>
            public static void TexStorageAttribs2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, (int*)attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage_compression]</b> <b>[entry point: <c>glTexStorageAttribs3DEXT</c>]</b><br/>  </summary>
            public static void TexStorageAttribs3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth, (int*)attrib_list);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTexStorageMem1DEXT</c>]</b><br/>  </summary>
            public static void TexStorageMem1DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTexStorageMem1DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTexStorageMem2DEXT</c>]</b><br/>  </summary>
            public static void TexStorageMem2DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTexStorageMem2DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTexStorageMem2DMultisampleEXT</c>]</b><br/>  </summary>
            public static void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem2DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTexStorageMem3DEXT</c>]</b><br/>  </summary>
            public static void TexStorageMem3DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTexStorageMem3DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTexStorageMem3DMultisampleEXT</c>]</b><br/>  </summary>
            public static void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem3DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTextureStorage1DEXT</c>]</b><br/>  </summary>
            public static void TextureStorage1DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTextureStorage2DEXT</c>]</b><br/>  </summary>
            public static void TextureStorage2DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_EXT_texture_storage]</b> <b>[entry point: <c>glTextureStorage3DEXT</c>]</b><br/>  </summary>
            public static void TextureStorage3DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTextureStorageMem1DEXT</c>]</b><br/>  </summary>
            public static void TextureStorageMem1DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTextureStorageMem1DEXT_fnptr(texture, levels, (uint)internalFormat, width, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTextureStorageMem2DEXT</c>]</b><br/>  </summary>
            public static void TextureStorageMem2DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTextureStorageMem2DMultisampleEXT</c>]</b><br/>  </summary>
            public static void TextureStorageMem2DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTextureStorageMem3DEXT</c>]</b><br/>  </summary>
            public static void TextureStorageMem3DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_memory_object]</b> <b>[entry point: <c>glTextureStorageMem3DMultisampleEXT</c>]</b><br/>  </summary>
            public static void TextureStorageMem3DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            /// <summary> <b>[requires: GL_EXT_texture_view]</b> <b>[entry point: <c>glTextureViewEXT</c>]</b><br/>  </summary>
            public static void TextureViewEXT(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewEXT_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glUseProgramStagesEXT</c>]</b><br/>  </summary>
            public static void UseProgramStagesEXT(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStagesEXT_fnptr(pipeline, (uint)stages, program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glUseShaderProgramEXT</c>]</b><br/>  </summary>
            public static void UseShaderProgramEXT(All type, int program) => GLPointers._glUseShaderProgramEXT_fnptr((uint)type, program);
            
            /// <summary> <b>[requires: GL_EXT_separate_shader_objects]</b> <b>[entry point: <c>glValidateProgramPipelineEXT</c>]</b><br/>  </summary>
            public static void ValidateProgramPipelineEXT(int pipeline) => GLPointers._glValidateProgramPipelineEXT_fnptr(pipeline);
            
            /// <summary> <b>[requires: GL_EXT_instanced_arrays]</b> <b>[entry point: <c>glVertexAttribDivisorEXT</c>]</b><br/>  </summary>
            public static void VertexAttribDivisorEXT(uint index, uint divisor) => GLPointers._glVertexAttribDivisorEXT_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_EXT_semaphore]</b> <b>[entry point: <c>glWaitSemaphoreEXT</c>]</b><br/>  </summary>
            public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* srcLayouts) => GLPointers._glWaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)srcLayouts);
            
            /// <summary> <b>[requires: GL_EXT_window_rectangles]</b> <b>[entry point: <c>glWindowRectanglesEXT</c>]</b><br/>  </summary>
            public static void WindowRectanglesEXT(All mode, int count, int* box) => GLPointers._glWindowRectanglesEXT_fnptr((uint)mode, count, box);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample]</b> <b>[entry point: <c>glFramebufferTexture2DDownsampleIMG</c>]</b><br/>  </summary>
            public static void FramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int xscale, int yscale) => GLPointers._glFramebufferTexture2DDownsampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b> <b>[entry point: <c>glFramebufferTexture2DMultisampleIMG</c>]</b><br/>  </summary>
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            /// <summary> <b>[requires: GL_IMG_framebuffer_downsample]</b> <b>[entry point: <c>glFramebufferTextureLayerDownsampleIMG</c>]</b><br/>  </summary>
            public static void FramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer, int xscale, int yscale) => GLPointers._glFramebufferTextureLayerDownsampleIMG_fnptr((uint)target, (uint)attachment, texture, level, layer, xscale, yscale);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glGetTextureHandleIMG</c>]</b><br/>  </summary>
            public static ulong GetTextureHandleIMG(int texture) => GLPointers._glGetTextureHandleIMG_fnptr(texture);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glGetTextureSamplerHandleIMG</c>]</b><br/>  </summary>
            public static ulong GetTextureSamplerHandleIMG(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleIMG_fnptr(texture, sampler);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glProgramUniformHandleui64IMG</c>]</b><br/>  </summary>
            public static void ProgramUniformHandleui64IMG(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64IMG_fnptr(program, location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glProgramUniformHandleui64vIMG</c>]</b><br/>  </summary>
            public static void ProgramUniformHandleui64vIMG(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vIMG_fnptr(program, location, count, values);
            
            /// <summary> <b>[requires: GL_IMG_multisampled_render_to_texture]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleIMG</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glUniformHandleui64IMG</c>]</b><br/>  </summary>
            public static void UniformHandleui64IMG(int location, ulong value) => GLPointers._glUniformHandleui64IMG_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_IMG_bindless_texture]</b> <b>[entry point: <c>glUniformHandleui64vIMG</c>]</b><br/>  </summary>
            public static void UniformHandleui64vIMG(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vIMG_fnptr(location, count, value);
            
        }
        /// <summary>INTEL extensions.</summary>
        public static unsafe partial class INTEL
        {
            /// <summary> <b>[requires: GL_INTEL_framebuffer_CMAA]</b> <b>[entry point: <c>glApplyFramebufferAttachmentCMAAINTEL</c>]</b><br/>  </summary>
            public static void ApplyFramebufferAttachmentCMAAINTEL() => GLPointers._glApplyFramebufferAttachmentCMAAINTEL_fnptr();
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glBeginPerfQueryINTEL</c>]</b><br/>  </summary>
            public static void BeginPerfQueryINTEL(int queryHandle) => GLPointers._glBeginPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glCreatePerfQueryINTEL</c>]</b><br/>  </summary>
            public static void CreatePerfQueryINTEL(uint queryId, int* queryHandle) => GLPointers._glCreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glDeletePerfQueryINTEL</c>]</b><br/>  </summary>
            public static void DeletePerfQueryINTEL(int queryHandle) => GLPointers._glDeletePerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glEndPerfQueryINTEL</c>]</b><br/>  </summary>
            public static void EndPerfQueryINTEL(int queryHandle) => GLPointers._glEndPerfQueryINTEL_fnptr(queryHandle);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetFirstPerfQueryIdINTEL</c>]</b><br/>  </summary>
            public static void GetFirstPerfQueryIdINTEL(uint* queryId) => GLPointers._glGetFirstPerfQueryIdINTEL_fnptr(queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetNextPerfQueryIdINTEL</c>]</b><br/>  </summary>
            public static void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => GLPointers._glGetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetPerfCounterInfoINTEL</c>]</b><br/>  </summary>
            public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => GLPointers._glGetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetPerfQueryDataINTEL</c>]</b><br/>  </summary>
            public static void GetPerfQueryDataINTEL(int queryHandle, PerfQueryDataFlags flags, int dataSize, void* data, uint* bytesWritten) => GLPointers._glGetPerfQueryDataINTEL_fnptr(queryHandle, (uint)flags, dataSize, data, bytesWritten);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetPerfQueryIdByNameINTEL</c>]</b><br/>  </summary>
            public static void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => GLPointers._glGetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            
            /// <summary> <b>[requires: GL_INTEL_performance_query]</b> <b>[entry point: <c>glGetPerfQueryInfoINTEL</c>]</b><br/>  </summary>
            public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, PerformanceQueryCapsMaskINTEL* capsMask) => GLPointers._glGetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, (uint*)capsMask);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: GL_KHR_blend_equation_advanced]</b> <b>[entry point: <c>glBlendBarrierKHR</c>]</b><br/>  </summary>
            public static void BlendBarrierKHR() => GLPointers._glBlendBarrierKHR_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageCallback</c>]</b><br/> Specify a callback to receive debugging messages from the GL. </summary>
            /// <param name="callback"> The address of a callback function that will be called when a debug message is generated. </param>
            /// <param name="userParam"> A user supplied pointer that will be passed on each invocation of callback. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageCallback.xhtml" /></remarks>
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageCallbackKHR</c>]</b><br/>  </summary>
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackKHR_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageControl</c>]</b><br/> Control the reporting of debug messages in a debug context. </summary>
            /// <param name="source"> The source of debug messages to enable or disable. </param>
            /// <param name="type"> The type of debug messages to enable or disable. </param>
            /// <param name="severity"> The severity of debug messages to enable or disable. </param>
            /// <param name="count"> The length of the array ids. </param>
            /// <param name="ids"> The address of an array of unsigned integers contianing the ids of the messages to enable or disable. </param>
            /// <param name="enabled"> A Boolean flag determining whether the selected messages should be enabled or disabled. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageControl.xhtml" /></remarks>
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageControlKHR</c>]</b><br/>  </summary>
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageInsert</c>]</b><br/> Inject an application-supplied message into the debug message queue. </summary>
            /// <param name="source"> The source of the debug message to insert. </param>
            /// <param name="type"> The type of the debug message insert. </param>
            /// <param name="id"> The user-supplied identifier of the message to insert. </param>
            /// <param name="severity"> The severity of the debug messages to insert. </param>
            /// <param name="length"> The length string contained in the character array whose address is given by message. </param>
            /// <param name="message"> The address of a character array containing the message to insert. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglDebugMessageInsert.xhtml" /></remarks>
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glDebugMessageInsertKHR</c>]</b><br/>  </summary>
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetDebugMessageLog</c>]</b><br/> Retrieve messages from the debug message log. </summary>
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
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glGetDebugMessageLogKHR</c>]</b><br/>  </summary>
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetGraphicsResetStatus</c>]</b><br/> Check if the rendering context has not been lost due to software or hardware issues. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetGraphicsResetStatus.xhtml" /></remarks>
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b> <b>[entry point: <c>glGetGraphicsResetStatusKHR</c>]</b><br/>  </summary>
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusKHR_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformfv</c>]</b><br/> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformfvKHR</c>]</b><br/>  </summary>
            public static void GetnUniformfvKHR(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformivKHR</c>]</b><br/>  </summary>
            public static void GetnUniformivKHR(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformuiv</c>]</b><br/> Returns the value of a uniform variable. </summary>
            /// <param name="program">Specifies the program object to be queried.</param>
            /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
            /// <param name="bufSize">Specifies the size of the buffer params. </param>
            /// <param name="parameters">Returns the value of the specified uniform variable.</param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetUniform.xhtml" /></remarks>
            public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b> <b>[entry point: <c>glGetnUniformuivKHR</c>]</b><br/>  </summary>
            public static void GetnUniformuivKHR(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectLabel</c>]</b><br/> Retrieve the label of a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectLabel.xhtml" /></remarks>
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectLabelKHR</c>]</b><br/>  </summary>
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectPtrLabel</c>]</b><br/> Retrieve the label of a sync object identified by a pointer. </summary>
            /// <param name="ptr"> The name of the sync object whose label to retrieve. </param>
            /// <param name="bifSize">!!missing documentation!!</param>
            /// <param name="length"> The address of a variable to receive the length of the object label. </param>
            /// <param name="label"> The address of a string that will receive the object label. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetObjectPtrLabel.xhtml" /></remarks>
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glGetObjectPtrLabelKHR</c>]</b><br/>  </summary>
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glGetPointerv</c>]</b><br/> Return the address of the specified pointer. </summary>
            /// <param name="pname"> Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. </param>
            /// <param name="parameters"> Returns the pointer value specified by pname. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglGetPointerv.xhtml" /></remarks>
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glGetPointervKHR</c>]</b><br/>  </summary>
            public static void GetPointervKHR_(All pname, void** parameters) => GLPointers._glGetPointervKHR_fnptr((uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_KHR_parallel_shader_compile]</b> <b>[entry point: <c>glMaxShaderCompilerThreadsKHR</c>]</b><br/>  </summary>
            public static void MaxShaderCompilerThreadsKHR(uint count) => GLPointers._glMaxShaderCompilerThreadsKHR_fnptr(count);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glObjectLabel</c>]</b><br/> Label a named object identified within a namespace. </summary>
            /// <param name="identifier"> The namespace from which the name of the object is allocated. </param>
            /// <param name="name"> The name of the object to label. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectLabel.xhtml" /></remarks>
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glObjectLabelKHR</c>]</b><br/>  </summary>
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glObjectPtrLabel</c>]</b><br/> Label a sync object identified by a pointer. </summary>
            /// <param name="ptr"> A pointer identifying a sync object. </param>
            /// <param name="length"> The length of the label to be used for the object. </param>
            /// <param name="label"> The address of a string containing the label to assign to the object. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglObjectPtrLabel.xhtml" /></remarks>
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glObjectPtrLabelKHR</c>]</b><br/>  </summary>
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glPopDebugGroup</c>]</b><br/> Pop the active debug group. </summary>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPopDebugGroup.xhtml" /></remarks>
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glPopDebugGroupKHR</c>]</b><br/>  </summary>
            public static void PopDebugGroupKHR() => GLPointers._glPopDebugGroupKHR_fnptr();
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_debug]</b> <b>[entry point: <c>glPushDebugGroup</c>]</b><br/> Push a named debug group into the command stream. </summary>
            /// <param name="source"> The source of the debug message. </param>
            /// <param name="id"> The identifier of the message. </param>
            /// <param name="length"> The length of the message to be sent to the debug output stream. </param>
            /// <param name="message"> The a string containing the message to be sent to the debug output stream. </param>
            /// <remarks><see href="https://www.khronos.org/registry/OpenGL-Refpages/es3.0/htmlglPushDebugGroup.xhtml" /></remarks>
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: GL_KHR_debug]</b> <b>[entry point: <c>glPushDebugGroupKHR</c>]</b><br/>  </summary>
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
            /// <summary> <b>[requires: v3.2 | GL_KHR_robustness]</b> <b>[entry point: <c>glReadnPixels</c>]</b><br/> Read a block of pixels from the frame buffer. </summary>
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
            
            /// <summary> <b>[requires: GL_KHR_robustness]</b> <b>[entry point: <c>glReadnPixelsKHR</c>]</b><br/>  </summary>
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsKHR_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y]</b> <b>[entry point: <c>glFramebufferParameteriMESA</c>]</b><br/>  </summary>
            public static void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteriMESA_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_MESA_framebuffer_flip_y]</b> <b>[entry point: <c>glGetFramebufferParameterivMESA</c>]</b><br/>  </summary>
            public static void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameterivMESA_fnptr((uint)target, (uint)pname, parameters);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GL_NV_conditional_render]</b> <b>[entry point: <c>glBeginConditionalRenderNV</c>]</b><br/>  </summary>
            public static void BeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => GLPointers._glBeginConditionalRenderNV_fnptr(id, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glBindShadingRateImageNV</c>]</b><br/>  </summary>
            public static void BindShadingRateImageNV(int texture) => GLPointers._glBindShadingRateImageNV_fnptr(texture);
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced]</b> <b>[entry point: <c>glBlendBarrierNV</c>]</b><br/>  </summary>
            public static void BlendBarrierNV() => GLPointers._glBlendBarrierNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_blend_equation_advanced]</b> <b>[entry point: <c>glBlendParameteriNV</c>]</b><br/>  </summary>
            public static void BlendParameteriNV(All pname, int value) => GLPointers._glBlendParameteriNV_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_blit]</b> <b>[entry point: <c>glBlitFramebufferNV</c>]</b><br/>  </summary>
            public static void BlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glBufferAttachMemoryNV</c>]</b><br/>  </summary>
            public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => GLPointers._glBufferAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b> <b>[entry point: <c>glBufferPageCommitmentMemNV</c>]</b><br/>  </summary>
            public static void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glBufferPageCommitmentMemNV_fnptr((uint)target, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_conservative_raster_pre_snap_triangles]</b> <b>[entry point: <c>glConservativeRasterParameteriNV</c>]</b><br/>  </summary>
            public static void ConservativeRasterParameteriNV(All pname, int param) => GLPointers._glConservativeRasterParameteriNV_fnptr((uint)pname, param);
            
            /// <summary> <b>[requires: GL_NV_copy_buffer]</b> <b>[entry point: <c>glCopyBufferSubDataNV</c>]</b><br/>  </summary>
            public static void CopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubDataNV_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glCopyPathNV</c>]</b><br/>  </summary>
            public static void CopyPathNV(uint resultPath, uint srcPath) => GLPointers._glCopyPathNV_fnptr(resultPath, srcPath);
            
            /// <summary> <b>[requires: GL_NV_coverage_sample]</b> <b>[entry point: <c>glCoverageMaskNV</c>]</b><br/>  </summary>
            public static void CoverageMaskNV(bool mask) => GLPointers._glCoverageMaskNV_fnptr((byte)(mask ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b> <b>[entry point: <c>glCoverageModulationNV</c>]</b><br/>  </summary>
            public static void CoverageModulationNV(All components) => GLPointers._glCoverageModulationNV_fnptr((uint)components);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b> <b>[entry point: <c>glCoverageModulationTableNV</c>]</b><br/>  </summary>
            public static void CoverageModulationTableNV(int n, float* v) => GLPointers._glCoverageModulationTableNV_fnptr(n, v);
            
            /// <summary> <b>[requires: GL_NV_coverage_sample]</b> <b>[entry point: <c>glCoverageOperationNV</c>]</b><br/>  </summary>
            public static void CoverageOperationNV(All operation) => GLPointers._glCoverageOperationNV_fnptr((uint)operation);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glCoverFillPathInstancedNV</c>]</b><br/>  </summary>
            public static void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glCoverFillPathNV</c>]</b><br/>  </summary>
            public static void CoverFillPathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverFillPathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glCoverStrokePathInstancedNV</c>]</b><br/>  </summary>
            public static void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glCoverStrokePathNV</c>]</b><br/>  </summary>
            public static void CoverStrokePathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverStrokePathNV_fnptr(path, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b> <b>[entry point: <c>glCreateSemaphoresNV</c>]</b><br/>  </summary>
            public static void CreateSemaphoresNV(int n, uint* semaphores) => GLPointers._glCreateSemaphoresNV_fnptr(n, semaphores);
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glDeleteFencesNV</c>]</b><br/>  </summary>
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._glDeleteFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glDeletePathsNV</c>]</b><br/>  </summary>
            public static void DeletePathsNV(uint path, int range) => GLPointers._glDeletePathsNV_fnptr(path, range);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glDepthRangeArrayfvNV</c>]</b><br/>  </summary>
            public static void DepthRangeArrayfvNV(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glDepthRangeIndexedfNV</c>]</b><br/>  </summary>
            public static void DepthRangeIndexedfNV(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfNV_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glDisableiNV</c>]</b><br/>  </summary>
            public static void DisableiNV(EnableCap target, uint index) => GLPointers._glDisableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced]</b> <b>[entry point: <c>glDrawArraysInstancedNV</c>]</b><br/>  </summary>
            public static void DrawArraysInstancedNV(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedNV_fnptr((uint)mode, first, count, primcount);
            
            /// <summary> <b>[requires: GL_NV_draw_buffers]</b> <b>[entry point: <c>glDrawBuffersNV</c>]</b><br/>  </summary>
            public static void DrawBuffersNV(int n, All* bufs) => GLPointers._glDrawBuffersNV_fnptr(n, (uint*)bufs);
            
            /// <summary> <b>[requires: GL_NV_draw_instanced]</b> <b>[entry point: <c>glDrawElementsInstancedNV</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedNV(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedNV_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b> <b>[entry point: <c>glDrawMeshTasksIndirectNV</c>]</b><br/>  </summary>
            public static void DrawMeshTasksIndirectNV(IntPtr indirect) => GLPointers._glDrawMeshTasksIndirectNV_fnptr(indirect);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b> <b>[entry point: <c>glDrawMeshTasksNV</c>]</b><br/>  </summary>
            public static void DrawMeshTasksNV(uint first, uint count) => GLPointers._glDrawMeshTasksNV_fnptr(first, count);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b> <b>[entry point: <c>glDrawVkImageNV</c>]</b><br/>  </summary>
            public static void DrawVkImageNV(ulong vkImage, int sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._glDrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glEnableiNV</c>]</b><br/>  </summary>
            public static void EnableiNV(EnableCap target, uint index) => GLPointers._glEnableiNV_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_NV_conditional_render]</b> <b>[entry point: <c>glEndConditionalRenderNV</c>]</b><br/>  </summary>
            public static void EndConditionalRenderNV() => GLPointers._glEndConditionalRenderNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glFinishFenceNV</c>]</b><br/>  </summary>
            public static void FinishFenceNV(uint fence) => GLPointers._glFinishFenceNV_fnptr(fence);
            
            /// <summary> <b>[requires: GL_NV_fragment_coverage_to_color]</b> <b>[entry point: <c>glFragmentCoverageColorNV</c>]</b><br/>  </summary>
            public static void FragmentCoverageColorNV(uint color) => GLPointers._glFragmentCoverageColorNV_fnptr(color);
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b> <b>[entry point: <c>glFramebufferSampleLocationsfvNV</c>]</b><br/>  </summary>
            public static void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, float* v) => GLPointers._glFramebufferSampleLocationsfvNV_fnptr((uint)target, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glGenFencesNV</c>]</b><br/>  </summary>
            public static void GenFencesNV(int n, uint* fences) => GLPointers._glGenFencesNV_fnptr(n, fences);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGenPathsNV</c>]</b><br/>  </summary>
            public static uint GenPathsNV(int range) => GLPointers._glGenPathsNV_fnptr(range);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_mixed_samples]</b> <b>[entry point: <c>glGetCoverageModulationTableNV</c>]</b><br/>  </summary>
            public static void GetCoverageModulationTableNV(int bufSize, float* v) => GLPointers._glGetCoverageModulationTableNV_fnptr(bufSize, v);
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glGetFenceivNV</c>]</b><br/>  </summary>
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._glGetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glGetFloati_vNV</c>]</b><br/>  </summary>
            public static void GetFloati_vNV(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vNV_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glGetImageHandleNV</c>]</b><br/>  </summary>
            public static ulong GetImageHandleNV(int texture, int level, bool layered, int layer, PixelFormat format) => GLPointers._glGetImageHandleNV_fnptr(texture, level, (byte)(layered ? 1 : 0), layer, (uint)format);
            
            /// <summary> <b>[requires: GL_NV_internalformat_sample_query]</b> <b>[entry point: <c>glGetInternalformatSampleivNV</c>]</b><br/>  </summary>
            public static void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformatSampleivNV_fnptr((uint)target, (uint)internalformat, samples, (uint)pname, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glGetMemoryObjectDetachedResourcesuivNV</c>]</b><br/>  </summary>
            public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, uint* parameters) => GLPointers._glGetMemoryObjectDetachedResourcesuivNV_fnptr(memory, (uint)pname, first, count, parameters);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathColorGenfvNV</c>]</b><br/>  </summary>
            public static void GetPathColorGenfvNV(PathColor color, PathGenMode pname, float* value) => GLPointers._glGetPathColorGenfvNV_fnptr((uint)color, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathColorGenivNV</c>]</b><br/>  </summary>
            public static void GetPathColorGenivNV(PathColor color, PathGenMode pname, int* value) => GLPointers._glGetPathColorGenivNV_fnptr((uint)color, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathCommandsNV</c>]</b><br/>  </summary>
            public static void GetPathCommandsNV(uint path, byte* commands) => GLPointers._glGetPathCommandsNV_fnptr(path, commands);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathCoordsNV</c>]</b><br/>  </summary>
            public static void GetPathCoordsNV(uint path, float* coords) => GLPointers._glGetPathCoordsNV_fnptr(path, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathDashArrayNV</c>]</b><br/>  </summary>
            public static void GetPathDashArrayNV(uint path, float* dashArray) => GLPointers._glGetPathDashArrayNV_fnptr(path, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathLengthNV</c>]</b><br/>  </summary>
            public static float GetPathLengthNV(uint path, int startSegment, int numSegments) => GLPointers._glGetPathLengthNV_fnptr(path, startSegment, numSegments);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathMetricRangeNV</c>]</b><br/>  </summary>
            public static void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => GLPointers._glGetPathMetricRangeNV_fnptr((uint)metricQueryMask, firstPathName, numPaths, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathMetricsNV</c>]</b><br/>  </summary>
            public static void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => GLPointers._glGetPathMetricsNV_fnptr((uint)metricQueryMask, numPaths, (uint)pathNameType, paths, pathBase, stride, metrics);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathParameterfvNV</c>]</b><br/>  </summary>
            public static void GetPathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glGetPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathParameterivNV</c>]</b><br/>  </summary>
            public static void GetPathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glGetPathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathSpacingNV</c>]</b><br/>  </summary>
            public static void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => GLPointers._glGetPathSpacingNV_fnptr((uint)pathListMode, numPaths, (uint)pathNameType, paths, pathBase, advanceScale, kerningScale, (uint)transformType, returnedSpacing);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathTexGenfvNV</c>]</b><br/>  </summary>
            public static void GetPathTexGenfvNV(TextureUnit texCoordSet, PathGenMode pname, float* value) => GLPointers._glGetPathTexGenfvNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetPathTexGenivNV</c>]</b><br/>  </summary>
            public static void GetPathTexGenivNV(TextureUnit texCoordSet, PathGenMode pname, int* value) => GLPointers._glGetPathTexGenivNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glGetProgramResourcefvNV</c>]</b><br/>  </summary>
            public static void GetProgramResourcefvNV(int program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => GLPointers._glGetProgramResourcefvNV_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b> <b>[entry point: <c>glGetSemaphoreParameterivNV</c>]</b><br/>  </summary>
            public static void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glGetSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glGetShadingRateImagePaletteNV</c>]</b><br/>  </summary>
            public static void GetShadingRateImagePaletteNV(uint viewport, uint entry, All* rate) => GLPointers._glGetShadingRateImagePaletteNV_fnptr(viewport, entry, (uint*)rate);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glGetShadingRateSampleLocationivNV</c>]</b><br/>  </summary>
            public static void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int* location) => GLPointers._glGetShadingRateSampleLocationivNV_fnptr((uint)rate, samples, index, location);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glGetTextureHandleNV</c>]</b><br/>  </summary>
            public static ulong GetTextureHandleNV(int texture) => GLPointers._glGetTextureHandleNV_fnptr(texture);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glGetTextureSamplerHandleNV</c>]</b><br/>  </summary>
            public static ulong GetTextureSamplerHandleNV(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleNV_fnptr(texture, sampler);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glGetUniformi64vNV</c>]</b><br/>  </summary>
            public static void GetUniformi64vNV(int program, int location, long* parameters) => GLPointers._glGetUniformi64vNV_fnptr(program, location, parameters);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b> <b>[entry point: <c>glGetVkProcAddrNV</c>]</b><br/>  </summary>
            public static IntPtr GetVkProcAddrNV(byte* name) => GLPointers._glGetVkProcAddrNV_fnptr(name);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glInterpolatePathsNV</c>]</b><br/>  </summary>
            public static void InterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => GLPointers._glInterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glIsEnablediNV</c>]</b><br/>  </summary>
            public static bool IsEnablediNV(EnableCap target, uint index) => GLPointers._glIsEnablediNV_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glIsFenceNV</c>]</b><br/>  </summary>
            public static bool IsFenceNV(uint fence) => GLPointers._glIsFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glIsImageHandleResidentNV</c>]</b><br/>  </summary>
            public static bool IsImageHandleResidentNV(ulong handle) => GLPointers._glIsImageHandleResidentNV_fnptr(handle) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glIsPathNV</c>]</b><br/>  </summary>
            public static bool IsPathNV(uint path) => GLPointers._glIsPathNV_fnptr(path) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glIsPointInFillPathNV</c>]</b><br/>  </summary>
            public static bool IsPointInFillPathNV(uint path, uint mask, float x, float y) => GLPointers._glIsPointInFillPathNV_fnptr(path, mask, x, y) != 0;
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glIsPointInStrokePathNV</c>]</b><br/>  </summary>
            public static bool IsPointInStrokePathNV(uint path, float x, float y) => GLPointers._glIsPointInStrokePathNV_fnptr(path, x, y) != 0;
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glIsTextureHandleResidentNV</c>]</b><br/>  </summary>
            public static bool IsTextureHandleResidentNV(ulong handle) => GLPointers._glIsTextureHandleResidentNV_fnptr(handle) != 0;
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glMakeImageHandleNonResidentNV</c>]</b><br/>  </summary>
            public static void MakeImageHandleNonResidentNV(ulong handle) => GLPointers._glMakeImageHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glMakeImageHandleResidentNV</c>]</b><br/>  </summary>
            public static void MakeImageHandleResidentNV(ulong handle, All access) => GLPointers._glMakeImageHandleResidentNV_fnptr(handle, (uint)access);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glMakeTextureHandleNonResidentNV</c>]</b><br/>  </summary>
            public static void MakeTextureHandleNonResidentNV(ulong handle) => GLPointers._glMakeTextureHandleNonResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glMakeTextureHandleResidentNV</c>]</b><br/>  </summary>
            public static void MakeTextureHandleResidentNV(ulong handle) => GLPointers._glMakeTextureHandleResidentNV_fnptr(handle);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixFrustumEXT</c>]</b><br/>  </summary>
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoad3x2fNV</c>]</b><br/>  </summary>
            public static void MatrixLoad3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoad3x3fNV</c>]</b><br/>  </summary>
            public static void MatrixLoad3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoaddEXT</c>]</b><br/>  </summary>
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoaddEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoadfEXT</c>]</b><br/>  </summary>
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoadIdentityEXT</c>]</b><br/>  </summary>
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._glMatrixLoadIdentityEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoadTranspose3x3fNV</c>]</b><br/>  </summary>
            public static void MatrixLoadTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoadTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoadTransposedEXT</c>]</b><br/>  </summary>
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixLoadTransposefEXT</c>]</b><br/>  </summary>
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMult3x2fNV</c>]</b><br/>  </summary>
            public static void MatrixMult3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x2fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMult3x3fNV</c>]</b><br/>  </summary>
            public static void MatrixMult3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMultdEXT</c>]</b><br/>  </summary>
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultdEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMultfEXT</c>]</b><br/>  </summary>
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultfEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMultTranspose3x3fNV</c>]</b><br/>  </summary>
            public static void MatrixMultTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMultTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMultTransposedEXT</c>]</b><br/>  </summary>
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixMultTransposefEXT</c>]</b><br/>  </summary>
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixOrthoEXT</c>]</b><br/>  </summary>
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixPopEXT</c>]</b><br/>  </summary>
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._glMatrixPopEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixPushEXT</c>]</b><br/>  </summary>
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._glMatrixPushEXT_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixRotatedEXT</c>]</b><br/>  </summary>
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._glMatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixRotatefEXT</c>]</b><br/>  </summary>
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._glMatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixScaledEXT</c>]</b><br/>  </summary>
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixScalefEXT</c>]</b><br/>  </summary>
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixTranslatedEXT</c>]</b><br/>  </summary>
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glMatrixTranslatefEXT</c>]</b><br/>  </summary>
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b> <b>[entry point: <c>glMultiDrawMeshTasksIndirectCountNV</c>]</b><br/>  </summary>
            public static void MultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_mesh_shader]</b> <b>[entry point: <c>glMultiDrawMeshTasksIndirectNV</c>]</b><br/>  </summary>
            public static void MultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glNamedBufferAttachMemoryNV</c>]</b><br/>  </summary>
            public static void NamedBufferAttachMemoryNV(int buffer, uint memory, ulong offset) => GLPointers._glNamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b> <b>[entry point: <c>glNamedBufferPageCommitmentMemNV</c>]</b><br/>  </summary>
            public static void NamedBufferPageCommitmentMemNV(int buffer, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glNamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b> <b>[entry point: <c>glNamedFramebufferSampleLocationsfvNV</c>]</b><br/>  </summary>
            public static void NamedFramebufferSampleLocationsfvNV(int framebuffer, uint start, int count, float* v) => GLPointers._glNamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathColorGenNV</c>]</b><br/>  </summary>
            public static void PathColorGenNV(PathColor color, PathGenMode genMode, PathColorFormat colorFormat, float* coeffs) => GLPointers._glPathColorGenNV_fnptr((uint)color, (uint)genMode, (uint)colorFormat, coeffs);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathCommandsNV</c>]</b><br/>  </summary>
            public static void PathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCommandsNV_fnptr(path, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathCoordsNV</c>]</b><br/>  </summary>
            public static void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCoordsNV_fnptr(path, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathCoverDepthFuncNV</c>]</b><br/>  </summary>
            public static void PathCoverDepthFuncNV(DepthFunction func) => GLPointers._glPathCoverDepthFuncNV_fnptr((uint)func);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathDashArrayNV</c>]</b><br/>  </summary>
            public static void PathDashArrayNV(uint path, int dashCount, float* dashArray) => GLPointers._glPathDashArrayNV_fnptr(path, dashCount, dashArray);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathFogGenNV</c>]</b><br/>  </summary>
            public static void PathFogGenNV(PathGenMode genMode) => GLPointers._glPathFogGenNV_fnptr((uint)genMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathGlyphIndexArrayNV</c>]</b><br/>  </summary>
            public static All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathGlyphIndexRangeNV</c>]</b><br/>  </summary>
            public static All PathGlyphIndexRangeNV(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => (All) GLPointers._glPathGlyphIndexRangeNV_fnptr((uint)fontTarget, fontName, (uint)fontStyle, pathParameterTemplate, emScale, baseAndCount);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathGlyphRangeNV</c>]</b><br/>  </summary>
            public static void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphRangeNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyph, numGlyphs, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathGlyphsNV</c>]</b><br/>  </summary>
            public static void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphsNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, numGlyphs, (uint)type, charcodes, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathMemoryGlyphIndexArrayNV</c>]</b><br/>  </summary>
            public static All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathMemoryGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathParameterfNV</c>]</b><br/>  </summary>
            public static void PathParameterfNV(uint path, PathParameter pname, float value) => GLPointers._glPathParameterfNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathParameterfvNV</c>]</b><br/>  </summary>
            public static void PathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathParameteriNV</c>]</b><br/>  </summary>
            public static void PathParameteriNV(uint path, PathParameter pname, int value) => GLPointers._glPathParameteriNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathParameterivNV</c>]</b><br/>  </summary>
            public static void PathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glPathParameterivNV_fnptr(path, (uint)pname, value);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathStencilDepthOffsetNV</c>]</b><br/>  </summary>
            public static void PathStencilDepthOffsetNV(float factor, float units) => GLPointers._glPathStencilDepthOffsetNV_fnptr(factor, units);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathStencilFuncNV</c>]</b><br/>  </summary>
            public static void PathStencilFuncNV(StencilFunction func, int reference, uint mask) => GLPointers._glPathStencilFuncNV_fnptr((uint)func, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathStringNV</c>]</b><br/>  </summary>
            public static void PathStringNV(uint path, PathStringFormat format, int length, void* pathString) => GLPointers._glPathStringNV_fnptr(path, (uint)format, length, pathString);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathSubCommandsNV</c>]</b><br/>  </summary>
            public static void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathSubCoordsNV</c>]</b><br/>  </summary>
            public static void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCoordsNV_fnptr(path, coordStart, numCoords, (uint)coordType, coords);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPathTexGenNV</c>]</b><br/>  </summary>
            public static void PathTexGenNV(PathColor texCoordSet, PathGenMode genMode, int components, float* coeffs) => GLPointers._glPathTexGenNV_fnptr((uint)texCoordSet, (uint)genMode, components, coeffs);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glPointAlongPathNV</c>]</b><br/>  </summary>
            public static bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => GLPointers._glPointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY) != 0;
            
            /// <summary> <b>[requires: GL_NV_polygon_mode]</b> <b>[entry point: <c>glPolygonModeNV</c>]</b><br/>  </summary>
            public static void PolygonModeNV(TriangleFace face, PolygonMode mode) => GLPointers._glPolygonModeNV_fnptr((uint)face, (uint)mode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glProgramPathFragmentInputGenNV</c>]</b><br/>  </summary>
            public static void ProgramPathFragmentInputGenNV(int program, int location, All genMode, int components, float* coeffs) => GLPointers._glProgramPathFragmentInputGenNV_fnptr(program, location, (uint)genMode, components, coeffs);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform1i64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform1i64NV(int program, int location, long x) => GLPointers._glProgramUniform1i64NV_fnptr(program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform1i64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform1i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform1ui64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform1ui64NV(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64NV_fnptr(program, location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform1ui64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform1ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform2i64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform2i64NV(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64NV_fnptr(program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform2i64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform2i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform2ui64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform2ui64NV(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64NV_fnptr(program, location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform2ui64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform2ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform3i64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform3i64NV(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64NV_fnptr(program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform3i64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform3i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform3ui64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform3ui64NV(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform3ui64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform3ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform4i64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform4i64NV(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform4i64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform4i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform4ui64NV</c>]</b><br/>  </summary>
            public static void ProgramUniform4ui64NV(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glProgramUniform4ui64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniform4ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vNV_fnptr(program, location, count, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glProgramUniformHandleui64NV</c>]</b><br/>  </summary>
            public static void ProgramUniformHandleui64NV(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64NV_fnptr(program, location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glProgramUniformHandleui64vNV</c>]</b><br/>  </summary>
            public static void ProgramUniformHandleui64vNV(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            
            /// <summary> <b>[requires: GL_EXT_raster_multisample | GL_NV_framebuffer_mixed_samples]</b> <b>[entry point: <c>glRasterSamplesEXT</c>]</b><br/>  </summary>
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_read_buffer]</b> <b>[entry point: <c>glReadBufferNV</c>]</b><br/>  </summary>
            public static void ReadBufferNV(All mode) => GLPointers._glReadBufferNV_fnptr((uint)mode);
            
            /// <summary> <b>[requires: GL_NV_framebuffer_multisample]</b> <b>[entry point: <c>glRenderbufferStorageMultisampleNV</c>]</b><br/>  </summary>
            public static void RenderbufferStorageMultisampleNV(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleNV_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glResetMemoryObjectParameterNV</c>]</b><br/>  </summary>
            public static void ResetMemoryObjectParameterNV(uint memory, All pname) => GLPointers._glResetMemoryObjectParameterNV_fnptr(memory, (uint)pname);
            
            /// <summary> <b>[requires: GL_NV_sample_locations]</b> <b>[entry point: <c>glResolveDepthValuesNV</c>]</b><br/>  </summary>
            public static void ResolveDepthValuesNV() => GLPointers._glResolveDepthValuesNV_fnptr();
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glScissorArrayvNV</c>]</b><br/>  </summary>
            public static void ScissorArrayvNV(uint first, int count, int* v) => GLPointers._glScissorArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive]</b> <b>[entry point: <c>glScissorExclusiveArrayvNV</c>]</b><br/>  </summary>
            public static void ScissorExclusiveArrayvNV(uint first, int count, int* v) => GLPointers._glScissorExclusiveArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_scissor_exclusive]</b> <b>[entry point: <c>glScissorExclusiveNV</c>]</b><br/>  </summary>
            public static void ScissorExclusiveNV(int x, int y, int width, int height) => GLPointers._glScissorExclusiveNV_fnptr(x, y, width, height);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glScissorIndexedNV</c>]</b><br/>  </summary>
            public static void ScissorIndexedNV(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedNV_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glScissorIndexedvNV</c>]</b><br/>  </summary>
            public static void ScissorIndexedvNV(uint index, int* v) => GLPointers._glScissorIndexedvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_timeline_semaphore]</b> <b>[entry point: <c>glSemaphoreParameterivNV</c>]</b><br/>  </summary>
            public static void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glSetFenceNV</c>]</b><br/>  </summary>
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._glSetFenceNV_fnptr(fence, (uint)condition);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glShadingRateImageBarrierNV</c>]</b><br/>  </summary>
            public static void ShadingRateImageBarrierNV(bool synchronize) => GLPointers._glShadingRateImageBarrierNV_fnptr((byte)(synchronize ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glShadingRateImagePaletteNV</c>]</b><br/>  </summary>
            public static void ShadingRateImagePaletteNV(uint viewport, uint first, int count, All* rates) => GLPointers._glShadingRateImagePaletteNV_fnptr(viewport, first, count, (uint*)rates);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glShadingRateSampleOrderCustomNV</c>]</b><br/>  </summary>
            public static void ShadingRateSampleOrderCustomNV(All rate, uint samples, int* locations) => GLPointers._glShadingRateSampleOrderCustomNV_fnptr((uint)rate, samples, locations);
            
            /// <summary> <b>[requires: GL_NV_shading_rate_image]</b> <b>[entry point: <c>glShadingRateSampleOrderNV</c>]</b><br/>  </summary>
            public static void ShadingRateSampleOrderNV(All order) => GLPointers._glShadingRateSampleOrderNV_fnptr((uint)order);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b> <b>[entry point: <c>glSignalVkFenceNV</c>]</b><br/>  </summary>
            public static void SignalVkFenceNV(ulong vkFence) => GLPointers._glSignalVkFenceNV_fnptr(vkFence);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b> <b>[entry point: <c>glSignalVkSemaphoreNV</c>]</b><br/>  </summary>
            public static void SignalVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glSignalVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilFillPathInstancedNV</c>]</b><br/>  </summary>
            public static void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilFillPathNV</c>]</b><br/>  </summary>
            public static void StencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => GLPointers._glStencilFillPathNV_fnptr(path, (uint)fillMode, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilStrokePathInstancedNV</c>]</b><br/>  </summary>
            public static void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilStrokePathNV</c>]</b><br/>  </summary>
            public static void StencilStrokePathNV(uint path, int reference, uint mask) => GLPointers._glStencilStrokePathNV_fnptr(path, reference, mask);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilThenCoverFillPathInstancedNV</c>]</b><br/>  </summary>
            public static void StencilThenCoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilThenCoverFillPathNV</c>]</b><br/>  </summary>
            public static void StencilThenCoverFillPathNV(uint path, PathFillMode fillMode, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverFillPathNV_fnptr(path, (uint)fillMode, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilThenCoverStrokePathInstancedNV</c>]</b><br/>  </summary>
            public static void StencilThenCoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glStencilThenCoverStrokePathNV</c>]</b><br/>  </summary>
            public static void StencilThenCoverStrokePathNV(uint path, int reference, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverStrokePathNV_fnptr(path, reference, mask, (uint)coverMode);
            
            /// <summary> <b>[requires: GL_NV_conservative_raster]</b> <b>[entry point: <c>glSubpixelPrecisionBiasNV</c>]</b><br/>  </summary>
            public static void SubpixelPrecisionBiasNV(uint xbits, uint ybits) => GLPointers._glSubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            
            /// <summary> <b>[requires: GL_NV_fence]</b> <b>[entry point: <c>glTestFenceNV</c>]</b><br/>  </summary>
            public static bool TestFenceNV(uint fence) => GLPointers._glTestFenceNV_fnptr(fence) != 0;
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glTexAttachMemoryNV</c>]</b><br/>  </summary>
            public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => GLPointers._glTexAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b> <b>[entry point: <c>glTexPageCommitmentMemNV</c>]</b><br/>  </summary>
            public static void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexPageCommitmentMemNV_fnptr((uint)target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_memory_attachment]</b> <b>[entry point: <c>glTextureAttachMemoryNV</c>]</b><br/>  </summary>
            public static void TextureAttachMemoryNV(int texture, uint memory, ulong offset) => GLPointers._glTextureAttachMemoryNV_fnptr(texture, memory, offset);
            
            /// <summary> <b>[requires: GL_NV_memory_object_sparse]</b> <b>[entry point: <c>glTexturePageCommitmentMemNV</c>]</b><br/>  </summary>
            public static void TexturePageCommitmentMemNV(int texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glTransformPathNV</c>]</b><br/>  </summary>
            public static void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => GLPointers._glTransformPathNV_fnptr(resultPath, srcPath, (uint)transformType, transformValues);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform1i64NV</c>]</b><br/>  </summary>
            public static void Uniform1i64NV(int location, long x) => GLPointers._glUniform1i64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform1i64vNV</c>]</b><br/>  </summary>
            public static void Uniform1i64vNV(int location, int count, long* value) => GLPointers._glUniform1i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform1ui64NV</c>]</b><br/>  </summary>
            public static void Uniform1ui64NV(int location, ulong x) => GLPointers._glUniform1ui64NV_fnptr(location, x);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform1ui64vNV</c>]</b><br/>  </summary>
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform1ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform2i64NV</c>]</b><br/>  </summary>
            public static void Uniform2i64NV(int location, long x, long y) => GLPointers._glUniform2i64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform2i64vNV</c>]</b><br/>  </summary>
            public static void Uniform2i64vNV(int location, int count, long* value) => GLPointers._glUniform2i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform2ui64NV</c>]</b><br/>  </summary>
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => GLPointers._glUniform2ui64NV_fnptr(location, x, y);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform2ui64vNV</c>]</b><br/>  </summary>
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform2ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform3i64NV</c>]</b><br/>  </summary>
            public static void Uniform3i64NV(int location, long x, long y, long z) => GLPointers._glUniform3i64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform3i64vNV</c>]</b><br/>  </summary>
            public static void Uniform3i64vNV(int location, int count, long* value) => GLPointers._glUniform3i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform3ui64NV</c>]</b><br/>  </summary>
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64NV_fnptr(location, x, y, z);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform3ui64vNV</c>]</b><br/>  </summary>
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform3ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform4i64NV</c>]</b><br/>  </summary>
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform4i64vNV</c>]</b><br/>  </summary>
            public static void Uniform4i64vNV(int location, int count, long* value) => GLPointers._glUniform4i64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform4ui64NV</c>]</b><br/>  </summary>
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64NV_fnptr(location, x, y, z, w);
            
            /// <summary> <b>[requires: GL_NV_gpu_shader5]</b> <b>[entry point: <c>glUniform4ui64vNV</c>]</b><br/>  </summary>
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform4ui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glUniformHandleui64NV</c>]</b><br/>  </summary>
            public static void UniformHandleui64NV(int location, ulong value) => GLPointers._glUniformHandleui64NV_fnptr(location, value);
            
            /// <summary> <b>[requires: GL_NV_bindless_texture]</b> <b>[entry point: <c>glUniformHandleui64vNV</c>]</b><br/>  </summary>
            public static void UniformHandleui64vNV(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vNV_fnptr(location, count, value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix2x3fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix2x3fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix2x4fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix2x4fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix3x2fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix3x2fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix3x4fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix3x4fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix4x2fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix4x2fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_non_square_matrices]</b> <b>[entry point: <c>glUniformMatrix4x3fvNV</c>]</b><br/>  </summary>
            public static void UniformMatrix4x3fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            /// <summary> <b>[requires: GL_NV_instanced_arrays]</b> <b>[entry point: <c>glVertexAttribDivisorNV</c>]</b><br/>  </summary>
            public static void VertexAttribDivisorNV(uint index, uint divisor) => GLPointers._glVertexAttribDivisorNV_fnptr(index, divisor);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glViewportArrayvNV</c>]</b><br/>  </summary>
            public static void ViewportArrayvNV(uint first, int count, float* v) => GLPointers._glViewportArrayvNV_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glViewportIndexedfNV</c>]</b><br/>  </summary>
            public static void ViewportIndexedfNV(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfNV_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_NV_viewport_array]</b> <b>[entry point: <c>glViewportIndexedfvNV</c>]</b><br/>  </summary>
            public static void ViewportIndexedfvNV(uint index, float* v) => GLPointers._glViewportIndexedfvNV_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_NV_clip_space_w_scaling]</b> <b>[entry point: <c>glViewportPositionWScaleNV</c>]</b><br/>  </summary>
            public static void ViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => GLPointers._glViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            
            /// <summary> <b>[requires: GL_NV_viewport_swizzle]</b> <b>[entry point: <c>glViewportSwizzleNV</c>]</b><br/>  </summary>
            public static void ViewportSwizzleNV(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => GLPointers._glViewportSwizzleNV_fnptr(index, (uint)swizzlex, (uint)swizzley, (uint)swizzlez, (uint)swizzlew);
            
            /// <summary> <b>[requires: GL_NV_draw_vulkan_image]</b> <b>[entry point: <c>glWaitVkSemaphoreNV</c>]</b><br/>  </summary>
            public static void WaitVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glWaitVkSemaphoreNV_fnptr(vkSemaphore);
            
            /// <summary> <b>[requires: GL_NV_path_rendering]</b> <b>[entry point: <c>glWeightPathsNV</c>]</b><br/>  </summary>
            public static void WeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights) => GLPointers._glWeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b> <b>[entry point: <c>glBindVertexArrayOES</c>]</b><br/>  </summary>
            public static void BindVertexArrayOES(int array) => GLPointers._glBindVertexArrayOES_fnptr(array);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendEquationiOES</c>]</b><br/>  </summary>
            public static void BlendEquationiOES(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiOES_fnptr(buf, (uint)mode);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendEquationSeparateiOES</c>]</b><br/>  </summary>
            public static void BlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiOES_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendFunciOES</c>]</b><br/>  </summary>
            public static void BlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciOES_fnptr(buf, (uint)src, (uint)dst);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b> <b>[entry point: <c>glBlendFuncSeparateiOES</c>]</b><br/>  </summary>
            public static void BlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiOES_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed]</b> <b>[entry point: <c>glColorMaskiOES</c>]</b><br/>  </summary>
            public static void ColorMaskiOES(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiOES_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glCompressedTexImage3DOES</c>]</b><br/>  </summary>
            public static void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glCompressedTexSubImage3DOES</c>]</b><br/>  </summary>
            public static void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            /// <summary> <b>[requires: GL_OES_copy_image]</b> <b>[entry point: <c>glCopyImageSubDataOES</c>]</b><br/>  </summary>
            public static void CopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataOES_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glCopyTexSubImage3DOES</c>]</b><br/>  </summary>
            public static void CopyTexSubImage3DOES(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b> <b>[entry point: <c>glDeleteVertexArraysOES</c>]</b><br/>  </summary>
            public static void DeleteVertexArraysOES(int n, int* arrays) => GLPointers._glDeleteVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glDepthRangeArrayfvOES</c>]</b><br/>  </summary>
            public static void DepthRangeArrayfvOES(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glDepthRangeIndexedfOES</c>]</b><br/>  </summary>
            public static void DepthRangeIndexedfOES(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfOES_fnptr(index, n, f);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b> <b>[entry point: <c>glDisableiOES</c>]</b><br/>  </summary>
            public static void DisableiOES(EnableCap target, uint index) => GLPointers._glDisableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawElementsBaseVertexOES</c>]</b><br/>  </summary>
            public static void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawElementsInstancedBaseVertexOES</c>]</b><br/>  </summary>
            public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            /// <summary> <b>[requires: GL_OES_draw_elements_base_vertex]</b> <b>[entry point: <c>glDrawRangeElementsBaseVertexOES</c>]</b><br/>  </summary>
            public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexOES_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b> <b>[entry point: <c>glEGLImageTargetRenderbufferStorageOES</c>]</b><br/>  </summary>
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => GLPointers._glEGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_EGL_image]</b> <b>[entry point: <c>glEGLImageTargetTexture2DOES</c>]</b><br/>  </summary>
            public static void EGLImageTargetTexture2DOES(All target, void* image) => GLPointers._glEGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b> <b>[entry point: <c>glEnableiOES</c>]</b><br/>  </summary>
            public static void EnableiOES(EnableCap target, uint index) => GLPointers._glEnableiOES_fnptr((uint)target, index);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glFramebufferTexture3DOES</c>]</b><br/>  </summary>
            public static void FramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            /// <summary> <b>[requires: GL_OES_geometry_shader]</b> <b>[entry point: <c>glFramebufferTextureOES</c>]</b><br/>  </summary>
            public static void FramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureOES_fnptr((uint)target, (uint)attachment, texture, level);
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b> <b>[entry point: <c>glGenVertexArraysOES</c>]</b><br/>  </summary>
            public static void GenVertexArraysOES(int n, int* arrays) => GLPointers._glGenVertexArraysOES_fnptr(n, arrays);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b> <b>[entry point: <c>glGetBufferPointervOES</c>]</b><br/>  </summary>
            public static void GetBufferPointervOES_(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glGetFloati_vOES</c>]</b><br/>  </summary>
            public static void GetFloati_vOES(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vOES_fnptr((uint)target, index, data);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary]</b> <b>[entry point: <c>glGetProgramBinaryOES</c>]</b><br/>  </summary>
            public static void GetProgramBinaryOES(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinaryOES_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glGetSamplerParameterIivOES</c>]</b><br/>  </summary>
            public static void GetSamplerParameterIivOES(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivOES_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glGetSamplerParameterIuivOES</c>]</b><br/>  </summary>
            public static void GetSamplerParameterIuivOES(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivOES_fnptr(sampler, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glGetTexParameterIivOES</c>]</b><br/>  </summary>
            public static void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glGetTexParameterIuivOES</c>]</b><br/>  </summary>
            public static void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_draw_buffers_indexed | GL_OES_viewport_array]</b> <b>[entry point: <c>glIsEnablediOES</c>]</b><br/>  </summary>
            public static bool IsEnablediOES(EnableCap target, uint index) => GLPointers._glIsEnablediOES_fnptr((uint)target, index) != 0;
            
            /// <summary> <b>[requires: GL_OES_vertex_array_object]</b> <b>[entry point: <c>glIsVertexArrayOES</c>]</b><br/>  </summary>
            public static bool IsVertexArrayOES(int array) => GLPointers._glIsVertexArrayOES_fnptr(array) != 0;
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b> <b>[entry point: <c>glMapBufferOES</c>]</b><br/>  </summary>
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferOES_fnptr((uint)target, (uint)access);
            
            /// <summary> <b>[requires: GL_OES_sample_shading]</b> <b>[entry point: <c>glMinSampleShadingOES</c>]</b><br/>  </summary>
            public static void MinSampleShadingOES(float value) => GLPointers._glMinSampleShadingOES_fnptr(value);
            
            /// <summary> <b>[requires: GL_EXT_draw_elements_base_vertex | GL_OES_draw_elements_base_vertex]</b> <b>[entry point: <c>glMultiDrawElementsBaseVertexEXT</c>]</b><br/>  </summary>
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            /// <summary> <b>[requires: GL_OES_tessellation_shader]</b> <b>[entry point: <c>glPatchParameteriOES</c>]</b><br/>  </summary>
            public static void PatchParameteriOES(PatchParameterName pname, int value) => GLPointers._glPatchParameteriOES_fnptr((uint)pname, value);
            
            /// <summary> <b>[requires: GL_OES_primitive_bounding_box]</b> <b>[entry point: <c>glPrimitiveBoundingBoxOES</c>]</b><br/>  </summary>
            public static void PrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            /// <summary> <b>[requires: GL_OES_get_program_binary]</b> <b>[entry point: <c>glProgramBinaryOES</c>]</b><br/>  </summary>
            public static void ProgramBinaryOES(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinaryOES_fnptr(program, (uint)binaryFormat, binary, length);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glSamplerParameterIivOES</c>]</b><br/>  </summary>
            public static void SamplerParameterIivOES(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivOES_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glSamplerParameterIuivOES</c>]</b><br/>  </summary>
            public static void SamplerParameterIuivOES(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivOES_fnptr(sampler, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glScissorArrayvOES</c>]</b><br/>  </summary>
            public static void ScissorArrayvOES(uint first, int count, int* v) => GLPointers._glScissorArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glScissorIndexedOES</c>]</b><br/>  </summary>
            public static void ScissorIndexedOES(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedOES_fnptr(index, left, bottom, width, height);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glScissorIndexedvOES</c>]</b><br/>  </summary>
            public static void ScissorIndexedvOES(uint index, int* v) => GLPointers._glScissorIndexedvOES_fnptr(index, v);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer]</b> <b>[entry point: <c>glTexBufferOES</c>]</b><br/>  </summary>
            public static void TexBufferOES(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferOES_fnptr((uint)target, (uint)internalformat, buffer);
            
            /// <summary> <b>[requires: GL_OES_texture_buffer]</b> <b>[entry point: <c>glTexBufferRangeOES</c>]</b><br/>  </summary>
            public static void TexBufferRangeOES(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeOES_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glTexImage3DOES</c>]</b><br/>  </summary>
            public static void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glTexParameterIivOES</c>]</b><br/>  </summary>
            public static void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_border_clamp]</b> <b>[entry point: <c>glTexParameterIuivOES</c>]</b><br/>  </summary>
            public static void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_OES_texture_storage_multisample_2d_array]</b> <b>[entry point: <c>glTexStorage3DMultisampleOES</c>]</b><br/>  </summary>
            public static void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisampleOES_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            /// <summary> <b>[requires: GL_OES_texture_3D]</b> <b>[entry point: <c>glTexSubImage3DOES</c>]</b><br/>  </summary>
            public static void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            /// <summary> <b>[requires: GL_OES_texture_view]</b> <b>[entry point: <c>glTextureViewOES</c>]</b><br/>  </summary>
            public static void TextureViewOES(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewOES_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            /// <summary> <b>[requires: GL_OES_mapbuffer]</b> <b>[entry point: <c>glUnmapBufferOES</c>]</b><br/>  </summary>
            public static bool UnmapBufferOES(All target) => GLPointers._glUnmapBufferOES_fnptr((uint)target) != 0;
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glViewportArrayvOES</c>]</b><br/>  </summary>
            public static void ViewportArrayvOES(uint first, int count, float* v) => GLPointers._glViewportArrayvOES_fnptr(first, count, v);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glViewportIndexedfOES</c>]</b><br/>  </summary>
            public static void ViewportIndexedfOES(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfOES_fnptr(index, x, y, w, h);
            
            /// <summary> <b>[requires: GL_OES_viewport_array]</b> <b>[entry point: <c>glViewportIndexedfvOES</c>]</b><br/>  </summary>
            public static void ViewportIndexedfvOES(uint index, float* v) => GLPointers._glViewportIndexedfvOES_fnptr(index, v);
            
        }
        /// <summary>OVR extensions.</summary>
        public static unsafe partial class OVR
        {
            /// <summary> <b>[requires: GL_OVR_multiview_multisampled_render_to_texture]</b> <b>[entry point: <c>glFramebufferTextureMultisampleMultiviewOVR</c>]</b><br/>  </summary>
            public static void FramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int samples, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultisampleMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, samples, baseViewIndex, numViews);
            
            /// <summary> <b>[requires: GL_OVR_multiview]</b> <b>[entry point: <c>glFramebufferTextureMultiviewOVR</c>]</b><br/>  </summary>
            public static void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, baseViewIndex, numViews);
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: GL_QCOM_alpha_test]</b> <b>[entry point: <c>glAlphaFuncQCOM</c>]</b><br/>  </summary>
            public static void AlphaFuncQCOM(All func, float reference) => GLPointers._glAlphaFuncQCOM_fnptr((uint)func, reference);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b> <b>[entry point: <c>glDisableDriverControlQCOM</c>]</b><br/>  </summary>
            public static void DisableDriverControlQCOM(uint driverControl) => GLPointers._glDisableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b> <b>[entry point: <c>glEnableDriverControlQCOM</c>]</b><br/>  </summary>
            public static void EnableDriverControlQCOM(uint driverControl) => GLPointers._glEnableDriverControlQCOM_fnptr(driverControl);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b> <b>[entry point: <c>glEndTilingQCOM</c>]</b><br/>  </summary>
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => GLPointers._glEndTilingQCOM_fnptr((uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetBufferPointervQCOM</c>]</b><br/>  </summary>
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => GLPointers._glExtGetBufferPointervQCOM_fnptr((uint)target, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetBuffersQCOM</c>]</b><br/>  </summary>
            public static void ExtGetBuffersQCOM(int* buffers, int maxBuffers, int* numBuffers) => GLPointers._glExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetFramebuffersQCOM</c>]</b><br/>  </summary>
            public static void ExtGetFramebuffersQCOM(int* framebuffers, int maxFramebuffers, int* numFramebuffers) => GLPointers._glExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b> <b>[entry point: <c>glExtGetProgramBinarySourceQCOM</c>]</b><br/>  </summary>
            public static void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, byte* source, int* length) => GLPointers._glExtGetProgramBinarySourceQCOM_fnptr(program, (uint)shadertype, source, length);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b> <b>[entry point: <c>glExtGetProgramsQCOM</c>]</b><br/>  </summary>
            public static void ExtGetProgramsQCOM(int* programs, int maxPrograms, int* numPrograms) => GLPointers._glExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetRenderbuffersQCOM</c>]</b><br/>  </summary>
            public static void ExtGetRenderbuffersQCOM(int* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => GLPointers._glExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b> <b>[entry point: <c>glExtGetShadersQCOM</c>]</b><br/>  </summary>
            public static void ExtGetShadersQCOM(int* shaders, int maxShaders, int* numShaders) => GLPointers._glExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetTexLevelParameterivQCOM</c>]</b><br/>  </summary>
            public static void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, int* parameters) => GLPointers._glExtGetTexLevelParameterivQCOM_fnptr(texture, (uint)face, level, (uint)pname, parameters);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetTexSubImageQCOM</c>]</b><br/>  </summary>
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => GLPointers._glExtGetTexSubImageQCOM_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, texels);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtGetTexturesQCOM</c>]</b><br/>  </summary>
            public static void ExtGetTexturesQCOM(int* textures, int maxTextures, int* numTextures) => GLPointers._glExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get2]</b> <b>[entry point: <c>glExtIsProgramBinaryQCOM</c>]</b><br/>  </summary>
            public static bool ExtIsProgramBinaryQCOM(int program) => GLPointers._glExtIsProgramBinaryQCOM_fnptr(program) != 0;
            
            /// <summary> <b>[requires: GL_QCOM_frame_extrapolation]</b> <b>[entry point: <c>glExtrapolateTex2DQCOM</c>]</b><br/>  </summary>
            public static void ExtrapolateTex2DQCOM(int src1, int src2, int output, float scaleFactor) => GLPointers._glExtrapolateTex2DQCOM_fnptr(src1, src2, output, scaleFactor);
            
            /// <summary> <b>[requires: GL_QCOM_extended_get]</b> <b>[entry point: <c>glExtTexObjectStateOverrideiQCOM</c>]</b><br/>  </summary>
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => GLPointers._glExtTexObjectStateOverrideiQCOM_fnptr((uint)target, (uint)pname, param);
            
            /// <summary> <b>[requires: GL_QCOM_shader_framebuffer_fetch_noncoherent]</b> <b>[entry point: <c>glFramebufferFetchBarrierQCOM</c>]</b><br/>  </summary>
            public static void FramebufferFetchBarrierQCOM() => GLPointers._glFramebufferFetchBarrierQCOM_fnptr();
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated]</b> <b>[entry point: <c>glFramebufferFoveationConfigQCOM</c>]</b><br/>  </summary>
            public static void FramebufferFoveationConfigQCOM(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures) => GLPointers._glFramebufferFoveationConfigQCOM_fnptr(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            
            /// <summary> <b>[requires: GL_QCOM_framebuffer_foveated]</b> <b>[entry point: <c>glFramebufferFoveationParametersQCOM</c>]</b><br/>  </summary>
            public static void FramebufferFoveationParametersQCOM(int framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glFramebufferFoveationParametersQCOM_fnptr(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b> <b>[entry point: <c>glGetDriverControlsQCOM</c>]</b><br/>  </summary>
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => GLPointers._glGetDriverControlsQCOM_fnptr(num, size, driverControls);
            
            /// <summary> <b>[requires: GL_QCOM_driver_control]</b> <b>[entry point: <c>glGetDriverControlStringQCOM</c>]</b><br/>  </summary>
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => GLPointers._glGetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            
            /// <summary> <b>[requires: GL_QCOM_shading_rate]</b> <b>[entry point: <c>glShadingRateQCOM</c>]</b><br/>  </summary>
            public static void ShadingRateQCOM(ShadingRateQCOM rate) => GLPointers._glShadingRateQCOM_fnptr((uint)rate);
            
            /// <summary> <b>[requires: GL_QCOM_tiled_rendering]</b> <b>[entry point: <c>glStartTilingQCOM</c>]</b><br/>  </summary>
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._glStartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation]</b> <b>[entry point: <c>glTexEstimateMotionQCOM</c>]</b><br/>  </summary>
            public static void TexEstimateMotionQCOM(int reference, int target, int output) => GLPointers._glTexEstimateMotionQCOM_fnptr(reference, target, output);
            
            /// <summary> <b>[requires: GL_QCOM_motion_estimation]</b> <b>[entry point: <c>glTexEstimateMotionRegionsQCOM</c>]</b><br/>  </summary>
            public static void TexEstimateMotionRegionsQCOM(int reference, int target, int output, int mask) => GLPointers._glTexEstimateMotionRegionsQCOM_fnptr(reference, target, output, mask);
            
            /// <summary> <b>[requires: GL_QCOM_texture_foveated]</b> <b>[entry point: <c>glTextureFoveationParametersQCOM</c>]</b><br/>  </summary>
            public static void TextureFoveationParametersQCOM(int texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glTextureFoveationParametersQCOM_fnptr(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
        }
    }
}
