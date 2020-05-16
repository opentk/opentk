using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.GLES110
{
    public unsafe static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glAlphaFuncx")]
        public static extern void AlphaFuncx(uint func, int reference);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(uint target, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(uint target, uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(uint sfactor, uint dfactor);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(uint target, IntPtr size, void* data, uint usage);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferSubData")]
        public static extern void BufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        public static extern void Clear(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearColorx")]
        public static extern void ClearColorx(int red, int green, int blue, int alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearDepthx")]
        public static extern void ClearDepthx(int depth);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(int s);
        
        [DllImport("opengl32.dll", EntryPoint = "glClientActiveTexture")]
        public static extern void ClientActiveTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glClipPlanex")]
        public static extern void ClipPlanex(uint plane, int* equation);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4ub")]
        public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4x")]
        public static extern void Color4x(int red, int green, int blue, int alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMask")]
        public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorPointer")]
        public static extern void ColorPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(uint func);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(byte flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangex")]
        public static extern void DepthRangex(int n, int f);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(uint mode, int first, int count);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements")]
        public static extern void DrawElements(uint mode, int count, uint type, void* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        public static extern void Enable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnableClientState")]
        public static extern void EnableClientState(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glFinish")]
        public static extern void Finish();
        
        [DllImport("opengl32.dll", EntryPoint = "glFlush")]
        public static extern void Flush();
        
        [DllImport("opengl32.dll", EntryPoint = "glFogx")]
        public static extern void Fogx(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogxv")]
        public static extern void Fogxv(uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glFrustumx")]
        public static extern void Frustumx(int l, int r, int b, int t, int n, int f);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBooleanv(uint pname, byte* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetClipPlanex")]
        public static extern void GetClipPlanex(uint plane, int* equation);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        public static extern uint GetError();
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFixedv")]
        public static extern void GetFixedv(uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetIntegerv(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetLightxv")]
        public static extern void GetLightxv(uint light, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMaterialxv")]
        public static extern void GetMaterialxv(uint face, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPointerv")]
        public static extern void GetPointerv(uint pname, void** parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetString")]
        public static extern byte* GetString(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnviv")]
        public static extern void GetTexEnviv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnvxv")]
        public static extern void GetTexEnvxv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterxv")]
        public static extern void GetTexParameterxv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        public static extern void Hint(uint target, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsBuffer")]
        public static extern byte IsBuffer(uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabled")]
        public static extern byte IsEnabled(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsTexture")]
        public static extern byte IsTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModelx")]
        public static extern void LightModelx(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModelxv")]
        public static extern void LightModelxv(uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightx")]
        public static extern void Lightx(uint light, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightxv")]
        public static extern void Lightxv(uint light, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLineWidthx")]
        public static extern void LineWidthx(int width);
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixx")]
        public static extern void LoadMatrixx(int* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glLogicOp")]
        public static extern void LogicOp(uint opcode);
        
        [DllImport("opengl32.dll", EntryPoint = "glMaterialx")]
        public static extern void Materialx(uint face, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glMaterialxv")]
        public static extern void Materialxv(uint face, uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixx")]
        public static extern void MultMatrixx(int* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4x")]
        public static extern void MultiTexCoord4x(uint texture, int s, int t, int r, int q);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3x")]
        public static extern void Normal3x(int nx, int ny, int nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormalPointer")]
        public static extern void NormalPointer(uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glOrthox")]
        public static extern void Orthox(int l, int r, int b, int t, int n, int f);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStorei(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameterx")]
        public static extern void PointParameterx(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameterxv")]
        public static extern void PointParameterxv(uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointSizex")]
        public static extern void PointSizex(int size);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetx")]
        public static extern void PolygonOffsetx(int factor, int units);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();
        
        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();
        
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glRotatex")]
        public static extern void Rotatex(int angle, int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(float value, byte invert);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleCoveragex")]
        public static extern void SampleCoveragex(int value, byte invert);
        
        [DllImport("opengl32.dll", EntryPoint = "glScalex")]
        public static extern void Scalex(int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glShadeModel")]
        public static extern void ShadeModel(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(uint func, int reference, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(uint fail, uint zfail, uint zpass);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordPointer")]
        public static extern void TexCoordPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvi")]
        public static extern void TexEnvi(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvx")]
        public static extern void TexEnvx(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnviv")]
        public static extern void TexEnviv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvxv")]
        public static extern void TexEnvxv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameteri(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterx")]
        public static extern void TexParameterx(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteriv")]
        public static extern void TexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterxv")]
        public static extern void TexParameterxv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTranslatex")]
        public static extern void Translatex(int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexPointer")]
        public static extern void VertexPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(int x, int y, int width, int height);
        
    }
}
