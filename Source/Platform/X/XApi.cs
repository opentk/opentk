#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X
{
    public static class Api
    {
        private const string _dll_name = "libX11";

        [StructLayout(LayoutKind.Sequential)]
        public struct VisualInfo
        {
            IntPtr visual;
	        int visualid;
	        int screen;
	        uint depth;
	        int @class;
	        ulong red_mask;
	        ulong green_mask;
	        ulong blue_mask;
	        int colormap_size;
	        int bits_per_rgb;
        }

        #region Functions

        [DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        public static extern IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        [DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        public static extern void CloseDisplay(IntPtr display);

        [DllImport(_dll_name, EntryPoint = "XDefaultScreen")]
        public static extern int DefaultScreen(IntPtr display);

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        public static extern IntPtr DefaultVisual(IntPtr display, int screen_number);

        [DllImport(_dll_name, EntryPoint = "XFree")]
        public static extern void Free(IntPtr data);

        #endregion
    }
}
