#region License
//
// Drm.cs
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

#pragma warning disable 0649 // field is never assigned

namespace OpenTK.Platform.Linux
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void VBlankCallback(int fd,
        int sequence,
        int tv_sec,
        int tv_usec,
        IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void PageFlipCallback(int fd,
        int sequence,
        int tv_sec,
        int tv_usec,
        IntPtr user_data);

    class Drm
    {
        const string lib = "libdrm";

        [DllImport(lib, EntryPoint = "drmHandleEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int HandleEvent(int fd, ref EventContext evctx);

        [DllImport(lib, EntryPoint = "drmModeAddFB", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ModeAddFB(int fd, int width, int height, byte depth,
            byte bpp, int pitch, int bo_handle,
            out int buf_id);

        [DllImport(lib, EntryPoint = "drmModeRmFB", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ModeRmFB(int fd, int bufferId);

        [DllImport(lib, EntryPoint = "drmModeFreeCrtc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ModeFreeCrtc(IntPtr ptr);

        [DllImport(lib, EntryPoint = "drmModeGetCrtc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetCrtc(int fd, int crtcId);

        [DllImport(lib, EntryPoint = "drmModeFreeConnector", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ModeFreeConnector(IntPtr ptr);

        [DllImport(lib, EntryPoint = "drmModeFreeEncoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ModeFreeEncoder(IntPtr ptr);

        [DllImport(lib, EntryPoint = "drmModeGetConnector", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetConnector(int fd, int connector_id);

        [DllImport(lib, EntryPoint = "drmModeGetEncoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetEncoder(int fd, int encoder_id);

        [DllImport(lib, EntryPoint = "drmModeGetResources", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetResources(int fd);

        [DllImport(lib, EntryPoint = "drmModePageFlip", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ModePageFlip(int fd, int crtc_id, int fb_id,
            PageFlipFlags flags, IntPtr user_data);

        [DllImport(lib, EntryPoint = "drmModeSetCrtc", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern int ModeSetCrtc(int fd, int crtcId, int bufferId,
            int x, int y, int* connectors, int count, ModeInfo* mode);

        [DllImport(lib, EntryPoint = "drmModeSetCursor2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetCursor(int fd, int crtcId, int bo_handle, int width, int height, int hot_x, int hot_y);

        [DllImport(lib, EntryPoint = "drmModeMoveCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MoveCursor(int fd, int crtcId, int x, int y);

    }

    enum ModeConnection
    {
        Connected = 1,
        Disconnected = 2,
        Unknown = 3
    }

    enum ModeSubPixel
    {
        Unknown = 1,
        HorizontalRgb = 2,
        HorizontalBgr = 3,
        VerticalRgb = 4,
        VerticalBgr = 5,
        None = 6
    }

    [Flags]
    enum PageFlipFlags
    {
        FlipEvent = 0x01,
        FlipAsync = 0x02,
        FlipFlags = FlipEvent | FlipAsync
    }

    [StructLayout(LayoutKind.Sequential)]
    struct EventContext
    {
        public int version;
        public IntPtr vblank_handler;
        public IntPtr page_flip_handler;

        public static readonly int Version = 2;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeConnector
    {
        public int connector_id;
        public int encoder_id;
        public int connector_type;
        public int connector_type_id;
        public ModeConnection connection;
        public int mmWidth, mmHeight;
        public ModeSubPixel subpixel;

        public int count_modes;
        public ModeInfo* modes;

        public int count_props;
        public int *props;
        public long *prop_values;

        public int count_encoders;
        public int *encoders;
    }

    struct ModeCrtc
    {
        public int crtc_id;
        public int buffer_id;

        public int x, y;
        public int width, height;
        public int mode_valid;
        public ModeInfo mode;

        public int gamma_size;
    }

    struct ModeEncoder
    {
        public int encoder_id;
        public int encoder_type;
        public int crtc_id;
        public int possible_crtcs;
        public int possible_clones;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeInfo
    {
        public uint clock;
        public ushort hdisplay, hsync_start, hsync_end, htotal, hskew;
        public ushort vdisplay, vsync_start, vsync_end, vtotal, vscan;

        public int vrefresh; // refresh rate * 1000

        public uint flags;
        public uint type;
        public fixed sbyte name[32];
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeRes
    {
        public int count_fbs;
        public int* fbs;
        public int count_crtcs;
        public int* crtcs;
        public int count_connectors;
        public int* connectors;
        public int count_encoders;
        public int* encoders;
        public int min_width, max_width;
        public int min_height, max_height;
    }
}

