//
// Gbm.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    using Device = IntPtr; // struct gbm_device*
    using Surface = IntPtr;
    using BufferObjectHandle = IntPtr;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DestroyUserDataCallback(BufferObject bo, IntPtr data);

    internal class Gbm
    {
        private const string lib = "gbm";

        [DllImport(lib, EntryPoint = "gbm_bo_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern BufferObject CreateBuffer(Device gbm, int width, int height, SurfaceFormat format,
            SurfaceFlags flags);

        [DllImport(lib, EntryPoint = "gbm_bo_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyBuffer(BufferObject bo);

        [DllImport(lib, EntryPoint = "gbm_bo_write", CallingConvention = CallingConvention.Cdecl)]
        public static extern int BOWrite(IntPtr bo, IntPtr buf, IntPtr count);

        [DllImport(lib, EntryPoint = "gbm_bo_get_device", CallingConvention = CallingConvention.Cdecl)]
        public static extern Device BOGetDevice(IntPtr bo);

        [DllImport(lib, EntryPoint = "gbm_bo_get_handle", CallingConvention = CallingConvention.Cdecl)]
        public static extern BufferObjectHandle BOGetHandle(IntPtr bo);

        [DllImport(lib, EntryPoint = "gbm_bo_get_height", CallingConvention = CallingConvention.Cdecl)]
        public static extern int BOGetHeight(IntPtr bo);

        [DllImport(lib, EntryPoint = "gbm_bo_get_width", CallingConvention = CallingConvention.Cdecl)]
        public static extern int BOGetWidth(IntPtr bo);

        [DllImport(lib, EntryPoint = "gbm_bo_get_stride", CallingConvention = CallingConvention.Cdecl)]
        public static extern int BOGetStride(IntPtr bo);

        [DllImport(lib, EntryPoint = "gbm_bo_set_user_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern void BOSetUserData(IntPtr bo, IntPtr data, DestroyUserDataCallback callback);

        [DllImport(lib, EntryPoint = "gbm_create_device", CallingConvention = CallingConvention.Cdecl)]
        public static extern Device CreateDevice(int fd);

        [DllImport(lib, EntryPoint = "gbm_device_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyDevice(Device gbm);

        [DllImport(lib, EntryPoint = "gbm_device_get_fd", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DeviceGetFD(IntPtr gbm);

        [DllImport(lib, EntryPoint = "gbm_surface_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern Surface CreateSurface(Device gbm, int width, int height, SurfaceFormat format,
            SurfaceFlags flags);

        [DllImport(lib, EntryPoint = "gbm_surface_destroy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroySurface(IntPtr surface);

        [DllImport(lib, EntryPoint = "gbm_device_is_format_supported", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsFormatSupported(Device gbm, SurfaceFormat format, SurfaceFlags usage);

        [DllImport(lib, EntryPoint = "gbm_surface_lock_front_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern BufferObject LockFrontBuffer(Surface surface);

        [DllImport(lib, EntryPoint = "gbm_surface_release_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ReleaseBuffer(Surface surface, BufferObject buffer);
    }

    internal enum SurfaceFormat
    {
        BigEndian = 1 << 31,
        C8 = 'C' | ('8' << 8) | (' ' << 16) | (' ' << 24),

        RGB332 = 'R' | ('G' << 8) | ('B' << 16) | ('8' << 24),
        BGR233 = 'B' | ('G' << 8) | ('R' << 16) | ('8' << 24),

        XRGB4444 = 'X' | ('R' << 8) | ('1' << 16) | ('2' << 24),
        XBGR4444 = 'X' | ('B' << 8) | ('1' << 16) | ('2' << 24),
        RGBX4444 = 'R' | ('X' << 8) | ('1' << 16) | ('2' << 24),
        BGRX4444 = 'B' | ('X' << 8) | ('1' << 16) | ('2' << 24),

        ARGB4444 = 'A' | ('R' << 8) | ('1' << 16) | ('2' << 24),
        ABGR4444 = 'A' | ('B' << 8) | ('1' << 16) | ('2' << 24),
        RGBA4444 = 'R' | ('A' << 8) | ('1' << 16) | ('2' << 24),
        BGRA4444 = 'B' | ('A' << 8) | ('1' << 16) | ('2' << 24),

        XRGB1555 = 'X' | ('R' << 8) | ('1' << 16) | ('5' << 24),
        XBGR1555 = 'X' | ('B' << 8) | ('1' << 16) | ('5' << 24),
        RGBX5551 = 'R' | ('X' << 8) | ('1' << 16) | ('5' << 24),
        BGRX5551 = 'B' | ('X' << 8) | ('1' << 16) | ('5' << 24),

        ARGB1555 = 'A' | ('R' << 8) | ('1' << 16) | ('5' << 24),
        ABGR1555 = 'A' | ('B' << 8) | ('1' << 16) | ('5' << 24),
        RGBA5551 = 'R' | ('A' << 8) | ('1' << 16) | ('5' << 24),
        BGRA5551 = 'B' | ('A' << 8) | ('1' << 16) | ('5' << 24),

        RGB565 = 'R' | ('G' << 8) | ('1' << 16) | ('6' << 24),
        BGR565 = 'B' | ('G' << 8) | ('1' << 16) | ('6' << 24),

        RGB888 = 'R' | ('G' << 8) | ('2' << 16) | ('4' << 24),
        BGR888 = 'B' | ('G' << 8) | ('2' << 16) | ('4' << 24),

        XRGB8888 = 'X' | ('R' << 8) | ('2' << 16) | ('4' << 24),
        XBGR8888 = 'X' | ('B' << 8) | ('2' << 16) | ('4' << 24),
        RGBX8888 = 'R' | ('X' << 8) | ('2' << 16) | ('4' << 24),
        BGRX8888 = 'B' | ('X' << 8) | ('2' << 16) | ('4' << 24),

        ARGB8888 = 'A' | ('R' << 8) | ('2' << 16) | ('4' << 24),
        ABGR8888 = 'A' | ('B' << 8) | ('2' << 16) | ('4' << 24),
        RGBA8888 = 'R' | ('A' << 8) | ('2' << 16) | ('4' << 24),
        BGRA8888 = 'B' | ('A' << 8) | ('2' << 16) | ('4' << 24),

        XRGB2101010 = 'X' | ('R' << 8) | ('3' << 16) | ('0' << 24),
        XBGR2101010 = 'X' | ('B' << 8) | ('3' << 16) | ('0' << 24),
        RGBX1010102 = 'R' | ('X' << 8) | ('3' << 16) | ('0' << 24),
        BGRX1010102 = 'B' | ('X' << 8) | ('3' << 16) | ('0' << 24),

        ARGB2101010 = 'A' | ('R' << 8) | ('3' << 16) | ('0' << 24),
        ABGR2101010 = 'A' | ('B' << 8) | ('3' << 16) | ('0' << 24),
        RGBA1010102 = 'R' | ('A' << 8) | ('3' << 16) | ('0' << 24),
        BGRA1010102 = 'B' | ('A' << 8) | ('3' << 16) | ('0' << 24),

        YUYV = 'Y' | ('U' << 8) | ('Y' << 16) | ('V' << 24),
        YVYU = 'Y' | ('V' << 8) | ('Y' << 16) | ('U' << 24),
        UYVY = 'U' | ('Y' << 8) | ('V' << 16) | ('Y' << 24),
        VYUY = 'V' | ('Y' << 8) | ('U' << 16) | ('Y' << 24),

        AYUV = 'A' | ('Y' << 8) | ('U' << 16) | ('V' << 24),

        NV12 = 'N' | ('V' << 8) | ('1' << 16) | ('2' << 24),
        NV21 = 'N' | ('V' << 8) | ('2' << 16) | ('1' << 24),
        NV16 = 'N' | ('V' << 8) | ('1' << 16) | ('6' << 24),
        NV61 = 'N' | ('V' << 8) | ('6' << 16) | ('1' << 24),

        YUV410 = 'Y' | ('U' << 8) | ('V' << 16) | ('9' << 24),
        YVU410 = 'Y' | ('V' << 8) | ('U' << 16) | ('9' << 24),
        YUV411 = 'Y' | ('U' << 8) | ('1' << 16) | ('1' << 24),
        YVU411 = 'Y' | ('V' << 8) | ('1' << 16) | ('1' << 24),
        YUV420 = 'Y' | ('U' << 8) | ('1' << 16) | ('2' << 24),
        YVU420 = 'Y' | ('V' << 8) | ('1' << 16) | ('2' << 24),
        YUV422 = 'Y' | ('U' << 8) | ('1' << 16) | ('6' << 24),
        YVU422 = 'Y' | ('V' << 8) | ('1' << 16) | ('6' << 24),
        YUV444 = 'Y' | ('U' << 8) | ('2' << 16) | ('4' << 24),
        YVU444 = 'Y' | ('V' << 8) | ('2' << 16) | ('4' << 24)
    }

    [Flags]
    internal enum SurfaceFlags
    {
        Scanout = 1 << 0,
        Cursor64x64 = 1 << 1,
        Rendering = 1 << 2,
        Write = 1 << 3
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct BufferObject : IEquatable<BufferObject>
    {
        private IntPtr buffer;

        public static readonly BufferObject Zero =
            default(BufferObject);

        public int Write(byte[] data)
        {
            unsafe
            {
                fixed (byte* pdata = data)
                {
                    return Gbm.BOWrite(buffer, (IntPtr)pdata, (IntPtr)data.Length);
                }
            }
        }

        public void SetUserData(IntPtr data, DestroyUserDataCallback destroyFB)
        {
            Gbm.BOSetUserData(buffer, data, destroyFB);
        }

        public Device Device => Gbm.BOGetDevice(buffer);

        public int Handle => Gbm.BOGetHandle(buffer).ToInt32();

        public int Width => Gbm.BOGetWidth(buffer);

        public int Height => Gbm.BOGetHeight(buffer);

        public int Stride => Gbm.BOGetStride(buffer);

        public void Dispose()
        {
            Gbm.DestroyBuffer(this);
            buffer = IntPtr.Zero;
        }

        public static bool operator ==(BufferObject left, BufferObject right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BufferObject left, BufferObject right)
        {
            return !left.Equals(right);
        }

        public override bool Equals(object obj)
        {
            return
                obj is BufferObject &&
                Equals((BufferObject)obj);
        }

        public override int GetHashCode()
        {
            return buffer.GetHashCode();
        }

        public override string ToString()
        {
            return $"[BufferObject: {buffer}]";
        }

        public bool Equals(BufferObject other)
        {
            return buffer == other.buffer;
        }
    }
}