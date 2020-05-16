using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class SUN
    {
        public unsafe static partial class ConvolutionBorderModes
        {
        }
        public unsafe static partial class GlobalAlpha
        {
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactorbSUN")]
            public static extern void GlGlobalAlphaFactorb(sbyte factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactorsSUN")]
            public static extern void GlGlobalAlphaFactors(short factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactoriSUN")]
            public static extern void GlGlobalAlphaFactori(int factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactorfSUN")]
            public static extern void GlGlobalAlphaFactorf(float factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactordSUN")]
            public static extern void GlGlobalAlphaFactord(double factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactorubSUN")]
            public static extern void GlGlobalAlphaFactorub(byte factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactorusSUN")]
            public static extern void GlGlobalAlphaFactorus(ushort factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGlobalAlphaFactoruiSUN")]
            public static extern void GlGlobalAlphaFactorui(uint factor);
            
        }
        public unsafe static partial class MeshArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawMeshArraysSUN")]
            public static extern void GlDrawMeshArrays(uint mode, int first, int count, int width);
            
        }
        public unsafe static partial class SliceAccum
        {
        }
        public unsafe static partial class TriangleList
        {
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiSUN")]
            public static extern void GlReplacementCodeui(uint code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeusSUN")]
            public static extern void GlReplacementCodeus(ushort code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeubSUN")]
            public static extern void GlReplacementCodeub(byte code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuivSUN")]
            public static extern void GlReplacementCodeuiv(uint* code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeusvSUN")]
            public static extern void GlReplacementCodeusv(ushort* code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeubvSUN")]
            public static extern void GlReplacementCodeubv(byte* code);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodePointerSUN")]
            public static extern void GlReplacementCodePointer(uint type, int stride, void** pointer);
            
        }
        public unsafe static partial class Vertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glColor4ubVertex2fSUN")]
            public static extern void GlColor4ubVertex2f(byte r, byte g, byte b, byte a, float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4ubVertex2fvSUN")]
            public static extern void GlColor4ubVertex2fv(byte* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4ubVertex3fSUN")]
            public static extern void GlColor4ubVertex3f(byte r, byte g, byte b, byte a, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4ubVertex3fvSUN")]
            public static extern void GlColor4ubVertex3fv(byte* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3fVertex3fSUN")]
            public static extern void GlColor3fVertex3f(float r, float g, float b, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3fVertex3fvSUN")]
            public static extern void GlColor3fVertex3fv(float* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3fVertex3fSUN")]
            public static extern void GlNormal3fVertex3f(float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3fVertex3fvSUN")]
            public static extern void GlNormal3fVertex3fv(float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4fNormal3fVertex3fSUN")]
            public static extern void GlColor4fNormal3fVertex3f(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
            public static extern void GlColor4fNormal3fVertex3fv(float* c, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fVertex3fSUN")]
            public static extern void GlTexCoord2fVertex3f(float s, float t, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fVertex3fvSUN")]
            public static extern void GlTexCoord2fVertex3fv(float* tc, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fVertex4fSUN")]
            public static extern void GlTexCoord4fVertex4f(float s, float t, float p, float q, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fVertex4fvSUN")]
            public static extern void GlTexCoord4fVertex4fv(float* tc, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor4ubVertex3fSUN")]
            public static extern void GlTexCoord2fColor4ubVertex3f(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
            public static extern void GlTexCoord2fColor4ubVertex3fv(float* tc, byte* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor3fVertex3fSUN")]
            public static extern void GlTexCoord2fColor3fVertex3f(float s, float t, float r, float g, float b, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
            public static extern void GlTexCoord2fColor3fVertex3fv(float* tc, float* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fNormal3fVertex3fSUN")]
            public static extern void GlTexCoord2fNormal3fVertex3f(float s, float t, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
            public static extern void GlTexCoord2fNormal3fVertex3fv(float* tc, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN")]
            public static extern void GlTexCoord2fColor4fNormal3fVertex3f(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
            public static extern void GlTexCoord2fColor4fNormal3fVertex3fv(float* tc, float* c, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN")]
            public static extern void GlTexCoord4fColor4fNormal3fVertex4f(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
            public static extern void GlTexCoord4fColor4fNormal3fVertex4fv(float* tc, float* c, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiVertex3fSUN")]
            public static extern void GlReplacementCodeuiVertex3f(uint rc, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
            public static extern void GlReplacementCodeuiVertex3fv(uint* rc, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN")]
            public static extern void GlReplacementCodeuiColor4ubVertex3f(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
            public static extern void GlReplacementCodeuiColor4ubVertex3fv(uint* rc, byte* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN")]
            public static extern void GlReplacementCodeuiColor3fVertex3f(uint rc, float r, float g, float b, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiColor3fVertex3fv(uint* rc, float* c, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN")]
            public static extern void GlReplacementCodeuiNormal3fVertex3f(uint rc, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiNormal3fVertex3fv(uint* rc, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN")]
            public static extern void GlReplacementCodeuiColor4fNormal3fVertex3f(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiColor4fNormal3fVertex3fv(uint* rc, float* c, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fVertex3f(uint rc, float s, float t, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fVertex3fv(uint* rc, float* tc, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fNormal3fVertex3f(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fNormal3fVertex3fv(uint* rc, float* tc, float* n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fColor4fNormal3fVertex3f(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
            public static extern void GlReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fv(uint* rc, float* tc, float* c, float* n, float* v);
            
        }
    }
}
