using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class NVX
    {
        public unsafe static partial class BlendEquationAdvancedMultiDrawBuffers
        {
        }
        public unsafe static partial class ConditionalRender
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginConditionalRenderNVX")]
            public static extern void GlBeginConditionalRender(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndConditionalRenderNVX")]
            public static extern void GlEndConditionalRender();
            
        }
        public unsafe static partial class GpuMemoryInfo
        {
        }
        public unsafe static partial class LinkedGpuMulticast
        {
            [DllImport("opengl32.dll", EntryPoint = "glLGPUNamedBufferSubDataNVX")]
            public static extern void GlLGPUNamedBufferSubData(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glLGPUCopyImageSubDataNVX")]
            public static extern void GlLGPUCopyImageSubData(uint sourceGpu, uint destinationGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glLGPUInterlockNVX")]
            public static extern void GlLGPUInterlock();
            
        }
        public unsafe static partial class GpuMulticast2
        {
            [DllImport("opengl32.dll", EntryPoint = "glUploadGpuMaskNVX")]
            public static extern void GlUploadGpuMask(uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastViewportArrayvNVX")]
            public static extern void GlMulticastViewportArrayv(uint gpu, uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastViewportPositionWScaleNVX")]
            public static extern void GlMulticastViewportPositionWScale(uint gpu, uint index, float xcoeff, float ycoeff);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastScissorArrayvNVX")]
            public static extern void GlMulticastScissorArrayv(uint gpu, uint first, int count, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glAsyncCopyBufferSubDataNVX")]
            public static extern uint GlAsyncCopyBufferSubData(int waitSemaphoreCount, uint* waitSemaphoreArray, uint* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size, int signalSemaphoreCount, uint* signalSemaphoreArray, uint* signalValueArray);
            
            [DllImport("opengl32.dll", EntryPoint = "glAsyncCopyImageSubDataNVX")]
            public static extern uint GlAsyncCopyImageSubData(int waitSemaphoreCount, uint* waitSemaphoreArray, uint* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, uint* signalValueArray);
            
        }
        public unsafe static partial class ProgressFence
        {
            [DllImport("opengl32.dll", EntryPoint = "glCreateProgressFenceNVX")]
            public static extern uint GlCreateProgressFence();
            
            [DllImport("opengl32.dll", EntryPoint = "glSignalSemaphoreui64NVX")]
            public static extern void GlSignalSemaphoreui64(uint signalGpu, int fenceObjectCount, uint* semaphoreArray, uint* fenceValueArray);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitSemaphoreui64NVX")]
            public static extern void GlWaitSemaphoreui64(uint waitGpu, int fenceObjectCount, uint* semaphoreArray, uint* fenceValueArray);
            
            [DllImport("opengl32.dll", EntryPoint = "glClientWaitSemaphoreui64NVX")]
            public static extern void GlClientWaitSemaphoreui64(int fenceObjectCount, uint* semaphoreArray, uint* fenceValueArray);
            
        }
    }
}
