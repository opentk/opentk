using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.GLES232
{
    public unsafe static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glAttachShader")]
        public static extern void AttachShader(uint program, uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindAttribLocation")]
        public static extern void BindAttribLocation(uint program, uint index, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(uint target, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(uint target, uint framebuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(uint target, uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(uint target, uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendColor")]
        public static extern void BlendColor(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquation")]
        public static extern void BlendEquation(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparate")]
        public static extern void BlendEquationSeparate(uint modeRGB, uint modeAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(uint sfactor, uint dfactor);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparate")]
        public static extern void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(uint target, IntPtr size, void* data, uint usage);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferSubData")]
        public static extern void BufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCheckFramebufferStatus")]
        public static extern uint CheckFramebufferStatus(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        public static extern void Clear(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearDepthf")]
        public static extern void ClearDepthf(float d);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(int s);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMask")]
        public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompileShader")]
        public static extern void CompileShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateProgram")]
        public static extern uint CreateProgram();
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateShader")]
        public static extern uint CreateShader(uint type);
        
        [DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(int n, uint* framebuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteProgram")]
        public static extern void DeleteProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(int n, uint* renderbuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteShader")]
        public static extern void DeleteShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(uint func);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(byte flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangef")]
        public static extern void DepthRangef(float n, float f);
        
        [DllImport("opengl32.dll", EntryPoint = "glDetachShader")]
        public static extern void DetachShader(uint program, uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(uint mode, int first, int count);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements")]
        public static extern void DrawElements(uint mode, int count, uint type, void* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        public static extern void Enable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnableVertexAttribArray")]
        public static extern void EnableVertexAttribArray(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glFinish")]
        public static extern void Finish();
        
        [DllImport("opengl32.dll", EntryPoint = "glFlush")]
        public static extern void Flush();
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
        
        [DllImport("opengl32.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenerateMipmap")]
        public static extern void GenerateMipmap(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(int n, uint* framebuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(int n, uint* renderbuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetAttribLocation")]
        public static extern int GetAttribLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBooleanv(uint pname, byte* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        public static extern uint GetError();
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloatv(uint pname, float* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetIntegerv(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgramiv(uint program, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShaderiv(uint shader, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(uint shader, int bufSize, int* length, char* source);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetString")]
        public static extern byte* GetString(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameterfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniformfv(uint program, int location, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniformiv(uint program, int location, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformLocation")]
        public static extern int GetUniformLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttribfv(uint index, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttribiv(uint index, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointerv(uint index, uint pname, void** pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        public static extern void Hint(uint target, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsBuffer")]
        public static extern byte IsBuffer(uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabled")]
        public static extern byte IsEnabled(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsFramebuffer")]
        public static extern byte IsFramebuffer(uint framebuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsProgram")]
        public static extern byte IsProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsRenderbuffer")]
        public static extern byte IsRenderbuffer(uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsShader")]
        public static extern byte IsShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsTexture")]
        public static extern byte IsTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(float width);
        
        [DllImport("opengl32.dll", EntryPoint = "glLinkProgram")]
        public static extern void LinkProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStorei(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(float factor, float units);
        
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glReleaseShaderCompiler")]
        public static extern void ReleaseShaderCompiler();
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorage")]
        public static extern void RenderbufferStorage(uint target, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(float value, byte invert);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);
        
        [DllImport("opengl32.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(uint shader, int count, char** str, int* length);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(uint func, int reference, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(uint face, uint func, int reference, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(uint face, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(uint fail, uint zfail, uint zpass);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilOpSeparate")]
        public static extern void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterf")]
        public static extern void TexParameterf(uint target, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterfv")]
        public static extern void TexParameterfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameteri(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteriv")]
        public static extern void TexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1f")]
        public static extern void Uniform1f(int location, float v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1fv")]
        public static extern void Uniform1fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1i")]
        public static extern void Uniform1i(int location, int v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1iv")]
        public static extern void Uniform1iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2f")]
        public static extern void Uniform2f(int location, float v0, float v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2fv")]
        public static extern void Uniform2fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2i")]
        public static extern void Uniform2i(int location, int v0, int v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2iv")]
        public static extern void Uniform2iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3f")]
        public static extern void Uniform3f(int location, float v0, float v1, float v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3fv")]
        public static extern void Uniform3fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3i")]
        public static extern void Uniform3i(int location, int v0, int v1, int v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3iv")]
        public static extern void Uniform3iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4f")]
        public static extern void Uniform4f(int location, float v0, float v1, float v2, float v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4fv")]
        public static extern void Uniform4fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4i")]
        public static extern void Uniform4i(int location, int v0, int v1, int v2, int v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4iv")]
        public static extern void Uniform4iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2fv")]
        public static extern void UniformMatrix2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3fv")]
        public static extern void UniformMatrix3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4fv")]
        public static extern void UniformMatrix4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUseProgram")]
        public static extern void UseProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glValidateProgram")]
        public static extern void ValidateProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1f")]
        public static extern void VertexAttrib1f(uint index, float x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern void VertexAttrib1fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2f")]
        public static extern void VertexAttrib2f(uint index, float x, float y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3f")]
        public static extern void VertexAttrib3f(uint index, float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4f")]
        public static extern void VertexAttrib4f(uint index, float x, float y, float z, float w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glReadBuffer")]
        public static extern void ReadBuffer(uint src);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElements")]
        public static extern void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage3D")]
        public static extern void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage3D")]
        public static extern void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage3D")]
        public static extern void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage3D")]
        public static extern void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage3D")]
        public static extern void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenQueries")]
        public static extern void GenQueries(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteQueries")]
        public static extern void DeleteQueries(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsQuery")]
        public static extern byte IsQuery(uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginQuery")]
        public static extern void BeginQuery(uint target, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndQuery")]
        public static extern void EndQuery(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryiv")]
        public static extern void GetQueryiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectuiv")]
        public static extern void GetQueryObjectuiv(uint id, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glUnmapBuffer")]
        public static extern byte UnmapBuffer(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferPointerv")]
        public static extern void GetBufferPointerv(uint target, uint pname, void** parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawBuffers")]
        public static extern void DrawBuffers(int n, uint* bufs);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x3fv")]
        public static extern void UniformMatrix2x3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x2fv")]
        public static extern void UniformMatrix3x2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x4fv")]
        public static extern void UniformMatrix2x4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x2fv")]
        public static extern void UniformMatrix4x2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x4fv")]
        public static extern void UniformMatrix3x4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x3fv")]
        public static extern void UniformMatrix4x3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlitFramebuffer")]
        public static extern void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisample")]
        public static extern void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayer")]
        public static extern void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapBufferRange")]
        public static extern void* MapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
        
        [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRange")]
        public static extern void FlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindVertexArray")]
        public static extern void BindVertexArray(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexArrays")]
        public static extern void DeleteVertexArrays(int n, uint* arrays);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenVertexArrays")]
        public static extern void GenVertexArrays(int n, uint* arrays);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsVertexArray")]
        public static extern byte IsVertexArray(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegeri_v")]
        public static extern void GetIntegeri_v(uint target, uint index, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginTransformFeedback")]
        public static extern void BeginTransformFeedback(uint primitiveMode);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndTransformFeedback")]
        public static extern void EndTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBufferRange")]
        public static extern void BindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBufferBase")]
        public static extern void BindBufferBase(uint target, uint index, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackVaryings")]
        public static extern void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbackVarying")]
        public static extern void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIPointer")]
        public static extern void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIiv")]
        public static extern void GetVertexAttribIiv(uint index, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIuiv")]
        public static extern void GetVertexAttribIuiv(uint index, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4i")]
        public static extern void VertexAttribI4i(uint index, int x, int y, int z, int w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4ui")]
        public static extern void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4iv")]
        public static extern void VertexAttribI4iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4uiv")]
        public static extern void VertexAttribI4uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformuiv")]
        public static extern void GetUniformuiv(uint program, int location, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFragDataLocation")]
        public static extern int GetFragDataLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1ui")]
        public static extern void Uniform1ui(int location, uint v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2ui")]
        public static extern void Uniform2ui(int location, uint v0, uint v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3ui")]
        public static extern void Uniform3ui(int location, uint v0, uint v1, uint v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4ui")]
        public static extern void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1uiv")]
        public static extern void Uniform1uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2uiv")]
        public static extern void Uniform2uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3uiv")]
        public static extern void Uniform3uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4uiv")]
        public static extern void Uniform4uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferiv")]
        public static extern void ClearBufferiv(uint buffer, int drawbuffer, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferuiv")]
        public static extern void ClearBufferuiv(uint buffer, int drawbuffer, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferfv")]
        public static extern void ClearBufferfv(uint buffer, int drawbuffer, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferfi")]
        public static extern void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetStringi")]
        public static extern byte* GetStringi(uint name, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyBufferSubData")]
        public static extern void CopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformIndices")]
        public static extern void GetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformsiv")]
        public static extern void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformBlockIndex")]
        public static extern uint GetUniformBlockIndex(uint program, char* uniformBlockName);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockiv")]
        public static extern void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockName")]
        public static extern void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformBlockBinding")]
        public static extern void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstanced")]
        public static extern void DrawArraysInstanced(uint mode, int first, int count, int instancecount);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstanced")]
        public static extern void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);
        
        [DllImport("opengl32.dll", EntryPoint = "glFenceSync")]
        public static extern GLsync* FenceSync(uint condition, uint flags);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsSync")]
        public static extern byte IsSync(GLsync* sync);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteSync")]
        public static extern void DeleteSync(GLsync* sync);
        
        [DllImport("opengl32.dll", EntryPoint = "glClientWaitSync")]
        public static extern uint ClientWaitSync(GLsync* sync, uint flags, uint timeout);
        
        [DllImport("opengl32.dll", EntryPoint = "glWaitSync")]
        public static extern void WaitSync(GLsync* sync, uint flags, uint timeout);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInteger64v")]
        public static extern void GetInteger64v(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSynciv")]
        public static extern void GetSynciv(GLsync* sync, uint pname, int count, int* length, int* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInteger64i_v")]
        public static extern void GetInteger64i_v(uint target, uint index, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameteri64v")]
        public static extern void GetBufferParameteri64v(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenSamplers")]
        public static extern void GenSamplers(int count, uint* samplers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteSamplers")]
        public static extern void DeleteSamplers(int count, uint* samplers);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsSampler")]
        public static extern byte IsSampler(uint sampler);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindSampler")]
        public static extern void BindSampler(uint unit, uint sampler);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteri")]
        public static extern void SamplerParameteri(uint sampler, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteriv")]
        public static extern void SamplerParameteriv(uint sampler, uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterf")]
        public static extern void SamplerParameterf(uint sampler, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterfv")]
        public static extern void SamplerParameterfv(uint sampler, uint pname, float* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameteriv")]
        public static extern void GetSamplerParameteriv(uint sampler, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterfv")]
        public static extern void GetSamplerParameterfv(uint sampler, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisor")]
        public static extern void VertexAttribDivisor(uint index, uint divisor);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindTransformFeedback")]
        public static extern void BindTransformFeedback(uint target, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTransformFeedbacks")]
        public static extern void DeleteTransformFeedbacks(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenTransformFeedbacks")]
        public static extern void GenTransformFeedbacks(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsTransformFeedback")]
        public static extern byte IsTransformFeedback(uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glPauseTransformFeedback")]
        public static extern void PauseTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glResumeTransformFeedback")]
        public static extern void ResumeTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramBinary")]
        public static extern void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramBinary")]
        public static extern void ProgramBinary(uint program, uint binaryFormat, void* binary, int length);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramParameteri")]
        public static extern void ProgramParameteri(uint program, uint pname, int value);
        
        [DllImport("opengl32.dll", EntryPoint = "glInvalidateFramebuffer")]
        public static extern void InvalidateFramebuffer(uint target, int numAttachments, uint* attachments);
        
        [DllImport("opengl32.dll", EntryPoint = "glInvalidateSubFramebuffer")]
        public static extern void InvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage2D")]
        public static extern void TexStorage2D(uint target, int levels, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage3D")]
        public static extern void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInternalformativ")]
        public static extern void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glDispatchCompute")]
        public static extern void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
        
        [DllImport("opengl32.dll", EntryPoint = "glDispatchComputeIndirect")]
        public static extern void DispatchComputeIndirect(IntPtr indirect);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArraysIndirect")]
        public static extern void DrawArraysIndirect(uint mode, void* indirect);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsIndirect")]
        public static extern void DrawElementsIndirect(uint mode, uint type, void* indirect);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferParameteri")]
        public static extern void FramebufferParameteri(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameteriv")]
        public static extern void GetFramebufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramInterfaceiv")]
        public static extern void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceIndex")]
        public static extern uint GetProgramResourceIndex(uint program, uint programInterface, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceName")]
        public static extern void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceiv")]
        public static extern void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceLocation")]
        public static extern int GetProgramResourceLocation(uint program, uint programInterface, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glUseProgramStages")]
        public static extern void UseProgramStages(uint pipeline, uint stages, uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glActiveShaderProgram")]
        public static extern void ActiveShaderProgram(uint pipeline, uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateShaderProgramv")]
        public static extern uint CreateShaderProgramv(uint type, int count, char** strings);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindProgramPipeline")]
        public static extern void BindProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteProgramPipelines")]
        public static extern void DeleteProgramPipelines(int n, uint* pipelines);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenProgramPipelines")]
        public static extern void GenProgramPipelines(int n, uint* pipelines);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsProgramPipeline")]
        public static extern byte IsProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineiv")]
        public static extern void GetProgramPipelineiv(uint pipeline, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i")]
        public static extern void ProgramUniform1i(uint program, int location, int v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i")]
        public static extern void ProgramUniform2i(uint program, int location, int v0, int v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i")]
        public static extern void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i")]
        public static extern void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui")]
        public static extern void ProgramUniform1ui(uint program, int location, uint v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui")]
        public static extern void ProgramUniform2ui(uint program, int location, uint v0, uint v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui")]
        public static extern void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui")]
        public static extern void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1f")]
        public static extern void ProgramUniform1f(uint program, int location, float v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2f")]
        public static extern void ProgramUniform2f(uint program, int location, float v0, float v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3f")]
        public static extern void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4f")]
        public static extern void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1iv")]
        public static extern void ProgramUniform1iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2iv")]
        public static extern void ProgramUniform2iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3iv")]
        public static extern void ProgramUniform3iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4iv")]
        public static extern void ProgramUniform4iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uiv")]
        public static extern void ProgramUniform1uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uiv")]
        public static extern void ProgramUniform2uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uiv")]
        public static extern void ProgramUniform3uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uiv")]
        public static extern void ProgramUniform4uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fv")]
        public static extern void ProgramUniform1fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fv")]
        public static extern void ProgramUniform2fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fv")]
        public static extern void ProgramUniform3fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fv")]
        public static extern void ProgramUniform4fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2fv")]
        public static extern void ProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3fv")]
        public static extern void ProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4fv")]
        public static extern void ProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3fv")]
        public static extern void ProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2fv")]
        public static extern void ProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4fv")]
        public static extern void ProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2fv")]
        public static extern void ProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4fv")]
        public static extern void ProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3fv")]
        public static extern void ProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glValidateProgramPipeline")]
        public static extern void ValidateProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineInfoLog")]
        public static extern void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindImageTexture")]
        public static extern void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleani_v")]
        public static extern void GetBooleani_v(uint target, uint index, byte* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrier")]
        public static extern void MemoryBarrier(uint barriers);
        
        [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrierByRegion")]
        public static extern void MemoryBarrierByRegion(uint barriers);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage2DMultisample")]
        public static extern void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMultisamplefv")]
        public static extern void GetMultisamplefv(uint pname, uint index, float* val);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleMaski")]
        public static extern void SampleMaski(uint maskNumber, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameteriv")]
        public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameterfv")]
        public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindVertexBuffer")]
        public static extern void BindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribFormat")]
        public static extern void VertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIFormat")]
        public static extern void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribBinding")]
        public static extern void VertexAttribBinding(uint attribindex, uint bindingindex);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexBindingDivisor")]
        public static extern void VertexBindingDivisor(uint bindingindex, uint divisor);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendBarrier")]
        public static extern void BlendBarrier();
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyImageSubData")]
        public static extern void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        
        [DllImport("opengl32.dll", EntryPoint = "glDebugMessageControl")]
        public static extern void DebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled);
        
        [DllImport("opengl32.dll", EntryPoint = "glDebugMessageInsert")]
        public static extern void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf);
        
        [DllImport("opengl32.dll", EntryPoint = "glDebugMessageCallback")]
        public static extern void DebugMessageCallback(GLDEBUGPROC callback, void* userParam);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetDebugMessageLog")]
        public static extern uint GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glPushDebugGroup")]
        public static extern void PushDebugGroup(uint source, uint id, int length, char* message);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopDebugGroup")]
        public static extern void PopDebugGroup();
        
        [DllImport("opengl32.dll", EntryPoint = "glObjectLabel")]
        public static extern void ObjectLabel(uint identifier, uint name, int length, char* label);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetObjectLabel")]
        public static extern void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label);
        
        [DllImport("opengl32.dll", EntryPoint = "glObjectPtrLabel")]
        public static extern void ObjectPtrLabel(void* ptr, int length, char* label);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetObjectPtrLabel")]
        public static extern void GetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPointerv")]
        public static extern void GetPointerv(uint pname, void** parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnablei")]
        public static extern void Enablei(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisablei")]
        public static extern void Disablei(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationi")]
        public static extern void BlendEquationi(uint buf, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparatei")]
        public static extern void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunci")]
        public static extern void BlendFunci(uint buf, uint src, uint dst);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparatei")]
        public static extern void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMaski")]
        public static extern void ColorMaski(uint index, byte r, byte g, byte b, byte a);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabledi")]
        public static extern byte IsEnabledi(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsBaseVertex")]
        public static extern void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsBaseVertex")]
        public static extern void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public static extern void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture")]
        public static extern void FramebufferTexture(uint target, uint attachment, uint texture, int level);
        
        [DllImport("opengl32.dll", EntryPoint = "glPrimitiveBoundingBox")]
        public static extern void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatus")]
        public static extern uint GetGraphicsResetStatus();
        
        [DllImport("opengl32.dll", EntryPoint = "glReadnPixels")]
        public static extern void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfv")]
        public static extern void GetnUniformfv(uint program, int location, int bufSize, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetnUniformiv")]
        public static extern void GetnUniformiv(uint program, int location, int bufSize, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetnUniformuiv")]
        public static extern void GetnUniformuiv(uint program, int location, int bufSize, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glMinSampleShading")]
        public static extern void MinSampleShading(float value);
        
        [DllImport("opengl32.dll", EntryPoint = "glPatchParameteri")]
        public static extern void PatchParameteri(uint pname, int value);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterIiv")]
        public static extern void TexParameterIiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterIuiv")]
        public static extern void TexParameterIuiv(uint target, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIiv")]
        public static extern void GetTexParameterIiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIuiv")]
        public static extern void GetTexParameterIuiv(uint target, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIiv")]
        public static extern void SamplerParameterIiv(uint sampler, uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIuiv")]
        public static extern void SamplerParameterIuiv(uint sampler, uint pname, uint* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIiv")]
        public static extern void GetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIuiv")]
        public static extern void GetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexBuffer")]
        public static extern void TexBuffer(uint target, uint internalformat, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexBufferRange")]
        public static extern void TexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage3DMultisample")]
        public static extern void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
        
    }
}
