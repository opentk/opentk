using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES1.Extensions
{
    public static partial class QCOM
    {
        public unsafe static partial class DriverControl
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern void GlGetDriverControls(int* num, int size, uint* driverControls);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern void GlGetDriverControlString(uint driverControl, int bufSize, int* length, char* driverControlString);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableDriverControlQCOM")]
            public static extern void GlEnableDriverControl(uint driverControl);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableDriverControlQCOM")]
            public static extern void GlDisableDriverControl(uint driverControl);
            
        }
        public unsafe static partial class ExtendedGet
        {
            [DllImport("opengl32.dll", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern void GlExtGetTextures(uint* textures, int maxTextures, int* numTextures);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern void GlExtGetBuffers(uint* buffers, int maxBuffers, int* numBuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern void GlExtGetRenderbuffers(uint* renderbuffers, int maxRenderbuffers, int* numRenderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern void GlExtGetFramebuffers(uint* framebuffers, int maxFramebuffers, int* numFramebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern void GlExtGetTexLevelParameteriv(uint texture, uint face, int level, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
            public static extern void GlExtTexObjectStateOverridei(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void GlExtGetTexSubImage(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* texels);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void GlExtGetBufferPointerv(uint target, void** parameters);
            
        }
        public unsafe static partial class ExtendedGet2
        {
            [DllImport("opengl32.dll", EntryPoint = "glExtGetShadersQCOM")]
            public static extern void GlExtGetShaders(uint* shaders, int maxShaders, int* numShaders);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern void GlExtGetPrograms(uint* programs, int maxPrograms, int* numPrograms);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtIsProgramBinaryQCOM")]
            public static extern byte GlExtIsProgramBinary(uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern void GlExtGetProgramBinarySource(uint program, uint shadertype, char* source, int* length);
            
        }
        public unsafe static partial class PerfmonGlobalMode
        {
        }
        public unsafe static partial class TiledRendering
        {
            [DllImport("opengl32.dll", EntryPoint = "glStartTilingQCOM")]
            public static extern void GlStartTiling(uint x, uint y, uint width, uint height, uint preserveMask);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndTilingQCOM")]
            public static extern void GlEndTiling(uint preserveMask);
            
        }
        public unsafe static partial class WriteonlyRendering
        {
        }
    }
}
