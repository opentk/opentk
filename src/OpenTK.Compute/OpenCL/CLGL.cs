using System;
using System.Runtime.InteropServices;
using OpenTK.Compute.Native;

namespace OpenTK.Compute.OpenCL
{
    public class CLGL : CLBase
    {
        public enum ObjectType : uint
        {
            ObjectBuffer = 0x2000,
            ObjectTexture2D = 0x2001,
            ObjectTexture3D = 0x2002,
            ObjectRenderBuffer = 0x2003,

            /// <summary>
            /// Introduced in OpenCL 1.2
            /// </summary>
            ObjectTexture2DArray = 0x200E,

            /// <summary>
            /// Introduced in OpenCL 1.2
            /// </summary>
            ObjectTexture1D = 0x200F,

            /// <summary>
            /// Introduced in OpenCL 1.2
            /// </summary>
            ObjectTexture1DArray = 0x2010,

            /// <summary>
            /// Introduced in OpenCL 1.2
            /// </summary>
            ObjectTextureBuffer = 0x2011,
        }

        public enum TextureInfo : uint
        {
            TextureTarget = 0x2004,
            MipmapLevel = 0x2005,

            /// <summary>
            /// Introduced in OpenCL 1.2
            /// </summary>
            NumSamples = 0x2012,
        }

        static CLGL()
        {
            CLBase.RegisterOpenCLResolver();
        }

        private const string LibName = "opencl";
        private const CallingConvention CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateFromGLBuffer")]
        public static extern CLBuffer CreateFromGLBuffer(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] int glBuffer,
            [Out] out CLResultCode error
        );

        /// <summary>
        /// Introduced in Opencl 1.2
        /// </summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="target">This corresponds to the texture target used in OpenGL; e.g. (int)TextureTarget.Texture2D</param>
        /// <param name="mipLevel"></param>
        /// <param name="texture"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateFromGLTexture")]
        public static extern CLBuffer CreateFromGLTexture(
            [In] CLContext context,
            [In] MemoryFlags flags,
            //TODO FIX
            [In] int target,
            [In] int mipLevel,
            [In] int texture,
            [Out] out CLResultCode error
        );

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateFromGLRenderbuffer")]
        public static extern CLBuffer CreateFromGLRenderbuffer(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] int renderBuffer,
            [Out] out CLResultCode error
        );

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetGLObjectInfo")]
        public static extern CLResultCode GetGLObjectInfo(
            [In] CLBuffer memObject,
            [Out] out ObjectType glObjectType,
            [Out] out int glObjectName
        );

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetGLTextureInfo")]
        public static extern CLResultCode GetGLTextureInfo(
            [In] CLBuffer memObject,
            [In] TextureInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned
        );

        public static CLResultCode GetGLTextureInfo(
            CLBuffer memObject,
            TextureInfo paramName,
            out byte[] paramValue)
        {
            GetGLTextureInfo(memObject, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt64()];
            return GetGLTextureInfo(memObject, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueAcquireGLObjects")]
        public static extern CLResultCode EnqueueAcquireGLObjects(
            [In] CLCommandQueue commandQueue,
            [In] uint numberOfObjects,
            [In] CLBuffer[] memoryObjects,
            [In] uint numEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event
        );

        public static CLResultCode EnqueueAcquireGLObjects(
            CLCommandQueue commandQueue,
            CLBuffer[] memoryObjects,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueAcquireGLObjects(commandQueue, (uint)memoryObjects.Length, memoryObjects, (uint)eventWaitList.Length, eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReleaseGLObjects")]
        public static extern CLResultCode EnqueueReleaseGLObjects(
            [In] CLCommandQueue commandQueue,
            [In] uint numberOfObjects,
            [In] CLBuffer[] memoryObjects,
            [In] uint numEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event
        );

        public static CLResultCode EnqueueReleaseGLObjects(
            CLCommandQueue commandQueue,
            CLBuffer[] memoryObjects,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueReleaseGLObjects(commandQueue, (uint)memoryObjects.Length, memoryObjects, (uint)eventWaitList.Length, eventWaitList, out @event);
        }

        #region Deprecated OpenCL 1.1 APIs

        /// <summary>
        /// Introduced in Opencl 1.1; [DEPRECATED]
        /// </summary>
        [Obsolete]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateFromGLTexture2D")]
        public static extern CLBuffer CreateFromGLTexture2D(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] int target,
            [In] int mipLevel,
            [In] int texture,
            [Out] out CLResultCode error
        );

        /// <summary>
        /// Introduced in Opencl 1.1; [DEPRECATED]
        /// </summary>
        [Obsolete]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateFromGLTexture3D")]
        public static extern CLBuffer CreateFromGLTexture3D(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] int target,
            [In] int mipLevel,
            [In] int texture,
            [Out] out CLResultCode error
        );

        #endregion

        public enum ContextInfo : uint
        {
            CurrentDeviceForGlContextKHR = 0x2006,
            DevicesForGlContextKHR = 0x2007
        }

        /// <summary>
        /// Introduced in Opencl 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetGLContextInfoKHR")]
        public static extern CLResultCode GetGLContextInfoKHR(
            [In] IntPtr[] properties,
            [In] ContextInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned
        );

        public static CLResultCode GetGLContextInfoKHR(
            IntPtr[] properties,
            ContextInfo paramName,
            out byte[] paramValue)
        {
            GetGLContextInfoKHR(properties, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt64()];
            return GetGLContextInfoKHR(properties, paramName, sizeReturned, paramValue, out _);
        }

        public static CLResultCode GetGLContextInfoKHR(
            CLContextProperties properties,
            ContextInfo paramName,
            out byte[] paramValue)
        {
            return GetGLContextInfoKHR(properties.CreatePropertyArray(), paramName, out paramValue);
        }

        /// <summary>
        /// Introduced in Opencl 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateEventFromGLsyncKHR")]
        public static extern CLEvent CreateEventFromGLsyncKHR(
            [In] CLContext context,
            [In] IntPtr sync,
            [Out] out CLResultCode error
        );
    }
}
