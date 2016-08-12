#region License
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
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Linux
{
    using Device = IntPtr; // struct gbm_device*
    using Surface = IntPtr;
    using BufferObjectHandle = IntPtr;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void DestroyUserDataCallback(BufferObject bo, IntPtr data);

    class Gbm
    {
        const string lib = "gbm";

        [DllImport(lib, EntryPoint = "gbm_bo_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern BufferObject CreateBuffer(Device gbm, int width, int height, SurfaceFormat format, SurfaceFlags flags);

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
        public static extern Surface CreateSurface(Device gbm, int width, int height, SurfaceFormat format, SurfaceFlags flags);

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

    enum SurfaceFormat
    {
        BigEndian = 1 << 31,
        C8 = ((int)('C') | ((int)('8') << 8) | ((int)(' ') << 16) | ((int)(' ') << 24)),

        RGB332 = ((int)('R') | ((int)('G') << 8) | ((int)('B') << 16) | ((int)('8') << 24)),
        BGR233 = ((int)('B') | ((int)('G') << 8) | ((int)('R') << 16) | ((int)('8') << 24)),

        XRGB4444 = ((int)('X') | ((int)('R') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        XBGR4444 = ((int)('X') | ((int)('B') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        RGBX4444 = ((int)('R') | ((int)('X') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        BGRX4444 = ((int)('B') | ((int)('X') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),

        ARGB4444 = ((int)('A') | ((int)('R') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        ABGR4444 = ((int)('A') | ((int)('B') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        RGBA4444 = ((int)('R') | ((int)('A') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        BGRA4444 = ((int)('B') | ((int)('A') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),

        XRGB1555 = ((int)('X') | ((int)('R') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        XBGR1555 = ((int)('X') | ((int)('B') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        RGBX5551 = ((int)('R') | ((int)('X') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        BGRX5551 = ((int)('B') | ((int)('X') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),

        ARGB1555 = ((int)('A') | ((int)('R') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        ABGR1555 = ((int)('A') | ((int)('B') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        RGBA5551 = ((int)('R') | ((int)('A') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),
        BGRA5551 = ((int)('B') | ((int)('A') << 8) | ((int)('1') << 16) | ((int)('5') << 24)),

        RGB565 = ((int)('R') | ((int)('G') << 8) | ((int)('1') << 16) | ((int)('6') << 24)),
        BGR565 = ((int)('B') | ((int)('G') << 8) | ((int)('1') << 16) | ((int)('6') << 24)),

        RGB888 = ((int)('R') | ((int)('G') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        BGR888 = ((int)('B') | ((int)('G') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),

        XRGB8888 = ((int)('X') | ((int)('R') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        XBGR8888 = ((int)('X') | ((int)('B') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        RGBX8888 = ((int)('R') | ((int)('X') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        BGRX8888 = ((int)('B') | ((int)('X') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),

        ARGB8888 = ((int)('A') | ((int)('R') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        ABGR8888 = ((int)('A') | ((int)('B') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        RGBA8888 = ((int)('R') | ((int)('A') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        BGRA8888 = ((int)('B') | ((int)('A') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),

        XRGB2101010 = ((int)('X') | ((int)('R') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        XBGR2101010 = ((int)('X') | ((int)('B') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        RGBX1010102 = ((int)('R') | ((int)('X') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        BGRX1010102 = ((int)('B') | ((int)('X') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),

        ARGB2101010 = ((int)('A') | ((int)('R') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        ABGR2101010 = ((int)('A') | ((int)('B') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        RGBA1010102 = ((int)('R') | ((int)('A') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),
        BGRA1010102 = ((int)('B') | ((int)('A') << 8) | ((int)('3') << 16) | ((int)('0') << 24)),

        YUYV = ((int)('Y') | ((int)('U') << 8) | ((int)('Y') << 16) | ((int)('V') << 24)),
        YVYU = ((int)('Y') | ((int)('V') << 8) | ((int)('Y') << 16) | ((int)('U') << 24)),
        UYVY = ((int)('U') | ((int)('Y') << 8) | ((int)('V') << 16) | ((int)('Y') << 24)),
        VYUY = ((int)('V') | ((int)('Y') << 8) | ((int)('U') << 16) | ((int)('Y') << 24)),

        AYUV = ((int)('A') | ((int)('Y') << 8) | ((int)('U') << 16) | ((int)('V') << 24)),

        NV12 = ((int)('N') | ((int)('V') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        NV21 = ((int)('N') | ((int)('V') << 8) | ((int)('2') << 16) | ((int)('1') << 24)),
        NV16 = ((int)('N') | ((int)('V') << 8) | ((int)('1') << 16) | ((int)('6') << 24)),
        NV61 = ((int)('N') | ((int)('V') << 8) | ((int)('6') << 16) | ((int)('1') << 24)),

        YUV410 = ((int)('Y') | ((int)('U') << 8) | ((int)('V') << 16) | ((int)('9') << 24)),
        YVU410 = ((int)('Y') | ((int)('V') << 8) | ((int)('U') << 16) | ((int)('9') << 24)),
        YUV411 = ((int)('Y') | ((int)('U') << 8) | ((int)('1') << 16) | ((int)('1') << 24)),
        YVU411 = ((int)('Y') | ((int)('V') << 8) | ((int)('1') << 16) | ((int)('1') << 24)),
        YUV420 = ((int)('Y') | ((int)('U') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        YVU420 = ((int)('Y') | ((int)('V') << 8) | ((int)('1') << 16) | ((int)('2') << 24)),
        YUV422 = ((int)('Y') | ((int)('U') << 8) | ((int)('1') << 16) | ((int)('6') << 24)),
        YVU422 = ((int)('Y') | ((int)('V') << 8) | ((int)('1') << 16) | ((int)('6') << 24)),
        YUV444 = ((int)('Y') | ((int)('U') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
        YVU444 = ((int)('Y') | ((int)('V') << 8) | ((int)('2') << 16) | ((int)('4') << 24)),
    }

    [Flags]
    enum SurfaceFlags
    {
        Scanout = (1 << 0),
        Cursor64x64 = (1 << 1),
        Rendering = (1 << 2),
        Write = (1 << 3),
    }

    [StructLayout(LayoutKind.Sequential)]
    struct BufferObject : IEquatable<BufferObject>
    {
        IntPtr buffer;

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

        public Device Device
        {
            get { return Gbm.BOGetDevice(buffer); }
        }

        public int Handle
        {
            get { return Gbm.BOGetHandle(buffer).ToInt32(); }
        }

        public int Width
        {
            get { return Gbm.BOGetWidth(buffer); }
        }

        public int Height
        {
            get { return Gbm.BOGetHeight(buffer); }
        }

        public int Stride
        {
            get { return Gbm.BOGetStride(buffer); }
        }

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
                this.Equals((BufferObject)obj);
        }

        public override int GetHashCode()
        {
            return buffer.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[BufferObject: {0}]", buffer);
        }

        #region IEquatable implementation

        public bool Equals(BufferObject other)
        {
            return buffer == other.buffer;
        }

        #endregion
    }
}

