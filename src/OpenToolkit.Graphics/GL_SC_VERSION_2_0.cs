using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.GLSC220
{
    public unsafe static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(uint texture);
        
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
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateProgram")]
        public static extern uint CreateProgram();
        
        [DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(uint func);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(byte flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangef")]
        public static extern void DepthRangef(float n, float f);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(uint mode, int first, int count);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElements")]
        public static extern void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
        
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
        
        [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatus")]
        public static extern uint GetGraphicsResetStatus();
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetIntegerv(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgramiv(uint program, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetString")]
        public static extern byte* GetString(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameterfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfv")]
        public static extern void GetnUniformfv(uint program, int location, int bufSize, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetnUniformiv")]
        public static extern void GetnUniformiv(uint program, int location, int bufSize, int* parameters);
        
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
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabled")]
        public static extern byte IsEnabled(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(float width);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStorei(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(float factor, float units);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramBinary")]
        public static extern void ProgramBinary(uint program, uint binaryFormat, void* binary, int length);
        
        [DllImport("opengl32.dll", EntryPoint = "glReadnPixels")]
        public static extern void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorage")]
        public static extern void RenderbufferStorage(uint target, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(float value, byte invert);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);
        
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
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage2D")]
        public static extern void TexStorage2D(uint target, int levels, uint internalformat, int width, int height);
        
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
        
    }
}
