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

        public struct Constants
        {
            public const int QueuedAlready = 0;
            public const int QueuedAfterReading = 1;
            public const int QueuedAfterFlush = 2;
        }


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

        // Display management
        [DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        extern public static IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        [DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        extern public static void CloseDisplay(IntPtr display);

        //

        [DllImport(_dll_name, EntryPoint = "XDefaultScreen")]
        extern public static int DefaultScreen(IntPtr display);

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        extern public static IntPtr DefaultVisual(IntPtr display, int screen_number);

        [DllImport(_dll_name, EntryPoint = "XFree")]
        extern public static void Free(IntPtr data);

        // Queue management
        [DllImport(_dll_name, EntryPoint = "XEventsQueued")]
        extern public static int EventsQueued(IntPtr Display, int mode);

        [DllImport(_dll_name, EntryPoint = "XPending")]
        extern public static int Pending(IntPtr Display);


        #endregion
    }
}