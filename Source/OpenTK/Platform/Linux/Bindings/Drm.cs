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

namespace OpenTK.Platform.Linux
{
    class Drm
    {
        const string lib = "libdrm";

        [DllImport(lib, EntryPoint = "drmModeGetCrtc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetCrtc(int fd, uint crtcId);

        [DllImport(lib, EntryPoint = "drmModeFreeConnector", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ModeFreeConnector(IntPtr ptr);

        [DllImport(lib, EntryPoint = "drmModeFreeEncoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ModeFreeEncoder(IntPtr ptr);

        [DllImport(lib, EntryPoint = "drmModeGetConnector", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetConnector(int fd, uint connector_id);

        [DllImport(lib, EntryPoint = "drmModeGetEncoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetEncoder(int fd, uint encoder_id);

        [DllImport(lib, EntryPoint = "drmModeGetResources", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ModeGetResources(int fd);

        [DllImport(lib, EntryPoint = "drmModeSetCrtc", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern int ModeSetCrtc(int fd, uint crtcId, uint bufferId,
            uint x, uint y, uint* connectors, int count, ModeInfo* mode);
    }

    enum ModeConnection : byte
    {
        Connected = 1,
        Disconnected = 2,
        Unknown = 3
    }

    enum ModeSubPixel : byte
    {
        Unknown = 1,
        HorizontalRgb = 2,
        HorizontalBgr = 3,
        VerticalRgb = 4,
        VerticalBgr = 5,
        None = 6
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeConnector
    {
        public uint connector_id;
        public uint encoder_id;
        public uint connector_type;
        public uint connector_type_id;
        public ModeConnection connection;
        public uint mmWidth, mmHeight;
        public ModeSubPixel subpixel;

        public int count_modes;
        public ModeInfo* modes;

        public int count_props;
        public uint *props;
        public ulong *prop_values;

        public int count_encoders;
        public uint *encoders;
    }

    struct ModeCrtc
    {
        public uint crtc_id;
        public uint buffer_id;

        public uint x, y;
        public uint width, height;
        public int mode_valid;
        public ModeInfo mode;

        public int gamma_size;
    }

    struct ModeEncoder
    {
        public uint encoder_id;
        public uint encoder_type;
        public uint crtc_id;
        public uint possible_crtcs;
        public uint possible_clones;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeInfo
    {
        public uint clock;
        public ushort hdisplay, hsync_start, hsync_end, htotal, hskew;
        public ushort vdisplay, vsync_start, vsync_end, vtotal, vscan;

        public uint vrefresh; // refresh rate * 1000

        public uint flags;
        public uint type;
        public fixed sbyte name[32];
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct ModeRes
    {
        public int count_fbs;
        public uint* fbs;
        public int count_crtcs;
        public uint* crtcs;
        public int count_connectors;
        public uint* connectors;
        public int count_encoders;
        public uint* encoders;
        public int min_width, max_width;
        public int min_height, max_height;
    }
}

