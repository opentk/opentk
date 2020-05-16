using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLCORE.Extensions
{
    public static partial class EXT
    {
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
        public unsafe static partial class DrawInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedEXT")]
            public static extern void GlDrawArraysInstanced(uint mode, int start, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedEXT")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
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
        public unsafe static partial class PolygonOffsetClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetClampEXT")]
            public static extern void GlPolygonOffsetClamp(float factor, float units, float clamp);
            
        }
        public unsafe static partial class PostDepthCoverage
        {
        }
        public unsafe static partial class RasterMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRasterSamplesEXT")]
            public static extern void GlRasterSamples(uint samples, byte fixedsamplelocations);
            
        }
        public unsafe static partial class SeparateShaderObjects
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
        public unsafe static partial class ShaderIntegerMix
        {
        }
        public unsafe static partial class TextureCompressionS3tc
        {
        }
        public unsafe static partial class TextureFilterMinmax
        {
        }
        public unsafe static partial class TextureSrgbR8
        {
        }
        public unsafe static partial class TextureSrgbDecode
        {
        }
        public unsafe static partial class WindowRectangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glWindowRectanglesEXT")]
            public static extern void GlWindowRectangles(uint mode, int count, int* box);
            
        }
        public unsafe static partial class TextureShadowLod
        {
        }
    }
}
