//
//  WinWindowsInfoInitializer.cs
//
//  The Open Toolkit Library License
//
//  Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights to
//  use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
//  the Software, and to permit persons to whom the Software is furnished to do
//  so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//  OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//  WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//  OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Platform;

namespace OpenTK.Win
{
    /// <summary>
    /// Handler class for initializing <see cref="IWindowInfo"/> objects under the Windows platform for both GTK2 and
    /// GTK3.
    /// </summary>
	public static class WinWindowsInfoInitializer
	{
#if GTK3
		private const string WinLibGDKName = "libgdk-3-0.dll";
#else
        private const string WinLibGDKName = "libgdk-win32-2.0-0.dll";
#endif

	    /// <summary>
	    /// Initializes an <see cref="IWindowInfo"/> under the Windows platform.
	    /// </summary>
	    /// <param name="gdkWindowHandle"></param>
		public static IWindowInfo Initialize(IntPtr gdkWindowHandle)
		{
#if GTK3
		    IntPtr windowHandle = gdk_win32_window_get_handle(gdkWindowHandle);
#else
            IntPtr windowHandle = gdk_win32_drawable_get_handle(gdkWindowHandle);
#endif
			return Utilities.CreateWindowsWindowInfo(windowHandle);
		}

#if GTK3
	    [SuppressUnmanagedCodeSecurity, DllImport(WinLibGDKName, CallingConvention = CallingConvention.Cdecl)]
	    static extern IntPtr gdk_win32_window_get_handle(IntPtr w);
#else
        [SuppressUnmanagedCodeSecurity, DllImport(WinLibGDKName, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr gdk_win32_drawable_get_handle(IntPtr d);
#endif

	}
}