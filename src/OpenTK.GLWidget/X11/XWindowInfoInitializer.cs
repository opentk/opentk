//
//  XWindowsInfoInitializer.cs
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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK.X11
{
	public static class XWindowInfoInitializer
	{

#if GTK3
	    const string UnixLibGdkName = "libgdk-3.so.0";
#else
        const string UnixLibGdkName = "libgdk-x11-2.0.so.0";
#endif
		private const string UnixLibX11Name = "libX11.so.6";
		private const string UnixLibGLName = "libGL.so.1";

		public static IWindowInfo Initialize(GraphicsMode mode, IntPtr displayHandle, int screenNumber, IntPtr gdkWindowHandle, IntPtr gdkRootWindowHandle)
		{
			IntPtr display = gdk_x11_display_get_xdisplay(displayHandle);

#if GTK3
		    IntPtr windowXid = gdk_x11_window_get_xid(gdkWindowHandle);
		    IntPtr rootWindowXid = gdk_x11_window_get_xid(gdkRootWindowHandle);
#else
            IntPtr windowHandle = gdk_x11_drawable_get_xid(gdkWindowHandle);
            IntPtr rootWindow = gdk_x11_drawable_get_xid(gdkRootWindowHandle);
#endif

			IntPtr visualInfo;
			if (mode.Index.HasValue)
			{
				XVisualInfo info = new XVisualInfo
				{
					VisualID = mode.Index.Value
				};

				int dummy;
				visualInfo = XGetVisualInfo(display, XVisualInfoMask.ID, ref info, out dummy);
			}
			else
			{
				visualInfo = GetVisualInfo(mode, display, screenNumber);
			}

			IWindowInfo retval = Utilities.CreateX11WindowInfo(display, screenNumber, windowXid, rootWindowXid, visualInfo);
			XFree(visualInfo);

			return retval;
		}

		private static IntPtr XGetVisualInfo(IntPtr display, XVisualInfoMask infoMask, ref XVisualInfo template, out int nitems)
		{
			return XGetVisualInfoInternal(display, (IntPtr)(int)infoMask, ref template, out nitems);
		}

		private static IntPtr GetVisualInfo(GraphicsMode mode, IntPtr display, int screenNumber)
		{
			try
			{
				int[] attributes = CreateAttributeList(mode).ToArray();
				return glXChooseVisual(display, screenNumber, attributes);
			}
			catch (DllNotFoundException e)
			{
				throw new DllNotFoundException("OpenGL dll not found!", e);
			}
			catch (EntryPointNotFoundException enf)
			{
				throw new EntryPointNotFoundException("Glx entry point not found!", enf);
			}
		}

		private static List<int> CreateAttributeList(GraphicsMode mode)
		{
			List<int> attributeList = new List<int>(24);

			attributeList.Add((int)GLXAttribute.RGBA);

			if (mode.Buffers > 1)
			{
				attributeList.Add((int)GLXAttribute.DoubleBuffer);
			}

			if (mode.Stereo)
			{
				attributeList.Add((int)GLXAttribute.Stereo);
			}

			attributeList.Add((int)GLXAttribute.RedSize);
			attributeList.Add(mode.ColorFormat.Red / 4); // TODO support 16-bit

			attributeList.Add((int)GLXAttribute.GreenSize);
			attributeList.Add(mode.ColorFormat.Green / 4); // TODO support 16-bit

			attributeList.Add((int)GLXAttribute.BlueSize);
			attributeList.Add(mode.ColorFormat.Blue / 4); // TODO support 16-bit

			attributeList.Add((int)GLXAttribute.AlphaSize);
			attributeList.Add(mode.ColorFormat.Alpha / 4); // TODO support 16-bit

			attributeList.Add((int)GLXAttribute.DepthSize);
			attributeList.Add(mode.Depth);

			attributeList.Add((int)GLXAttribute.StencilSize);
			attributeList.Add(mode.Stencil);

			//attributeList.Add(GLX_AUX_BUFFERS);
			//attributeList.Add(Buffers);

			attributeList.Add((int)GLXAttribute.AccumRedSize);
			attributeList.Add(mode.AccumulatorFormat.Red / 4);// TODO support 16-bit

			attributeList.Add((int)GLXAttribute.AccumGreenSize);
			attributeList.Add(mode.AccumulatorFormat.Green / 4);// TODO support 16-bit

			attributeList.Add((int)GLXAttribute.AccumBlueSize);
			attributeList.Add(mode.AccumulatorFormat.Blue / 4);// TODO support 16-bit

			attributeList.Add((int)GLXAttribute.AccumAlphaSize);
			attributeList.Add(mode.AccumulatorFormat.Alpha / 4);// TODO support 16-bit

			attributeList.Add((int)GLXAttribute.None);

			return attributeList;
		}

		[DllImport(UnixLibX11Name, EntryPoint = "XGetVisualInfo")]
		private static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr infoMask, ref XVisualInfo template, out int nitems);

		[SuppressUnmanagedCodeSecurity, DllImport(UnixLibX11Name)]
		private static extern void XFree(IntPtr handle);

#if GTK3
		/// <summary> Returns the X resource (window or pixmap) belonging to a GdkWindow. </summary>
		/// <remarks> XID gdk_x11_window_get_xid(GdkWindow *drawable); </remarks>
		/// <param name="gdkDisplay"> The GdkDrawable. </param>
		/// <returns> The ID of window's X resource. </returns>
		[SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
		private static extern IntPtr gdk_x11_window_get_xid(IntPtr gdkDisplay);
#else
	    /// <summary> Returns the X resource (window or pixmap) belonging to a GdkDrawable. </summary>
	    /// <remarks> XID gdk_x11_drawable_get_xid(GdkDrawable *drawable); </remarks>
	    /// <param name="gdkDisplay"> The GdkDrawable. </param>
	    /// <returns> The ID of drawable's X resource. </returns>
	    [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
	    static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkDisplay);
#endif
		/// <summary> Returns the X display of a GdkDisplay. </summary>
		/// <remarks> Display* gdk_x11_display_get_xdisplay(GdkDisplay *display); </remarks>
		/// <param name="gdkDisplay"> The GdkDrawable. </param>
		/// <returns> The X Display of the GdkDisplay. </returns>
		[SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
		private static extern IntPtr gdk_x11_display_get_xdisplay(IntPtr gdkDisplay);

		[SuppressUnmanagedCodeSecurity, DllImport(UnixLibGLName)]
		private static extern IntPtr glXChooseVisual(IntPtr display, int screen, int[] attr);
	}
}