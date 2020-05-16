using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class KHR
    {
        public unsafe static partial class BlendEquationAdvanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendBarrierKHR")]
            public static extern void GlBlendBarrier();
            
        }
        public unsafe static partial class BlendEquationAdvancedCoherent
        {
        }
        public unsafe static partial class ContextFlushControl
        {
        }
        public unsafe static partial class Debug
        {
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageControl")]
            public static extern void GlDebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageInsert")]
            public static extern void GlDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageCallback")]
            public static extern void GlDebugMessageCallback(GLDEBUGPROC callback, void* userParam);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDebugMessageLog")]
            public static extern uint GlGetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
            
            [DllImport("opengl32.dll", EntryPoint = "glPushDebugGroup")]
            public static extern void GlPushDebugGroup(uint source, uint id, int length, char* message);
            
            [DllImport("opengl32.dll", EntryPoint = "glPopDebugGroup")]
            public static extern void GlPopDebugGroup();
            
            [DllImport("opengl32.dll", EntryPoint = "glObjectLabel")]
            public static extern void GlObjectLabel(uint identifier, uint name, int length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectLabel")]
            public static extern void GlGetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glObjectPtrLabel")]
            public static extern void GlObjectPtrLabel(void* ptr, int length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectPtrLabel")]
            public static extern void GlGetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPointerv")]
            public static extern void GlGetPointerv(uint pname, void** parameters);
            
        }
        public unsafe static partial class NoError
        {
        }
        public unsafe static partial class RobustBufferAccessBehavior
        {
        }
        public unsafe static partial class Robustness
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatus")]
            public static extern uint GlGetGraphicsResetStatus();
            
            [DllImport("opengl32.dll", EntryPoint = "glReadnPixels")]
            public static extern void GlReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfv")]
            public static extern void GlGetnUniformfv(uint program, int location, int bufSize, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformiv")]
            public static extern void GlGetnUniformiv(uint program, int location, int bufSize, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformuiv")]
            public static extern void GlGetnUniformuiv(uint program, int location, int bufSize, uint* parameters);
            
        }
        public unsafe static partial class ShaderSubgroup
        {
        }
        public unsafe static partial class TextureCompressionAstcHdr
        {
        }
        public unsafe static partial class TextureCompressionAstcLdr
        {
        }
        public unsafe static partial class TextureCompressionAstcSliced3d
        {
        }
        public unsafe static partial class ParallelShaderCompile
        {
            [DllImport("opengl32.dll", EntryPoint = "glMaxShaderCompilerThreadsKHR")]
            public static extern void GlMaxShaderCompilerThreads(uint count);
            
        }
    }
}
