//
// WinRawJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006 Stefanos Apostolopoulos
// Copyright (c) 2007 Erik Ylvisaker
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

#if !MINIMAL
using System.Drawing;

#endif

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

#pragma warning disable 3019    // CLS-compliance checking
#pragma warning disable 0649    // struct members not explicitly initialized
#pragma warning disable 0169    // field / method is never used.
#pragma warning disable 0414    // field assigned but never used.

namespace OpenTK.Platform.Windows
{
    
    

    /// \internal
    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    internal static class API
    {
        internal static readonly short PixelFormatDescriptorSize;
        internal static readonly short PixelFormatDescriptorVersion;

        internal static readonly int WindowInfoSize;

        // Prevent BeforeFieldInit optimization, and initialize 'size' fields.
        static API()
        {
            PixelFormatDescriptorVersion = 1;
            PixelFormatDescriptorSize = (short)Marshal.SizeOf(typeof(PixelFormatDescriptor));
            WindowInfoSize = Marshal.SizeOf(typeof(WindowInfo));
        }
    }

    internal static class Constants
    {
        // Found in winuser.h
        internal const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;

        // WM_ACTIVATE state values (found in winuser.h)
        internal const int WA_INACTIVE = 0;
        internal const int WA_ACTIVE = 1;
        internal const int WA_CLICKACTIVE = 2;

        // Window Messages (found in winuser.h)
        internal const int WM_NULL = 0x0000;
        internal const int WM_CREATE = 0x0001;
        internal const int WM_DESTROY = 0x0002;
        internal const int WM_MOVE = 0x0003;
        internal const int WM_SIZE = 0x0005;
        internal const int WM_ACTIVATE = 0x0006;
        internal const int WM_SETFOCUS = 0x0007;
        internal const int WM_KILLFOCUS = 0x0008;
        internal const int WM_ENABLE = 0x000A;
        internal const int WM_SETREDRAW = 0x000B;
        internal const int WM_SETTEXT = 0x000C;
        internal const int WM_GETTEXT = 0x000D;
        internal const int WM_GETTEXTLENGTH = 0x000E;
        internal const int WM_PAINT = 0x000F;

        internal const int WM_CLOSE = 0x0010;

        // _WIN32_WCE
        internal const int WM_QUERYENDSESSION = 0x0011;
        internal const int WM_QUERYOPEN = 0x0013;
        internal const int WM_ENDSESSION = 0x0016;
        internal const int WM_QUIT = 0x0012;
        internal const int WM_ERASEBKGND = 0x0014;
        internal const int WM_SYSCOLORCHANGE = 0x0015;
        internal const int WM_SHOWWINDOW = 0x0018;

        internal const int WM_WININICHANGE = 0x001A;

        // WINVER >= 0x400
        internal const int WM_SETTINGCHANGE = WM_WININICHANGE;

        internal const int WM_DEVMODECHANGE = 0x001B;
        internal const int WM_ACTIVATEAPP = 0x001C;
        internal const int WM_FONTCHANGE = 0x001D;
        internal const int WM_TIMECHANGE = 0x001E;
        internal const int WM_CANCELMODE = 0x001F;
        internal const int WM_SETCURSOR = 0x0020;
        internal const int WM_MOUSEACTIVATE = 0x0021;
        internal const int WM_CHILDACTIVATE = 0x0022;
        internal const int WM_QUEUESYNC = 0x0023;

        internal const int WM_GETMINMAXINFO = 0x0024;

        internal const int WM_WINDOWPOSCHANGING = 0x0046;
        internal const int WM_WINDOWPOSCHANGED = 0x0047;

        // Keyboard events (found in winuser.h)
        internal const int WM_INPUT = 0x00FF; // Raw input. XP and higher only.
        internal const int WM_KEYDOWN = 0x0100;
        internal const int WM_KEYUP = 0x101;
        internal const int WM_SYSKEYDOWN = 0x0104;
        internal const int WM_SYSKEYUP = 0x0105;
        internal const int WM_COMMAND = 0x0111;
        internal const int WM_SYSCOMMAND = 0x0112;
        internal const int WM_ENTERIDLE = 0x121;

        // Pixel types (found in wingdi.h)
        internal const byte PFD_TYPE_RGBA = 0;
        internal const byte PFD_TYPE_COLORINDEX = 1;

        // Layer types (found in wingdi.h)
        internal const byte PFD_MAIN_PLANE = 0;
        internal const byte PFD_OVERLAY_PLANE = 1;
        internal const byte PFD_UNDERLAY_PLANE = unchecked((byte)-1);

        // Device mode types (found in wingdi.h)
        internal const int DM_LOGPIXELS = 0x00020000;
        internal const int DM_BITSPERPEL = 0x00040000;
        internal const int DM_PELSWIDTH = 0x00080000;
        internal const int DM_PELSHEIGHT = 0x00100000;
        internal const int DM_DISPLAYFLAGS = 0x00200000;
        internal const int DM_DISPLAYFREQUENCY = 0x00400000;

        // ChangeDisplaySettings results (found in winuser.h)
        internal const int DISP_CHANGE_SUCCESSFUL = 0;
        internal const int DISP_CHANGE_RESTART = 1;
        internal const int DISP_CHANGE_FAILED = -1;

        // (found in winuser.h)
        internal const int ENUM_REGISTRY_SETTINGS = -2;
        internal const int ENUM_CURRENT_SETTINGS = -1;

        // System Error Codes
        // http://msdn.microsoft.com/en-us/library/windows/desktop/ms681381(v=vs.85).aspx

        /// <summary>
        /// The point passed to GetMouseMovePoints is not in the buffer.
        /// </summary>
        internal const int ERROR_POINT_NOT_FOUND = 1171;

        /// <summary>
        /// Retrieves the points using the display resolution.
        /// </summary>
        internal const int GMMP_USE_DISPLAY_POINTS = 1;

        /// <summary>
        /// Retrieves high resolution points. Points can range from zero to
        /// 65,535 (0xFFFF) in both x and y coordinates. This is the resolution
        /// provided by absolute coordinate pointing devices such as drawing
        /// tablets.
        /// </summary>
        internal const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;

        internal static readonly IntPtr MESSAGE_ONLY = new IntPtr(-3);

        internal static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(unchecked((int)0x80000002));
    }

#if ANDROID || IPHONE || MINIMAL
    internal class RegistryKey
    {
        IntPtr hkey;

        internal RegistryKey(IntPtr hkey)
        {
            this.hkey = hkey;
        }

        internal string GetValue(string subkey)
        {
            int type;
            int data_size = 255;
            StringBuilder data = new StringBuilder(data_size);
            Functions.RegGetValue(hkey, subkey, "", 0xffff, out type, data, ref data_size);
            return data.ToString();
        }

        internal RegistryKey OpenSubKey(string subkey)
        {
            IntPtr result;
            Functions.RegOpenKeyEx(hkey, subkey, 0, 1, out result);
            return new RegistryKey(result);
        }
    }

    internal static class Registry
    {
        internal static readonly RegistryKey LocalMachine =
            new RegistryKey(Constants.HKEY_LOCAL_MACHINE);
    }

#endif


    internal enum SizeMessage
    {
        MAXHIDE = 4,
        MAXIMIZED = 2,
        MAXSHOW = 3,
        MINIMIZED = 1,
        RESTORED = 0
    }
}

#pragma warning restore 3019
#pragma warning restore 0649
#pragma warning restore 0169
#pragma warning restore 0414
