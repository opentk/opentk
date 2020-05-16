using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class EXT
    {
        public unsafe static partial class _422Pixels
        {
        }
        public unsafe static partial class EglImageStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetTexStorageEXT")]
            public static extern void GlEGLImageTargetTexStorage(uint target, void* image, int* attrib_list);
            
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetTextureStorageEXT")]
            public static extern void GlEGLImageTargetTextureStorage(uint texture, void* image, int* attrib_list);
            
        }
        public unsafe static partial class EglSync
        {
        }
        public unsafe static partial class Abgr
        {
        }
        public unsafe static partial class Bgra
        {
        }
        public unsafe static partial class BindableUniform
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniformBufferEXT")]
            public static extern void GlUniformBuffer(uint program, int location, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformBufferSizeEXT")]
            public static extern int GlGetUniformBufferSize(uint program, int location);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformOffsetEXT")]
            public static extern IntPtr GlGetUniformOffset(uint program, int location);
            
        }
        public unsafe static partial class BlendColor
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendColorEXT")]
            public static extern void GlBlendColor(float red, float green, float blue, float alpha);
            
        }
        public unsafe static partial class BlendEquationSeparate
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateEXT")]
            public static extern void GlBlendEquationSeparate(uint modeRGB, uint modeAlpha);
            
        }
        public unsafe static partial class BlendFuncSeparate
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateEXT")]
            public static extern void GlBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
            
        }
        public unsafe static partial class BlendLogicOp
        {
        }
        public unsafe static partial class BlendMinmax
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationEXT")]
            public static extern void GlBlendEquation(uint mode);
            
        }
        public unsafe static partial class BlendSubtract
        {
        }
        public unsafe static partial class ClipVolumeHint
        {
        }
        public unsafe static partial class Cmyka
        {
        }
        public unsafe static partial class ColorSubtable
        {
            [DllImport("opengl32.dll", EntryPoint = "glColorSubTableEXT")]
            public static extern void GlColorSubTable(uint target, int start, int count, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyColorSubTableEXT")]
            public static extern void GlCopyColorSubTable(uint target, int start, int x, int y, int width);
            
        }
        public unsafe static partial class CompiledVertexArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glLockArraysEXT")]
            public static extern void GlLockArrays(int first, int count);
            
            [DllImport("opengl32.dll", EntryPoint = "glUnlockArraysEXT")]
            public static extern void GlUnlockArrays();
            
        }
        public unsafe static partial class Convolution
        {
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionFilter1DEXT")]
            public static extern void GlConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionFilter2DEXT")]
            public static extern void GlConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameterfEXT")]
            public static extern void GlConvolutionParameterf(uint target, uint pname, float parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameterfvEXT")]
            public static extern void GlConvolutionParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameteriEXT")]
            public static extern void GlConvolutionParameteri(uint target, uint pname, int parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameterivEXT")]
            public static extern void GlConvolutionParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyConvolutionFilter1DEXT")]
            public static extern void GlCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyConvolutionFilter2DEXT")]
            public static extern void GlCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetConvolutionFilterEXT")]
            public static extern void GlGetConvolutionFilter(uint target, uint format, uint type, void* image);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetConvolutionParameterfvEXT")]
            public static extern void GlGetConvolutionParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetConvolutionParameterivEXT")]
            public static extern void GlGetConvolutionParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSeparableFilterEXT")]
            public static extern void GlGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);
            
            [DllImport("opengl32.dll", EntryPoint = "glSeparableFilter2DEXT")]
            public static extern void GlSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);
            
        }
        public unsafe static partial class CoordinateFrame
        {
            [DllImport("opengl32.dll", EntryPoint = "glTangent3bEXT")]
            public static extern void GlTangent3b(sbyte tx, sbyte ty, sbyte tz);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3bvEXT")]
            public static extern void GlTangent3bv(sbyte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3dEXT")]
            public static extern void GlTangent3d(double tx, double ty, double tz);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3dvEXT")]
            public static extern void GlTangent3dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3fEXT")]
            public static extern void GlTangent3f(float tx, float ty, float tz);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3fvEXT")]
            public static extern void GlTangent3fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3iEXT")]
            public static extern void GlTangent3i(int tx, int ty, int tz);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3ivEXT")]
            public static extern void GlTangent3iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3sEXT")]
            public static extern void GlTangent3s(short tx, short ty, short tz);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangent3svEXT")]
            public static extern void GlTangent3sv(short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3bEXT")]
            public static extern void GlBinormal3b(sbyte bx, sbyte by, sbyte bz);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3bvEXT")]
            public static extern void GlBinormal3bv(sbyte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3dEXT")]
            public static extern void GlBinormal3d(double bx, double by, double bz);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3dvEXT")]
            public static extern void GlBinormal3dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3fEXT")]
            public static extern void GlBinormal3f(float bx, float by, float bz);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3fvEXT")]
            public static extern void GlBinormal3fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3iEXT")]
            public static extern void GlBinormal3i(int bx, int by, int bz);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3ivEXT")]
            public static extern void GlBinormal3iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3sEXT")]
            public static extern void GlBinormal3s(short bx, short by, short bz);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormal3svEXT")]
            public static extern void GlBinormal3sv(short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTangentPointerEXT")]
            public static extern void GlTangentPointer(uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBinormalPointerEXT")]
            public static extern void GlBinormalPointer(uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class CopyTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage1DEXT")]
            public static extern void GlCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage2DEXT")]
            public static extern void GlCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage1DEXT")]
            public static extern void GlCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage2DEXT")]
            public static extern void GlCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage3DEXT")]
            public static extern void GlCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            
        }
        public unsafe static partial class CullVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glCullParameterdvEXT")]
            public static extern void GlCullParameterdv(uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCullParameterfvEXT")]
            public static extern void GlCullParameterfv(uint pname, float* parameters);
            
        }
        public unsafe static partial class DebugLabel
        {
            [DllImport("opengl32.dll", EntryPoint = "glLabelObjectEXT")]
            public static extern void GlLabelObject(uint type, uint obj, int length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectLabelEXT")]
            public static extern void GlGetObjectLabel(uint type, uint obj, int bufSize, int* length, char* label);
            
        }
        public unsafe static partial class DebugMarker
        {
            [DllImport("opengl32.dll", EntryPoint = "glInsertEventMarkerEXT")]
            public static extern void GlInsertEventMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPushGroupMarkerEXT")]
            public static extern void GlPushGroupMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPopGroupMarkerEXT")]
            public static extern void GlPopGroupMarker();
            
        }
        public unsafe static partial class DepthBoundsTest
        {
            [DllImport("opengl32.dll", EntryPoint = "glDepthBoundsEXT")]
            public static extern void GlDepthBounds(double zmin, double zmax);
            
        }
        public unsafe static partial class DirectStateAccess
        {
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadfEXT")]
            public static extern void GlMatrixLoadf(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoaddEXT")]
            public static extern void GlMatrixLoadd(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultfEXT")]
            public static extern void GlMatrixMultf(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultdEXT")]
            public static extern void GlMatrixMultd(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadIdentityEXT")]
            public static extern void GlMatrixLoadIdentity(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixRotatefEXT")]
            public static extern void GlMatrixRotatef(uint mode, float angle, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixRotatedEXT")]
            public static extern void GlMatrixRotated(uint mode, double angle, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixScalefEXT")]
            public static extern void GlMatrixScalef(uint mode, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixScaledEXT")]
            public static extern void GlMatrixScaled(uint mode, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixTranslatefEXT")]
            public static extern void GlMatrixTranslatef(uint mode, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixTranslatedEXT")]
            public static extern void GlMatrixTranslated(uint mode, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixFrustumEXT")]
            public static extern void GlMatrixFrustum(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixOrthoEXT")]
            public static extern void GlMatrixOrtho(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixPopEXT")]
            public static extern void GlMatrixPop(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixPushEXT")]
            public static extern void GlMatrixPush(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glClientAttribDefaultEXT")]
            public static extern void GlClientAttribDefault(uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glPushClientAttribDefaultEXT")]
            public static extern void GlPushClientAttribDefault(uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterfEXT")]
            public static extern void GlTextureParameterf(uint texture, uint target, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterfvEXT")]
            public static extern void GlTextureParameterfv(uint texture, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameteriEXT")]
            public static extern void GlTextureParameteri(uint texture, uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterivEXT")]
            public static extern void GlTextureParameteriv(uint texture, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage1DEXT")]
            public static extern void GlTextureImage1D(uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage2DEXT")]
            public static extern void GlTextureImage2D(uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage1DEXT")]
            public static extern void GlTextureSubImage1D(uint texture, uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage2DEXT")]
            public static extern void GlTextureSubImage2D(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureImage1DEXT")]
            public static extern void GlCopyTextureImage1D(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureImage2DEXT")]
            public static extern void GlCopyTextureImage2D(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage1DEXT")]
            public static extern void GlCopyTextureSubImage1D(uint texture, uint target, int level, int xoffset, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage2DEXT")]
            public static extern void GlCopyTextureSubImage2D(uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureImageEXT")]
            public static extern void GlGetTextureImage(uint texture, uint target, int level, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterfvEXT")]
            public static extern void GlGetTextureParameterfv(uint texture, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterivEXT")]
            public static extern void GlGetTextureParameteriv(uint texture, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureLevelParameterfvEXT")]
            public static extern void GlGetTextureLevelParameterfv(uint texture, uint target, int level, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureLevelParameterivEXT")]
            public static extern void GlGetTextureLevelParameteriv(uint texture, uint target, int level, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage3DEXT")]
            public static extern void GlTextureImage3D(uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage3DEXT")]
            public static extern void GlTextureSubImage3D(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage3DEXT")]
            public static extern void GlCopyTextureSubImage3D(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindMultiTextureEXT")]
            public static extern void GlBindMultiTexture(uint texunit, uint target, uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordPointerEXT")]
            public static extern void GlMultiTexCoordPointer(uint texunit, int size, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexEnvfEXT")]
            public static extern void GlMultiTexEnvf(uint texunit, uint target, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexEnvfvEXT")]
            public static extern void GlMultiTexEnvfv(uint texunit, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexEnviEXT")]
            public static extern void GlMultiTexEnvi(uint texunit, uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexEnvivEXT")]
            public static extern void GlMultiTexEnviv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGendEXT")]
            public static extern void GlMultiTexGend(uint texunit, uint coord, uint pname, double param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGendvEXT")]
            public static extern void GlMultiTexGendv(uint texunit, uint coord, uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGenfEXT")]
            public static extern void GlMultiTexGenf(uint texunit, uint coord, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGenfvEXT")]
            public static extern void GlMultiTexGenfv(uint texunit, uint coord, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGeniEXT")]
            public static extern void GlMultiTexGeni(uint texunit, uint coord, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexGenivEXT")]
            public static extern void GlMultiTexGeniv(uint texunit, uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexEnvfvEXT")]
            public static extern void GlGetMultiTexEnvfv(uint texunit, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexEnvivEXT")]
            public static extern void GlGetMultiTexEnviv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexGendvEXT")]
            public static extern void GlGetMultiTexGendv(uint texunit, uint coord, uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexGenfvEXT")]
            public static extern void GlGetMultiTexGenfv(uint texunit, uint coord, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexGenivEXT")]
            public static extern void GlGetMultiTexGeniv(uint texunit, uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameteriEXT")]
            public static extern void GlMultiTexParameteri(uint texunit, uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameterivEXT")]
            public static extern void GlMultiTexParameteriv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameterfEXT")]
            public static extern void GlMultiTexParameterf(uint texunit, uint target, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameterfvEXT")]
            public static extern void GlMultiTexParameterfv(uint texunit, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexImage1DEXT")]
            public static extern void GlMultiTexImage1D(uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexImage2DEXT")]
            public static extern void GlMultiTexImage2D(uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexSubImage1DEXT")]
            public static extern void GlMultiTexSubImage1D(uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexSubImage2DEXT")]
            public static extern void GlMultiTexSubImage2D(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyMultiTexImage1DEXT")]
            public static extern void GlCopyMultiTexImage1D(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyMultiTexImage2DEXT")]
            public static extern void GlCopyMultiTexImage2D(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyMultiTexSubImage1DEXT")]
            public static extern void GlCopyMultiTexSubImage1D(uint texunit, uint target, int level, int xoffset, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyMultiTexSubImage2DEXT")]
            public static extern void GlCopyMultiTexSubImage2D(uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexImageEXT")]
            public static extern void GlGetMultiTexImage(uint texunit, uint target, int level, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexParameterfvEXT")]
            public static extern void GlGetMultiTexParameterfv(uint texunit, uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexParameterivEXT")]
            public static extern void GlGetMultiTexParameteriv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
            public static extern void GlGetMultiTexLevelParameterfv(uint texunit, uint target, int level, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexLevelParameterivEXT")]
            public static extern void GlGetMultiTexLevelParameteriv(uint texunit, uint target, int level, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexImage3DEXT")]
            public static extern void GlMultiTexImage3D(uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexSubImage3DEXT")]
            public static extern void GlMultiTexSubImage3D(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyMultiTexSubImage3DEXT")]
            public static extern void GlCopyMultiTexSubImage3D(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableClientStateIndexedEXT")]
            public static extern void GlEnableClientStateIndexed(uint array, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableClientStateIndexedEXT")]
            public static extern void GlDisableClientStateIndexed(uint array, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFloatIndexedvEXT")]
            public static extern void GlGetFloatIndexedv(uint target, uint index, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDoubleIndexedvEXT")]
            public static extern void GlGetDoubleIndexedv(uint target, uint index, double* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPointerIndexedvEXT")]
            public static extern void GlGetPointerIndexedv(uint target, uint index, void** data);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableIndexedEXT")]
            public static extern void GlEnableIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableIndexedEXT")]
            public static extern void GlDisableIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnabledIndexedEXT")]
            public static extern byte GlIsEnabledIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegerIndexedvEXT")]
            public static extern void GlGetIntegerIndexedv(uint target, uint index, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetBooleanIndexedvEXT")]
            public static extern void GlGetBooleanIndexedv(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureImage3DEXT")]
            public static extern void GlCompressedTextureImage3D(uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureImage2DEXT")]
            public static extern void GlCompressedTextureImage2D(uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureImage1DEXT")]
            public static extern void GlCompressedTextureImage1D(uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage3DEXT")]
            public static extern void GlCompressedTextureSubImage3D(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage2DEXT")]
            public static extern void GlCompressedTextureSubImage2D(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage1DEXT")]
            public static extern void GlCompressedTextureSubImage1D(uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCompressedTextureImageEXT")]
            public static extern void GlGetCompressedTextureImage(uint texture, uint target, int lod, void* img);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexImage3DEXT")]
            public static extern void GlCompressedMultiTexImage3D(uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexImage2DEXT")]
            public static extern void GlCompressedMultiTexImage2D(uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexImage1DEXT")]
            public static extern void GlCompressedMultiTexImage1D(uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
            public static extern void GlCompressedMultiTexSubImage3D(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
            public static extern void GlCompressedMultiTexSubImage2D(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
            public static extern void GlCompressedMultiTexSubImage1D(uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, void* bits);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCompressedMultiTexImageEXT")]
            public static extern void GlGetCompressedMultiTexImage(uint texunit, uint target, int lod, void* img);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadTransposefEXT")]
            public static extern void GlMatrixLoadTransposef(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadTransposedEXT")]
            public static extern void GlMatrixLoadTransposed(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultTransposefEXT")]
            public static extern void GlMatrixMultTransposef(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultTransposedEXT")]
            public static extern void GlMatrixMultTransposed(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferDataEXT")]
            public static extern void GlNamedBufferData(uint buffer, IntPtr size, void* data, uint usage);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferSubDataEXT")]
            public static extern void GlNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapNamedBufferEXT")]
            public static extern void* GlMapNamedBuffer(uint buffer, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glUnmapNamedBufferEXT")]
            public static extern byte GlUnmapNamedBuffer(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferParameterivEXT")]
            public static extern void GlGetNamedBufferParameteriv(uint buffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferPointervEXT")]
            public static extern void GlGetNamedBufferPointerv(uint buffer, uint pname, void** parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferSubDataEXT")]
            public static extern void GlGetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fEXT")]
            public static extern void GlProgramUniform1f(uint program, int location, float v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fEXT")]
            public static extern void GlProgramUniform2f(uint program, int location, float v0, float v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fEXT")]
            public static extern void GlProgramUniform3f(uint program, int location, float v0, float v1, float v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fEXT")]
            public static extern void GlProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1iEXT")]
            public static extern void GlProgramUniform1i(uint program, int location, int v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2iEXT")]
            public static extern void GlProgramUniform2i(uint program, int location, int v0, int v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3iEXT")]
            public static extern void GlProgramUniform3i(uint program, int location, int v0, int v1, int v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4iEXT")]
            public static extern void GlProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fvEXT")]
            public static extern void GlProgramUniform1fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fvEXT")]
            public static extern void GlProgramUniform2fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fvEXT")]
            public static extern void GlProgramUniform3fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fvEXT")]
            public static extern void GlProgramUniform4fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ivEXT")]
            public static extern void GlProgramUniform1iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ivEXT")]
            public static extern void GlProgramUniform2iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ivEXT")]
            public static extern void GlProgramUniform3iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ivEXT")]
            public static extern void GlProgramUniform4iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2fvEXT")]
            public static extern void GlProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3fvEXT")]
            public static extern void GlProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4fvEXT")]
            public static extern void GlProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
            public static extern void GlProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
            public static extern void GlProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
            public static extern void GlProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
            public static extern void GlProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
            public static extern void GlProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
            public static extern void GlProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureBufferEXT")]
            public static extern void GlTextureBuffer(uint texture, uint target, uint internalformat, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexBufferEXT")]
            public static extern void GlMultiTexBuffer(uint texunit, uint target, uint internalformat, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterIivEXT")]
            public static extern void GlTextureParameterIiv(uint texture, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterIuivEXT")]
            public static extern void GlTextureParameterIuiv(uint texture, uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterIivEXT")]
            public static extern void GlGetTextureParameterIiv(uint texture, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterIuivEXT")]
            public static extern void GlGetTextureParameterIuiv(uint texture, uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameterIivEXT")]
            public static extern void GlMultiTexParameterIiv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexParameterIuivEXT")]
            public static extern void GlMultiTexParameterIuiv(uint texunit, uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexParameterIivEXT")]
            public static extern void GlGetMultiTexParameterIiv(uint texunit, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultiTexParameterIuivEXT")]
            public static extern void GlGetMultiTexParameterIuiv(uint texunit, uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uiEXT")]
            public static extern void GlProgramUniform1ui(uint program, int location, uint v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uiEXT")]
            public static extern void GlProgramUniform2ui(uint program, int location, uint v0, uint v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uiEXT")]
            public static extern void GlProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uiEXT")]
            public static extern void GlProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uivEXT")]
            public static extern void GlProgramUniform1uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uivEXT")]
            public static extern void GlProgramUniform2uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uivEXT")]
            public static extern void GlProgramUniform3uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uivEXT")]
            public static extern void GlProgramUniform4uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
            public static extern void GlNamedProgramLocalParameters4fv(uint program, uint target, uint index, int count, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameterI4iEXT")]
            public static extern void GlNamedProgramLocalParameterI4i(uint program, uint target, uint index, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
            public static extern void GlNamedProgramLocalParameterI4iv(uint program, uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
            public static extern void GlNamedProgramLocalParametersI4iv(uint program, uint target, uint index, int count, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameterI4uiEXT")]
            public static extern void GlNamedProgramLocalParameterI4ui(uint program, uint target, uint index, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
            public static extern void GlNamedProgramLocalParameterI4uiv(uint program, uint target, uint index, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
            public static extern void GlNamedProgramLocalParametersI4uiv(uint program, uint target, uint index, int count, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
            public static extern void GlGetNamedProgramLocalParameterIiv(uint program, uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
            public static extern void GlGetNamedProgramLocalParameterIuiv(uint program, uint target, uint index, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableClientStateiEXT")]
            public static extern void GlEnableClientStatei(uint array, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableClientStateiEXT")]
            public static extern void GlDisableClientStatei(uint array, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFloati_vEXT")]
            public static extern void GlGetFloati_v(uint pname, uint index, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDoublei_vEXT")]
            public static extern void GlGetDoublei_v(uint pname, uint index, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPointeri_vEXT")]
            public static extern void GlGetPointeri_v(uint pname, uint index, void** parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramStringEXT")]
            public static extern void GlNamedProgramString(uint program, uint target, uint format, int len, void* str);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameter4dEXT")]
            public static extern void GlNamedProgramLocalParameter4d(uint program, uint target, uint index, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
            public static extern void GlNamedProgramLocalParameter4dv(uint program, uint target, uint index, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameter4fEXT")]
            public static extern void GlNamedProgramLocalParameter4f(uint program, uint target, uint index, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
            public static extern void GlNamedProgramLocalParameter4fv(uint program, uint target, uint index, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
            public static extern void GlGetNamedProgramLocalParameterdv(uint program, uint target, uint index, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
            public static extern void GlGetNamedProgramLocalParameterfv(uint program, uint target, uint index, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramivEXT")]
            public static extern void GlGetNamedProgramiv(uint program, uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedProgramStringEXT")]
            public static extern void GlGetNamedProgramString(uint program, uint target, uint pname, void* str);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageEXT")]
            public static extern void GlNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
            public static extern void GlGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageMultisampleEXT")]
            public static extern void GlNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
            public static extern void GlNamedRenderbufferStorageMultisampleCoverage(uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glCheckNamedFramebufferStatusEXT")]
            public static extern uint GlCheckNamedFramebufferStatus(uint framebuffer, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTexture1DEXT")]
            public static extern void GlNamedFramebufferTexture1D(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTexture2DEXT")]
            public static extern void GlNamedFramebufferTexture2D(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTexture3DEXT")]
            public static extern void GlNamedFramebufferTexture3D(uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferRenderbufferEXT")]
            public static extern void GlNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
            public static extern void GlGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateTextureMipmapEXT")]
            public static extern void GlGenerateTextureMipmap(uint texture, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateMultiTexMipmapEXT")]
            public static extern void GlGenerateMultiTexMipmap(uint texunit, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferDrawBufferEXT")]
            public static extern void GlFramebufferDrawBuffer(uint framebuffer, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferDrawBuffersEXT")]
            public static extern void GlFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferReadBufferEXT")]
            public static extern void GlFramebufferReadBuffer(uint framebuffer, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameterivEXT")]
            public static extern void GlGetFramebufferParameteriv(uint framebuffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedCopyBufferSubDataEXT")]
            public static extern void GlNamedCopyBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTextureEXT")]
            public static extern void GlNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTextureLayerEXT")]
            public static extern void GlNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTextureFaceEXT")]
            public static extern void GlNamedFramebufferTextureFace(uint framebuffer, uint attachment, uint texture, int level, uint face);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureRenderbufferEXT")]
            public static extern void GlTextureRenderbuffer(uint texture, uint target, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexRenderbufferEXT")]
            public static extern void GlMultiTexRenderbuffer(uint texunit, uint target, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexOffsetEXT")]
            public static extern void GlVertexArrayVertexOffset(uint vaobj, uint buffer, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayColorOffsetEXT")]
            public static extern void GlVertexArrayColorOffset(uint vaobj, uint buffer, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayEdgeFlagOffsetEXT")]
            public static extern void GlVertexArrayEdgeFlagOffset(uint vaobj, uint buffer, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayIndexOffsetEXT")]
            public static extern void GlVertexArrayIndexOffset(uint vaobj, uint buffer, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayNormalOffsetEXT")]
            public static extern void GlVertexArrayNormalOffset(uint vaobj, uint buffer, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayTexCoordOffsetEXT")]
            public static extern void GlVertexArrayTexCoordOffset(uint vaobj, uint buffer, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT")]
            public static extern void GlVertexArrayMultiTexCoordOffset(uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayFogCoordOffsetEXT")]
            public static extern void GlVertexArrayFogCoordOffset(uint vaobj, uint buffer, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArraySecondaryColorOffsetEXT")]
            public static extern void GlVertexArraySecondaryColorOffset(uint vaobj, uint buffer, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribOffsetEXT")]
            public static extern void GlVertexArrayVertexAttribOffset(uint vaobj, uint buffer, uint index, int size, uint type, byte normalized, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribIOffsetEXT")]
            public static extern void GlVertexArrayVertexAttribIOffset(uint vaobj, uint buffer, uint index, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableVertexArrayEXT")]
            public static extern void GlEnableVertexArray(uint vaobj, uint array);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableVertexArrayEXT")]
            public static extern void GlDisableVertexArray(uint vaobj, uint array);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableVertexArrayAttribEXT")]
            public static extern void GlEnableVertexArrayAttrib(uint vaobj, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableVertexArrayAttribEXT")]
            public static extern void GlDisableVertexArrayAttrib(uint vaobj, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayIntegervEXT")]
            public static extern void GlGetVertexArrayIntegerv(uint vaobj, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayPointervEXT")]
            public static extern void GlGetVertexArrayPointerv(uint vaobj, uint pname, void** param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
            public static extern void GlGetVertexArrayIntegeri_v(uint vaobj, uint index, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayPointeri_vEXT")]
            public static extern void GlGetVertexArrayPointeri_v(uint vaobj, uint index, uint pname, void** param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapNamedBufferRangeEXT")]
            public static extern void* GlMapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedNamedBufferRangeEXT")]
            public static extern void GlFlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorageEXT")]
            public static extern void GlNamedBufferStorage(uint buffer, IntPtr size, void* data, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedBufferDataEXT")]
            public static extern void GlClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedBufferSubDataEXT")]
            public static extern void GlClearNamedBufferSubData(uint buffer, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferParameteriEXT")]
            public static extern void GlNamedFramebufferParameteri(uint framebuffer, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedFramebufferParameterivEXT")]
            public static extern void GlGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1dEXT")]
            public static extern void GlProgramUniform1d(uint program, int location, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2dEXT")]
            public static extern void GlProgramUniform2d(uint program, int location, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3dEXT")]
            public static extern void GlProgramUniform3d(uint program, int location, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4dEXT")]
            public static extern void GlProgramUniform4d(uint program, int location, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1dvEXT")]
            public static extern void GlProgramUniform1dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2dvEXT")]
            public static extern void GlProgramUniform2dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3dvEXT")]
            public static extern void GlProgramUniform3dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4dvEXT")]
            public static extern void GlProgramUniform4dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2dvEXT")]
            public static extern void GlProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3dvEXT")]
            public static extern void GlProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4dvEXT")]
            public static extern void GlProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3dvEXT")]
            public static extern void GlProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4dvEXT")]
            public static extern void GlProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2dvEXT")]
            public static extern void GlProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4dvEXT")]
            public static extern void GlProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2dvEXT")]
            public static extern void GlProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3dvEXT")]
            public static extern void GlProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureBufferRangeEXT")]
            public static extern void GlTextureBufferRange(uint texture, uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage1DEXT")]
            public static extern void GlTextureStorage1D(uint texture, uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2DEXT")]
            public static extern void GlTextureStorage2D(uint texture, uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3DEXT")]
            public static extern void GlTextureStorage3D(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2DMultisampleEXT")]
            public static extern void GlTextureStorage2DMultisample(uint texture, uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3DMultisampleEXT")]
            public static extern void GlTextureStorage3DMultisample(uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayBindVertexBufferEXT")]
            public static extern void GlVertexArrayBindVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribFormatEXT")]
            public static extern void GlVertexArrayVertexAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribIFormatEXT")]
            public static extern void GlVertexArrayVertexAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribLFormatEXT")]
            public static extern void GlVertexArrayVertexAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribBindingEXT")]
            public static extern void GlVertexArrayVertexAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexBindingDivisorEXT")]
            public static extern void GlVertexArrayVertexBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribLOffsetEXT")]
            public static extern void GlVertexArrayVertexAttribLOffset(uint vaobj, uint buffer, uint index, int size, uint type, int stride, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexturePageCommitmentEXT")]
            public static extern void GlTexturePageCommitment(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexAttribDivisorEXT")]
            public static extern void GlVertexArrayVertexAttribDivisor(uint vaobj, uint index, uint divisor);
            
        }
        public unsafe static partial class DrawBuffers2
        {
            [DllImport("opengl32.dll", EntryPoint = "glColorMaskIndexedEXT")]
            public static extern void GlColorMaskIndexed(uint index, byte r, byte g, byte b, byte a);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetBooleanIndexedvEXT")]
            public static extern void GlGetBooleanIndexedv(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegerIndexedvEXT")]
            public static extern void GlGetIntegerIndexedv(uint target, uint index, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableIndexedEXT")]
            public static extern void GlEnableIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableIndexedEXT")]
            public static extern void GlDisableIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnabledIndexedEXT")]
            public static extern byte GlIsEnabledIndexed(uint target, uint index);
            
        }
        public unsafe static partial class DrawInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedEXT")]
            public static extern void GlDrawArraysInstanced(uint mode, int start, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedEXT")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
        }
        public unsafe static partial class DrawRangeElements
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsEXT")]
            public static extern void GlDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
            
        }
        public unsafe static partial class ExternalBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorageExternalEXT")]
            public static extern void GlBufferStorageExternal(uint target, IntPtr offset, IntPtr size, void* clientBuffer, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorageExternalEXT")]
            public static extern void GlNamedBufferStorageExternal(uint buffer, IntPtr offset, IntPtr size, void* clientBuffer, uint flags);
            
        }
        public unsafe static partial class FogCoord
        {
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordfEXT")]
            public static extern void GlFogCoordf(float coord);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordfvEXT")]
            public static extern void GlFogCoordfv(float* coord);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoorddEXT")]
            public static extern void GlFogCoordd(double coord);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoorddvEXT")]
            public static extern void GlFogCoorddv(double* coord);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordPointerEXT")]
            public static extern void GlFogCoordPointer(uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class FramebufferBlit
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlitFramebufferEXT")]
            public static extern void GlBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
        }
        public unsafe static partial class FramebufferMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class FramebufferMultisampleBlitScaled
        {
        }
        public unsafe static partial class FramebufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glIsRenderbufferEXT")]
            public static extern byte GlIsRenderbuffer(uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindRenderbufferEXT")]
            public static extern void GlBindRenderbuffer(uint target, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteRenderbuffersEXT")]
            public static extern void GlDeleteRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenRenderbuffersEXT")]
            public static extern void GlGenRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageEXT")]
            public static extern void GlRenderbufferStorage(uint target, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameterivEXT")]
            public static extern void GlGetRenderbufferParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFramebufferEXT")]
            public static extern byte GlIsFramebuffer(uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFramebufferEXT")]
            public static extern void GlBindFramebuffer(uint target, uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFramebuffersEXT")]
            public static extern void GlDeleteFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenFramebuffersEXT")]
            public static extern void GlGenFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glCheckFramebufferStatusEXT")]
            public static extern uint GlCheckFramebufferStatus(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture1DEXT")]
            public static extern void GlFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DEXT")]
            public static extern void GlFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture3DEXT")]
            public static extern void GlFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferRenderbufferEXT")]
            public static extern void GlFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
            public static extern void GlGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateMipmapEXT")]
            public static extern void GlGenerateMipmap(uint target);
            
        }
        public unsafe static partial class FramebufferSrgb
        {
        }
        public unsafe static partial class GeometryShader4
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameteriEXT")]
            public static extern void GlProgramParameteri(uint program, uint pname, int value);
            
        }
        public unsafe static partial class GpuProgramParameters
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParameters4fvEXT")]
            public static extern void GlProgramEnvParameters4fv(uint target, uint index, int count, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParameters4fvEXT")]
            public static extern void GlProgramLocalParameters4fv(uint target, uint index, int count, float* parameters);
            
        }
        public unsafe static partial class GpuShader4
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformuivEXT")]
            public static extern void GlGetUniformuiv(uint program, int location, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocationEXT")]
            public static extern void GlBindFragDataLocation(uint program, uint color, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragDataLocationEXT")]
            public static extern int GlGetFragDataLocation(uint program, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1uiEXT")]
            public static extern void GlUniform1ui(int location, uint v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2uiEXT")]
            public static extern void GlUniform2ui(int location, uint v0, uint v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3uiEXT")]
            public static extern void GlUniform3ui(int location, uint v0, uint v1, uint v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4uiEXT")]
            public static extern void GlUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1uivEXT")]
            public static extern void GlUniform1uiv(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2uivEXT")]
            public static extern void GlUniform2uiv(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3uivEXT")]
            public static extern void GlUniform3uiv(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4uivEXT")]
            public static extern void GlUniform4uiv(int location, int count, uint* value);
            
        }
        public unsafe static partial class Histogram
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetHistogramEXT")]
            public static extern void GlGetHistogram(uint target, byte reset, uint format, uint type, void* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetHistogramParameterfvEXT")]
            public static extern void GlGetHistogramParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetHistogramParameterivEXT")]
            public static extern void GlGetHistogramParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMinmaxEXT")]
            public static extern void GlGetMinmax(uint target, byte reset, uint format, uint type, void* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMinmaxParameterfvEXT")]
            public static extern void GlGetMinmaxParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMinmaxParameterivEXT")]
            public static extern void GlGetMinmaxParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glHistogramEXT")]
            public static extern void GlHistogram(uint target, int width, uint internalformat, byte sink);
            
            [DllImport("opengl32.dll", EntryPoint = "glMinmaxEXT")]
            public static extern void GlMinmax(uint target, uint internalformat, byte sink);
            
            [DllImport("opengl32.dll", EntryPoint = "glResetHistogramEXT")]
            public static extern void GlResetHistogram(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glResetMinmaxEXT")]
            public static extern void GlResetMinmax(uint target);
            
        }
        public unsafe static partial class IndexArrayFormats
        {
        }
        public unsafe static partial class IndexFunc
        {
            [DllImport("opengl32.dll", EntryPoint = "glIndexFuncEXT")]
            public static extern void GlIndexFunc(uint func, float reference);
            
        }
        public unsafe static partial class IndexMaterial
        {
            [DllImport("opengl32.dll", EntryPoint = "glIndexMaterialEXT")]
            public static extern void GlIndexMaterial(uint face, uint mode);
            
        }
        public unsafe static partial class IndexTexture
        {
        }
        public unsafe static partial class LightTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glApplyTextureEXT")]
            public static extern void GlApplyTexture(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureLightEXT")]
            public static extern void GlTextureLight(uint pname);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureMaterialEXT")]
            public static extern void GlTextureMaterial(uint face, uint mode);
            
        }
        public unsafe static partial class MemoryObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytevEXT")]
            public static extern void GlGetUnsignedBytev(uint pname, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static extern void GlGetUnsignedBytei_v(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteMemoryObjectsEXT")]
            public static extern void GlDeleteMemoryObjects(int n, uint* memoryObjects);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsMemoryObjectEXT")]
            public static extern byte GlIsMemoryObject(uint memoryObject);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateMemoryObjectsEXT")]
            public static extern void GlCreateMemoryObjects(int n, uint* memoryObjects);
            
            [DllImport("opengl32.dll", EntryPoint = "glMemoryObjectParameterivEXT")]
            public static extern void GlMemoryObjectParameteriv(uint memoryObject, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMemoryObjectParameterivEXT")]
            public static extern void GlGetMemoryObjectParameteriv(uint memoryObject, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem2DEXT")]
            public static extern void GlTexStorageMem2D(uint target, int levels, uint internalFormat, int width, int height, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem2DMultisampleEXT")]
            public static extern void GlTexStorageMem2DMultisample(uint target, int samples, uint internalFormat, int width, int height, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem3DEXT")]
            public static extern void GlTexStorageMem3D(uint target, int levels, uint internalFormat, int width, int height, int depth, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem3DMultisampleEXT")]
            public static extern void GlTexStorageMem3DMultisample(uint target, int samples, uint internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorageMemEXT")]
            public static extern void GlBufferStorageMem(uint target, IntPtr size, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem2DEXT")]
            public static extern void GlTextureStorageMem2D(uint texture, int levels, uint internalFormat, int width, int height, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem2DMultisampleEXT")]
            public static extern void GlTextureStorageMem2DMultisample(uint texture, int samples, uint internalFormat, int width, int height, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem3DEXT")]
            public static extern void GlTextureStorageMem3D(uint texture, int levels, uint internalFormat, int width, int height, int depth, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem3DMultisampleEXT")]
            public static extern void GlTextureStorageMem3DMultisample(uint texture, int samples, uint internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorageMemEXT")]
            public static extern void GlNamedBufferStorageMem(uint buffer, IntPtr size, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem1DEXT")]
            public static extern void GlTexStorageMem1D(uint target, int levels, uint internalFormat, int width, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem1DEXT")]
            public static extern void GlTextureStorageMem1D(uint texture, int levels, uint internalFormat, int width, uint memory, uint offset);
            
        }
        public unsafe static partial class MemoryObjectFd
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryFdEXT")]
            public static extern void GlImportMemoryFd(uint memory, uint size, uint handleType, int fd);
            
        }
        public unsafe static partial class MemoryObjectWin32
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryWin32HandleEXT")]
            public static extern void GlImportMemoryWin32Handle(uint memory, uint size, uint handleType, void* handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryWin32NameEXT")]
            public static extern void GlImportMemoryWin32Name(uint memory, uint size, uint handleType, void* name);
            
        }
        public unsafe static partial class MiscAttribute
        {
        }
        public unsafe static partial class MultiDrawArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysEXT")]
            public static extern void GlMultiDrawArrays(uint mode, int* first, int* count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern void GlMultiDrawElements(uint mode, int* count, uint type, void** indices, int primcount);
            
        }
        public unsafe static partial class Multisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glSampleMaskEXT")]
            public static extern void GlSampleMask(float value, byte invert);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplePatternEXT")]
            public static extern void GlSamplePattern(uint pattern);
            
        }
        public unsafe static partial class MultiviewTessellationGeometryShader
        {
        }
        public unsafe static partial class MultiviewTextureMultisample
        {
        }
        public unsafe static partial class MultiviewTimerQuery
        {
        }
        public unsafe static partial class PackedDepthStencil
        {
        }
        public unsafe static partial class PackedFloat
        {
        }
        public unsafe static partial class PackedPixels
        {
        }
        public unsafe static partial class PalettedTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glColorTableEXT")]
            public static extern void GlColorTable(uint target, uint internalFormat, int width, uint format, uint type, void* table);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableEXT")]
            public static extern void GlGetColorTable(uint target, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableParameterivEXT")]
            public static extern void GlGetColorTableParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableParameterfvEXT")]
            public static extern void GlGetColorTableParameterfv(uint target, uint pname, float* parameters);
            
        }
        public unsafe static partial class PixelBufferObject
        {
        }
        public unsafe static partial class PixelTransform
        {
            [DllImport("opengl32.dll", EntryPoint = "glPixelTransformParameteriEXT")]
            public static extern void GlPixelTransformParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTransformParameterfEXT")]
            public static extern void GlPixelTransformParameterf(uint target, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTransformParameterivEXT")]
            public static extern void GlPixelTransformParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTransformParameterfvEXT")]
            public static extern void GlPixelTransformParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPixelTransformParameterivEXT")]
            public static extern void GlGetPixelTransformParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPixelTransformParameterfvEXT")]
            public static extern void GlGetPixelTransformParameterfv(uint target, uint pname, float* parameters);
            
        }
        public unsafe static partial class PixelTransformColorTable
        {
        }
        public unsafe static partial class PointParameters
        {
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterfEXT")]
            public static extern void GlPointParameterf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterfvEXT")]
            public static extern void GlPointParameterfv(uint pname, float* parameters);
            
        }
        public unsafe static partial class PolygonOffset
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetEXT")]
            public static extern void GlPolygonOffset(float factor, float bias);
            
        }
        public unsafe static partial class PolygonOffsetClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetClampEXT")]
            public static extern void GlPolygonOffsetClamp(float factor, float units, float clamp);
            
        }
        public unsafe static partial class PostDepthCoverage
        {
        }
        public unsafe static partial class ProvokingVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glProvokingVertexEXT")]
            public static extern void GlProvokingVertex(uint mode);
            
        }
        public unsafe static partial class RasterMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRasterSamplesEXT")]
            public static extern void GlRasterSamples(uint samples, byte fixedsamplelocations);
            
        }
        public unsafe static partial class RescaleNormal
        {
        }
        public unsafe static partial class Semaphore
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytevEXT")]
            public static extern void GlGetUnsignedBytev(uint pname, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static extern void GlGetUnsignedBytei_v(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenSemaphoresEXT")]
            public static extern void GlGenSemaphores(int n, uint* semaphores);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteSemaphoresEXT")]
            public static extern void GlDeleteSemaphores(int n, uint* semaphores);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsSemaphoreEXT")]
            public static extern byte GlIsSemaphore(uint semaphore);
            
            [DllImport("opengl32.dll", EntryPoint = "glSemaphoreParameterui64vEXT")]
            public static extern void GlSemaphoreParameterui64v(uint semaphore, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSemaphoreParameterui64vEXT")]
            public static extern void GlGetSemaphoreParameterui64v(uint semaphore, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitSemaphoreEXT")]
            public static extern void GlWaitSemaphore(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* srcLayouts);
            
            [DllImport("opengl32.dll", EntryPoint = "glSignalSemaphoreEXT")]
            public static extern void GlSignalSemaphore(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* dstLayouts);
            
        }
        public unsafe static partial class SemaphoreFd
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreFdEXT")]
            public static extern void GlImportSemaphoreFd(uint semaphore, uint handleType, int fd);
            
        }
        public unsafe static partial class SemaphoreWin32
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreWin32HandleEXT")]
            public static extern void GlImportSemaphoreWin32Handle(uint semaphore, uint handleType, void* handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreWin32NameEXT")]
            public static extern void GlImportSemaphoreWin32Name(uint semaphore, uint handleType, void* name);
            
        }
        public unsafe static partial class SecondaryColor
        {
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3bEXT")]
            public static extern void GlSecondaryColor3b(sbyte red, sbyte green, sbyte blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3bvEXT")]
            public static extern void GlSecondaryColor3bv(sbyte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3dEXT")]
            public static extern void GlSecondaryColor3d(double red, double green, double blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3dvEXT")]
            public static extern void GlSecondaryColor3dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3fEXT")]
            public static extern void GlSecondaryColor3f(float red, float green, float blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3fvEXT")]
            public static extern void GlSecondaryColor3fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3iEXT")]
            public static extern void GlSecondaryColor3i(int red, int green, int blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ivEXT")]
            public static extern void GlSecondaryColor3iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3sEXT")]
            public static extern void GlSecondaryColor3s(short red, short green, short blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3svEXT")]
            public static extern void GlSecondaryColor3sv(short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ubEXT")]
            public static extern void GlSecondaryColor3ub(byte red, byte green, byte blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ubvEXT")]
            public static extern void GlSecondaryColor3ubv(byte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3uiEXT")]
            public static extern void GlSecondaryColor3ui(uint red, uint green, uint blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3uivEXT")]
            public static extern void GlSecondaryColor3uiv(uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3usEXT")]
            public static extern void GlSecondaryColor3us(ushort red, ushort green, ushort blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3usvEXT")]
            public static extern void GlSecondaryColor3usv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorPointerEXT")]
            public static extern void GlSecondaryColorPointer(int size, uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class SeparateShaderObjects
        {
            [DllImport("opengl32.dll", EntryPoint = "glUseShaderProgramEXT")]
            public static extern void GlUseShaderProgram(uint type, uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glActiveProgramEXT")]
            public static extern void GlActiveProgram(uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateShaderProgramEXT")]
            public static extern uint GlCreateShaderProgram(uint type, char* str);
            
        }
        public unsafe static partial class SeparateSpecularColor
        {
        }
        public unsafe static partial class ShaderFramebufferFetch
        {
        }
        public unsafe static partial class ShaderFramebufferFetchNonCoherent
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferFetchBarrierEXT")]
            public static extern void GlFramebufferFetchBarrier();
            
        }
        public unsafe static partial class ShaderImageLoadFormatted
        {
        }
        public unsafe static partial class ShaderImageLoadStore
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindImageTextureEXT")]
            public static extern void GlBindImageTexture(uint index, uint texture, int level, byte layered, int layer, uint access, int format);
            
            [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrierEXT")]
            public static extern void GlMemoryBarrier(uint barriers);
            
        }
        public unsafe static partial class ShaderIntegerMix
        {
        }
        public unsafe static partial class ShadowFuncs
        {
        }
        public unsafe static partial class SharedTexturePalette
        {
        }
        public unsafe static partial class SparseTexture2
        {
        }
        public unsafe static partial class StencilClearTag
        {
            [DllImport("opengl32.dll", EntryPoint = "glStencilClearTagEXT")]
            public static extern void GlStencilClearTag(int stencilTagBits, uint stencilClearTag);
            
        }
        public unsafe static partial class StencilTwoSide
        {
            [DllImport("opengl32.dll", EntryPoint = "glActiveStencilFaceEXT")]
            public static extern void GlActiveStencilFace(uint face);
            
        }
        public unsafe static partial class StencilWrap
        {
        }
        public unsafe static partial class Subtexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexSubImage1DEXT")]
            public static extern void GlTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexSubImage2DEXT")]
            public static extern void GlTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
            
        }
        public unsafe static partial class Texture
        {
        }
        public unsafe static partial class Texture3d
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexImage3DEXT")]
            public static extern void GlTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexSubImage3DEXT")]
            public static extern void GlTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
            
        }
        public unsafe static partial class TextureArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayerEXT")]
            public static extern void GlFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
            
        }
        public unsafe static partial class TextureBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferEXT")]
            public static extern void GlTexBuffer(uint target, uint internalformat, uint buffer);
            
        }
        public unsafe static partial class TextureCompressionLatc
        {
        }
        public unsafe static partial class TextureCompressionRgtc
        {
        }
        public unsafe static partial class TextureCompressionS3tc
        {
        }
        public unsafe static partial class TextureCubeMap
        {
        }
        public unsafe static partial class TextureEnvAdd
        {
        }
        public unsafe static partial class TextureEnvCombine
        {
        }
        public unsafe static partial class TextureEnvDot3
        {
        }
        public unsafe static partial class TextureFilterAnisotropic
        {
        }
        public unsafe static partial class TextureFilterMinmax
        {
        }
        public unsafe static partial class TextureInteger
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIivEXT")]
            public static extern void GlTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIuivEXT")]
            public static extern void GlTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIivEXT")]
            public static extern void GlGetTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIuivEXT")]
            public static extern void GlGetTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearColorIiEXT")]
            public static extern void GlClearColorIi(int red, int green, int blue, int alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearColorIuiEXT")]
            public static extern void GlClearColorIui(uint red, uint green, uint blue, uint alpha);
            
        }
        public unsafe static partial class TextureLodBias
        {
        }
        public unsafe static partial class TextureMirrorClamp
        {
        }
        public unsafe static partial class TextureObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glAreTexturesResidentEXT")]
            public static extern byte GlAreTexturesResident(int n, uint* textures, byte* residences);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindTextureEXT")]
            public static extern void GlBindTexture(uint target, uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteTexturesEXT")]
            public static extern void GlDeleteTextures(int n, uint* textures);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenTexturesEXT")]
            public static extern void GlGenTextures(int n, uint* textures);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsTextureEXT")]
            public static extern byte GlIsTexture(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glPrioritizeTexturesEXT")]
            public static extern void GlPrioritizeTextures(int n, uint* textures, float* priorities);
            
        }
        public unsafe static partial class TexturePerturbNormal
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureNormalEXT")]
            public static extern void GlTextureNormal(uint mode);
            
        }
        public unsafe static partial class TextureSrgb
        {
        }
        public unsafe static partial class TextureSrgbR8
        {
        }
        public unsafe static partial class TextureSrgbDecode
        {
        }
        public unsafe static partial class TextureSharedExponent
        {
        }
        public unsafe static partial class TextureSnorm
        {
        }
        public unsafe static partial class TextureSwizzle
        {
        }
        public unsafe static partial class TimerQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjecti64vEXT")]
            public static extern void GlGetQueryObjecti64v(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectui64vEXT")]
            public static extern void GlGetQueryObjectui64v(uint id, uint pname, uint* parameters);
            
        }
        public unsafe static partial class TransformFeedback
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginTransformFeedbackEXT")]
            public static extern void GlBeginTransformFeedback(uint primitiveMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndTransformFeedbackEXT")]
            public static extern void GlEndTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferRangeEXT")]
            public static extern void GlBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferOffsetEXT")]
            public static extern void GlBindBufferOffset(uint target, uint index, uint buffer, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferBaseEXT")]
            public static extern void GlBindBufferBase(uint target, uint index, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackVaryingsEXT")]
            public static extern void GlTransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbackVaryingEXT")]
            public static extern void GlGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
            
        }
        public unsafe static partial class VertexArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glArrayElementEXT")]
            public static extern void GlArrayElement(int i);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorPointerEXT")]
            public static extern void GlColorPointer(int size, uint type, int stride, int count, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysEXT")]
            public static extern void GlDrawArrays(uint mode, int first, int count);
            
            [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagPointerEXT")]
            public static extern void GlEdgeFlagPointer(int stride, int count, byte* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPointervEXT")]
            public static extern void GlGetPointerv(uint pname, void** parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIndexPointerEXT")]
            public static extern void GlIndexPointer(uint type, int stride, int count, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalPointerEXT")]
            public static extern void GlNormalPointer(uint type, int stride, int count, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoordPointerEXT")]
            public static extern void GlTexCoordPointer(int size, uint type, int stride, int count, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexPointerEXT")]
            public static extern void GlVertexPointer(int size, uint type, int stride, int count, void* pointer);
            
        }
        public unsafe static partial class VertexArrayBgra
        {
        }
        public unsafe static partial class VertexAttrib64bit
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1dEXT")]
            public static extern void GlVertexAttribL1d(uint index, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2dEXT")]
            public static extern void GlVertexAttribL2d(uint index, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3dEXT")]
            public static extern void GlVertexAttribL3d(uint index, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4dEXT")]
            public static extern void GlVertexAttribL4d(uint index, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1dvEXT")]
            public static extern void GlVertexAttribL1dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2dvEXT")]
            public static extern void GlVertexAttribL2dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3dvEXT")]
            public static extern void GlVertexAttribL3dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4dvEXT")]
            public static extern void GlVertexAttribL4dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribLPointerEXT")]
            public static extern void GlVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLdvEXT")]
            public static extern void GlGetVertexAttribLdv(uint index, uint pname, double* parameters);
            
        }
        public unsafe static partial class VertexShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginVertexShaderEXT")]
            public static extern void GlBeginVertexShader();
            
            [DllImport("opengl32.dll", EntryPoint = "glEndVertexShaderEXT")]
            public static extern void GlEndVertexShader();
            
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexShaderEXT")]
            public static extern void GlBindVertexShader(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenVertexShadersEXT")]
            public static extern uint GlGenVertexShaders(uint range);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexShaderEXT")]
            public static extern void GlDeleteVertexShader(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glShaderOp1EXT")]
            public static extern void GlShaderOp1(uint op, uint res, uint arg1);
            
            [DllImport("opengl32.dll", EntryPoint = "glShaderOp2EXT")]
            public static extern void GlShaderOp2(uint op, uint res, uint arg1, uint arg2);
            
            [DllImport("opengl32.dll", EntryPoint = "glShaderOp3EXT")]
            public static extern void GlShaderOp3(uint op, uint res, uint arg1, uint arg2, uint arg3);
            
            [DllImport("opengl32.dll", EntryPoint = "glSwizzleEXT")]
            public static extern void GlSwizzle(uint res, uint input, uint outX, uint outY, uint outZ, uint outW);
            
            [DllImport("opengl32.dll", EntryPoint = "glWriteMaskEXT")]
            public static extern void GlWriteMask(uint res, uint input, uint outX, uint outY, uint outZ, uint outW);
            
            [DllImport("opengl32.dll", EntryPoint = "glInsertComponentEXT")]
            public static extern void GlInsertComponent(uint res, uint src, uint num);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtractComponentEXT")]
            public static extern void GlExtractComponent(uint res, uint src, uint num);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenSymbolsEXT")]
            public static extern uint GlGenSymbols(uint datatype, uint storagetype, uint range, uint components);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetInvariantEXT")]
            public static extern void GlSetInvariant(uint id, uint type, void* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetLocalConstantEXT")]
            public static extern void GlSetLocalConstant(uint id, uint type, void* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantbvEXT")]
            public static extern void GlVariantbv(uint id, sbyte* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantsvEXT")]
            public static extern void GlVariantsv(uint id, short* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantivEXT")]
            public static extern void GlVariantiv(uint id, int* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantfvEXT")]
            public static extern void GlVariantfv(uint id, float* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantdvEXT")]
            public static extern void GlVariantdv(uint id, double* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantubvEXT")]
            public static extern void GlVariantubv(uint id, byte* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantusvEXT")]
            public static extern void GlVariantusv(uint id, ushort* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantuivEXT")]
            public static extern void GlVariantuiv(uint id, uint* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantPointerEXT")]
            public static extern void GlVariantPointer(uint id, uint type, uint stride, void* addr);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableVariantClientStateEXT")]
            public static extern void GlEnableVariantClientState(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableVariantClientStateEXT")]
            public static extern void GlDisableVariantClientState(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindLightParameterEXT")]
            public static extern uint GlBindLightParameter(uint light, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindMaterialParameterEXT")]
            public static extern uint GlBindMaterialParameter(uint face, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindTexGenParameterEXT")]
            public static extern uint GlBindTexGenParameter(uint unit, uint coord, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindTextureUnitParameterEXT")]
            public static extern uint GlBindTextureUnitParameter(uint unit, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindParameterEXT")]
            public static extern uint GlBindParameter(uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsVariantEnabledEXT")]
            public static extern byte GlIsVariantEnabled(uint id, uint cap);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantBooleanvEXT")]
            public static extern void GlGetVariantBooleanv(uint id, uint value, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantIntegervEXT")]
            public static extern void GlGetVariantIntegerv(uint id, uint value, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantFloatvEXT")]
            public static extern void GlGetVariantFloatv(uint id, uint value, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantPointervEXT")]
            public static extern void GlGetVariantPointerv(uint id, uint value, void** data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInvariantBooleanvEXT")]
            public static extern void GlGetInvariantBooleanv(uint id, uint value, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInvariantIntegervEXT")]
            public static extern void GlGetInvariantIntegerv(uint id, uint value, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInvariantFloatvEXT")]
            public static extern void GlGetInvariantFloatv(uint id, uint value, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetLocalConstantBooleanvEXT")]
            public static extern void GlGetLocalConstantBooleanv(uint id, uint value, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetLocalConstantIntegervEXT")]
            public static extern void GlGetLocalConstantIntegerv(uint id, uint value, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetLocalConstantFloatvEXT")]
            public static extern void GlGetLocalConstantFloatv(uint id, uint value, float* data);
            
        }
        public unsafe static partial class VertexWeighting
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexWeightfEXT")]
            public static extern void GlVertexWeightf(float weight);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexWeightfvEXT")]
            public static extern void GlVertexWeightfv(float* weight);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexWeightPointerEXT")]
            public static extern void GlVertexWeightPointer(int size, uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class Win32KeyedMutex
        {
            [DllImport("opengl32.dll", EntryPoint = "glAcquireKeyedMutexWin32EXT")]
            public static extern byte GlAcquireKeyedMutexWin32(uint memory, uint key, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glReleaseKeyedMutexWin32EXT")]
            public static extern byte GlReleaseKeyedMutexWin32(uint memory, uint key);
            
        }
        public unsafe static partial class WindowRectangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glWindowRectanglesEXT")]
            public static extern void GlWindowRectangles(uint mode, int count, int* box);
            
        }
        public unsafe static partial class X11SyncObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportSyncEXT")]
            public static extern GLsync* GlImportSync(uint external_sync_type, IntPtr external_sync, uint flags);
            
        }
        public unsafe static partial class TextureShadowLod
        {
        }
    }
}
